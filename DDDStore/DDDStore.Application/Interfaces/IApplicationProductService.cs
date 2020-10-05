using DDDStore.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Application.Interfaces
{
    interface IApplicationProductService
    {
        void Add(ProductDTO productDTO);
        ProductDTO GetById(int id);
        IEnumerable<ProductDTO> GetAll();
        void Update(ProductDTO productDTO);
        void Remove(ProductDTO productDTO);
        void Dispose();
    }
}
