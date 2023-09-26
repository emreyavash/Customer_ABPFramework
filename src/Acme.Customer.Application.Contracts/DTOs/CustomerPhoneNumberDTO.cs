using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Customer.DTOs
{
    public class CustomerPhoneNumberDTO : AuditedEntityDto<Guid>
    {
        public Guid CustomerId { get; set; }
        public Guid PhoneTypeId { get; set; }
        public string PhoneNumber { get; set; }
    }
}
