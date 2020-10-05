using DDDStore.Domain.Core.Interfaces.Repositories;
using DDDStore.Domain.Core.Interfaces.Services;
using DDDStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Domain.Services.Services
{
    public class ProductService : BaseService<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
        }
    }
}
