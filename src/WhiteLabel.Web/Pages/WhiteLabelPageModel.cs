using WhiteLabel.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace WhiteLabel.Web.Pages;

public abstract class WhiteLabelPageModel : AbpPageModel
{
    protected WhiteLabelPageModel()
    {
        LocalizationResourceType = typeof(WhiteLabelResource);
    }
}
