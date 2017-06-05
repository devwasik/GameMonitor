using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace GameMonitor
{
    class ProgramLogic
    {
        private List<string> games = new List<string>();                    //List that will be built to hold all the process names in games.txt file

        private string appRunning = "Paused";                               //Default value when program is launched
        private string currentGame = " ";
        private string fpath = "C:\\Users\\Nick\\Desktop\\games.txt";       //Need to make this not hard coded
        private bool playingGame = false;

        public ProgramLogic()                                               //Need to load game list text file via constructor and eventually a user file here as well
        {
            LoadGameList();
        }

        public List<string> LoadGameList()
        {
            try
            {
                StreamReader sr = new StreamReader(fpath);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    games.Add(line);
                }
            }
            catch(Exception e)                                  //Remove - this was just for testing the method with a breakpoint and make sure filepath was read
            {
                Console.WriteLine(e);
            }
            return games;
        }

        private void CheckProcesses(object state, ElapsedEventArgs args)
        {
            Process[] processCheck = Process.GetProcesses();

            for (int g = 0; g < games.Count; g++)
            {
                foreach (Process process in processCheck)
                {
                    if (process.ProcessName == games[g])
                    {
                        currentGame = games[g];
                        playingGame = true;
                        break;
                    }
                    else                                               //No game found
                    {
                        playingGame = false;
                    }
                }
                if (playingGame)                                       //Exit loop if game is found
                {
                    break;
                }
            }                                       
            
            if (!playingGame)                                          //If entire loop finishes and playingGame still equals false execute stoppedplaying method to reset currentGame variable
            {
                StoppedPlaying();
            }
        }

        private void StoppedPlaying()
        {
            playingGame = false;
            appRunning = "Stopped";
            currentGame = " ";
        }


        public string AppRunning
        {
            get
            {
                return this.appRunning;
            }
            set
            {
                this.appRunning = value;
                if (this.appRunning == "Running")
                {
                    Timer timer = new Timer(5000);
                    timer.Interval = 5000;
                    timer.Elapsed += new ElapsedEventHandler(CheckProcesses);
                    timer.Enabled = true;
                    timer.AutoReset = true;
                }
            }
        }

        public string CurrentGame
        {
            get
            {
                return currentGame;
            }
            set
            {
                currentGame = value;
                if (currentGame != " ")
                {
                    //Create event to change game text GUI
                }
            }
        }
    }
}

