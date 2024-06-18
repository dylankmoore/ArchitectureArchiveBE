using Microsoft.EntityFrameworkCore;
using ArchitectureArchiveBE.Data;
using ArchitectureArchiveBE.Models;
using ArchitectureArchiveBE.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectureArchiveBE.API
{
    public class BuildingAPI
    {
        public static void Map(WebApplication app)
        {
            // GET ALL BUILDINGS
            app.MapGet("/buildings", (ArchitectureArchiveBEDbContext db) =>
            {
                var buildings = db.Buildings
                    .Include(b => b.Style)
                    .Include(b => b.Tags)
                    .Include(b => b.User)
                    .Select(b => new
                    {
                        b.BuildingId,
                        b.Name,
                        b.Location,
                        b.YearBuilt,
                        b.Description,
                        b.IsRegistered,
                        b.UserId,
                        b.StyleId,
                        Style = b.Style.Name,
                        b.ImageURL,
                        Tags = b.Tags.Select(t => t.Name).ToList(),
                    })
                    .ToList();

                return Results.Ok(buildings);
            });

            // GET BUILDING BY ID
            app.MapGet("/buildings/{buildingId}", (ArchitectureArchiveBEDbContext db, int buildingId) =>
            {
                var buildingDetails = db.Buildings
                    .Where(b => b.BuildingId == buildingId)
                    .Select(b => new {
                        b.BuildingId,
                        b.Name,
                        b.Location,
                        b.YearBuilt,
                        b.Description,
                        IsRegisteredBool = b.IsRegistered,
                        b.UserId,
                        b.StyleId,
                        Style = b.Style.Name,
                        b.ImageURL,
                        Tags = b.Tags.Select(t => t.Name).ToList(),
                    })
                    .FirstOrDefault();

                if (buildingDetails == null)
                {
                    return Results.NotFound("Building not found.");
                }

                return Results.Ok(buildingDetails);
            });

            // CREATE A BUILDING
            app.MapPost("/buildings/new", (ArchitectureArchiveBEDbContext db, BuildingDTO buildingDto) =>
            {
                // erify that the user exists
                var user = db.Users.FirstOrDefault(u => u.Id == buildingDto.UserId);
                if (user == null)
                {
                    return Results.NotFound("User not found.");
                }

                // create a new building and associate it with the user
                var newBuilding = new Building
                {
                    Name = buildingDto.Name,
                    Location = buildingDto.Location,
                    YearBuilt = buildingDto.YearBuilt,
                    Description = buildingDto.Description,
                    IsRegistered = buildingDto.IsRegistered,
                    ImageURL = buildingDto.ImageURL,
                    UserId = buildingDto.UserId,
                    Tags = new List<Tag>()
                };

                // add the building to the database
                db.Buildings.Add(newBuilding);
                db.SaveChanges();

                // add tags to the building
                if (buildingDto.TagIds != null && buildingDto.TagIds.Count > 0)
                {
                    foreach (var tagId in buildingDto.TagIds)
                    {
                        var tag = db.Tags.Find(tagId);
                        if (tag != null)
                        {
                            newBuilding.Tags.Add(tag);
                        }
                        else
                        {
                            Console.WriteLine($"Tag with ID {tagId} not found.");
                        }
                    }
                }

                // add style to the building if provided
                if (buildingDto.StyleId != null)
                {
                    var style = db.Styles.Find(buildingDto.StyleId);
                    if (style != null)
                    {
                        newBuilding.Style = style;
                    }
                    else
                    {
                        Console.WriteLine($"Style with ID {buildingDto.StyleId} not found.");
                    }
                }

                db.SaveChanges();

                return Results.Created($"/buildings/{newBuilding.BuildingId}", newBuilding);
            });

            // UPDATE BUILDING
            app.MapPut("/buildings/{buildingId}", (ArchitectureArchiveBEDbContext db, int buildingId, BuildingDTO buildingDto) =>
            {
                var building = db.Buildings.Include(b => b.Tags).FirstOrDefault(b => b.BuildingId == buildingId);
                if (building == null)
                {
                    return Results.NotFound("Building not found.");
                }

                // verify that the user exists
                var user = db.Users.FirstOrDefault(u => u.Id == buildingDto.UserId);
                if (user == null)
                {
                    return Results.NotFound("User not found.");
                }

                // update building properties
                building.Name = buildingDto.Name ?? building.Name;
                building.Location = buildingDto.Location ?? building.Location;
                building.YearBuilt = buildingDto.YearBuilt ?? building.YearBuilt;
                building.Description = buildingDto.Description ?? building.Description;
                building.IsRegistered = buildingDto.IsRegistered;
                building.ImageURL = buildingDto.ImageURL ?? building.ImageURL;
                building.UserId = buildingDto.UserId;

                // update tags
                building.Tags.Clear();
                if (buildingDto.TagIds != null && buildingDto.TagIds.Count > 0)
                {
                    foreach (var tagId in buildingDto.TagIds)
                    {
                        var tag = db.Tags.Find(tagId);
                        if (tag != null)
                        {
                            building.Tags.Add(tag);
                        }
                        else
                        {
                            Console.WriteLine($"Tag with ID {tagId} not found.");
                        }
                    }
                }

                // update style
                if (buildingDto.StyleId != null)
                {
                    var style = db.Styles.Find(buildingDto.StyleId);
                    if (style != null)
                    {
                        building.Style = style;
                    }
                    else
                    {
                        Console.WriteLine($"Style with ID {buildingDto.StyleId} not found.");
                    }
                }
                else
                {
                    building.Style = null;
                }

                db.SaveChanges();
                return Results.Ok(new { Message = "Building updated successfully.", Building = building });
            });

            // DELETE BUILDINGS
            app.MapDelete("/buildings/{buildingId}", (ArchitectureArchiveBEDbContext db, int buildingId) =>
            {
                var building = db.Buildings.Find(buildingId);
                if (building == null)
                {
                    return Results.NotFound("Building not found.");
                }

                db.Buildings.Remove(building);
                db.SaveChanges();
                return Results.Ok(new { Message = "Building deleted successfully." });
            });

            // SEARCH BUILDINGS
            app.MapGet("/search", (ArchitectureArchiveBEDbContext db, string query) =>
            {
                query = query.ToLower();

                var searchResults = db.Buildings
                    .Where(b => EF.Functions.Like(b.Name.ToLower(), $"%{query}%") ||
                                EF.Functions.Like(b.Location.ToLower(), $"%{query}%") ||
                                EF.Functions.Like(b.YearBuilt.ToLower(), $"%{query}%") ||
                                EF.Functions.Like(b.Style.Name.ToLower(), $"%{query}%") ||
                                b.Tags.Any(t => EF.Functions.Like(t.Name.ToLower(), $"%{query}%")))
                    .Include(b => b.Style)
                    .Include(b => b.Tags)
                    .Include(b => b.User)
                    .Select(b => new
                    {
                        b.BuildingId,
                        b.Name,
                        b.Location,
                        b.YearBuilt,
                        b.Description,
                        b.IsRegistered,
                        b.UserId,
                        b.StyleId,
                        Style = b.Style.Name,
                        b.ImageURL,
                        Tags = b.Tags.Select(t => t.Name).ToList(),
                    })
                    .ToList();

                return Results.Ok(searchResults);
            });


        }
    }
}
