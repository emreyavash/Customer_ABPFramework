using Acme.Customer.Create_UpdateDTO;
using Acme.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.Customer.İnterface
{
    public interface ICustomerAppService :IApplicationService
    {
        Task CreateCustomer(CreateUpdateCustomerDTO customerDTO);
        Task DeleteCustomer(Guid id);
        Task<List<CustomerDTO>> GetCustomers();
        Task<CustomerDTO> GetCustomerById(Guid id);

    }
}
