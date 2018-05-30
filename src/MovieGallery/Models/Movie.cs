using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieGallery.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string Title { get; set; }
		public string DescriptionHtml { get; set; }
		public Actor[] Actors { get; set; }
		public bool Favorite { get; set; }

		// title-year.jpg
		public string CoverImageFileName 
		{
			get 
			{
				return Title.ToLower() + "-" + ReleaseDate.Year + ".jpg";
			}
		}

		public string ReleaseDateDisplay 
		{ 
			get 
			{
				return ReleaseDate.ToString("MMMM dd, yyyy");
			} 
		}
	}
}