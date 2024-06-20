namespace ArchitectureArchiveBE.Models
{
    public class Collection
    {
        public int CollectionId { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public ICollection<Building> Buildings { get; set; }

    }
}
