using DDDStore.Domain.Core.Interfaces.Repositories;
using DDDStore.Domain.Entities;
using DDDStore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Infrastructure.Repository.Repositories
{
    public class OrderItemRepository : BaseRepository<OrderItem>, IOrderItemRepository
    {
        private readonly SqlContext _sqlContext;
        public OrderItemRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
