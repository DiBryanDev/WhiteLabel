using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace WhiteLabel.Pages;

[Collection(WhiteLabelTestConsts.CollectionDefinitionName)]
public class Index_Tests : WhiteLabelWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
