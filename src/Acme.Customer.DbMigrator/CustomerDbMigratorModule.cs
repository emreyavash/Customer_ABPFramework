using Acme.Customer.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.Customer.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CustomerEntityFrameworkCoreModule),
    typeof(CustomerApplicationContractsModule)
    )]
public class CustomerDbMigratorModule : AbpModule
{

}
