using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    public interface Person
    {

        string GetName();

    }

    public class PersonModel : Person
    {

        private string name;

        public PersonModel(string name)
        {

            //Name = name;
            this.name = name;

        }

        //public string Name { get { return name; } set { name = value; } }
        public string GetName()
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
