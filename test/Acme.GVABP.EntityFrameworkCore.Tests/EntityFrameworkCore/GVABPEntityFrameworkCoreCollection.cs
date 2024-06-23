using Xunit;

namespace Acme.GVABP.EntityFrameworkCore;

[CollectionDefinition(GVABPTestConsts.CollectionDefinitionName)]
public class GVABPEntityFrameworkCoreCollection : ICollectionFixture<GVABPEntityFrameworkCoreFixture>
{

}
