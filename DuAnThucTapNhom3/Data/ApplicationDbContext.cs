using DuAnThucTapNhom3.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace DuAnThucTapNhom3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<SubjectType> SubjectType { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
