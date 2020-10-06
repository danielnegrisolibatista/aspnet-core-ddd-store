using DDDStore.Domain.Core.Interfaces.Repositories;
using DDDStore.Domain.Entities;
using DDDStore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Infrastructure.Repository.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        private readonly SqlContext _sqlContext;
        public CustomerRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
