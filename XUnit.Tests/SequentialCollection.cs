using Xunit;

namespace XUnit.Tests
{
    [CollectionDefinition(XUnit.Tests.Definitions.Sequential)]
    public class SequentialCollection : ICollectionFixture<SequentialFixture>
    {

    }
}