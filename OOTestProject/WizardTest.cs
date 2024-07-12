using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2;

namespace OOTestProject
{
    [TestClass]
    public class WizardTest
    {
        [TestMethod]
        public void GetNameTest01()
        {

            Wizard wizard = new WizardModel();

            Assert.AreEqual("ゲストプレイヤー", wizard.GetName());
        }

        [TestMethod]
        public void GetNameTest02()
        {

            // string name, int hitPoint, int magicPoint
            Wizard wizard = new WizardModel(2, "Wizard", 2000, 150, 0);
            Assert.AreEqual("Wizard", wizard.GetName());
        }

        [TestMethod]
        public void GetNameTest03()
        {

            // string name, int hitPoint, int magicPoint
            Wizard wizard = new WizardModel(2, "Wizard", 2000, 150, 0);
            Assert.AreEqual(2000, wizard.GetHitPoint());
        }

        [TestMethod]
        public void GetNameTest04()
        {

            // string name, int hitPoint, int magicPoint
            Wizard wizard = new WizardModel(2,"Wizard", 2000, 150,0);
            Assert.AreEqual(150, wizard.GetMagicPoint());
        }

        [TestMethod]
        public void GetNameTest05()
        {
            Wizard wizard = new WizardModel(2, "Wizard", 2000, 150, 0);
            Assert.AreEqual(0, wizard.GetLevel());
        }

        [TestMethod]
        public void GetNameTest06()
        {
            Wizard wizard = new WizardModel(2, "Wizard", 2000, 150, 10);
            Assert.AreEqual(10, wizard.GetArmorClass());
        }
    }
}