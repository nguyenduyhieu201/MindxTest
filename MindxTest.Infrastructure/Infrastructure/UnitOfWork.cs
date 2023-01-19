namespace MindxTest.Infrastructure.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private readonly MindxDbContext _MindxDbContext;
        public UnitOfWork(IDbFactory dbFactory, MindxDbContext MindxDbContext)
        {
            _dbFactory = dbFactory;
            _MindxDbContext = MindxDbContext;
        }
        public async Task<int> Commit()
        {
            return await _MindxDbContext.SaveChangesAsync();
        }
    }
}