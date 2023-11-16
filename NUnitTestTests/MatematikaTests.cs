using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.Tests
{
    [TestClass()]
    public class MatematikaTestscase
    {
        [TestMethod()]
        public void UserTest()
        {
            Matematika mtk = new Matematika();
            Assert.AreEqual("AnnisaRisyafa", mtk.User("AnnisaRisyafa"));
        }
        [TestMethod()]
        public void TambahTest()
        {
            Matematika mtk = new Matematika();
            Assert.AreEqual(20, mtk.Tambah(10, 10));
        }
        [TestMethod()]
        public void KurangTest()
        {
            Matematika mtk = new Matematika();
            Assert.AreEqual(20, mtk.Kurang(30, 10));
        }
    }
}