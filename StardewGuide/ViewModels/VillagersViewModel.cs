using Microsoft.AspNetCore.Mvc.Rendering;
using StardewGuide.Models;
using System.ComponentModel.DataAnnotations;

namespace StardewGuide.ViewModels
{
    public class VillagersViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Birthday { get; set; }
        public string? ImageFileName { get; set; }
    }
}