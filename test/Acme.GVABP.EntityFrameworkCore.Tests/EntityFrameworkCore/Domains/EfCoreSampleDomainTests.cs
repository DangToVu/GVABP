using Acme.GVABP.Samples;
using Xunit;

namespace Acme.GVABP.EntityFrameworkCore.Domains;

[Collection(GVABPTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<GVABPEntityFrameworkCoreTestModule>
{

}
