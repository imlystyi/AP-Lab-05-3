// Lab_05_3_UT.cs
// Якубовський Владислав
// Unit-тест до програми Lab_05_3.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AP_Lab_05_3;

namespace AP_Lab_05_3_UT
{
    [TestClass]
    public class Lab_05_3_UT
    {
        [TestMethod]
        public void TestF()
        {
            double n = Lab_05_3.F(2),
                k = Lab_05_3.F(0.7);

            Assert.AreEqual(0.7172576, n, 0.001);
            Assert.AreEqual(1.0820004, k, 0.001);
        }
    }
}