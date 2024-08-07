﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.MockForm
{
    public class MockPlayer1 : MockPlayer_Y
    {
        int HP = 100;
        int MAXHP = 100;

        string name = "Player1";
        string job = "狂祖";

        int AttackPoint = 1;

        int PlayerLv = 10;

        int AC = 50;

        public MockPlayer1(int hp,int maxhp,string _name,string _jub,int attackpoint,int playerLv,int ac)
        {
            HP = hp;
            MAXHP = maxhp;
            name = _name;
            job = _jub;
            AttackPoint = attackpoint;
            PlayerLv = playerLv;
            AC = ac;
        }


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

        public string GetJobName()
        {

            return "#GetJobName()";

        }

        public int GetExperiencePoint()
        {
            throw new NotImplementedException();
        }
    }
}
