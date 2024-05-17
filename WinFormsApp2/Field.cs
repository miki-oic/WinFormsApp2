using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Field
    {

        private string name = "";

        public Field()
        {

        }

        public string getName()
        {

            return name;

        }

        protected string setName(string name)
        {

            return this.name = name;

        }

    }

    public class Castle : Field
    {

        public Castle(string name)
        {

            setName(name);

        }

    }

    public class Colosseum : Field
    {

        public Colosseum(string name)
        {

            setName(name);

        }

    }

}
