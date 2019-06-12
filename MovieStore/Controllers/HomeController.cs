using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Models;

namespace MovieStore.Controllers
{
    public class HomeController : Controller
    {
        public static List<MovieModel> Movies = new List<MovieModel>
        {

                new MovieModel(1, "Fantastic Mr. Fox", "Wes Anderson", "An urbane fox cannot resist returning to his farm raiding ways and then must help his community survive the farmers' retaliation.",9.2),
                new MovieModel(2, "The Life Aquatic with Steve Zissou", "Wes Anderson", "With a plan to exact revenge on a mythical shark that killed his partner, Oceanographer Steve Zissou rallies a crew that includes his estranged wife, a journalist, and a man who may or may not be his son.",9.1),
                new MovieModel(3, "Rushmore", "Wes Anderson", "The extracurricular king of Rushmore Preparatory School is put on academic probation.",9.1),
                new MovieModel(4, "Wonder Woman ", "Patty Jenkins", "Plot unknown. A sequel to the 2017 super hero film 'Wonder Woman'.",8.9,true),
                new MovieModel(5, "Godzilla vs. Kong", "Adam Wingard", "As the gigantic Kong meets the unstoppable Godzilla, the world watches to see which one of them will become King of the Monsters.",9.0,true),
                new MovieModel(6, "Onward", "Dan Scanlon", "Set in a suburban fantasy world, two teenage elf brothers embark on a quest to discover if there is still magic out there.",8.8,true),

        };
        public IActionResult Index()
        {

            return View(Movies);
        }

        public IActionResult Upcoming()
        {

            return View(Movies);
        }

        public IActionResult Reviews()
        {

            return View(Movies);
        }
        public IActionResult Edit(int id)
        {
            var movie = Movies.FirstOrDefault(m => m.Id == id);

            return View(movie);
        }
        public IActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public IActionResult SaveChanges(MovieModel movie)
        {
            if (!ModelState.IsValid) {
                return View("Edit");
            }
            var index = Movies.FindIndex(i => i.Id == movie.Id);
            Movies[index] = movie;
            return View("Index", Movies);
        }
        [HttpPost]
        public IActionResult Add(MovieModel movie)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Movies.Add(movie);
            return View("Index", Movies);
        }
        public IActionResult Delete(int id)
        {
            var movie = Movies.FirstOrDefault(m => m.Id == id);
            Movies.Remove(movie);
            return View("Index",Movies);
        }
    }
}
