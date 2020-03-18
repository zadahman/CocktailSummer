using CoScheduleChallenge.DataContext;
using CoScheduleChallenge.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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
            User user = _dbContext.Users.FirstOrDefault();
            if (user != null)
            {
                return RedirectToAction("CocktailHome"); 
            }
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(User model)
        {
            try
            {
                _dbContext.Users.Add(model);
                _dbContext.SaveChanges();
                return View("CocktailHome");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message + "\n" + ex.StackTrace);
                return BadRequest($"An error occurred. {ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult CocktailHome()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCocktail([FromBody] Cocktail model)
        {
            try
            {
                User user = _dbContext.Users.FirstOrDefault();
                _dbContext.Cocktails.Add(model);
                _dbContext.SaveChanges();
                return new JsonResult($"{user.Username}, the {model.Name} Cocktail has been Successfully Added to your Favorites.");
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
        public IActionResult EditCocktail(string id)
        {
            Cocktail cocktail = _dbContext.Cocktails.Find(id);
            return View(cocktail);
        }


        [HttpGet]
        public ActionResult GetComment()
        {
            try
            {
                Comment getComment = new Comment();

                if (_dbContext.Comments.Any())
                {
                    getComment = _dbContext.Comments.FirstOrDefault();
                }

                return new JsonResult(getComment.UserComment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest($"Error occurred. {ex.Message}");
            }
        }

        [HttpPost]
        public ActionResult UpdateComment([FromBody] string comment)
        {
            try
            {
                Comment getComment = new Comment();

                if (_dbContext.Comments.Any())
                {
                    getComment = _dbContext.Comments.FirstOrDefault();
                }

                getComment.UserComment = comment;
                _dbContext.SaveChanges();

                return new JsonResult(getComment.UserComment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest($"Error occurred. {ex.Message}");
            }
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
                return new JsonResult($"{cocktailName} cocktail has been deleted successfully.");
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
