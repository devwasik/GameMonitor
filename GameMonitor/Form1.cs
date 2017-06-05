using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMonitor
{
    public partial class GameMonitor : Form
    {
        FileIO file = new FileIO();
        ProgramLogic p = new ProgramLogic();
        User user = new User();


        public GameMonitor()
        {

            InitializeComponent();
            appStatusLbl.ForeColor = Color.Red;                             //Default state of "paused"         
            appStatusLbl.Text = p.AppRunning;                               //Get value of appRunning variable
           
        }

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (p.AppRunning == "Paused")                                  
            {
                p.AppRunning = "Running";
                startStopBtn.Text = "Stop";
                appStatusLbl.ForeColor = Color.Green;
                appStatusLbl.Text = p.AppRunning;
             
                if (p.CurrentGame != " ")
                {
                    playingLbl.Text = p.CurrentGame;
                }
            }
            else
            {
                p.AppRunning = "Paused";
                startStopBtn.Text = "Start";
                appStatusLbl.ForeColor = Color.Red;
                appStatusLbl.Text = p.AppRunning;
            }
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.FileName = "";
            sfd.Title = "Create new user file";
            sfd.ShowDialog();
            sfd.Dispose();
            System.IO.File.WriteAllText(sfd.FileName + ".txt", "");
        }

        private void loadUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.ShowDialog();
        }

        private void loadUserFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.ShowDialog();
        }
    }
}
