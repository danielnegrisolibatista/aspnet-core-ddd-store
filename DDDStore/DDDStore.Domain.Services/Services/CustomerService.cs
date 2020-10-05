using DDDStore.Domain.Core.Interfaces.Repositories;
using DDDStore.Domain.Core.Interfaces.Services;
using DDDStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Domain.Services.Services
{
    public class CustomerService : BaseService<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository) : base(customerRepository)
        {
            _customerRepository = customerRepository;
        }
    }
}
