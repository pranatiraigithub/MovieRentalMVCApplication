using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieRentalMVCApplication.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public int GenreId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateofAddingCD { get; set; }
        public int NoOfCDs { get; set; }
        public Genre Genre { get; set; }
 
    }
}