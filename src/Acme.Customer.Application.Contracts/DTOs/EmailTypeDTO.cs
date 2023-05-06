using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.Customer.DTOs
{
    public class EmailTypeDTO : AuditedEntityDto<Guid>
    {
        public string EmailTypeName { get; set; }

    }
}
