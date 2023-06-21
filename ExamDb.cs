using Examsystem.Config;
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
            new AccountConfiguration().Configure(modelBuilder.Entity<Account>());
            new TeaherConfiguration().Configure(modelBuilder.Entity<Teacher>());
            new QuestionConfiguration().Configure(modelBuilder.Entity<Question>());
            new ResultConfiguration().Configure(modelBuilder.Entity<Result>());

            modelBuilder.Entity<Student>()
                .HasKey(s => s.studentId);
            modelBuilder.Entity<Exam>()
                .HasKey(e => e.examId);

        }
        public virtual DbSet<Account> accounts { get; set; }
        public virtual DbSet<Teacher> teachers { get; set; }
        public virtual DbSet<Student> students { get; set; }
        public virtual DbSet<Result>results { get; set; }
        public virtual DbSet<Exam>exams { get; set; }
        public virtual DbSet<Question>questions { get; set; }
    }
}
