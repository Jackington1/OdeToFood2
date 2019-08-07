using Microsoft.EntityFrameworkCore;
using OdeToFood2.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood2.Data
{
    public class OdeToFood2DbContext : DbContext
    {

        public OdeToFood2DbContext(DbContextOptions<OdeToFood2DbContext> options) : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
