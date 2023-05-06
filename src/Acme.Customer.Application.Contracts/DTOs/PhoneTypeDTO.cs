using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Customer.DTOs
{
    public class PhoneTypeDTO : AuditedEntityDto<Guid>
    {
        public string PhoneTypeName { get; set; }

    }
}
