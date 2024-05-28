using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    public interface Field
    {

        string getName();

    }

    public abstract class FieldModel
    {

        private string name = "";

        public FieldModel()
        {

        }

        public string getName()
        {

            return name;

        }

        public string setName(string name)
        {

            return this.name = name;

        }

    }

    public class Shop : FieldModel
    {

        public Shop(string name)
        {

            setName(name);

        }

    }

    public class Castle : FieldModel
    {

        public Castle(string name)
        {

            setName(name);

        }

    }

    public class Colosseum : FieldModel
    {

        public Colosseum(string name)
        {

            setName(name);

        }

    }

}
