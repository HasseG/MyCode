using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MyFirstWebApp.Data
{
    public class MyFirstWebAppContext : DbContext
    {
        public MyFirstWebAppContext (DbContextOptions<MyFirstWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
