using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(BedBoxDbContext context)
            : base(context)
        {

        }

        public BedBoxDbContext context { get { return _context as BedBoxDbContext; } }


    }
}
