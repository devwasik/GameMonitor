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
using System.Windows.Forms;

namespace GameMonitor {

    public partial class GameMonitor : Form {

        /// <summary>Program processes and logic .</summary>
		ProgramLogic p = new ProgramLogic();
        /// <summary> User file manager.</summary>
        User user = new User();
        /// <summary>Game file manager.</summary>
        GameFile gfile = new GameFile();

        /// <summary>
        /// Default constructor. Initialize the form components and adjust component properties.
        /// </summary>
        public GameMonitor() {

            InitializeComponent();

            //Make sure we start with only login panel visible
            InitializeAppView();

            /*
			 * Set the default status as paused and color appropriately.
			 * todo: set the color of the text in the same place that you change the actual text (move to a property).
			 */
            appStatusLbl.ForeColor = Color.Red;
            appStatusLbl.Text = "Paused";
            userLbl.Text = user.Username;
        }

        public void ExceptionHandler(string message, string stackTrace)
        {

            MessageBox.Show("A critical error has occured.\n\n ------------------------------\n\nMessage:\n\n" + message
                + "\n\n\n ------------------------------\n Stack trace:\n\n" + stackTrace);
        }

        #region Event Handlers

        private void startStopBtn_Click(object sender, EventArgs e) {
            if (p.AppRunning == false) {
                p.AppRunning = true;
                startStopBtn.Text = "Stop";
                appStatusLbl.ForeColor = Color.Green;
                appStatusLbl.Text = "Running";

                if (p.CurrentGame != " ") {
                    playingLbl.Text = p.CurrentGame;
                }
            } else {
                p.AppRunning = false;
                startStopBtn.Text = "Start";
                appStatusLbl.ForeColor = Color.Red;
                appStatusLbl.Text = "Paused";
            }
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e) {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text File|*.txt";
                sfd.FileName = "";
                sfd.Title = "Create new user file";
                sfd.ShowDialog();
                sfd.Dispose();
                System.IO.File.WriteAllText(sfd.FileName + ".txt", "");
            }
            catch (Exception ex)
            {
                ExceptionHandler(ex.Message, ex.StackTrace);
            }
        }

        private void loadUserToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.ShowDialog();
        }

        private void loadUserFileBtn_Click(object sender, EventArgs e)
        {
            Stream fs = null;
            OpenFileDialog ofg = new OpenFileDialog();

            ofg.InitialDirectory = "c:\\";
            ofg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofg.FilterIndex = 2;
            ofg.RestoreDirectory = true;

            if (ofg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fs = ofg.OpenFile()) != null)
                    {
                        using (fs)
                        {
                            MessageBox.Show(File.ReadAllText(ofg.FileName));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file. Error details: " + ex.Message);
                }
            }
        }

        private void editGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetView();
            editGamesPanel.Visible = true;
        }

        private void backBtn1_Click(object sender, EventArgs e)
        {
            editGamesPanel.Visible = false;
            homePanel.Visible = true;
        }

        private void addGameBtn_Click(object sender, EventArgs e)
        {
            addGamePanel.Visible = true;
            homePanel.Visible = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            addGamePanel.Visible = false;
        }

        private void gameNameAddTxtBox_TextChanged(object sender, EventArgs e)
        {
            string addGame;
            string addProcess;

            addGame = gameNameAddTxtBox.Text;
            addProcess = gameProcessAddTxtBox.Text;
        }

        private void addGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetView();
            addGamePanel.Visible = true;
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
            addGamePanel.Visible = false;
            editGamesPanel.Visible = false;
            loginPanel.Visible = false;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            ResetView();
            homePanel.Visible = true;
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            user.Username = loginUserTxtBox.Text;
            user.Password = loginPasswordTxtBox.Text;
            if (user.Login())
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
    }
}

		#endregion
