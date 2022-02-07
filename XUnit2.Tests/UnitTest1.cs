using System;
using System.Threading.Tasks;
using Xunit;

namespace XUnit2.Tests
{
    [Collection(Definitions.Sequential)]
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            Console.WriteLine("Start XUnit2.Tests.UnitTest1.Test1");
            await Task.Delay(1000 * 10);
            Console.WriteLine("End XUnit2.Tests.UnitTest1.Test1");
        }
        
        [Fact]
        public async Task Test2()
        {
            Console.WriteLine("Start XUnit2.Tests.UnitTest1.Test2");
            await Task.Delay(1000 * 10);
            Console.WriteLine("End XUnit2.Tests.UnitTest1.Test2");
        }
    }
}