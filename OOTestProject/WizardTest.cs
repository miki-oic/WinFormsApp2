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
            Wizard wizard = new WizardModel("Wizard", 2000, 150);
            Assert.AreEqual("Assert", wizard.GetName());
        }

        [TestMethod]
        public void GetNameTest03()
        {

            // string name, int hitPoint, int magicPoint
            Wizard wizard = new WizardModel("Wizard", 2000, 150);
            Assert.AreEqual(200, wizard.GetHitPoint());
        }

        [TestMethod]
        public void GetNameTest04()
        {

            // string name, int hitPoint, int magicPoint
            Wizard wizard = new WizardModel("Wizard", 2000, 150);
            Assert.AreEqual(150, wizard.GetMagicPoint());
        }
    }
}