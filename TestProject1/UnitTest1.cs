using System.IO;
using System;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World! from ...";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                TestProject1.TestDemo.Print();
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}