using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMvcApp.Models;

namespace MyMvcApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry 
                { 
                    Id = 1, 
                    Title="Went Hiking",
                    Content="Went hiking with Joe!", 
                    Created = new DateTime(2024, 04, 20, 12, 0, 0)
                },
                new DiaryEntry 
                { 
                    Id = 2, 
                    Title="Went shopping",
                    Content="Went shopping with Joe!", 
                    Created = new DateTime(2024, 04, 20, 12, 0, 0)
                },
                new DiaryEntry 
                { 
                    Id = 3, 
                    Title="Went swim",
                    Content="Went swim with Joe!", 
                    Created = new DateTime(2024, 04, 20, 12, 0, 0)
                }
            );
        }
    }
}