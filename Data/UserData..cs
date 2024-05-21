using ArchitectureArchiveBE.Models;
namespace ArchitectureArchiveBE.Data
{
    public class UserData
    {
        public static List<User> Users = new List<User>
        {
           new User { Id = 1, Uid = "uidstring" },
           new User { Id = 2, Uid = "uidstring" },
        };
    }
}
