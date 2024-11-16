using Volo.Abp.Settings;

namespace WhiteLabel.Settings;

public class WhiteLabelSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(WhiteLabelSettings.MySetting1));
    }
}
