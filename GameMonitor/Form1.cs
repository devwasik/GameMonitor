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
using System.Drawing;
using System.IO;
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

        /// <summary>
        /// Default constructor. Initialize the form components and adjust component properties.
        /// </summary>
        public GameMonitor()
        {

            InitializeComponent();

            //Make sure we start with only login panel visible
            InitializeAppView();

            //Refresh UI every 5 seconds
            tc.TheTimeChanged += new TimerClass.TimerTickHandler(IntervalHasPassed);

            /*
			 * Set the default status as paused and color appropriately.
			 * todo: set the color of the text in the same place that you change the actual text (move to a property).
			 */
            appStatusLbl.ForeColor = Color.Red;
            appStatusLbl.Text = "Paused";
        }

        public void ExceptionHandler(string message, string stackTrace)
        {

            MessageBox.Show("A critical error has occured.\n\n ------------------------------\n\nMessage:\n\n" + message
                + "\n\n\n ------------------------------\n Stack trace:\n\n" + stackTrace);
        }

        #region Event Handlers

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (p.AppRunning == false)
            {
                p.AppRunning = true;
                startStopBtn.Text = "Stop";
                appStatusLbl.ForeColor = Color.Green;
                appStatusLbl.Text = "Running";
            }
            else
            {
                p.AppRunning = false;
                startStopBtn.Text = "Start";
                appStatusLbl.ForeColor = Color.Red;
                appStatusLbl.Text = "Paused";
            }
        }

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
                MessageBox.Show("Login Success");
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
    }
}


		#endregion
