using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest
{
    [TestClass]
    public class EqualsTest
    {
        [TestMethod]
        public void ReferenceEquals_Test()
        {
            var a = new object();
            var b = new object();
            Assert.IsTrue(ReferenceEquals(null, null));
            Assert.IsFalse(ReferenceEquals(null, a));
            Assert.IsFalse(ReferenceEquals(null, b));
            Assert.IsFalse(ReferenceEquals(a, b));
        }

        [TestMethod]
        public void VirtualEquals_Test()
        {
            // TODO
        }

        [TestMethod]
        public void StaticEqualsMethod_Test()
        {
            // TODO
        }

        [TestMethod]
        public void CompareOperator_Test()
        {
            // TODO
        }
    }
}
