using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Monster : Player
    {
        private int hitPoint;
        private int armorClass;
        private int experiencePoint;
        private char type;

        public int GetExperiencePoint()
        {
            return experiencePoint;
        }

        public Player AddObserver(Observer observer)
        {
            return this;
        }

        public int Attack()
        {
            return 0;
        }

        public Player DamagedBy(Attacker attacker)
        {
            hitPoint -= attacker.Attack() + armorClass;
            return this;
        }

        public int GetArmorClass()
        {
           return armorClass;
        }

        public int GetHitPoint()
        {
            return hitPoint;
        }

        public string GetJob()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return type.ToString();
        }

        public bool IsCollapsed()
        {
            return !IsOk();
        }

        public bool IsOk()
        {
            return hitPoint > 0;
        }

        public int GetLevel()
        {
            throw new NotImplementedException();
        }
    }
}
