using Acme.Customer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Customer.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CustomerController : AbpControllerBase
{
    protected CustomerController()
    {
        LocalizationResource = typeof(CustomerResource);
    }
}
