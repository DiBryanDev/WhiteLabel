using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace WhiteLabel.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class WhiteLabelDbContextFactory : IDesignTimeDbContextFactory<WhiteLabelDbContext>
{
    public WhiteLabelDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        WhiteLabelEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<WhiteLabelDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new WhiteLabelDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../WhiteLabel.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
