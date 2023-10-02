using ConsoleApp1;
using NUnit.Framework;

namespace TestProject1
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
            var obj = new Program();
                
            Assert.Pass();
        }
    }
}