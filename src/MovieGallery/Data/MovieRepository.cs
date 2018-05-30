using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieGallery.Models;

namespace MovieGallery.Data
{
	public class MovieRepository
	{
		private static Movie[] _movies = new Movie[] {
			new Movie() {
				Title = "The Dark Knight",
				ReleaseDate = new DateTime(2008, 7, 18),
				DescriptionHtml = "<p>With the help of allies Lt. Jim Gordon (Gary Oldman) and DA Harvey Dent (Aaron Eckhart), Batman (Christian Bale) has been able to keep a tight lid on crime in Gotham City. But when a vile young criminal calling himself the Joker (Heath Ledger) suddenly throws the town into chaos, the caped Crusader begins to tread a fine line between heroism and vigilantism.</p>",
				Actors = new Actor[] {
					new Actor() { Name = "Christian Bale", Role ="Batman/Bruce Wayne" },
					new Actor() { Name = "Heath Ledger", Role ="The Joker" },
					new Actor() { Name = "Gary Oldman", Role ="Commissioner Gordon" }
				},
				Id = 1
			}
		};

		public Movie GetMovie(int id)
		{
			Movie movieToReturn = null;
			foreach (Movie movie in _movies)
			{
				if (movie.Id == id)
				{
					movieToReturn = movie;
					break;
				}
			}

			return movieToReturn;
		}

		public Movie[] GetMovies()
		{
			return _movies;
		}
	}
}