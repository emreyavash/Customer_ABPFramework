using Acme.Customer.Create_UpdateDTO;
using Acme.Customer.DTOs;
using Acme.Customer.İnterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        public async Task<IActionResult> CreateCustomer(CreateUpdateCustomerDTO customerDTO)
        {
            await _customerService.CreateCustomer(customerDTO);
            return Ok("Eklendi");
        }
        [HttpDelete("DeleteCustomer")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            await _customerService.DeleteCustomer(id);
            return Ok("Silindi");
        }
        [HttpGet("GetCustomers")]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _customerService.GetCustomers();
            return Ok(customers);
        }
        [HttpGet("GetCustomerById")]
        public async Task<IActionResult> GetCustomerById(Guid id)
        {
            var customer = await _customerService.GetCustomerById(id);
            return Ok(customer);
        }
    }
}
