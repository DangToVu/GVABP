using Volo.Abp.Modularity;

namespace Acme.GVABP;

[DependsOn(
    typeof(GVABPApplicationModule),
    typeof(GVABPDomainTestModule)
)]
public class GVABPApplicationTestModule : AbpModule
{

}
