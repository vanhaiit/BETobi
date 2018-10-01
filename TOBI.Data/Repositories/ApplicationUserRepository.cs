using TOBI.Infrastructure;
using TOBI.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TOBI.Data.Repositories
{

        
    public interface IApplicationUserRepository :IRepository<ApplicationUser>
    {
        IEnumerable<ApplicationUser> GetByID(string id);
        List<ApplicationUser> GetUser(string id);
    }
    public class ApplicationUserRepository : RepositoryBase<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ApplicationUser> GetByID(string id)
        {
            return this.DbContext.ApplicationUsers.Where(x => x.Id == id);
        }


        public List<ApplicationUser> GetUser(string id)
        {
            return this.DbContext.ApplicationUsers.Where(x => x.Id == id).ToList(); ;
        }
    }
}