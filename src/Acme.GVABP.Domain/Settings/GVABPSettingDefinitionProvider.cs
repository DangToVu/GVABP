using Volo.Abp.Settings;

namespace Acme.GVABP.Settings;

public class GVABPSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(GVABPSettings.MySetting1));
    }
}
