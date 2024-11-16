using Volo.Abp.Modularity;

namespace WhiteLabel;

public abstract class WhiteLabelApplicationTestBase<TStartupModule> : WhiteLabelTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
