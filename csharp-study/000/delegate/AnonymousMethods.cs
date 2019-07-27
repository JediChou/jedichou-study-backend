using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest_VS2008.Delegate
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
        delegate string DelegateTest(string val);

        public string GetAString(string val)
        {
            const string mid = " kill";
            DelegateTest anonDel = delegate(string param)
            {
                param += mid;
                param += " bill";
                return param;
            };

            return anonDel(val);
        }
    }
}
