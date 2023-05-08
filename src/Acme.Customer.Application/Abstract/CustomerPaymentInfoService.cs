using Acme.Customer.Create_UpdateDTO;
using Acme.Customer.DTOs;
using Acme.Customer.Entities;
using Acme.Customer.İnterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.Customer.Abstract
{
    public class CustomerPaymentInfoService : CrudAppService<
        CustomerPaymentInfo,
        CustomerPaymentInfoDTO,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCustomerPaymentInfoDTO>, ICustomerPaymentInfoService
    {
        public CustomerPaymentInfoService(IRepository<CustomerPaymentInfo, Guid> repository) : base(repository)
        {
        }
    }
}
