﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.Customer.Entities
{
    public class AddressType : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public AddressType(Guid id) :base(id) 
        {
            
        }

        private AddressType()
        {
        }
    }
}
