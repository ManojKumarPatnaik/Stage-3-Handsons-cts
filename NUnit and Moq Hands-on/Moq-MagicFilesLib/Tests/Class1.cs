using MagicFilesLib;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class Class1
    {
        Mock<IDirectoryExplorer> mock = new Mock<IDirectoryExplorer>();
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";
        [SetUp]
        public void Init()
        {
            mock = new Mock<IDirectoryExplorer>(MockBehavior.Strict);
        }
        [Test]
        [TestCase("Home/New/")]
        public void TestDirectory(string path)
        {
            List<string> files = new List<string>() { _file1, _file2 };
            mock.Setup(p => p.GetFiles(path)).Returns(files);
            ICollection<string> actual = mock.Object.GetFiles(path);
            Assert.NotNull(actual);
            Assert.AreEqual(actual.Count,2);
            Assert.That(actual.Contains(_file2));

        }
    }
}

    

