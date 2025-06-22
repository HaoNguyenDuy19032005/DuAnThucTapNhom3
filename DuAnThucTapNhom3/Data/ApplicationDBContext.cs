using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using DuAnThucTapNhom3.Models;

namespace DuAnThucTapNhom3.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<ClassModel> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClassModel>().ToTable("Classes");

            modelBuilder.Entity<ClassModel>()
                .HasKey(c => c.ClassID);



            modelBuilder.Entity<ClassModel>()
                .HasOne(c => c.Class)
                .WithMany(s => s.Classes)
                .HasForeignKey(c => c.SubjectID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}