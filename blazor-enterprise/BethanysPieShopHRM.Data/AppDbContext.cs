using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopHRM.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //DbSet
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
           
            
        }
    }
}
