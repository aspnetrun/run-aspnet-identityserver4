using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movies.API.Models;

namespace Movies.API.Data
{
    public class MoviesAPIContext : DbContext
    {
        public MoviesAPIContext (DbContextOptions<MoviesAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Movies.API.Models.Movie> Movie { get; set; }
    }
}
