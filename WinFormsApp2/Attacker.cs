using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    /// <summary>
    /// 攻撃者
    /// </summary>
    public interface Attacker
    {

        /// <summary>
        /// 攻撃します。
        /// </summary>
        /// <returns>攻撃値</returns>
        int Attack();

    }

}
