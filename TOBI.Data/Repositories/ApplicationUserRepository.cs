using TOBI.Infrastructure;
using TOBI.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TOBI.Data.Repositories
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        List<ApplicationUser> GetAll(string userName);
        ApplicationUser GetUserName(string key);
    }

    public class ApplicationUserRepository : RepositoryBase<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public List<ApplicationUser> GetAll(string userName)
        {
            return this.DbContext.Set<ApplicationUser>().Where<ApplicationUser>(x => x.UserName == userName).ToList();
        }

        public ApplicationUser GetUserName(string key)
        {
            return this.DbContext.Set<ApplicationUser>().Where<ApplicationUser>(x => x.UserName == key).Single();
        }
    }
}