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

		/// <summary>Private FileIO manager.</summary>
		FileIO file = new FileIO();
		/// <summary>Private ProgramLogic manager.</summary>
		ProgramLogic p = new ProgramLogic();
		/// <summary>Private user information.</summary>
		User user = new User();


		/// <summary>
		/// Default constructor. Initialize the form components and adjust component properties.
		/// </summary>
		public GameMonitor() {

			InitializeComponent();

			/*
			 * Set the default status as paused and color appropriately.
			 * todo: set the color of the text in the same place that you change the actual text (move to a property).
			 */
			appStatusLbl.ForeColor = Color.Red;
			appStatusLbl.Text = p.AppRunning;

            //Need a getter here to go through games.txt and files can be loaded into the gameEditPanel

            //Just testing here -- delete this
            List<string> test = new List<string>();
            test.Add("Wow");
            test.Add("adkfjasklj");
            editGamesTxtBox.Text = p.BuildEditGamePanel(test);
           

		}

		#region Event Handlers

		/// <summary>
		/// Event handler for StartStopBtn.OnClick
		/// </summary>
		private void startStopBtn_Click( object sender, EventArgs e ) {
			if( p.AppRunning == "Paused" ) {
				p.AppRunning = "Running";
				startStopBtn.Text = "Stop";
				appStatusLbl.ForeColor = Color.Green;
				appStatusLbl.Text = p.AppRunning;

				if( p.CurrentGame != " " ) {
					playingLbl.Text = p.CurrentGame;
				}
			} else {
				p.AppRunning = "Paused";
				startStopBtn.Text = "Start";
				appStatusLbl.ForeColor = Color.Red;
				appStatusLbl.Text = p.AppRunning;
			}
		}

		/// <summary>
		/// Event handler for NewUserToolStripMenuItem.OnClick
		/// </summary>
		private void newUserToolStripMenuItem_Click( object sender, EventArgs e ) {
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Text File|*.txt";
			sfd.FileName = "";
			sfd.Title = "Create new user file";
			sfd.ShowDialog();
			sfd.Dispose();
			System.IO.File.WriteAllText( sfd.FileName + ".txt", "" );
		}

		/// <summary>
		/// Event handler for LoadUserToolStripMenuItem.OnClick
		/// </summary>
		private void loadUserToolStripMenuItem_Click( object sender, EventArgs e ) {
			OpenFileDialog ofg = new OpenFileDialog();
			ofg.ShowDialog();
		}

        /// <summary>
        /// Event handler for LoadUserBtn.OnClick
        /// </summary>
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
            editGamesPanel.Visible = true;
        }

        private void backBtn1_Click(object sender, EventArgs e)
        {
            editGamesPanel.Visible = false;
        }

        private void editGamesTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

		#endregion
