﻿using System;
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
			return Content("Hello World");
		}
	}
}