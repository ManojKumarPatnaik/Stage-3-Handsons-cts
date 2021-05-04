using CustomerCommLib;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCommTest
{
    [TestFixture]
    class Tests
    {
        Mock<IMailSender> mock = new Mock<IMailSender>();
        CustomerComm systemUnderTest;
        [OneTimeSetUp]
        public void Init()
        {
            mock = new Mock<IMailSender>(MockBehavior.Strict);
            systemUnderTest = new CustomerComm(mock.Object);
        }
        [Test]
        [TestCase("cust123@abc.com", "Some Message")]
        [TestCase("abc@abc.com", "Different Message")]
        public void TestSendMail(string mail, string message)
        {
           
            mock.Setup(p => p.SendMail(mail, message)).Returns(true);
            bool actual = systemUnderTest.SendMailToCustomer(mail ,message);
            Assert.AreEqual(actual, false);
        }
    }
}
