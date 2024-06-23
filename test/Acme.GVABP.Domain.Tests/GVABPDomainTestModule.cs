using Volo.Abp.Modularity;

namespace Acme.GVABP;

[DependsOn(
    typeof(GVABPDomainModule),
    typeof(GVABPTestBaseModule)
)]
public class GVABPDomainTestModule : AbpModule
{

}
