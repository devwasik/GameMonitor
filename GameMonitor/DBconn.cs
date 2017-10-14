using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Web;
using MySql.Data.MySqlClient;

namespace GameMonitor
{
    class DBconn
    {
        public bool Connect()
        {
            MySqlConnection dbConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=gamemonitor;uid=root;password=");
            return true;
        }
    }
}
