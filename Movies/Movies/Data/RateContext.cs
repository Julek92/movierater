using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movies.Models;

namespace Movies.Data
{
    public class RateContext : DbContext
    {
        public RateContext(DbContextOptions<RateContext> options) : base(options)
        {
        }

        public DbSet<Rate> Rate { get; set; }

    }
}
