using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest_VS2008.Operator
{
    [TestClass]
    public class EqualsTest
    {
        [TestMethod]
        public void ReferenceEquals_Test()
        {
            var a = new object();
            var b = new object();

            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            // ReSharper disable once EqualExpressionComparison
            Assert.IsTrue(ReferenceEquals(null, null));
            
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            Assert.IsFalse(ReferenceEquals(null, a));
            
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            Assert.IsFalse(ReferenceEquals(null, b));
            Assert.IsFalse(ReferenceEquals(a, b));
        }

        [TestMethod, Ignore]
        public void VirtualEquals_Test()
        {
            // TODO need to fix
        }

        [TestMethod, Ignore]
        public void StaticEqualsMethod_Test()
        {
            // TODO need to fix
        }

        [TestMethod, Ignore]
        public void CompareOperator_Test()
        {
            // TODO need to fix
        }
    }
}
