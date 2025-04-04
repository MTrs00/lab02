using lab02;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("GUI")]


namespace lab02
{
    internal class spaceRecord : DbContext
    {
        public DbSet<peopleInSpace> PeopleInSpaces { get; set; }
        public spaceRecord()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=Univ.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<peopleInSpace>().HasData(
                new peopleInSpace()
                {
                    Id = 1,
                    message = "success",
                    number = 1
                }
            );

            modelBuilder.Entity<personInSpace>().HasData(
                new personInSpace() { Id = 1, name = "Mateusz", craft = "ISS", peopleInSpaceId = 1 }
               );
        }
    }
}
