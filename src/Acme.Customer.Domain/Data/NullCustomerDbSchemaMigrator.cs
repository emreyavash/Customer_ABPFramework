using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.Customer.Data;

/* This is used if database provider does't define
 * ICustomerDbSchemaMigrator implementation.
 */
public class NullCustomerDbSchemaMigrator : ICustomerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
