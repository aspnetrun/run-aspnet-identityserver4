using IdentityModel.Client;
using Movies.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.ApiServices
{
    public class MovieApiService : IMovieApiService
    {
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            // 1. "retrieve" our api credentials. This must be registered on Identity Server!
            var apiClientCredentials = new ClientCredentialsTokenRequest
            {
                Address = "http://localhost:5005/connect/token",

                ClientId = "movieClient",
                ClientSecret = "secret",

                // This is the scope our Protected API requires. 
                Scope = "movieAPI"
            };


            // TODO : consume API here with IHttpClientFactory classes
            var movieList = new List<Movie>();
            movieList.Add(
                    new Movie
                    {
                        Id = 1,
                        Genre = "Comics",
                        Title = "asd",
                        Rating = "9.3",
                        ImageUrl = "images/src",
                        ReleaseDate = DateTime.Now,
                        Owner = "swn"
                    }
                );

            return await Task.FromResult(movieList);
        }

        public Task<Movie> GetMovie(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> CreateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }
    }
}
