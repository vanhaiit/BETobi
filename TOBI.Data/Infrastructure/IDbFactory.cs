using TOBI.Model.Models;
using System;

namespace TOBI.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TOBIDbConText Init();
    }
}