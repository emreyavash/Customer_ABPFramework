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
        public Guid CustomerId { get; set; }
        public Guid PhoneTypeId { get; set; }
        public string PhoneNumber { get; set; }

        public CustomerPhoneNumber(Guid customerId, Guid phoneTypeId)
        {
            CustomerId = customerId;
            PhoneTypeId = phoneTypeId;
        }
    }
}
