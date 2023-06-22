using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Customer.DTOs
{
    public class CustomerAddressDTO : AuditedEntityDto<Guid>
    {
            
        public Guid CustomerId { get; set; }
        public Guid AddressId { get; set; }
        public string Address { get; set; }
    }
}
