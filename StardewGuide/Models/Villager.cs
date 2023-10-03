using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace StardewGuide.Models
{
    public class Villager
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Birthday { get; set; }
        public string? ImageFileName { get; set; }

        public Villager(int id, string name, string birthday)
        {
            Id = id;
            Name = name;
            Birthday = birthday;
            ImageFileName = Id.ToString();
        }

        public Villager()
        {
        }

        public override string? ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Villager @villager && Id == villager.Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //TODO: method to update/edit the villagers heart events
    }
}