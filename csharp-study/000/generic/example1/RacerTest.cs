using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudyTest_VS2008.generic.example1
{
    [TestClass]
    public class RacerTest
    {
        [TestMethod]
        public void RacerTest_CreateInstance_Test()
        {
            var list = new List<Racer> {new Racer("Rose", "RoseMartin")};
            Assert.AreEqual("Rose", list[0].Name);
            Assert.AreEqual("RoseMartin", list[0].Car);
        }

        [TestMethod]
        public void RacerTest_FindAll_Test()
        {
            // Define a racer container
            var list = new List<Racer>();
            Assert.AreEqual(0, list.Count);

            list.Add(new Racer("Rose", "RoseMartion"));
            list.Add(new Racer("Latin", "Benni"));
            list.Add(new Racer("Becky", "BMW"));


        }
    }
}
