using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.Customer;

[Dependency(ReplaceServices = true)]
public class CustomerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Customer";
}
