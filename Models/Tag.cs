namespace ArchitectureArchiveBE.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string Name {  get; set; }
        public ICollection<Building> Buildings { get; set; }
    }
}
