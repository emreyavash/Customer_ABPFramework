using Volo.Abp.Modularity;

namespace Acme.Customer;

[DependsOn(
    typeof(CustomerApplicationModule),
    typeof(CustomerDomainTestModule)
    )]
public class CustomerApplicationTestModule : AbpModule
{

}
