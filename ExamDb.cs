using Examsystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examsystem
{
    public class ExamDb:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ExamDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasKey(a => a.Id);
            modelBuilder.Entity<Account>()
                .HasIndex(a => a.userName).IsUnique();
            modelBuilder.Entity<Student>()
                .HasKey(s => s.studentId);
            modelBuilder.Entity<Teacher>()
                .HasKey(t => t.teacherId);
            modelBuilder.Entity<Exam>()
                .HasKey(e => e.examId);
            modelBuilder.Entity<Question>()
                .HasKey(q => q.questionId);
            modelBuilder.Entity<Question>()
                .Property(q=>q.examId).IsRequired(false);
            modelBuilder.Entity<Result>()
                .HasKey(r => new { r.sId, r.examId });
            modelBuilder.Entity<Result>().Property(r => r.examId).IsRequired();
            modelBuilder.Entity<Result>().Property(r => r.sId).IsRequired();
            modelBuilder.Entity<Teacher>().Property(t=>t.teacherId).ValueGeneratedOnAdd();
            #region relationship
            modelBuilder.Entity<Account>()
                .HasOne(a => a.student)
                .WithOne(s => s.account)
                .HasForeignKey<Student>(s => s.accId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Account>()
                .HasOne(a=>a.teacher)
                .WithOne(t => t.account)
                .HasForeignKey<Teacher>(t => t.accId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.exams)
                .WithOne(e => e.teacher)
                .HasForeignKey(e => e.teacherId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Question>()
                .HasOne(q => q.exam)
                .WithMany(e => e.questions)
                .HasForeignKey(q => q.examId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Result>()
                .HasOne(r => r.student)
                .WithMany(s => s.results)
                .HasForeignKey(r => r.sId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Result>()
               .HasOne(r => r.exam)
               .WithMany(e => e.results)
               .HasForeignKey(r => r.examId)
               .OnDelete(DeleteBehavior.Restrict);
            #endregion

        }
        public virtual DbSet<Account> accounts { get; set; }
        public virtual DbSet<Teacher> teachers { get; set; }
        public virtual DbSet<Student> students { get; set; }
        public virtual DbSet<Result>results { get; set; }
        public virtual DbSet<Exam>exams { get; set; }
        public virtual DbSet<Question>questions { get; set; }
    }
}
