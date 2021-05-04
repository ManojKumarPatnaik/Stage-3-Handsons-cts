using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerCommLib;
using Moq;
using NUnit.Framework;

namespace CustomerComm.Tests
{
    [TestFixture]
    class Tester
    {
        Mock<IMailSender> mock = new Mock<IMailSender>();
        CustomerComm systemUnderTest;
        [Test]
        [TestCase("cust123@abc.com", "Some Message", true)]
        public void TestSendMail(string mail, string message, bool expectedResult)
        {
            mock = new Mock<IMailSender>(MockBehavior.Strict);
            systemUnderTest = new CustomerComm(mock.Object);
            mock.Setup(p => p.SendMail(mail, message)).Returns(expectedResult);
            bool actual = systemUnderTest.SendMailToCustomer();
            Assert.AreEqual(actual, expectedResult);
        }
    }
}
