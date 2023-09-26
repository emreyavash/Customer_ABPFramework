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
    public class CustomerEmailService : CrudAppService<
        CustomerEmail,
        CustomerEmailDTO,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCustomerEmailDTO>, ICustomerEmailService
    {
        private readonly IRepository<CustomerEmail,Guid> _repository;
        public CustomerEmailService(IRepository<CustomerEmail, Guid> repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<CustomerEmailDTO> GetEmailByCustomerId(Guid customerId)
        {
            var customerEmail = await _repository.FindAsync(x=>x.CustomerId == customerId);
            return ObjectMapper.Map<CustomerEmail, CustomerEmailDTO>(customerEmail);

        }
    }
}
