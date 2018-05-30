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
			new Movie()
			{
				Title = "The Dark Knight",
				ReleaseDate = new DateTime(2008, 7, 18),
				DescriptionHtml = "<p>With the help of allies Lt. Jim Gordon (Gary Oldman) and DA Harvey Dent (Aaron Eckhart), Batman (Christian Bale) has been able to keep a tight lid on crime in Gotham City. But when a vile young criminal calling himself the Joker (Heath Ledger) suddenly throws the town into chaos, the caped Crusader begins to tread a fine line between heroism and vigilantism.</p>",
				Actors = new Actor[] {
					new Actor() { Name = "Christian Bale", Role ="Batman/Bruce Wayne" },
					new Actor() { Name = "Heath Ledger", Role ="The Joker" },
					new Actor() { Name = "Gary Oldman", Role ="Commissioner Gordon" }
				},
				Id = 1
			},
			new Movie()
			{
				Title = "Arrival",
				ReleaseDate = new DateTime(2016, 11, 11),
				DescriptionHtml = "<p>Linguistics professor Louise Banks (Amy Adams) leads an elite team of investigators when gigantic spaceships touch down in 12 locations around the world. As nations teeter on the verge of global war, Banks and her crew must race against time to find a way to communicate with the extraterrestrial visitors. Hoping to unravel the mystery, she takes a chance that could threaten her life and quite possibly all of mankind.</p>",
				Actors = new Actor[] {
					new Actor() { Name = "Amy Adams", Role = "Dr. Louise Banks" },
					new Actor() { Name = "Jeremy Renner", Role = "Ian Donnelly" },
					new Actor() { Name = "Forest Whitaker", Role = "Colonel Walker" }
				},
				Id = 2,
				Favorite = true
			},
			new Movie()
			{
				Title = "Blade Runner 2049",
				ReleaseDate = new DateTime(2017, 10, 3),
				DescriptionHtml = "<p>Officer K (Ryan Gosling), a new blade runner for the Los Angeles Police Department, unearths a long-buried secret that has the potential to plunge what's left of society into chaos. His discovery leads him on a quest to find Rick Deckard (Harrison Ford), a former blade runner who's been missing for 30 years.</p>",
				Actors = new Actor[] { 
					new Actor() { Name = "Ryan Gosling", Role = "Officer K" },
					new Actor() { Name = "Harrison Ford", Role = "Rick Deckard" },
					new Actor() { Name = "Ana de Armas", Role = "Joi" }
				},
				Id = 3,
				Favorite = true
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