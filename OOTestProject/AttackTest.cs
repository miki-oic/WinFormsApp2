using WinFormsApp2;

namespace OOTestProject
{
    [TestClass]
    public class AttackTest
    {
        [TestMethod]
        public void TestMethod()
        {

            Fighter fighter = new FighterModel();
            Wizard wizard = new WizardModel();
            Field field = new ColosseumModel("ì¨ãZèÍ");

            new Attack(fighter, wizard, field);

            Assert.AreEqual(900, wizard.GetHitPoint());

        }

        [TestMethod]
        public void  FighterTest()
        {
            Fighter fighter = new FighterModel();
            Assert.AreEqual(100, fighter.Attack());
        }

        [TestMethod]
        public void WizardTest()
        {
            Wizard wizard = new WizardModel();
            Assert.AreEqual(100, wizard.Attack());
        }

        [TestMethod]
        public void PriestTest()
        {
            Priest priest = new PriestModel();
            Assert.AreEqual(100, priest.Attack());
        }

    }
}