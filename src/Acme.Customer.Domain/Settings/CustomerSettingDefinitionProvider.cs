using Volo.Abp.Settings;

namespace Acme.Customer.Settings;

public class CustomerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CustomerSettings.MySetting1));
    }
}
