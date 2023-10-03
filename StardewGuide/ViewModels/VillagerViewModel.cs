using Microsoft.AspNetCore.Mvc.Rendering;
using StardewGuide.Models;
using System.ComponentModel.DataAnnotations;

namespace StardewGuide.ViewModels
{
    public class VillagersViewModel
    {
        public int Id { get; }
        public string? Name { get; }
        public string? Birthday { get; }
        public string? ImageFileName { get; }
    }
}