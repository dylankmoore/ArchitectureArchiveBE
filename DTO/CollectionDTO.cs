namespace ArchitectureArchiveBE.DTO
{
    public class CollectionDTO
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public List<int> BuildingIds { get; set; }
    }
}
