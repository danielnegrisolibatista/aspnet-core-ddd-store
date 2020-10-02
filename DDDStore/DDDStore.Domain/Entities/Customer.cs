using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Domain.Entities
{
    public class Customer : EntityBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
    }
}
