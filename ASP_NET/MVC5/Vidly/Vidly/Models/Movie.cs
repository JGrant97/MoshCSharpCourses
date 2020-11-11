using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int Stock { get; set; }
        [ForeignKey("MovieGenres_Id")]

        public MovieGenres MovieGenres { get; set; }

        public byte MovieGenres_Id { get; set; }
    }
}