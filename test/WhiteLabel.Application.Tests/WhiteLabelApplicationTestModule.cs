using Volo.Abp.Modularity;

namespace WhiteLabel;

[DependsOn(
    typeof(WhiteLabelApplicationModule),
    typeof(WhiteLabelDomainTestModule)
)]
public class WhiteLabelApplicationTestModule : AbpModule
{

}
