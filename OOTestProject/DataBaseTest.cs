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

            string sql = "SELECT * FROM public.person;";
            //string sql = "SELECT 'id', 'name', 'hitPoint', 'strengh', 'armorClass' FROM public.person;";
            string ConnectionString =
                "Server=127.0.0.1;"
                + "Port=5432;"
                + "Database=rdb;"
                + "User ID=oo;"
                + "Password=oic;";

            NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
            connection.Open();

            NpgsqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                Fighter fighter = new FighterModel(
                    // int id
                    reader.GetInt32(0),
                    //(int) reader["id"],
                    // string name
                    reader.GetString(1),
                    //(string) reader["name"],
                    // int hitPoint
                    reader.GetInt32(2),
                    //(int) reader["hitPoint"],
                    // int strengh
                    reader.GetInt32(3),
                    //(int) reader["strengh"],
                    // int armorClass
                    reader.GetInt32(4));
                    //(int) reader["armorClass"]);
                //Assert.AreEqual("ゲストプレイヤー", fighter.GetName());

                Debug.Print(fighter.ToString());

            }

        }
    }
}
