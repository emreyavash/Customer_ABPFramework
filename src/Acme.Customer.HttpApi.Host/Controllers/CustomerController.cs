using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Customer.Controllers
{
 
    public class CustomerController : AbpController
    {
        [HttpGet]
        public ActionResult Deneme()
        {
            return null;
        }
    }
}
