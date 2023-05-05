using Acme.Customer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.Customer;

[DependsOn(
    typeof(CustomerEntityFrameworkCoreTestModule)
    )]
public class CustomerDomainTestModule : AbpModule
{

}
