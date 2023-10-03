using StardewGuide.Models;

namespace StardewGuide.ViewModels
{
    public class VillagerDetailsViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Birthday { get; set; }
        public string? ImageFileName { get; set; }

        public VillagerDetailsViewModel(Villager theVillager)
        {
            Id = theVillager.Id;
            Name = theVillager.Name;
            Birthday = theVillager.Birthday;
            ImageFileName = theVillager.ImageFileName;
        }
    }
}