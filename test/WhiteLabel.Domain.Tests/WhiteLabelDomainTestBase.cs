using Volo.Abp.Modularity;

namespace WhiteLabel;

/* Inherit from this class for your domain layer tests. */
public abstract class WhiteLabelDomainTestBase<TStartupModule> : WhiteLabelTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
