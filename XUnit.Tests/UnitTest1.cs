using System;
using System.Threading.Tasks;
using Xunit;

namespace XUnit.Tests
{
    [Collection(Definitions.Sequential)]
    public class UnitTest1
    {
        private readonly SequentialFixture _fixture;

        public UnitTest1(SequentialFixture fixture)
        {
            _fixture = fixture;
        }
        
        [Fact]
        public async Task Test1()
        {
            Console.WriteLine("Start XUnit.Tests.UnitTest1.Test1");
            await Task.Delay(1000 * 5);
            Console.WriteLine("End XUnit.Tests.UnitTest1.Test1");
            Assert.True(false);
        }
        
        [Fact]
        public async Task Test2()
        {
            Console.WriteLine("Start XUnit.Tests.UnitTest1.Test2");
            await Task.Delay(1000 * 5);
            Console.WriteLine("End XUnit.Tests.UnitTest1.Test2");
        }
    }
}