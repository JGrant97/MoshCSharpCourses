using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<MovieGenres>MovieGenres { get; set; }
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Required]
        [Range(1, 20)]
        public int? Stock { get; set; }

        [Display(Name = "Movie Genres")]
        [Required]
        public byte? MovieGenres_Id { get; set; }
        public string Title
        {
            get
            {
                if (Id != 0)
                {
                    return "Edit Movie";
                }
                return "New Movie";
            }
        }
        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            Stock = movie.Stock;
            MovieGenres_Id = movie.MovieGenres_Id;
        }
    }
}