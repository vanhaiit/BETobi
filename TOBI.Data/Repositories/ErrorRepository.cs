using TOBI.Data.Infrastructure;
using TOBI.Infrastructure;
using TOBI.Model.Models;

namespace TOBI.Data.Repositories
{
    public interface IErrorRepository : IRepository<Error>
    {
    }

    public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}