using System;
using TOBI.Model.Models;
using TOBI.Data.Infrastructure;
using TOBI.Infrastructure;


namespace TOBI.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private TOBIDbConText dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public TOBIDbConText DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }
      

        public void Commit()
        {
            DbContext.SaveChanges();
        }

     
    }
}