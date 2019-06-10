using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public MovieModel() { }
        public MovieModel(int id,string title,string director,string description,decimal price)
        {
            Id = id;
            Title = title;
            Director = director;
            Description = description;
            Price = price;
        }
    }
}
