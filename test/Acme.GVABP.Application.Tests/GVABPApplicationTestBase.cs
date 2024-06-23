using Volo.Abp.Modularity;

namespace Acme.GVABP;

public abstract class GVABPApplicationTestBase<TStartupModule> : GVABPTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
