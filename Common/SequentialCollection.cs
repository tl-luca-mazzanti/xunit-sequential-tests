using Xunit;

namespace Common
{
    [CollectionDefinition(Definitions.Sequential)]
    public class SequentialCollection : ICollectionFixture<SequentialFixture>
    {

    }
}