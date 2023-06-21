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
    internal class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(q => q.questionId);
            builder.Property(q => q.examId).IsRequired(false);
            builder.HasOne(q => q.exam)
                   .WithMany(e => e.questions)
                   .HasForeignKey(q => q.examId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
