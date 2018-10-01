using TOBI.Infrastructure;
using TOBI.Data.Infrastructure;
using TOBI.Data.Repositories;
using TOBI.Model.Models;
using System;
using System.Collections.Generic;

namespace TOBI.Service
{
    public interface IApplicationUserService
    {
        IEnumerable<ApplicationUser> GetAll();
       
        void Update(ApplicationUser appUser);
        void Save();
    }


    public class ApplicationUserService : IApplicationUserService
    {
        private IApplicationUserRepository _appUserRepository;
        private IUnitOfWork _unitOfWork;
        public ApplicationUserService(IUnitOfWork unitOfWork,
            IApplicationUserRepository appUserRepository)
        {
            this._appUserRepository = appUserRepository;
            this._unitOfWork = unitOfWork;
        }

       
        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ApplicationUser appUser)
        {
            _appUserRepository.Update(appUser);
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return _appUserRepository.GetAll();
        }
    }
}