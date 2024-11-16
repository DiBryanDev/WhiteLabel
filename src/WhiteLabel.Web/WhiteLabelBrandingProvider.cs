using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using WhiteLabel.Localization;

namespace WhiteLabel.Web;

[Dependency(ReplaceServices = true)]
public class WhiteLabelBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<WhiteLabelResource> _localizer;

    public WhiteLabelBrandingProvider(IStringLocalizer<WhiteLabelResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
