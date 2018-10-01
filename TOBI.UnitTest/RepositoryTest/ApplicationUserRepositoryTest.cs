using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TOBI.Data.Infrastructure;
using TOBI.Data.Repositories;
using TOBI.Infrastructure;
using TOBI.Model.Models;

namespace TOBI.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IApplicationUserRepository objRepository;
        IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new ApplicationUserRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(1, list.Count);
        }

    }
}