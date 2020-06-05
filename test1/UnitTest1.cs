using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //act 
            int n = unitTests_1.Program.getNumber(10);


            //assert
            Assert.AreEqual(0, n);
        }
    }
}
