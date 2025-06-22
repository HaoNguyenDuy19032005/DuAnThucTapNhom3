using Microsoft.EntityFrameworkCore;
using DuAnThucTapNhom3.Models;

namespace DuAnThucTapNhom3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet cho các bảng
        public DbSet<SubjectModel> Subjects { get; set; }
        public DbSet<SubjectTypeModel> SubjectTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Đặt tên bảng và cột theo kiểu PostgreSQL (optional)
            modelBuilder.Entity<SubjectModel>().ToTable("subjects");
            modelBuilder.Entity<SubjectTypeModel>().ToTable("subject_types");

            modelBuilder.Entity<SubjectModel>()
                .HasKey(s => s.SubjectCode);

            modelBuilder.Entity<SubjectTypeModel>()
                .HasKey(st => st.SubjectTypeID);

            modelBuilder.Entity<SubjectModel>()
                .HasOne(s => s.SubjectType)
                .WithMany(st => st.Subjects)
                .HasForeignKey(s => s.SubjectTypeID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
