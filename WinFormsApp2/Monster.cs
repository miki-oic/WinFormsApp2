using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Monster:Player
    {
        private int hitPoint;
        private int armorClass;
        private int experiencePoint;
        private char type;

        //TODO:monster変更
        public Player AddObserver(Observer observer)
        {
            throw new NotImplementedException();
        }

        public int Attack()
        {
            return 0;
        }

        public Player DamagedBy(Attacker attacker)
        {
            throw new NotImplementedException();
        }

        public int GetHitPoint()
        {
            return hitPoint;
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public bool IsCollapsed()
        {
            throw new NotImplementedException();
        }

        public bool IsOk()
        {
            throw new NotImplementedException();
        }
    }
}
