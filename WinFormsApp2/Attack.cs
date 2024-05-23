using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    public class Attack
    {

        public Attack(Player attacker, Player target, Field field)
        {

            target.damagedBy(attacker);

        }

    }

    public interface Attacker
    {

        /// <summary>
        /// 攻撃します。
        /// </summary>
        /// <returns>攻撃力</returns>
        int attack();

    }

}
