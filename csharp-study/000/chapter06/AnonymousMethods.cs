using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest.chapter06
{
    [TestClass]
    public class AnonymousMethods
    {
        [TestMethod]
        public void AnonymousMethods_SimpleExample()        
        {
            var dsc = new DelegateSimpleClass();
            Assert.AreEqual("Jedi kill bill", dsc.GetAString("Jedi"));
        }
    }

    class DelegateSimpleClass
    {
        delegate string delegateTest(string val);

        public string GetAString(string val)
        {
            var mid = " kill";
            delegateTest anonDel = delegate(string param)
            {
                param += mid;
                param += " bill";
                return param;
            };

            return anonDel(val);
        }
    }
}
