using DataAccessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class UnitOfWork : IUnitOfWork
    {

        protected readonly BedBoxDbContext _context;

        public UnitOfWork(BedBoxDbContext context)
        {
            _context = context;

            IBoxRepository = new BoxRepository(_context);
            IOrderRepository = new OrderRepository(_context);
            IAddressRepository = new AddressRepository(_context);
            ICategoryRepository = new CategoryRepository(_context);
            IProductRepository = new ProductRepository(_context);

        }

        public IBoxRepository IBoxRepository { get; private set; }

        public IOrderRepository IOrderRepository { get; private set; }

        public IAddressRepository IAddressRepository { get; private set; }

        public ICategoryRepository ICategoryRepository { get; private set; }

        public IProductRepository IProductRepository { get; private set; }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public async void Dispose()
        {
           await _context.DisposeAsync();

        }

       
    }
}
