using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.Customer.Entities
{
    public class CustomerEmail : AuditedAggregateRoot<Guid>
    {
        public int CustomerId { get; set; }
        public int EmailTypeId { get; set; }
        public string Email { get; set; }
    }
}
