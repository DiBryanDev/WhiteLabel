using WhiteLabel.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace WhiteLabel.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(WhiteLabelEntityFrameworkCoreModule),
    typeof(WhiteLabelApplicationContractsModule)
)]
public class WhiteLabelDbMigratorModule : AbpModule
{
}
