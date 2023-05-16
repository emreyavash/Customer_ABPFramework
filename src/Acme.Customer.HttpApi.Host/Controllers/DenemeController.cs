using Acme.Customer.Abstract;
using Acme.Customer.Create_UpdateDTO;
using Acme.Customer.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Acme.Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DenemeController : ControllerBase
    {
        private readonly DenemeService _service;

        public DenemeController(DenemeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _service.GetCustomers();
            return Ok(result);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> CreateAsync(CreateDenemeDTO customerDTO)
        {
            await _service.CreateDeneme(customerDTO);
            return Ok("Eklendi");
        }
    }
}
