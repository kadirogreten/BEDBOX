using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public interface IUnitOfWork : IDisposable
    {
        IBoxRepository BoxRepository { get;}


        int Complete();
    }
}
