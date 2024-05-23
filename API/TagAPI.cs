using Microsoft.EntityFrameworkCore;
using ArchitectureArchiveBE.Data;
using ArchitectureArchiveBE.Models;

namespace ArchitectureArchiveBE.API
{
    public static class TagAPI
    {
        public static void Map(WebApplication app)
        {
            // ADD TAGS TO BUILDINGS
            app.MapPost("/buildings/{buildingId}/tags", (ArchitectureArchiveBEDbContext db, int buildingId, List<int> tagIds) =>
            {
                var building = db.Buildings.Include(b => b.Tags).FirstOrDefault(b => b.BuildingId == buildingId);
                if (building == null)
                {
                    return Results.NotFound("Building not found.");
                }

                var tags = db.Tags.Where(t => tagIds.Contains(t.TagId)).ToList();
                if (tags.Count != tagIds.Count)
                {
                    return Results.BadRequest("One or more tags not found.");
                }

                // add new tags to building
                foreach (var tag in tags)
                {
                    if (!building.Tags.Contains(tag))
                    {
                        building.Tags.Add(tag);
                    }
                }

                db.SaveChanges();

                return Results.Ok(new
                {
                    BuildingId = building.BuildingId,
                    Tags = building.Tags.Select(t => t.Name).ToList()
                });
            });

            // DELETE TAGS FROM BUILDING
            app.MapDelete("/buildings/{buildingId}/tags/{tagId}", (ArchitectureArchiveBEDbContext db, int buildingId, int tagId) =>
            {
                var building = db.Buildings.Include(b => b.Tags).FirstOrDefault(b => b.BuildingId == buildingId);
                if (building == null)
                {
                    return Results.NotFound("Building not found.");
                }

                var tag = building.Tags.FirstOrDefault(t => t.TagId == tagId);
                if (tag == null)
                {
                    return Results.NotFound("Tag not found.");
                }

                // remove tag association
                building.Tags.Remove(tag);
                db.SaveChanges();

                return Results.Ok(new { Message = "Tag removed from building successfully." });
            });

            // GET ALL TAGS
            app.MapGet("/tags", (ArchitectureArchiveBEDbContext db) =>
            {
                var tags = db.Tags
                    .Select(t => new
                    {
                        t.TagId,
                        t.Name
                    })
                    .ToList();

                return Results.Ok(tags);
            });

        }
    }
}