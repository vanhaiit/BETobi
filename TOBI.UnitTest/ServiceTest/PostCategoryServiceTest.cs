using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using TOBI.Data.Infrastructure;
using TOBI.Data.Repositories;
using TOBI.Model.Models;
using TOBI.Service;

namespace TOBI.UnitTest.ServiceTest
{
    //[TestClass]
    //public class PostCategoryServiceTest
    //{
    //    private Mock<IApplicationUserRepository> _mockRepository;
    //    private Mock<IUnitOfWork> _mockUnitOfWork;
    //    private IApplicationUserService _categoryService;
    //    private List<ApplicationUser> listUser;


    //    [TestInitialize]
    //    public void Initialize()
    //    {
    //        _mockRepository = new Mock<IApplicationUserRepository>();
    //        _mockUnitOfWork = new Mock<IUnitOfWork>();
    //    }

    //    [TestMethod]
    //    public void PostCategory_Service_GetAll()
    //    {
    //        var list = listUser.Select(s => new { s.User_id, s.UserName, s.Account_id, s.PasswordHash, s.History_id,s.TotalAmount }).ToList();
    //        //setup method
    //        _mockRepository.Setup(m => m.GetAll(null)).Returns(list);

    //        //call action
    //        var result = _categoryService.GetAll() as List<listUser>;

    //        //compare
    //        Assert.IsNotNull(result);
    //        Assert.AreEqual(0,result.Count);
    //    }
       
    //}
}
