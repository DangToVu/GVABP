using System;
using System.Collections.Generic;
using System.Text;
using Acme.GVABP.Localization;
using Volo.Abp.Application.Services;

namespace Acme.GVABP;

/* Inherit your application services from this class.
 */
public abstract class GVABPAppService : ApplicationService
{
    protected GVABPAppService()
    {
        LocalizationResource = typeof(GVABPResource);
    }
}
