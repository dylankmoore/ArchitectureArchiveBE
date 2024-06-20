using Microsoft.EntityFrameworkCore;
using ArchitectureArchiveBE.Data;
using ArchitectureArchiveBE.Models;
using ArchitectureArchiveBE.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectureArchiveBE.API
{
    public class CollectionAPI
    {
        public static void Map(WebApplication app)
        {
            // GET ALL COLLECTIONS
            app.MapGet("/collections", (ArchitectureArchiveBEDbContext db) =>
            {
                var collections = db.Collections
                    .Include(c => c.Buildings)
                    .Select(c => new
                    {
                        c.CollectionId,
                        c.Name,
                        c.ImageURL,
                        c.Description,
                        Buildings = c.Buildings.Select(b => new
                        {
                            b.BuildingId,
                            b.Name,
                            b.Location,
                            b.YearBuilt,
                            b.Description,
                            b.ImageURL
                        }).ToList()
                    })
                    .ToList();

                return Results.Ok(collections);
            });

            // GET COLLECTION BY ID
            app.MapGet("/collections/{collectionId}", (ArchitectureArchiveBEDbContext db, int collectionId) =>
            {
                var collection = db.Collections
                    .Where(c => c.CollectionId == collectionId)
                    .Include(c => c.Buildings)
                        .ThenInclude(b => b.Style)
                    .Select(c => new
                    {
                        c.CollectionId,
                        c.Name,
                        c.ImageURL,
                        c.Description,
                        Buildings = c.Buildings.Select(b => new
                        {
                            b.BuildingId,
                            b.Name,
                            b.Location,
                            b.YearBuilt,
                            b.Description,
                            b.ImageURL,
                            Style = b.Style.Name // Include the Style name in the projection
                        }).ToList()
                    })
                    .FirstOrDefault();

                if (collection == null)
                {
                    return Results.NotFound("Collection not found.");
                }

                return Results.Ok(collection);
            });

            // CREATE COLLECTION
            app.MapPost("/collections/new", (ArchitectureArchiveBEDbContext db, CollectionDTO collectionDto) =>
            {
                var newCollection = new Collection
                {
                    Name = collectionDto.Name,
                    ImageURL = collectionDto.ImageURL,
                    Description = collectionDto.Description,
                    Buildings = new List<Building>()
                };

                if (collectionDto.BuildingIds != null && collectionDto.BuildingIds.Count > 0)
                {
                    foreach (var buildingId in collectionDto.BuildingIds)
                    {
                        var building = db.Buildings.Find(buildingId);
                        if (building != null)
                        {
                            newCollection.Buildings.Add(building);
                        }
                    }
                }

                db.Collections.Add(newCollection);
                db.SaveChanges();

                return Results.Created($"/collections/{newCollection.CollectionId}", newCollection);
            });

            // UPDATE COLLECTION
            app.MapPut("/collections/{collectionId}", (ArchitectureArchiveBEDbContext db, int collectionId, CollectionDTO collectionDto) =>
            {
                var collection = db.Collections.Include(c => c.Buildings).FirstOrDefault(c => c.CollectionId == collectionId);
                if (collection == null)
                {
                    return Results.NotFound("Collection not found.");
                }

                collection.Name = collectionDto.Name ?? collection.Name;
                collection.ImageURL = collectionDto.ImageURL ?? collection.ImageURL;
                collection.Description = collectionDto.Description ?? collection.Description;

                collection.Buildings.Clear();
                if (collectionDto.BuildingIds != null && collectionDto.BuildingIds.Count > 0)
                {
                    foreach (var buildingId in collectionDto.BuildingIds)
                    {
                        var building = db.Buildings.Find(buildingId);
                        if (building != null)
                        {
                            collection.Buildings.Add(building);
                        }
                    }
                }

                db.SaveChanges();
                return Results.Ok(new { Message = "Collection updated successfully.", Collection = collection });
            });

            // DELETE COLLECTION
            app.MapDelete("/collections/{collectionId}", (ArchitectureArchiveBEDbContext db, int collectionId) =>
            {
                var collection = db.Collections.Find(collectionId);
                if (collection == null)
                {
                    return Results.NotFound("Collection not found.");
                }

                db.Collections.Remove(collection);
                db.SaveChanges();
                return Results.Ok(new { Message = "Collection deleted successfully." });
            });

            // ADD BUILDING TO COLLECTION
            app.MapPost("/collections/{collectionId}/buildings/{buildingId}", (ArchitectureArchiveBEDbContext db, int collectionId, int buildingId) =>
            {
                var collection = db.Collections.Include(c => c.Buildings).FirstOrDefault(c => c.CollectionId == collectionId);
                if (collection == null)
                {
                    return Results.NotFound("Collection not found.");
                }

                var building = db.Buildings.Find(buildingId);
                if (building == null)
                {
                    return Results.NotFound("Building not found.");
                }

                collection.Buildings.Add(building);
                db.SaveChanges();

                return Results.Ok(new { Message = "Building added to collection successfully.", Collection = collection });
            });

            // REMOVE BUILDING FROM COLLECTION
            app.MapDelete("/collections/{collectionId}/buildings/{buildingId}", (ArchitectureArchiveBEDbContext db, int collectionId, int buildingId) =>
            {
                var collection = db.Collections.Include(c => c.Buildings).FirstOrDefault(c => c.CollectionId == collectionId);
                if (collection == null)
                {
                    return Results.NotFound("Collection not found.");
                }

                var building = collection.Buildings.FirstOrDefault(b => b.BuildingId == buildingId);
                if (building == null)
                {
                    return Results.NotFound("Building not found in this collection.");
                }

                collection.Buildings.Remove(building);
                db.SaveChanges();

                return Results.Ok(new { Message = "Building removed from collection successfully.", Collection = collection });
            });
        }
    }
}
