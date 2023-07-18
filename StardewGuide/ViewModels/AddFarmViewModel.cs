
using Microsoft.AspNetCore.Mvc.Rendering;
using StardewGuide.Models;
using System.ComponentModel.DataAnnotations;
using StardewGuide.Extensions;


namespace StardewGuide.ViewModels
{
    public class AddFarmViewModel
    {
        [Required(ErrorMessage = "Your farm needs a name!")]
        [StringLength(50, ErrorMessage = "Sorry, that name is too long.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Don't forget to add the date!")]
        public DateOnly DateCreated { get; set; }

        [Required(ErrorMessage = "Please select which type of farm you have.")]
        public FarmType? Type { get; set; }
        public List<SelectListItem> FarmTypes { get; set; } = new List<SelectListItem>
        {
            new SelectListItem("Select",""),
            new SelectListItem(FarmType.Standard.GetDisplay(), ((int)FarmType.Standard).ToString()),
            new SelectListItem(FarmType.Forest.GetDisplay(), ((int)FarmType.Forest).ToString()),
            new SelectListItem(FarmType.HillTop.GetDisplay(), ((int)FarmType.HillTop).ToString()),
            new SelectListItem(FarmType.Riverland.GetDisplay(), ((int)FarmType.Riverland).ToString()),
            new SelectListItem(FarmType.Wilderness.GetDisplay(), ((int)FarmType.Wilderness).ToString()),
            new SelectListItem(FarmType.FourCorners.GetDisplay(), ((int)FarmType.FourCorners).ToString()),
            new SelectListItem(FarmType.Beach.GetDisplay(), ((int)FarmType.Beach).ToString()),
        };
    }
}
