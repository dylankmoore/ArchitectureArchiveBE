using Microsoft.EntityFrameworkCore;
using ArchitectureArchiveBE.Data;
using ArchitectureArchiveBE.Models;

namespace ArchitectureArchiveBE.API
{
    public class StyleAPI
    {
        public static void Map(WebApplication app)
        {
            // ADD STYLE TO BUILDING
            app.MapPost("/buildings/{buildingId}/style/{styleId}", (ArchitectureArchiveBEDbContext db, int buildingId, int styleId) =>
            {
                var building = db.Buildings.FirstOrDefault(b => b.BuildingId == buildingId);
                if (building == null)
                {
                    return Results.NotFound("Building not found.");
                }

                var style = db.Styles.FirstOrDefault(s => s.StyleId == styleId);
                if (style == null)
                {
                    return Results.NotFound("Style category not found.");
                }

                // update style
                building.StyleId = styleId;
                db.SaveChanges();

                return Results.Ok(new
                {
                    BuildingId = building.BuildingId,
                    StyleId = building.StyleId,
                    StyleName = style.Name,
                    Message = "Style category updated successfully."
                });
            });

            // REMOVE STYLE FROM BUILDING
            app.MapDelete("/buildings/{buildingId}/styles/{styleId}", (ArchitectureArchiveBEDbContext db, int buildingId, int styleId) =>
            {
                // Find the building
                var building = db.Buildings.Include(b => b.Style).FirstOrDefault(b => b.BuildingId == buildingId);
                if (building == null)
                {
                    return Results.NotFound("Building not found.");
                }

                // Check if the building has the specified style
                if (building.StyleId != styleId)
                {
                    return Results.NotFound("Style not associated with this building.");
                }

                // Remove the style association
                building.StyleId = null;

                db.SaveChanges();

                return Results.Ok(new { Message = "Style removed from building successfully." });
            });

            // GET ALL STYLES
            app.MapGet("/styles", (ArchitectureArchiveBEDbContext db) =>
            {
                var styles = db.Styles
                    .Select(t => new
                    {
                        t.StyleId,
                        t.Name
                    })
                    .ToList();

                return Results.Ok(styles);
            });
        }
    }
}
