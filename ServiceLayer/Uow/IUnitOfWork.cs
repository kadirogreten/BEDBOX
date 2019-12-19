using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IUnitOfWork : IDisposable
    {
        IBoxRepository IBoxRepository { get;}
        IOrderRepository IOrderRepository { get; }
        IAddressRepository IAddressRepository { get; }
        ICategoryRepository ICategoryRepository { get; }
        IProductRepository IProductRepository { get; }


        Task<int> Complete();
    }
}
