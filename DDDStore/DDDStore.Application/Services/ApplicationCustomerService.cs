using DDDStore.Application.DTO;
using DDDStore.Application.Interfaces;
using DDDStore.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Application.Services
{
    public class ApplicationCustomerService : IApplicationCustomerService
    {
        private readonly ICustomerService _customerService;
        public void Add(CustomerDTO customerDTO)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<CustomerDTO> GetAll()
        {
            throw new NotImplementedException();
        }
        public CustomerDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Remove(CustomerDTO customerDTO)
        {
            throw new NotImplementedException();
        }
        public void Update(CustomerDTO customerDTO)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
