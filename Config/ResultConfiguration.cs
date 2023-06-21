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
    internal class ResultConfiguration : IEntityTypeConfiguration<Result>
    {
        public void Configure(EntityTypeBuilder<Result> builder)
        {
            builder.HasKey(r => new { r.sId, r.examId });
            builder.Property(r => r.examId).IsRequired();
            builder.Property(r => r.sId).IsRequired();
            builder.HasOne(r => r.student)
                   .WithMany(s => s.results)
                   .HasForeignKey(r => r.sId)
                   .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(r => r.exam)
                   .WithMany(e => e.results)
                   .HasForeignKey(r => r.examId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
