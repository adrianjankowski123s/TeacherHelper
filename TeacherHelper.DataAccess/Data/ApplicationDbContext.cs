using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeacherHelper.Models;

namespace TeacherHelper.DataAccess.Repository.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Logbook> Logbooks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Grade>()
            .HasOne(e => e.Teacher)
            .WithMany(e => e.Grades)
            .HasForeignKey(s => s.TeacherId)
            .IsRequired(false);

            modelBuilder.Entity<Logbook>()
         .HasOne(e => e.Teacher)
         .WithMany(e => e.Logbooks)
         .HasForeignKey(s => s.TeacherId)
         .IsRequired(false);

            modelBuilder.Entity<Student>()
         .HasOne(e => e.Grade)
         .WithMany(e => e.Students)
         .HasForeignKey(s => s.GradeId)
         .IsRequired(false);


        }

    }

}

