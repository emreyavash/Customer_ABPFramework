using System;
using System.Collections.Generic;
using System.Text;
using Acme.Customer.Localization;
using Volo.Abp.Application.Services;

namespace Acme.Customer;

/* Inherit your application services from this class.
 */
public abstract class CustomerAppService : ApplicationService
{
    protected CustomerAppService()
    {
        LocalizationResource = typeof(CustomerResource);
    }
}
