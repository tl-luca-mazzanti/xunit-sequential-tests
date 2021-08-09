using System;
using System.Threading.Tasks;
using Xunit;

namespace XUnit.Tests
{
    [Collection(Definitions.Sequential)]
    public class UnitTest2
    {
        private readonly SequentialFixture _fixture;

        public UnitTest2(SequentialFixture fixture)
        {
            _fixture = fixture;
        }
        
        [Fact]
        public async Task Test1()
        {
            Console.WriteLine("Start XUnit.Tests.UnitTest2.Test1");
            await Task.Delay(1000 * 5);
            Console.WriteLine("End XUnit.Tests.UnitTest2.Test1");
        }
        
        [Fact]
        public async Task Test2()
        {
            Console.WriteLine("Start XUnit.Tests.UnitTest2.Test2");
            await Task.Delay(1000 * 5);
            Console.WriteLine("End XUnit.Tests.UnitTest2.Test2");
        }
    }
}