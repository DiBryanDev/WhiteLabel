using Microsoft.AspNetCore.Builder;
using WhiteLabel;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<WhiteLabelWebTestModule>();

public partial class Program
{
}
