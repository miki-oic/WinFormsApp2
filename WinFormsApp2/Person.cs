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

        int GetId();

        string GetName();

    }

    public class PersonModel : Person
    {

        private int id;
        private string name;

        public PersonModel(int id, string name)
        {

            this.id = id;
            //Name = name;
            this.name = name;

        }

        public int GetId()
        {

            return id;

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

    public class RecordablePersonModel : PersonModel, RecordableObject
    {

        public RecordablePersonModel(int id, string name) : base(id, name)
        {
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

    }

}
