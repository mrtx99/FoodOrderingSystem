using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.DL
{
    class DBConnection
    {
        private SqlConnection con;
        public DBConnection()
        {

            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath[0] + @"GM.mdf;Integrated Security=True";    
            con = new SqlConnection(conString);
        }

        public SqlConnection Con { get => con; }
    }
}
