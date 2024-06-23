using Acme.GVABP.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.GVABP.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class GVABPController : AbpControllerBase
{
    protected GVABPController()
    {
        LocalizationResource = typeof(GVABPResource);
    }
}
