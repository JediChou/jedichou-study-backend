using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace StudyTest_VS2008.MoqStudy
{
    [TestClass]
    public class UseMoq4
    {
        [TestMethod]
        public void SimpleTest_UseMoq4()
        {
            var mock = new Mock<IFoo>();
            mock.Setup(foo => foo.DoSomething("ping")).Returns(true);
            Assert.AreEqual(true, mock.Object.DoSomething("ping"));
        }

        [TestMethod]
        public void SimpleTest_WithManyStringParameter_UseMoq4()
        {
            var mock = new Mock<IEmailSender>();
            mock.Setup(sender => sender.SendEmail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            Assert.AreEqual(true, mock.Object.SendEmail("Fuck HYX", "Me@hotmail"));
        }

        [TestMethod]
        public void SimpleTest_SimulateAParameterRange()
        {
            var numbers = new int[] {1, 2, 3, 4, 5};
            var elements = new List<string>();
            elements.Add("H");
            elements.Add("He");
            elements.Add("Li");

            var mock = new Mock<IProductRepository>();
            mock.Setup(p => p.Get(It.Is<int>(id=>id >0 && id < 6))).Returns(elements);
            
            foreach(var number in numbers)
                foreach(var item in mock.Object.Get(number))
                    Assert.IsFalse(item.Equals(string.Empty));
        }
    }

    public interface IFoo
    {
        bool DoSomething(string command);
    }

    public interface IEmailSender
    {
        bool SendEmail(string subject, string email);
    }

    public interface IProductRepository
    {
        List<string> Get(int ID);
    }
}
