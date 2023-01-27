namespace MindxTest.Infrastructure.Infrastructure
{
    public class DbFactory : Dispoable, IDbFactory
    {
        private MindxDbContext dbContext;
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}

// public MindxDbContext Init()
// {
//     return dbContext ?? (dbContext = new MindxDbContext());
// }