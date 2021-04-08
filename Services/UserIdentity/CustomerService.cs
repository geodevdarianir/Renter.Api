using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.UserIdentity
{
    public class CustomerService : ICustomerService
    {
        public readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }


    }
}
