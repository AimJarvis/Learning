using ConsoleApp1;
using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            ConsoleApp1.Program obj = new Program();
        int output=  obj.Calc(1, 2);
            
            Assert.True(output==3);
        }
    }
}