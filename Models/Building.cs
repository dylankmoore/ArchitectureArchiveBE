namespace ArchitectureArchiveBE.Models
{
    public class Building
    {
        public int BuildingId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string YearBuilt { get; set; }
        public string Description { get; set; }
        public bool IsRegistered { get; set; }
        public int UserId { get; set; }
        public int StyleId { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
