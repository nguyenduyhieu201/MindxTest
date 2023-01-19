namespace MindxTest.Infrastructure.Infrastructure
{
    public interface IUnitOfWork
    {
        public Task<int> Commit();
    }
}