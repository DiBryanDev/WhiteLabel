using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace WhiteLabel.Data;

/* This is used if database provider does't define
 * IWhiteLabelDbSchemaMigrator implementation.
 */
public class NullWhiteLabelDbSchemaMigrator : IWhiteLabelDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
