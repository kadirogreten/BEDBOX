using DataAccessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class UnitOfWork : IUnitOfWork
    {

        protected readonly BedBoxDbContext _context;

        public UnitOfWork(BedBoxDbContext context)
        {
            _context = context;

            BoxRepository = new BoxRepository(_context);

        }

        public IBoxRepository BoxRepository { get; private set; }
      

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();

        }
    }
}
