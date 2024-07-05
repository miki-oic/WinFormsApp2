using WinFormsApp2;

namespace OOTestProject
{
    [TestClass]
    public class AttackTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            Fighter fighter = new FighterModel();
            Wizard wizard = new WizardModel();
            Field field = new ColosseumModel("ì¨ãZèÍ");

            new Attack(fighter, wizard, field);

            Assert.AreEqual(900, wizard.GetHitPoint());

        }
    }
}