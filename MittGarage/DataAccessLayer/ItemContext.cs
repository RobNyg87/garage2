﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MittGarage.DataAccessLayer
{
    public class ItemContext : DbContext
    {
        public ItemContext() : base("DefaultConnection") { }
        public DbSet<Models.Vehicle> Item { get; set; }
        public DbSet<Models.Owner> Owner { get; set; }
        public DbSet<Models.VehicleType> Types { get; set; }
    }
}