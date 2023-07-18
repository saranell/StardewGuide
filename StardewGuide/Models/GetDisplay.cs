using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace StardewGuide.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplay(this Enum value)
        {
            return value.GetType()
                .GetMember(value.ToString())[0]
                .GetCustomAttribute<DisplayAttribute>()
                ?.Name ?? value.ToString();
        }
    }
    
}
