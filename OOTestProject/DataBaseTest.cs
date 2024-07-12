using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2;

namespace OOTestProject
{
    [TestClass]
    public class DataBaseTest
    {
        [TestMethod]
        public void PersonGetNameTest01()
        {

            string sql = "SELECT id, name FROM public.person;";
            string ConnectionString =
                "Server=127.0.0.1;"
                + "Port=5432;"
                + "Database=postgres;"
                + "User ID=oo;"
                + "Password=oic;";

            NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
            connection.Open();

            NpgsqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                Debug.Print(reader["id"] + ":" + reader["name"]);

            }

            //Fighter fighter = new FighterModel();
            //Assert.AreEqual("ゲストプレイヤー", fighter.GetName());
        }
    }
}
