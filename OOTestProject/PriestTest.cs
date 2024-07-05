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
            Assert.AreEqual("", priest.GetName());
        }

        [TestMethod]
        public void GetNameTest02()
        {
            Priest priest = new PriestModel("Priest", 3000, 100);
            Assert.AreEqual("Priest", priest.GetName());
        }

        [TestMethod]
        public void GetNameTest03()
        {
            Priest priest = new PriestModel("Priest", 3000, 100);
            Assert.AreEqual(300, priest.GetHitPoint());
        }

        [TestMethod]
        public void GetNameTest04()
        {
            Priest priest = new PriestModel("Priest", 3000, 100);
            Assert.AreEqual(300, priest.GetFaithPoint());
        }

        public void GetNameTest05()
        {
            Priest priest = new PriestModel("Priest", 3000, 100);
            Assert.AreEqual(10, priest.GetLevel());
        }

        [TestMethod]
        public void GetNameTest06()
        {
            Priest priest = new PriestModel("Priest", 3000, 100);
            Assert.AreEqual(10, priest.GetArmorClass());
        }
    }
}
