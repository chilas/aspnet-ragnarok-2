using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp
{
    public enum Rating
    {
        Poor,
        Good,
        veryGood,
        Excellent
    }
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Rating Rating { get; set; }
    }
    public class HomeController : Controller
    {
        public string Index()
        {
            var model = "Hello Jollof!";
            return model;
        }
        public IActionResult Jollof()
        {
            var model = "Hello Jollof Again!";
            return View("Jollof", model);
        }

        [Route("api/menu")]
        public IActionResult Menu()
        {
            var model = new List<Menu>()
            {
                new Menu{
                    Id = 1,
                    Name = "Nigerian Jollof",
                    Rating = Rating.Excellent
                },
                new Menu {
                    Id = 2,
                    Name = "Amala",
                    Rating = Rating.veryGood
                },
                new Menu {
                    Id = 3,
                    Name = "Ghanaian Jollof",
                    Rating = Rating.Poor
                }
            };

            return new ObjectResult(model);
        }
    }
}