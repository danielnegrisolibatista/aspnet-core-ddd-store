using DDDStore.Application.DTO;
using DDDStore.Application.Interfaces;
using DDDStore.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Application.Services
{
    public class ApplicationProductService : IApplicationProductService
    {
        private readonly ICustomerService _customerService;

        public ApplicationProductService(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public void Add(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<ProductDTO> GetAll()
        {
            throw new NotImplementedException();
        }
        public ProductDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Remove(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }
        public void Update(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
