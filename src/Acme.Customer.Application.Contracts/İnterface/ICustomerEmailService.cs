using Acme.Customer.Create_UpdateDTO;
using Acme.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.Customer.İnterface
{
    public interface ICustomerEmailService : ICrudAppService<
        CustomerEmailDTO,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCustomerEmailDTO>
    {
    }
}
