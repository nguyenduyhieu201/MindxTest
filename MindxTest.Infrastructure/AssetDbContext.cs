// using MindxTest.Infrastructure.Configuration;
using MindxTest.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace MindxTest.Infrastructure.Infrastructure
{
    public class MindxDbContext : DbContext
    {
        public MindxDbContext()
        {

        }
        public MindxDbContext(DbContextOptions<MindxDbContext> options) : base(options)
        {

        }
        public DbSet<Education> Educations { set; get; }
        public DbSet<Experience> Experiences { set; get; }
        public DbSet<Information> Informations { set; get; }
        public DbSet<Resume> Resumes { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<Skill> Skills { set; get; }

        protected override void OnModelCreating(ModelBuilder buillder)
        {
            
        }
    }
}



// buillder.ApplyConfigurationsFromAssembly(typeof(AssetConfiguration).Assembly);
            // buillder.ApplyConfigurationsFromAssembly(typeof(AssignmentConfiguration).Assembly);
            // buillder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
            // buillder.ApplyConfigurationsFromAssembly(typeof(ReturnForRequestConfiguration).Assembly);
            // buillder.ApplyConfigurationsFromAssembly(typeof(CategoryConfiguration).Assembly);