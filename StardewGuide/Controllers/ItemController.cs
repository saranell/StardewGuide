using Microsoft.AspNetCore.Mvc;
using StardewGuide.Data;
using StardewGuide.Models;

namespace StardewGuide.Controllers
{
    public class ItemController : Controller
    {
        private FarmDbContext context;
        public ItemController (FarmDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<Item> items = context.Items.ToList();

            return View(items);
        }
    }
}