using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    public class Person
    {

        private string name;

        public Person(string name)
        {

            this.name = name;
            //Name = name;

        }

        //public string Name { get { return name; } set { name = value; } }
        public string getName()
        {

            return name;

        }
        /*
        public string Name
        {
            get
            {
                Debug.Assert(name != null);
                return name;

            }
            
            set
            {

                Debug.Assert(value != null);
                name = value;

            }

        }
        */

    }

}
