using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MockAPI.Models;

namespace MockAPI.Infrastructure
{
    public class MockAPIDbContext : DbContext
    {
        public DbSet<Place> Places { get; set; }
    }
}