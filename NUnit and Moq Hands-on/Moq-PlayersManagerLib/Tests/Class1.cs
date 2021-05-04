using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using PlayersManagerLib;

namespace Tests
{
    [TestFixture]
    public class Class1
    {
        private Mock<IPlayerMapper> mock ;
        [OneTimeSetUp]
        public void Init()
        {
            mock = new Mock<IPlayerMapper>();
        }
        [Test]
        [TestCase("Divya",23,"India",30)]
        public void Tester(string name, int age, string country, int noOfMatches)
        {
            mock.Setup(p => p.IsPlayerNameExistsInDb(name)).Returns(false);
            mock.Setup(p => p.AddNewPlayerIntoDb(name));
            Player player = new Player(name,age,country,noOfMatches);
            Player newp = player.RegisterNewPlayer(name, mock.Object);
            Assert.AreEqual(name, newp.Name);
        }
        

    }
}
