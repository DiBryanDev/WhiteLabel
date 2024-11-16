using WhiteLabel.Samples;
using Xunit;

namespace WhiteLabel.EntityFrameworkCore.Applications;

[Collection(WhiteLabelTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<WhiteLabelEntityFrameworkCoreTestModule>
{

}
