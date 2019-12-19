using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class BedBoxDbContext : IdentityDbContext<BedBoxUser>
    {

        public BedBoxDbContext(DbContextOptions<BedBoxDbContext> options)
            : base(options)
        {
        }

        public DbSet<Box> Box { get; set; }
        public DbSet<BoxImage> BoxImage { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Order> Order { get; set; }

    }
}
