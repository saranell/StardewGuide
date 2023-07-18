using StardewGuide.Models;

namespace StardewGuide.ViewModels
{
    public class FarmDetailViewModel
    {
        public int FarmId { get; set; }
        public string? Name { get; set; }
        public FarmType? Type { get; set; }
        public DateOnly DateCreated { get; set; }
        public ICollection<Villager>? Villagers { get; set; }

        public FarmDetailViewModel(Farm theFarm)
        {
            FarmId = theFarm.Id;
            Name = theFarm.Name;
            Type = theFarm.Type;
            DateCreated = theFarm.DateCreated;
            Villagers = new List<Villager>();
        }
    }
}