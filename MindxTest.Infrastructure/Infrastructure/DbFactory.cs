namespace MindxTest.Infrastructure.Infrastructure
{
    public class DbFactory : Dispoable, IDbFactory
    {
        private MindxDbContext dbContext;
        public MindxDbContext Init()
        {
            return dbContext ?? (dbContext = new MindxDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}