using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_lah263.Models
{
    public class MovieApplicationContext: DbContext
    {
        public MovieApplicationContext (DbContextOptions<MovieApplicationContext> options) : base (options)
        {
            //leave blank
        }
        public DbSet<NewMovie> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<NewMovie>().HasData(
                
                new NewMovie
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
                    Title = "The Accountant",
                    Year = 2016,
                    Director = "Rod",
                    Rating = "R",
                    Edited = true
                },
                new NewMovie
                {
                    MovieID = 2,
                    Category = "Comedy",
                    Title = "Nacho Libre",
                    Year = 2006,
                    Director = "Jared Hess",
                    Rating = "PG",
                    Edited = false
                },
                new NewMovie
                {
                    MovieID = 3,
                    Category = "Drama",
                    Title = "Ever After",
                    Year = 1998,
                    Director = "Andy Tennant",
                    Rating = "PG",
                    Edited = false
                }
            );
        }
    }
}
