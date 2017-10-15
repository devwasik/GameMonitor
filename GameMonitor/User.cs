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

using System.Collections.Generic;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace GameMonitor {

    /// <summary>
    ///User Data
    /// </summary>
    class User
    {
        #region Variables
        private string username,
            password,
            email;


        #endregion

        #region Properties

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        #endregion

        public bool Login()
        {
            MySqlConnection dbConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=gamemonitor;uid=root;password=");
            dbConn.Open();
            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT * FROM users WHERE username = @username and password = @password";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
