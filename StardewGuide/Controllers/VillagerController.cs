using Microsoft.AspNetCore.Mvc;
using StardewGuide.Data;
using StardewGuide.Models;
using StardewGuide.ViewModels;


namespace StardewGuide.Controllers
{ 
    public class VillagerController : Controller 
    {
        private FarmDbContext context;

        public VillagerController (FarmDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<Villager> villagers = context.Villagers
                .Where(v => !DBNull.Value.Equals(v.Name) && v.Name != "")
                .ToList();

            return View(villagers);
        }

// TODO: populate the Best_Gifts property with list of items
        public IActionResult Gifts(VillagerViewModel villagerViewModel)
        {
            var villagers = context.Villagers.ToList();
            var viewModelList = new List<VillagerViewModel>();

            foreach (var villager in villagers)
            {
                var bestGifts = context.Items
                    .Where(item => item.VillagerId == villager.Id)
                    .ToList();

                var viewModel = new VillagerViewModel
                {
                    Id = villager.Id,
                    Name = villager.Name,
                    Birthday = villager.Birthday,
                    Best_Gifts = bestGifts 
                };

                viewModelList.Add(viewModel);
            }
            return View(viewModelList);
        }
    }
}
