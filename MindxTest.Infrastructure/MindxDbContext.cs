// using MindxTest.Infrastructure.Configuration;
using MindxTest.Model.Model;
using Microsoft.EntityFrameworkCore;
using MindxTest.Infrastructure.Configuration;

namespace MindxTest.Infrastructure.Infrastructure
{
    public class MindxDbContext : DbContext
    {
        public MindxDbContext(DbContextOptions<MindxDbContext> options) : base(options)
        {
        }
        public DbSet<Resume> Resumes { set; get; }
        public DbSet<User> Users { set; get; }

        protected override void OnModelCreating(ModelBuilder buillder)
        {
            buillder.ApplyConfigurationsFromAssembly(typeof(ResumeConfiguration).Assembly);
            buillder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
        }
    }
}

// public DbSet<Skill> Skills { set; get; }

// public DbSet<Education> Educations { set; get; }
// public DbSet<Experience> Experiences { set; get; }
// public DbSet<Information> Informations { set; get; }

// buillder.ApplyConfigurationsFromAssembly(typeof(AssetConfiguration).Assembly);
// buillder.ApplyConfigurationsFromAssembly(typeof(AssignmentConfiguration).Assembly);
// buillder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
// buillder.ApplyConfigurationsFromAssembly(typeof(ReturnForRequestConfiguration).Assembly);
// buillder.ApplyConfigurationsFromAssembly(typeof(CategoryConfiguration).Assembly);

// public MindxDbContext()
// {

// }