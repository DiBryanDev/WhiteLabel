using WhiteLabel.Localization;
using Volo.Abp.Application.Services;

namespace WhiteLabel;

/* Inherit your application services from this class.
 */
public abstract class WhiteLabelAppService : ApplicationService
{
    protected WhiteLabelAppService()
    {
        LocalizationResource = typeof(WhiteLabelResource);
    }
}
