using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Field
    {
        public string getName()
        {

            return "";

        }
    }

    public class Castle : Field
    {

    }

    public class Player : Magician
    {
        public string getName()
        {
            throw new NotImplementedException();
        }
    }

    public interface Magician
    {

        string getName();

    }
}
