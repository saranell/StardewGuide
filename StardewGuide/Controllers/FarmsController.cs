using Microsoft.AspNetCore.Mvc;
using StardewGuide.Data;
using StardewGuide.Models;
using StardewGuide.ViewModels;

namespace StardewGuide.Controllers
{
    public class FarmsController : Controller
    {
        private FarmDbContext context;

        public FarmsController(FarmDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<Farm> farms = context.Farms.ToList();

            return View(farms);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddFarmViewModel addFarmViewModel = new();

            return View(addFarmViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddFarmViewModel addFarmViewModel)
        {
            if (ModelState.IsValid)
            {
                Farm newFarm = new()
                {
                    Name = addFarmViewModel.Name,
                    Type = addFarmViewModel.Type,
                    DateCreated = addFarmViewModel.DateCreated,
                };

                context.Farms.Add(newFarm);
                context.SaveChanges();

                return Redirect("/Farms");
            }
            return View(addFarmViewModel);
        }

        public IActionResult Details(int id)
        {
            Farm theFarm = context.Farms
                .Single(f => f.Id == id);
            FarmDetailViewModel viewModel = new(theFarm);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                Farm? theFarm = context.Farms.SingleOrDefault(f => f.Id == id);

                if (theFarm != null)
                {
                    context.Farms.Remove(theFarm);

                    context.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }

            return Redirect("/Farms");
        }
    }
}