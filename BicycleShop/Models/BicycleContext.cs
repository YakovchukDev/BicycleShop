﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BicycleShop.Models
{
    public class BicycleContext : DbContext
    {
        public DbSet<Bicycle> Bicycles { get; set; }
        public BicycleContext(DbContextOptions<BicycleContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}