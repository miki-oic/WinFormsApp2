
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.MockForm
{
    public class Command
    {
        string command = "行動なし";
        public virtual string GetCommand()
        {
            return command;
        }
    }

    public class Attack : Command
    {
        public override string GetCommand()
        {
            return "攻撃をした！";
        }
    }

    public class Gurid : Command
    {
        public override string GetCommand()
        {
            return "防御した!";
        }
    }

    public class Magic : Command
    {
        public override string GetCommand()
        {
            return "魔法を唱えた";
        }
    }

    public class Escape : Command
    {
        public override string GetCommand()
        {
            return "逃走を計った！";
        }
    }


    public class CurseUnLock : Command 
    {
        public override string GetCommand()
        {
            return "呪いを解いた！";
        }
    }
}
