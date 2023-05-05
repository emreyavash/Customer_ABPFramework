using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.Customer.Entities
{
    public class EmailType : AuditedAggregateRoot<Guid>
    {
        public string EmailTypeName { get; set; }
    }
}
