using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    /// <summary>
    /// 攻撃
    /// </summary>
    public class Attack
    {

        public Attack(Attacker attacker, Player target, Field field)
        {
            
            target.DamagedBy(attacker);
            
        }

    }

}
