using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using act.Models;

namespace act.Contexts
{
    internal class ProjectsContext:DbContext
    {
        public DbSet<ProjectModel> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=act.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectModel>().HasData(
                new ProjectModel { Name = "Project 1", Description = "project 1", StartDate = DateOnly.Parse("04/12/2023"), EndDate = DateOnly.Parse("06/12/2023") },
                new ProjectModel { Name = "Project 2", Description = "project 2", StartDate = DateOnly.Parse("05/22/2023"), EndDate = DateOnly.Parse("08/30/2023") });


        }
    }
}
