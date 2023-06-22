using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.Customer.Entities
{
    public class CustomerAddress : AuditedAggregateRoot<Guid>
    {
        public Guid CustomerId { get; set; }
        public Guid AddressId { get; set; }
        public string Address { get; set; }
        public CustomerAddress(Guid customerId,Guid addressId) {
            CustomerId = customerId;
            AddressId = addressId;
        }
    }
}
