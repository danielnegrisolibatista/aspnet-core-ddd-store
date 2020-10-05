﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DDDStore.Application.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
    }
}
