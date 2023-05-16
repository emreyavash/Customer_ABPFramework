using Acme.Customer.Create_UpdateDTO;
using Acme.Customer.İnterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : AbpController
    {
        private readonly ICustomerAppService _customerService;

        public CustomerController(ICustomerAppService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("CreateCustomer")]
        public async Task<ActionResult> CreateCustomer(CreateUpdateCustomerDTO customerDTO)
        {
            await _customerService.CreateCustomer(customerDTO);
            return Ok("Eklendi");
        }
    }
}
