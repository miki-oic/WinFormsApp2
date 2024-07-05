using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2;

namespace OOTestProject
{
    [TestClass]
    public class FieldTest
    {
        [TestMethod]
        public void GetNameTest() {
            
            Field field = new ColosseumModel("闘技場");

            Assert.AreEqual("闘技場", field.GetName());
        }
    }
}
