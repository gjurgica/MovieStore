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
        public bool CommingSoon { get; set; }
        public double Rank { get; set; }
        public MovieModel() { }
        public MovieModel(int id,string title,string director,string description,double rank, bool commingSoon = false)
        {
            Id = id;
            Title = title;
            Director = director;
            Description = description;
            Rank = rank;
            CommingSoon = commingSoon;
        }
    }
}
