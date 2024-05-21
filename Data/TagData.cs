using ArchitectureArchiveBE.Models;
namespace ArchitectureArchiveBE.Data
{
    public class TagData
    {
        public static List<Tag> Tags = new List<Tag>
        {
            new Tag { TagId = 1, Name = "National Monument" },
            new Tag { TagId = 2, Name = "Tourist Attraction" },
            new Tag { TagId = 3, Name = "Endangered" },
            new Tag { TagId = 4, Name = "Art Installation" },
            new Tag { TagId = 5, Name = "Renovated" },
            new Tag { TagId = 6, Name = "Cultural Landmark" },
            new Tag { TagId = 7, Name = "Museum" },
            new Tag { TagId = 8, Name = "Under Construction" },
            new Tag { TagId = 9, Name = "Closed for Renovation" },
            new Tag { TagId = 10, Name = "Sustainable" },
            new Tag { TagId = 11, Name = "Innovation"}
        };
    }
}
