using WhiteLabel.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace WhiteLabel.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class WhiteLabelController : AbpControllerBase
{
    protected WhiteLabelController()
    {
        LocalizationResource = typeof(WhiteLabelResource);
    }
}
