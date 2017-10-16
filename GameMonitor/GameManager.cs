/*
 * Copyright 2017 Nick Wasik
 *
 * NOTICE:  All information contained herein is, and remains the property of Nick Wasik
 * and his suppliers, if any.  The intellectual and technical concepts contained herein are
 * proprietary to Nick Wasik and his suppliers and may be covered by U.S. and Foreign
 * Patents, patents in process, and are protected by trade secret or copyright law. Dissemination
 * of this information or reproduction of this material is strictly forbidden unless prior written
 * permission is obtained from Nick Wasik.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

//This class will be used for the gameProcesses.txt file
//Will allow user to edit, add, and remove items

namespace GameMonitor
{
    class GameManager
    {
        #region Objects
        private static List<string> gameProcesses = new List<string>();
        private static List<string> gameName = new List<string>();
        #endregion

        #region Properties
        public static List<string> GameProcesses
        {
            get
            {
                return gameProcesses;
            }
            set
            {
                gameProcesses = value;
            }
        }

        public static List<string> GameName
        {
            get
            {
                return gameName;
            }
            set
            {
                gameName = value;
            }
        }

        #endregion

        public static List<string> LoadGameList()
        {

            //To Do: Move connection to its own DB class

            MySqlConnection dbConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=gamemonitor;uid=root;password=");
            dbConn.Open();
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT * FROM games";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                gameName.Add(reader["gameName"].ToString());
                gameProcesses.Add(reader["processName"].ToString());
            }

            /*  For testing - converts the List to string
             
            StringBuilder builder = new StringBuilder();

            foreach (string str in GameName)
            {
                builder.Append(str.ToString()).AppendLine();
            }

            MessageBox.Show(builder.ToString());

             */

            return gameName;
            


        }
    }
}
