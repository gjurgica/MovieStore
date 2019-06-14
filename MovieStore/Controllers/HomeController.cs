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

                new MovieModel(1, "Fantastic Mr. Fox", "Wes Anderson", "An urbane fox cannot resist returning to his farm raiding ways and then must help his community survive the farmers' retaliation.",9.2,"https://is3-ssl.mzstatic.com/image/thumb/Video128/v4/81/cb/97/81cb9711-d122-9f9a-6c21-84bf64ce62e3/contsched.mklrrrvf.lsr/268x0w.jpg"),
                new MovieModel(2, "The Life Aquatic with Steve Zissou", "Wes Anderson", "With a plan to exact revenge on a mythical shark that killed his partner, Oceanographer Steve Zissou rallies a crew that includes his estranged wife, a journalist, and a man who may or may not be his son.",9.1,"https://uvmbored.com/wp-content/uploads/2017/09/17152dd137d39aaa25d81e4a89dcd7d1.jpg"),
                new MovieModel(3, "Rushmore", "Wes Anderson", "The extracurricular king of Rushmore Preparatory School is put on academic probation.",9.1,"https://upload.wikimedia.org/wikipedia/en/thumb/4/42/Rushmoreposter.png/220px-Rushmoreposter.png"),
                new MovieModel(4, "Wonder Woman ", "Patty Jenkins", "Plot unknown. A sequel to the 2017 super hero film 'Wonder Woman'.",8.9,"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSi_mkbN_GwV0BbHv_n72Wu0Ow0WJoNwBStbtoBk-IYLThKZlgt",true),
                new MovieModel(5, "Godzilla vs. Kong", "Adam Wingard", "As the gigantic Kong meets the unstoppable Godzilla, the world watches to see which one of them will become King of the Monsters.",9.0,"https://i.pinimg.com/originals/db/e2/92/dbe29210395ba76a389547ba0083437c.jpg",true),
                new MovieModel(6, "Onward", "Dan Scanlon", "Set in a suburban fantasy world, two teenage elf brothers embark on a quest to discover if there is still magic out there.",8.8,"https://i2.wp.com/thankthephoenicians.com/wp-content/uploads/2018/12/Disney-Pixar-Onward.png?fit=683%2C1024",true),

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
