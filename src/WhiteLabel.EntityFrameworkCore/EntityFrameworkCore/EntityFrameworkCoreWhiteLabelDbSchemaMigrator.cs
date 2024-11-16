using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WhiteLabel.Data;
using Volo.Abp.DependencyInjection;

namespace WhiteLabel.EntityFrameworkCore;

public class EntityFrameworkCoreWhiteLabelDbSchemaMigrator
    : IWhiteLabelDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreWhiteLabelDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the WhiteLabelDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<WhiteLabelDbContext>()
            .Database
            .MigrateAsync();
    }
}
