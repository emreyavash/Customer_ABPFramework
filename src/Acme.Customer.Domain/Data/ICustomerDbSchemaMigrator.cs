using System.Threading.Tasks;

namespace Acme.Customer.Data;

public interface ICustomerDbSchemaMigrator
{
    Task MigrateAsync();
}
