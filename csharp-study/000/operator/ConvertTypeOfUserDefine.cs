using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest_VS2008.Operator
{
    [TestClass]
    public class ConvertTypeOfUserDefine
    {
        [TestMethod]
        public void CreateCurrency_Test()
        {
            var balance = new Currency(10, 50);
            Assert.AreEqual((uint)10, balance.Dollars);
            Assert.AreEqual((ushort)50, balance.Cents);
        }

        [TestMethod]
        public void CurrencyToString_Test()
        {
            var balance = new Currency(10, 50);
            const string expected = "$10.50";
            Assert.AreEqual(expected, balance.ToString());
        }

        [TestMethod]
        public void ConvertCurrencyToFloat_Test()
        {
            var balance = new Currency(10, 50);
            Assert.AreEqual(10.5, balance);
        }

        [TestMethod]
        public void ConvertFloatToCurrency_Test()
        {
            const float floatValue = 20.10f;
            var result = (Currency)floatValue;
            Assert.AreEqual((uint)20, result.Dollars);
            Assert.AreEqual((ushort)10, result.Cents);
        }

        [TestMethod]
        public void ObjectConvert_BaseToBase_Test()
        {
            object derivedObject = new Currency(40, 0);
            var baseObject = new object();
            var derivedCopy = (Currency)derivedObject;
            Assert.IsNotNull(derivedCopy);
        }

        [TestMethod]
        public void ObjectConvert_BaseToSub_Test()
        {
            try
            {
                object derivedObject = new Currency(40, 0);
                var baseObject = new object();
                var derivedCopy = (Currency)baseObject;
            }
            catch (Exception ex)
            {
                Assert.IsNotNull(ex);
            }
        }

        [TestMethod]
        public void OtherTypeConvert_Test()
        {
            try 
	        {	        
		        var balance = new Currency(10, 50);
                var a = (double)balance;
                var b = (long)balance;
	        }
	        catch (Exception ex)
	        {
                Assert.IsNull(ex);
	        };
        }

        [TestMethod]
        public void OtherTypeConvert_WithManyConvertPrefix_Test()
        {
            try
            {
                var balance = new Currency(10, 50);
                var a = (int)(long)(double)balance;
                var b = (ushort)(double)(long)balance;
            }
            catch (Exception ex)
            {
                Assert.IsNull(ex);
            };
        }

        [TestMethod]
        public void ChangeUintToUserDefineObject_Test()
        {
            const int dollars = 20;
            var targetObject = (Currency)dollars;
            Assert.AreEqual((uint)20, targetObject.Dollars);
            Assert.AreEqual((ushort)0, targetObject.Cents);
        }

        [TestMethod]
        public void ChangeUserDefineObjectToUint_Test()
        {
            var currency = new Currency(50, 50);
            Assert.AreEqual((uint)50, (uint)currency);
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

        public static implicit operator float(Currency value)
        {
            return value.Dollars + (value.Cents / 100.0f);
        }

        public static implicit operator Currency(float value)
        {
            var dollars = (uint)value;
            var cents = (ushort)((value - dollars) * 100);
            return new Currency(dollars, cents);
        }

        public static implicit operator Currency(uint value)
        {
            return new Currency(value, 0);
        }

        public static implicit operator uint(Currency value)
        {
            return value.Dollars;
        }
    }
}
