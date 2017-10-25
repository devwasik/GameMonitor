
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace GameMonitor
{

    public partial class GameMonitor : Form
    {

        /// <summary>Program processes and logic .</summary>
		ProgramLogic p = new ProgramLogic();
        /// <summary> User file manager.</summary>
        User user = new User();
        /// <summary>Game manager.</summary>
        GameManager gm = new GameManager();

        TimerClass tc = new TimerClass();
        
        //Overloaded TC constructor accepts a string 
        TimerClass lh = new TimerClass("placeholder"); 
        

        /// <summary>
        /// Default constructor. Initialize the form components and adjust component properties.
        /// </summary>
        public GameMonitor()
        {

            InitializeComponent();

            //Make sure we start with only login panel visible
            InitializeAppView();

            //p.CheckAppVersion(); -- see if app is on latest version
            //Refresh UI every 5 seconds
            tc.TheTimeChanged += new TimerClass.TimerTickHandler(IntervalHasPassed);
            lh.TheTimeChanged += new TimerClass.TimerTickHandler(LogHoursInterval);
        }

        public void ExceptionHandler(string message, string stackTrace)
        {

            MessageBox.Show("A critical error has occured.\n\n ------------------------------\n\nMessage:\n\n" + message
                + "\n\n\n ------------------------------\n Stack trace:\n\n" + stackTrace);
        }

        #region Event Handlers

  

        private void InitializeAppView()
        {
            ResetView();
            loginPanel.Visible = true;

        }

        //Hide all panels
        private void ResetView()
        {
            homePanel.Visible = false;
            loginPanel.Visible = false;
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            user.Username = loginUserTxtBox.Text;
            user.Password = loginPasswordTxtBox.Text;

            if (user.Login(user.Username, user.Password))
            {
                ResetView();
                userLbl.Text = user.Username;
                homePanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Login Failed");
            }

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void IntervalHasPassed(string newTime)
        {
            this.Invoke(new MethodInvoker(delegate () { playingLbl.Text = p.CurrentGame; }));
        }

        protected void LogHoursInterval(string newTime)
        {
            //Make sure username is set
            if (user.Username != "")
            {
                WebRequest request = WebRequest.Create("http://www.devwasik.net/logHours.php");
                // Set the Method property of the request to POST.
                request.Method = "POST";
                // Create POST data and convert it to a byte array.
                string postData = "username=" + user.Username + "&currentGame=" + p.CurrentGame;
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


                // Clean up the streams.
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://devwasik.net/register.php/");
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user.Username = "";
            ResetView();
            //Reset previous values in username/textbox or they will still be filled in after logoff
            loginUserTxtBox.Text = "";
            loginPasswordTxtBox.Text = "";
            loginPanel.Visible = true;
            
        }
    }
}


		#endregion
