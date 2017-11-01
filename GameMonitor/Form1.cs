
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

        /// <summary> User manager.</summary>
        User user = new User();

        /// <summary>Game manager.</summary>
        GameManager gm = new GameManager();

        /// <summary>
        /// Timer class manages process checking, time upload, UI refreshes/// </summary>
        /// 1st timer refreshes UI and second is used to upload game time every 1 min
        TimerClass tc = new TimerClass();
        TimerClass lh = new TimerClass("x"); 
        

        public GameMonitor()
        {

            InitializeComponent();

            //Make sure we start with only login panel visible
            InitializeAppView();

            //p.CheckAppVersion(); -- see if app is on latest version

            //Refresh UI every 5 seconds
            tc.TheTimeChanged += new TimerClass.TimerTickHandler(IntervalHasPassed);

            //Log hours every 1 minute 
            lh.TheTimeChanged += new TimerClass.TimerTickHandler(LogHours);
        }

      

        public void ExceptionHandler(string message, string stackTrace)
        {

            MessageBox.Show("A critical error has occured.\n\n ------------------------------\n\nMessage:\n\n" + message
                + "\n\n\n ------------------------------\n Stack trace:\n\n" + stackTrace);
        }

        #region Event Handlers

  
        //Set up initial form view
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

            //Pass in values to boolean method in user class = if true log user in
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

        //Update UI every 5 seconds
        protected void IntervalHasPassed(string newTime)
        {
            this.Invoke(new MethodInvoker(delegate () { playingLbl.Text = p.CurrentGame; }));
        }

        //Log hours every minute
        protected void LogHours(string z)
        {
            this.Invoke(new MethodInvoker(delegate () { p.LogHoursInterval("z", user.Username); } ));
        }
       

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://devwasik.net/register.php/");
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user.Username = "";
            ResetView();
            loginUserTxtBox.Text = "";
            loginPasswordTxtBox.Text = "";
            loginPanel.Visible = true;
            
        }
        private void MinimzedTray()
        {
            notifyIcon1.Visible = true;
            notifyIcon1.Icon = SystemIcons.Application;

            notifyIcon1.BalloonTipText = "Minimized";
            notifyIcon1.BalloonTipTitle = "Your Application is Running in BackGround";
            notifyIcon1.ShowBalloonTip(10);
            

        }

        //
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                MinimzedTray();
                //add context menu here for right click menu options n tray icon
            }
            else if (FormWindowState.Normal == this.WindowState)
            {

             
            }
        }

        //Working
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        //Working
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

 
        //not working
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.BalloonTipText = "Normal";
            notifyIcon1.ShowBalloonTip(500);
        }

        //not working -  bubble notification comes up but app closes out when exited
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
               
                MinimzedTray();
                

            }

            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                MinimzedTray();
                
                
            }

        }
        //not working
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                MinimzedTray();

            }
        }
        
    }
}


		#endregion
