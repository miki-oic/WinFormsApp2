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
            Assert.AreEqual("ゲストプレイヤー", fighter.GetName());
        }

        [TestMethod]
        public void GetNameTest02()
        {
            Fighter fighter = new FighterModel(1, "Fighter", 2000, 300, 0);
            Assert.AreEqual("Fighter", fighter.GetName());
        }

        [TestMethod]
        public void GetHitPointTest03()
        {
            Fighter fighter = new FighterModel(1, "Fighter", 2000, 300, 0);
            Assert.AreEqual(2000, fighter.GetHitPoint());
        }

        [TestMethod]
        public void GetStrenghTest04()
        {
            Fighter fighter = new FighterModel(1, "Fighter", 2000, 300, 0);
            Assert.AreEqual(300, fighter.GetStrengh());
        }

        [TestMethod]
        public void GetLevelTest05()
        {
            Fighter fighter = new FighterModel(1, "Fighter", 2000, 300, 0);
            Assert.AreEqual(0, fighter.GetLevel());
        }

        [TestMethod]
        public void GetArmorClassTest06()
        {
            Fighter fighter = new FighterModel(1, "Fighter", 2000, 300, 10);
            Assert.AreEqual(10, fighter.GetArmorClass());
        }
    }
}
