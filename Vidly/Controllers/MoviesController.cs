using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModels;
using System;
using System.Data.Entity.Validation;

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

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ViewResult New()
        {
            var genre = _context.Genre.ToList();
            var ViewModel = new MoviesFormViewModel
            {
                Genres = genre
            };
            return View("MoviesForm", ViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MoviesFormViewModel(movie)
                {
                    Genres = _context.Genre.ToList()
                };
                return View("MoviesForm", viewModel);
            }
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();
            var ViewModel = new MoviesFormViewModel(movie)
            {
                Genres = _context.Genre.ToList()
            };
            return View("MoviesForm", ViewModel);
        }
        // GET: Movies
        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
            {
                return View("List");
            }
                
            return View("ReadOnlyList");
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

    }
}