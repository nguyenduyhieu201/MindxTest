using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MindxTest.Model.Model;

namespace MindxTest.Infrastructure.Configuration
{
    public class ResumeConfiguration : IEntityTypeConfiguration<Resume>
    {
        public void Configure(EntityTypeBuilder<Resume> builder)
        {
            builder.HasOne<User>(s => s.User)
                   .WithMany(r => r.Resumes);
        }

    }
}


           // builder.HasOne(b => b.Skill).WithOne(s => s.Resume);
            // builder.HasOne(b => b.Information).WithOne(i => i.Resume);
            // builder.HasOne(b => b.Experience).WithOne(e => e.Resume);
            // builder.HasOne(b => b.Education).WithOne(e => e.Resume);