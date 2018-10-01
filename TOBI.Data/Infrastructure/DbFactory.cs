using System;
using TOBI.Data.Infrastructure;
using TOBI.Infrastructure;
using TOBI.Infrastructure;
using TOBI.Model.Models;


namespace TOBI.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TOBIDbConText dbContext;

        public TOBIDbConText Init()
        {
            return dbContext ?? (dbContext = new TOBIDbConText());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
            
                
        }
    }
}