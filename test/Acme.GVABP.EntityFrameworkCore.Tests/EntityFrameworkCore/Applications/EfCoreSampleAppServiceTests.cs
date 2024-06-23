using Acme.GVABP.Samples;
using Xunit;

namespace Acme.GVABP.EntityFrameworkCore.Applications;

[Collection(GVABPTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<GVABPEntityFrameworkCoreTestModule>
{

}
