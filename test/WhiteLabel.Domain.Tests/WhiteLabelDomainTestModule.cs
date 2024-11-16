using Volo.Abp.Modularity;

namespace WhiteLabel;

[DependsOn(
    typeof(WhiteLabelDomainModule),
    typeof(WhiteLabelTestBaseModule)
)]
public class WhiteLabelDomainTestModule : AbpModule
{

}
