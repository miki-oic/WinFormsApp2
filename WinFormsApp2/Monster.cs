using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Monster : Player
    {
        private int HItP;
        private int AC;
        private int EXP;
        private char Race;

        public int GetAC()
        {
            return AC;
        }
        public int GetEXP()
        {
            return EXP;
        }
        public char GetRace()
        {
            return Race;
        }

        public int GetHitPoint()
        {
            return HItP;
        }

        public string GetJob()
        {
            throw new NotImplementedException();
        }

        public Player DamagedBy(Attacker attacker)
        {
            throw new NotImplementedException();
        }

        public bool IsOk()
        {
            throw new NotImplementedException();
        }

        public bool IsCollapsed()
        {
            throw new NotImplementedException();
        }

        public Player AddObserver(Observer observer)
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public int Attack()
        {
            throw new NotImplementedException();
        }
    }
}
