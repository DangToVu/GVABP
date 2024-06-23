using Volo.Abp.Modularity;

namespace Acme.GVABP;

/* Inherit from this class for your domain layer tests. */
public abstract class GVABPDomainTestBase<TStartupModule> : GVABPTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
