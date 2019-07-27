namespace DaHuaPatternTest.DHP01.Sample01Test
{
    using DaHuaPatternLibrary.DHP01.Sample01;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class CalculatorTest
    {
        ///<summary>
        /// Calculator construct test
        ///</summary>
        [TestMethod]
        public void CalculatorConstructorTest()
        {
            var target = new Calculator();
            Assert.AreEqual(
                "DaHuaPatternLibrary.DHP01.Sample01.Calculator", 
                target.GetType().ToString()
            );
        }

        /// <summary>
        /// Check Calculator's plus operate
        /// </summary>
        [TestMethod]
        public void CalculatorCallPlus()
        {
            var target = new Calculator();
            Assert.AreEqual("20", target.Call("10", "+", "10"));
            Assert.AreEqual("20", target.Call("01", "+", "19"));
            Assert.AreEqual("21", target.Call("-1", "+", "22"));
        }

        /// <summary>
        /// Check Calculator's sub operate
        /// </summary>
        [TestMethod]
        public void CalculatorCallSub()
        {
            var target = new Calculator();
            Assert.AreEqual("0", target.Call("10", "-", "10"));
            Assert.AreEqual("-18", target.Call("01", "-", "19"));
            Assert.AreEqual("-23", target.Call("-1", "-", "22"));
        }

        [TestMethod]
        public void CalculatorCallMul()
        {
            var target = new Calculator();
            Assert.AreEqual("100", target.Call("10", "*", "10"));
            Assert.AreEqual("19", target.Call("01", "*", "19"));
            Assert.AreEqual("-22", target.Call("-1", "*", "22"));
        }

        [TestMethod]
        public void CalculatorCallDiv()
        {
            
        }
    }
}
