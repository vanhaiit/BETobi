namespace TOBI.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}