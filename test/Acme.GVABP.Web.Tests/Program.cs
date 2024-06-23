using Microsoft.AspNetCore.Builder;
using Acme.GVABP;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<GVABPWebTestModule>();

public partial class Program
{
}
