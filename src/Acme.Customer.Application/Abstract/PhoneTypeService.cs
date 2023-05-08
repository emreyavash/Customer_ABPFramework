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
    public class PhoneTypeService : CrudAppService<
        PhoneType,
        PhoneTypeDTO,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdatePhoneTypeDTO>, IPhoneTypeService
    {
        public PhoneTypeService(IRepository<PhoneType, Guid> repository) : base(repository)
        {
        }
    }
}
