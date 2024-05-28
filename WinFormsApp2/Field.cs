using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    public interface Field
    {

        string GetName();

    }

    public abstract class FieldModel : Field
    {

        private string name;

        public FieldModel()
        {

            name = "";

        }

        public string GetName()
        {

            return name;

        }

        public string SetName(string name)
        {

            return this.name = name;

        }

    }

    public class ShopModel : FieldModel
    {

        public ShopModel(string name)
        {

            SetName(name);

        }

    }

    public class CastleModel : FieldModel
    {

        public CastleModel(string name)
        {

            SetName(name);

        }

    }

    public class ColosseumModel : FieldModel
    {

        public ColosseumModel(string name)
        {

            SetName(name);

        }

    }

}
