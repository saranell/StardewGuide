namespace StardewGuide.Models
{
    public class Farm
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public FarmType? Type { get; set; }
        public DateOnly DateCreated { get; set; }
        public ICollection<Villager>? Villagers { get; set; }
        public Farm(string name)
        {
            Name = name;
            Villagers = new List<Villager>();
        }
        public Farm() 
        { 
        }
        public override string? ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Farm @farm && Id == farm.Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
