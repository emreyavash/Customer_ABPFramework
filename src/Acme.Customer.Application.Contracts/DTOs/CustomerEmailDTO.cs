using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Customer.DTOs
{
    public class CustomerEmailDTO : AuditedEntityDto<Guid>
    {
        public Guid CustomerId { get; set; }
        public Guid EmailTypeId { get; set; }
        public string Email { get; set; }
    }
}
