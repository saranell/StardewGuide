namespace StardewGuide.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ItemCategory Category { get; set; }
    }
}