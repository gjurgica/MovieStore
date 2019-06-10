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

                new MovieModel(1, "Fantastic Mr. Fox", "Wes Anderson", "An urbane fox cannot resist returning to his farm raiding ways and then must help his community survive the farmers' retaliation.", 265),
                new MovieModel(2, "The Life Aquatic with Steve Zissou", "Wes Anderson", "With a plan to exact revenge on a mythical shark that killed his partner, Oceanographer Steve Zissou rallies a crew that includes his estranged wife, a journalist, and a man who may or may not be his son.", 250),
                new MovieModel(3, "Rushmore", "Wes Anderson", "The extracurricular king of Rushmore Preparatory School is put on academic probation.", 350)

        };
        public IActionResult Index()
        {

            return View(Movies);
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Contact()
        {

            return View();
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
