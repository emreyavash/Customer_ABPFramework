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
        public Guid PaymentId { get; set; }
        public Guid CustomerId { get; set; }
        

        public CustomerPaymentInfo( Guid id):base(id)
        {
      
        }

        private CustomerPaymentInfo()
        {
        }
    }
}
