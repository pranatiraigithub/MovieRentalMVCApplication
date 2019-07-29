using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieRentalMVCApplication.Models;
using System.Web.Mvc;
using System.Data.Entity;
using MovieRentalMVCApplication.ViewModels;


namespace MovieRentalMVCApplication.Controllers
{
    public class MovieController : Controller
    {
        ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movie
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();
            return View(movies);
        }
        public ActionResult Details(int? id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);
            return View(movie);
        }
        public ActionResult MovieNewView(Movie movie)
        {
            var genres = _context.Genres.ToList();
            var newmovieviewModel = new NewMovieViewModel
            {
                Movie= movie,
                Genres = genres
            };
            return View(newmovieviewModel);
        }
        public ActionResult Edit(int? id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            var viewModel = new NewMovieViewModel
            {
                Movie= movie,
                Genres= _context.Genres.ToList()
            };
            return View("MovieNewView", viewModel);
        }
        [HttpPost]

        public ActionResult Save(Movie movie)
        {
            //if (!ModelState.IsValid)
            //{
            //    var viewModel = new NewMovieViewModel
            //    {
            //        Movie = movie,
            //        Genres = _context.Genres.ToList()
            //    };
            //    return View("MovieForm", viewModel);
            //}

            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                movieInDb.MovieName = movie.MovieName;
                movieInDb.NoOfCDs = movie.NoOfCDs;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movie");
        }

        public ActionResult Delete(int? Id)
        {
            Movie movie = _context.Movies.Find(Id);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }

}