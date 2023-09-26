using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Customer.DTOs
{
    public class CustomerPaymentInfoDTO : AuditedEntityDto<Guid>
    {
        public Guid PaymentId { get; set; }

        public Guid CustomerId { get; set; }
    }
}
