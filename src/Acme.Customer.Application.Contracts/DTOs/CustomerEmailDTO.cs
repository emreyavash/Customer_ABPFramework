using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Customer.DTOs
{
    public class CustomerEmailDTO : AuditedEntityDto<Guid>
    {
        public int CustomerId { get; set; }
        public int EmailTypeId { get; set; }
        public string Email { get; set; }
    }
}
