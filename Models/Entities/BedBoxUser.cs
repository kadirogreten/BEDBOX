
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BedBoxUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }


        public ICollection<Address> Address { get; set; }
        public ICollection<Order> Order { get; set; }
    }

   
}
