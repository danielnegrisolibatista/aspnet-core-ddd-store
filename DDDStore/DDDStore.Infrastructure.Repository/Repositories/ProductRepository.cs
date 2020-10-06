using DDDStore.Domain.Core.Interfaces.Repositories;
using DDDStore.Domain.Entities;
using DDDStore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Infrastructure.Repository.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly SqlContext _context;
        public ProductRepository(SqlContext Context) : base(Context)
        {
            _context = Context;
        }
    }
}
