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
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(a => a.Id);
            builder.HasIndex(a => a.userName).IsUnique();
            builder.HasCheckConstraint("gender", "gender in ('m','M','f','F')");
            builder.HasOne(a => a.student)
                .WithOne(s => s.account)
                .HasForeignKey<Student>(s => s.accId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.teacher)
                .WithOne(t => t.account)
                .HasForeignKey<Teacher>(t => t.accId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
