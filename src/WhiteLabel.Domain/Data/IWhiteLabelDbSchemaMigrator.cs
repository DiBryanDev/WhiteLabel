using System.Threading.Tasks;

namespace WhiteLabel.Data;

public interface IWhiteLabelDbSchemaMigrator
{
    Task MigrateAsync();
}
