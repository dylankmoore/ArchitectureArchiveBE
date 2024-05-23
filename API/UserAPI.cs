using ArchitectureArchiveBE.Data;
using ArchitectureArchiveBE.Models;
using Microsoft.EntityFrameworkCore;

namespace ArchitectureArchiveBE.API
{
    public class UserAPI
    {
        public static void Map(WebApplication app)
        {
            // CHECK USER
            app.MapPost("/checkuser", (ArchitectureArchiveBEDbContext db, User user) => {
                var userUid = db.Users.SingleOrDefault(u => u.Uid == user.Uid);
                if (userUid == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(userUid);
            });

            // GET USER BY ID
            app.MapGet("/user/{id}", (ArchitectureArchiveBEDbContext db, int id) => {
                var userDetails = db.Users.SingleOrDefault(u => u.Id == id);
                if (userDetails is null)
                {
                    return Results.NotFound(id);
                }
                return Results.Ok(userDetails);
            });
        }
    }
}
