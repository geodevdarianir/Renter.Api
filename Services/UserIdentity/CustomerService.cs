using Entities.Context;
using Entities.Models.Users;
using Repository;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.UserIdentity
{
    public class CustomerService : ICustomerService
    {
        public readonly IRepository<Address> _adress;
        private readonly ApplicationDbContext _context;
        public CustomerService(IRepository<Address> adress, ApplicationDbContext context)
        {
            _adress = adress;
            _context = context;
        }

        public void test()
        {
            Guid id = new Guid();
            _adress.GetByIdAsync(id);

            _context.Addresses.Where(p => p.Id == id);
        }

    }
}
