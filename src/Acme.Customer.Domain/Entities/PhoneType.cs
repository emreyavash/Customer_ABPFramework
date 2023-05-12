using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.Customer.Entities
{
    public class PhoneType : AuditedAggregateRoot<Guid>
    {
        public string PhoneTypeName { get; set; }

        public PhoneType(Guid id):base(id) 
        {
        }
    }
}
