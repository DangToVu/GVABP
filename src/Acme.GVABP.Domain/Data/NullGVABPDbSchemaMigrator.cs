using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.GVABP.Data;

/* This is used if database provider does't define
 * IGVABPDbSchemaMigrator implementation.
 */
public class NullGVABPDbSchemaMigrator : IGVABPDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
