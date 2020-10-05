using DDDStore.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Application.Interfaces
{
    interface IApplicationCustomerService
    {
        void Add(CustomerDTO customerDTO);
        CustomerDTO GetById(int id);
        IEnumerable<CustomerDTO> GetAll();
        void Update(CustomerDTO customerDTO);
        void Remove(CustomerDTO customerDTO);
        void Dispose();
    }
}
