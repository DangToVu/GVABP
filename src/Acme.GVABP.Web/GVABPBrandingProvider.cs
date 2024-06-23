using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.GVABP.Web;

[Dependency(ReplaceServices = true)]
public class GVABPBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "GVABP";
}
