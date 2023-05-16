using Acme.Customer.Create_UpdateDTO;
using Acme.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Acme.Customer.İnterface
{
    public interface IDenemeService :IApplicationService
    {
        Task CreateDeneme(CreateDenemeDTO customerDTO);
        Task<List<DenemeDTO>> GetCustomers();
    }
}
