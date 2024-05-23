namespace ArchitectureArchiveBE.DTO
{
    public class BuildingDTO
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string YearBuilt { get; set; }
        public string Description { get; set; }
        public bool IsRegistered { get; set; }
        public int UserId { get; set; }
        public int? StyleId { get; set; }
        public string ImageURL { get; set; }
    }
}
