﻿using System;
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

        string GetJobName();

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

        public override string GetJobName()
        {

            return "魔術師";

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
        /// <param name="id">ID</param>
        /// <param name="name">名前</param>
        /// <param name="hitPoint">体力</param>
        /// <param name="magicPoint">魔法力</param>
        /// <param name="aromorClass">防御力</param>

        public WizardModel(int id, string name, int hitPoint, int magicPoint, int aromorClass) : base(id, name, hitPoint, aromorClass)
        {
            
            this.magicPoint = magicPoint;

        }

        public override string GetJobName()
        {

            return "魔術師";

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
