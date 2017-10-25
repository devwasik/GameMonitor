using System.Collections.Generic;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace GameMonitor {

    /// <summary>
    ///User Data
    /// </summary>
    class User
    {
        #region Variables
        private string username,
            password;


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
        #endregion


        public bool Login(string userName, string pass)
        {
            // Create a request using a URL that can receive a post. 
            WebRequest request = WebRequest.Create("http://www.devwasik.net/appLogin.php");
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            string postData = "username="+userName +"&password="+pass;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            if (responseFromServer == "success")
            {
                return true;
            }

            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();

            return false;
        }

       
    }
}
