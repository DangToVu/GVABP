using Acme.GVABP.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.GVABP.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(GVABPEntityFrameworkCoreModule),
    typeof(GVABPApplicationContractsModule)
    )]
public class GVABPDbMigratorModule : AbpModule
{
}
