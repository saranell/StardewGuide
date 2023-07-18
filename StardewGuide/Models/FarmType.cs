using System.ComponentModel.DataAnnotations;

namespace StardewGuide.Models
{
    public enum FarmType
    {
        Standard,
        Forest,
        [Display(Name="Hill-top")] 
        HillTop,
        Riverland,
        Wilderness,
        [Display(Name="Four Corners")]
        FourCorners,
        Beach
    }
}
