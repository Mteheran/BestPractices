namespace BestPractices.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StringInterpolationTest
    {
        [TestMethod]
        public void stringDemo()
        {
            var StrinInterfoplationclass = new StringInterpolation();

            Assert.AreEqual("Full Name is: Steve Jobs", StrinInterfoplationclass.StringDemo("Steve","Jobs"));
        }
    }
}
