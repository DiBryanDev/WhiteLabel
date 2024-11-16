using WhiteLabel.Samples;
using Xunit;

namespace WhiteLabel.EntityFrameworkCore.Domains;

[Collection(WhiteLabelTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<WhiteLabelEntityFrameworkCoreTestModule>
{

}
