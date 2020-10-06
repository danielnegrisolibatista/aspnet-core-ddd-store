using DDDStore.Domain.Core.Interfaces.Repositories;
using DDDStore.Domain.Entities;
using DDDStore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Infrastructure.Repository.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        private readonly SqlContext _sqlContext;
        public OrderRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
