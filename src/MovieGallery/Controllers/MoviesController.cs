using MovieGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieGallery.Data;

namespace MovieGallery.Controllers
{
	public class MoviesController : Controller
	{
		private MovieRepository _movieRepository = null;

		public MoviesController() {
			_movieRepository = new MovieRepository();
		}

		public ActionResult Detail(int? id)
		{
			if (id == null)
				return HttpNotFound();

			Movie movie = _movieRepository.GetMovie(id.Value);

			return View(movie);
		}

		public ActionResult Index()
		{
			Movie[] movies = _movieRepository.GetMovies();

			return View(movies);
		}
	}
}