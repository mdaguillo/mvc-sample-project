using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieGallery.Controllers
{
	public class MoviesController : Controller
	{
		public ActionResult Detail()
		{
			ViewBag.MovieTitle = "The Dark Knight";
			ViewBag.ReleaseYear = 2008;

			return View();
		}
	}
}