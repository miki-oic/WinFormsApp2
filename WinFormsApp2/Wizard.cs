using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    /// <summary>
    /// 魔導士
    /// </summary>
    public interface Wizard : Player
    {
        int GetMagicPoint();

        /// <summary>
        /// 呪文を唱えます。
        /// </summary>
        /// <returns>効果の値</returns>
        int Spell();

    }

    public class WizerdMock : PlayerModel, Wizard
    {
        public override int Attack()
        {
            return 100;
        }

        public int GetMagicPoint()
        {
            throw new NotImplementedException();
        }

        public int Spell()
        {
            return 100;
        }
    }
    public class WizardModel : PlayerModel, Wizard
    {

        private int magicPoint;

        public WizardModel()
        {

            magicPoint = 100;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="hitPoint">体力</param>
        /// <param name="magicPoint">魔法力</param>
        /// <param name="job">職業</param>
        /// <param name="aromorClass">防御力</param>
        
        public WizardModel(string name, int hitPoint, int magicPoint,string job,int aromorClass) : base(name, hitPoint,job,aromorClass)
        {
            
            this.magicPoint = magicPoint;

        }

        /// <summary>
        /// 魔力を返します。
        /// </summary>
        /// <returns>魔力</returns>
        public int GetMagicPoint()
        {

            return magicPoint;

        }

        public override int Attack()
        {

            return Spell();

        }

        public int Spell()
        {

            return magicPoint;

        }

    }

}
