using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2;

namespace OOTestProject
{
    [TestClass]
    public class FighterTest
    {
        [TestMethod]
        public void GetNameTest01()
        {
            Fighter fighter = new FighterModel();
            Assert.AreEqual("", fighter.GetName());
        }

        [TestMethod]
        public void GetNameTest02()
        {
            Fighter fighter = new FighterModel("Fighter",2000,300);
            Assert.AreEqual("Fighter", fighter.GetName());
        }

        [TestMethod]
        public void GetNameTest03()
        {
            Fighter fighter = new FighterModel("Fighter", 2000, 300);
            Assert.AreEqual(300, fighter.GetHitPoint());
        }

        [TestMethod]
        public void GetNameTest04()
        {
            Fighter fighter = new FighterModel("Fighter", 2000, 300);
            Assert.AreEqual(300, fighter.GetStrengh());
        }

    }
}
