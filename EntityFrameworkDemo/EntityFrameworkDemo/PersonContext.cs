using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class PersonContext : DbContext
    {
        internal DbSet<Person> People { get; set; }
        internal DbSet<Person2> OtherPeople { get; set; }
        internal DbSet<Person3> OtherOtherPeople { get; set; }
        internal DbSet<Person3> NewPeoble { get; set; }
        protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=People.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Make Id required.
            modelBuilder.Entity<Person>()
                .Property(p => p.Id)
                .IsRequired();

            // Make Name required.
            modelBuilder.Entity<Person3>()
                .Property(p => p.Name)
                .IsRequired();

            modelBuilder.Entity<Person2>()
             .Property(p => p.Id)
             .IsRequired();
            modelBuilder.Entity<Person4>()
            .Property(p => p.Id)
            .IsRequired();
        }
    }
}
