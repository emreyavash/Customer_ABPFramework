using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.Customer.Entities
{
    public class CustomerPaymentInfo : AuditedAggregateRoot<Guid>

    {
        public ICollection<CustomerPayment> PaymentId { get; set; }
        public Guid CustomerId { get; set; }

        public CustomerPaymentInfo( Guid customerId)
        {
            PaymentId =  new Collection<CustomerPayment>();
            CustomerId = customerId;
        }
    }
}
