using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    public class Player : Fighter, Wizard
    {

        private int hitPoint = 0;
        private int strengh = 0;
        private int magicPoint = 0;

        public Player damagedBy(Player enemy)
        {

            int damaged = enemy.getMagicPoint();

            return this;

        }

        public bool isEnergetic()
        {

            return hitPoint > 0;

        }

        public bool isCollapsed()
        {

            return !isEnergetic();

        }

        public int getStrengh()
        {

            return strengh;

        }

        public Fighter slash()
        {
            throw new NotImplementedException();
        }

        public int getMagicPoint()
        {

            return magicPoint;

        }

        public Wizard spell()
        {
            throw new NotImplementedException();
        }

    }

    public interface Fighter
    {

        int getStrengh();

        Fighter slash();

    }

    public interface Wizard
    {

        int getMagicPoint();

        Wizard spell();

    }

}
