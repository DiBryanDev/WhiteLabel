using Xunit;

namespace WhiteLabel.EntityFrameworkCore;

[CollectionDefinition(WhiteLabelTestConsts.CollectionDefinitionName)]
public class WhiteLabelEntityFrameworkCoreCollection : ICollectionFixture<WhiteLabelEntityFrameworkCoreFixture>
{

}
