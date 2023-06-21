using Examsystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Examsystem.Config
{
    public class TeaherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(t => t.teacherId);
            builder.Property(t => t.teacherId).ValueGeneratedOnAdd();
            builder.HasMany(t => t.exams)
                   .WithOne(e => e.teacher)
                   .HasForeignKey(e => e.teacherId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
