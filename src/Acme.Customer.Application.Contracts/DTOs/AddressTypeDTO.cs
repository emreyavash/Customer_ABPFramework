using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Customer.DTOs
{
     public class AddressTypeDTO : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

    }
}
