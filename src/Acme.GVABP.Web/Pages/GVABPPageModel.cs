using Acme.GVABP.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.GVABP.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class GVABPPageModel : AbpPageModel
{
    protected GVABPPageModel()
    {
        LocalizationResourceType = typeof(GVABPResource);
    }
}
