using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Customer.Controllers
{
 
    public class CustomersController : AbpController
    {
        [HttpGet]
        public ActionResult Deneme()
        {
            return null;
        }
    }
}
