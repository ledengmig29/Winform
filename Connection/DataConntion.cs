using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Connection
{
    class DataConntion
    {
        public  void Conection()
        {
           
        }
        public static MySqlConnection Camcon()

        {

            return new MySqlConnection("server = 150.158.155.116; user id = root;password = ZHANGcheng123.;database = memo; Charset=utf8");

        }
    }
}
