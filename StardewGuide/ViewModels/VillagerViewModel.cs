using Microsoft.AspNetCore.Mvc.Rendering;
using StardewGuide.Models;
using System.ComponentModel.DataAnnotations;

namespace StardewGuide.ViewModels
{
    public class VillagerViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Birthday { get; set; }
        public List<Item>? Best_Gifts { get; set; }

    }
}