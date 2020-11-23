using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Release Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        [Required]
        [Range(1, 20)]
        public int Stock { get; set; }

        public int NumberAvailable { get; set; }

        [ForeignKey("MovieGenres_Id")]
        public MovieGenres MovieGenres { get; set; }

        [Display(Name = "Movie Genres")]
        [Required]
        public byte MovieGenres_Id { get; set; }
    }
}