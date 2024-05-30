using Microsoft.EntityFrameworkCore;
using ArchitectureArchiveBE.Data;
using ArchitectureArchiveBE.Models;
using ArchitectureArchiveBE.DTO;

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
                        IsRegistered = b.IsRegistered ? "Registered" : "Not Registered",
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
            app.MapPost("/buildings", (ArchitectureArchiveBEDbContext db, BuildingDTO buildingDto) =>
            {
                // verify that user exists
                var user = db.Users.FirstOrDefault(u => u.Id == buildingDto.UserId);
                if (user == null)
                {
                    return Results.NotFound("User not found.");
                }

                // create a new building and associate it with the user & style
                var newBuilding = new Building
                {
                    Name = buildingDto.Name,
                    Location = buildingDto.Location,
                    YearBuilt = buildingDto.YearBuilt,
                    Description = buildingDto.Description,
                    IsRegistered = buildingDto.IsRegistered,
                    UserId = buildingDto.UserId,
                    StyleId = buildingDto.StyleId,
                    ImageURL = buildingDto.ImageURL,
                };

                // add the building to the database & save changes
                db.Buildings.Add(newBuilding);
                db.SaveChanges();

                return Results.Created($"/buildings/{newBuilding.BuildingId}", newBuilding);
            });

            // UPDATE BUILDING
            app.MapPut("/buildings/{buildingId}", (ArchitectureArchiveBEDbContext db, int buildingId, BuildingDTO buildingDto) =>
            {
                var building = db.Buildings.Find(buildingId);
                if (building == null)
                {
                    return Results.NotFound("Building not found.");
                }

                building.Name = buildingDto.Name ?? building.Name;
                building.Location = buildingDto.Location ?? building.Location;
                building.YearBuilt = buildingDto.YearBuilt ?? building.YearBuilt;
                building.Description = buildingDto.Description ?? building.Description;
                building.IsRegistered = buildingDto.IsRegistered != false ? buildingDto.IsRegistered : building.IsRegistered;
                building.StyleId = buildingDto.StyleId != null ? buildingDto.StyleId : building.StyleId;
                building.ImageURL = buildingDto.ImageURL ?? building.ImageURL;

                db.SaveChanges();
                return Results.Ok(new { Message = "Building updated successfully." });
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

        }
    }
}
