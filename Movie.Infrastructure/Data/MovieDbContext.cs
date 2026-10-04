using Microsoft.EntityFrameworkCore;
using Movie.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Infrastructure.Data
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie.Domain.Entities.Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public Dbs
    }
}
