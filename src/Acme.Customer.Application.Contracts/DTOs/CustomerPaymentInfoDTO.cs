using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Customer.DTOs
{
    public class CustomerPaymentInfoDTO : AuditedEntityDto<Guid>
    {
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
    }
}
