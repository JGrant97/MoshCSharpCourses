﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index()
        {

            var movies = _context.Movies.Include(m => m.MovieGenres).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(m => m.MovieGenres).SingleOrDefault(m => m.Id == id);

            if (movies == null)
            {
                return HttpNotFound();
            }

            return View(movies);
        }


        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie(){ Name = "Shrek"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer1"},
                new Customer {Name = "Customer2"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);
        
        }


        
        //[Route("movies/released/{year}/{month:regex(\\d{4):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}