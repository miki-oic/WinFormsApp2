using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2;

namespace OOTestProject
{
    [TestClass]
    public class PriestTest
    {

        [TestMethod]
        public void GetNameTest01()
        {
            Priest priest = new PriestModel();
            Assert.AreEqual("ゲストプレイヤー", priest.GetName());
        }

        [TestMethod]
        public void GetNameTest02()
        {
            Priest priest = new PriestModel(3,"Priest", 3000, 100,10);
            Assert.AreEqual("Priest", priest.GetName());
        }

        [TestMethod]
        public void GetHitPointTest03()
        {
            Priest priest = new PriestModel(3,"Priest", 3000, 100,10);
            Assert.AreEqual(3000, priest.GetHitPoint());
        }

        [TestMethod]
        public void GetFaithTest04()
        {
            Priest priest = new PriestModel(3,"Priest", 3000, 100,10);
            Assert.AreEqual(100, priest.GetFaithPoint());
        }

        public void GetLevelTest05()
        {
            Priest priest = new PriestModel(3,"Priest", 3000, 100,10);
            Assert.AreEqual(0, priest.GetLevel());
        }

        [TestMethod]
        public void GetArmorClassTest06()
        {
            Priest priest = new PriestModel(3,"Priest", 3000, 100,10);
            Assert.AreEqual(10, priest.GetArmorClass());
        }
    }
}
