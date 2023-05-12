using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.Customer.Entities
{
    public class CustomerEmail : AuditedAggregateRoot<Guid>
    {
        public Guid CustomerId { get; set; }
        public Guid EmailTypeId { get; set; }
        public string Email { get; set; }

        public CustomerEmail(Guid customerId, Guid emailTypeId)
        {
            CustomerId = customerId;
            EmailTypeId = emailTypeId;
        }
    }
}
