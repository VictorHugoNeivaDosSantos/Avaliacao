using AvaliaçãoTecnobyte.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliaçãoTecnobyte.Context
{
    public class ContextSystem : DbContext
    {
        public DbSet<People> People { get; set; }

        public ContextSystem(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>()
                .HasKey(hk => hk.PeopleId);
            modelBuilder.Entity<People>()
                .Property(p => p.PeopleId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<People>()
                .HasIndex(p => p.CpfCnpj)
                .IsUnique(true);

            base.OnModelCreating(modelBuilder);
        }
    }
}
