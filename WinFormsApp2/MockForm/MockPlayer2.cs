using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.MockForm
{
    internal class MockPlayer2: MockPlayer_Y
    {
        int HP = 100;
        int MAXHP = 100;

        string name = "Player2";
        string job = "狂信者";

        int AttackPoint = 1;

        int PlayerLv = 10;

        int AC = 50;

        public Player AddObserver(Observer observer)
        {
            throw new NotImplementedException();
        }

        public int Attack()
        {
            return AttackPoint;
        }

        public Player DamagedBy(Attacker attacker)
        {
            throw new NotImplementedException();
        }

        public string GetMAXHitPoint()
        {
            return MAXHP.ToString();
        }

        public int GetHitPoint()
        {
            return HP;
        }

        public string GetHitPointForDisplay()
        {
            return GetHitPoint().ToString();
        }

        public string GetName()
        {
            return name;
        }

        public bool IsCollapsed()
        {
            throw new NotImplementedException();
        }

        public bool IsOk()
        {
            throw new NotImplementedException();
        }

        public string GetJob()
        {
            return job;
        }

        public string GetPlayerLv()
        {
            return PlayerLv.ToString();
        }

        public string GetACForDisplay()
        {
            return AC.ToString();
        }

        public int GetArmorClass()
        {
            return AC;
        }

        public int GetLevel()
        {
            return PlayerLv;
        }

        public int GetId()
        {
            throw new NotImplementedException();
        }
    }
}
