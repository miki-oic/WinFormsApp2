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

        /// <summary>
        /// 名前を返します。
        /// </summary>
        /// <returns>名前</returns>
        string getName();

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
