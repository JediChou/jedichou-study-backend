using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest_VS2008.Delegate
{
    [TestClass]
    public class SimpleDelegate
    {
        private delegate string GetAString();
        
        [TestMethod]
        public void SimpleDelegate_Test()
        {
            var i = int.Parse("99");
            Assert.AreEqual(99, i);
        }

        [TestMethod]
        public void UseDelegate_Case1_Test()
        {
            var x = 40;
            var firstStringMethod = new GetAString(x.ToString);
            Assert.AreEqual("40", firstStringMethod());
        }

        [TestMethod]
        public void UseDelegate_Case2_Test()
        {
            var balance = new Currency(34, 50);
            var firstMethod = new GetAString(balance.ToString);
            Assert.AreEqual("$34.50", firstMethod());
        }

        [TestMethod]
        public void UseDelegate_Case3_Test()
        {
            var balance = new Currency(34, 50);
            var firstMethod = new GetAString(Currency.GetCurrencyUnit);
            Assert.AreEqual("Dollars", firstMethod());
        }
    }

    struct Currency
    {
        public uint Dollars;
        public ushort Cents;

        public Currency(uint dollars, ushort cents)
        {
            this.Dollars = dollars;
            this.Cents = cents;
        }

        public override string ToString()
        {
            return string.Format("${0}.{1,-2:00}", Dollars, Cents);
        }

        public static explicit operator Currency(float value)
        {
            checked
            {
                var dollars = (uint)value;
                var cents = (ushort)((value - dollars) * 100);
                return new Currency(dollars, cents);
            }
        }

        public static implicit operator Currency(uint value)
        {
            return new Currency(value, 0);
        }

        public static implicit operator uint(Currency value)
        {
            return value.Dollars;
        }

        public static string GetCurrencyUnit()
        {
            return "Dollars";
        }
    }
}
