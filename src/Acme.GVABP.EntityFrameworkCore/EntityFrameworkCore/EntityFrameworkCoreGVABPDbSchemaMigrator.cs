using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.GVABP.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.GVABP.EntityFrameworkCore;

public class EntityFrameworkCoreGVABPDbSchemaMigrator
    : IGVABPDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreGVABPDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the GVABPDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<GVABPDbContext>()
            .Database
            .MigrateAsync();
    }
}
