using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.Customer.Entities
{
    public class CustomerPhoneNumber :AuditedAggregateRoot<Guid>
    {
        public int CustomerId { get; set; }
        public int PhoneTypeId { get; set; }
        public string PhoneNumber { get; set; }

    }
}
