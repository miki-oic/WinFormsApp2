using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace OOTestProject
{

    [TestClass]
    public class PlayerStatusLabelTest
    {

        [TestMethod]
        public void CreatePlayerStatusLabelTest01()
        {

            Label label = new PlayerStatusLabel();

            Assert.AreEqual("", label.Text);

        }

        [TestMethod]
        public void CreatePlayerStatusLabelTest02()
        {

            PlayerStatusLabel label = new PlayerStatusLabel();
            label.AddPlayer(new FighterModel());

            Assert.AreEqual("ゲストプレイヤー", label.Text);

        }

    }

}
