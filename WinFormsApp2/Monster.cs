using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public interface Monster : Player
    { 
        char GetType();

    }

    public class MonsterModel : PlayerModel, Monster
    {
        
        private char type;

        public override int Attack()
        {
            return 0;
        }

        char Monster.GetType()
        {
            return type;
        }
    }
}
