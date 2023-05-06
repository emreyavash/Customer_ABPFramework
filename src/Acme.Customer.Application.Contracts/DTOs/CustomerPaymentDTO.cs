using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Customer.DTOs
{
    public class CustomerPaymentDTO : AuditedEntityDto<Guid>
    {
        public string PaymentName { get; set; }

    }
}
