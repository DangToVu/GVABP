using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.GVABP.Pages;

public class Index_Tests : GVABPWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
