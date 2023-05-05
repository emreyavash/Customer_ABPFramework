using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.Customer.Entities
{
    public class CustomerPaymentInfo : AuditedAggregateRoot<Guid>

    {
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
    }
}
