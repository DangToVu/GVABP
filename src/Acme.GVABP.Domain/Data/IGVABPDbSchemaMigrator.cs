using System.Threading.Tasks;

namespace Acme.GVABP.Data;

public interface IGVABPDbSchemaMigrator
{
    Task MigrateAsync();
}
