using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoScheduleChallenge.Models;
using CoSchedule_Challenge.Models;
using System.IO;

namespace CoScheduleChallenge.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CocktailDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, CocktailDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCocktail([FromBody] Cocktail model)
        {
            try
            {
                _dbContext.Cocktails.Add(model);
                _dbContext.SaveChanges();
                return new JsonResult($"Successfully Added the Cocktail {model.Name} to your Favorites.");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message + "\n" + ex.StackTrace);
                return BadRequest($"An error occurred. {ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult Favorites()
        {
            return View(_dbContext.Cocktails.ToList());
        }

        [HttpGet]
        public ActionResult EditCocktail(string id)
        {
            Cocktail cocktail = new Cocktail();
            var _cocktail = _dbContext.Cocktails.Find(id);
            cocktail = _cocktail;

            return View(cocktail);
        }

        [HttpPost]
        public IActionResult EditCocktail(Cocktail model)
        {
            Cocktail getCocktail = _dbContext.Cocktails.Find(model.Id);

            try
            {
                getCocktail.Name = model.Name;
                getCocktail.Instructions = model.Instructions;
                getCocktail.DrinkCategory = model.DrinkCategory;
                getCocktail.DrinkType = model.DrinkType;
                getCocktail.GlassType = model.GlassType;
                getCocktail.ImageLink = model.ImageLink;
                getCocktail.Ingredient1 = model.Ingredient1;
                getCocktail.Ingredient2 = model.Ingredient2;
                getCocktail.Ingredient3 = model.Ingredient3;
                getCocktail.Ingredient4 = model.Ingredient4;
                getCocktail.Ingredient5 = model.Ingredient5;
                getCocktail.Ingredient6 = model.Ingredient6;
                getCocktail.Ingredient7 = model.Ingredient7;
                getCocktail.Ingredient8 = model.Ingredient8;
                getCocktail.Ingredient9 = model.Ingredient9;
                getCocktail.Ingredient10 = model.Ingredient10;
                getCocktail.Ingredient11 = model.Ingredient11;
                getCocktail.Ingredient12 = model.Ingredient12;
                getCocktail.Ingredient13 = model.Ingredient13;
                getCocktail.Ingredient14 = model.Ingredient14;
                getCocktail.Ingredient15 = model.Ingredient15;
                getCocktail.MeasureForIngredient1 = model.MeasureForIngredient1;
                getCocktail.MeasureForIngredient2 = model.MeasureForIngredient2;
                getCocktail.MeasureForIngredient3 = model.MeasureForIngredient3;
                getCocktail.MeasureForIngredient4 = model.MeasureForIngredient4;
                getCocktail.MeasureForIngredient5 = model.MeasureForIngredient5;
                getCocktail.MeasureForIngredient6 = model.MeasureForIngredient6;
                getCocktail.MeasureForIngredient7 = model.MeasureForIngredient7;
                getCocktail.MeasureForIngredient8 = model.MeasureForIngredient8;
                getCocktail.MeasureForIngredient9 = model.MeasureForIngredient9;
                getCocktail.MeasureForIngredient10 = model.MeasureForIngredient10;
                getCocktail.MeasureForIngredient11 = model.MeasureForIngredient11;
                getCocktail.MeasureForIngredient12 = model.MeasureForIngredient12;
                getCocktail.MeasureForIngredient13 = model.MeasureForIngredient13;
                getCocktail.MeasureForIngredient14 = model.MeasureForIngredient14;
                getCocktail.MeasureForIngredient15 = model.MeasureForIngredient15;

                _dbContext.SaveChanges();
                return RedirectToAction("Favorites");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest($"Error occurred. {ex.Message}");
            }
        }

        [HttpDelete]
        public ActionResult DeleteCocktail(string id)
        {
            Cocktail cocktail = _dbContext.Cocktails.Find(id);
            string cocktailName = cocktail.Name;
            try
            {
                _dbContext.Cocktails.Remove(cocktail);
                _dbContext.SaveChanges();
                return new JsonResult($"{cocktailName} has been deleted successfully.");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest($"An error occurred. {ex.Message}");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
