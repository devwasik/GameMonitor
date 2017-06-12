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
using System.Diagnostics;
using System.Timers;
using System.IO;

namespace GameMonitor {

	/// <summary>
	/// Manages the background services thread that check system processes for running game applications.
	/// </summary>
	class ProgramLogic {

		#region Objects

		/// <summary>List that will be built to hold all the process names in games.txt file.</summary>
		private List<string> gameProcesses = new List<string>();
        private List<string> gameName = new List<string>();

		#endregion

		#region Properties

		/// <summary>
		/// Public property that indicates if a game application is running.
		/// Valid values are "Paused" or "Running"
		/// todo: I would suggest changing this to an enum.
		/// </summary>
		public string AppRunning {
			get {
				return appRunning;
			}
			set {
				appRunning = value;
				/*
				 * If the new value being set is "Running", perform the operations to enable the timer.
				 * todo: Move all of the timer setup stuff to the Constructor, you only need to enable the timer here.
				 */
				if( appRunning == "Running" ) {
					Timer timer = new Timer(5000);
					timer.Interval = 5000;
					timer.Elapsed += new ElapsedEventHandler( CheckProcesses );
					timer.Enabled = true;
					timer.AutoReset = true;
				}
			}
		}

        public List<string> GameName
        {
            get
            {
                return gameName;
            }
        }


		/// <summary>
		/// Public property that holds the name of the currently running game.
		/// </summary>
		public string CurrentGame {
			get {
				return currentGame;
			}
			set {
				currentGame = value;
				if( currentGame != " " ) {
					//Create event to change game text GUI
				}
			}
		}

        #endregion

        #region Values

        /// <summary>Current application running status. Default = Paused.</summary>
        private string appRunning = "Paused";
		/// <summary>Title of the currently running game.</summary>
		private string currentGame = " ";
		/// <summary>
		/// Path to the user's game list file.
		/// Todo: Remove hardcoding, allow user to select a game list file.
		/// </summary>
		private string fpath = "C:\\Users\\Nick\\Desktop\\gameProcesses.txt";
		/// <summary>Private flag indicating if a game is running or not. Default = False.</summary>
		private bool playingGame = false;

		#endregion

		/// <summary>
		/// Default constructor. Here we will load game list text file via constructor and eventually a user file here as well
		/// </summary>
		public ProgramLogic() {

			LoadGameList();
		}

		/// <summary>
		/// Loads the list of gameProcesses from the game list file.
		/// </summary>
		/// <returns></returns>
		public List<string> LoadGameList() {

			try {
				/*
				 * Create stream reader and read the whole file, line by line, adding each line to game list.
				 */
				StreamReader sr = new StreamReader(fpath);
                string line = "";

                //Read each line and take the process name / game name seperated by commas
                string[] csv;
                csv = line.Split(',');
                while ((line = sr.ReadLine()) != null) { 
                    //First item in the line is the process name
                    gameProcesses.Add(csv[0]);                  
                    //After processName there is a comma then -> game name
                    gameName.Add(csv[1]);
                }
            }

			
			catch( Exception e )  {

				Console.WriteLine( e ); 
                //Need to generate exception window
			}

			/*
			 * todo: I don't think this needs to return anything.
			 * The gameProcesses var is visible to this whole class, and you don't ask for a
			 * return value when you are calling this method from ProgramLogic constructor.
			 */
			return gameProcesses;
		}

        public string BuildEditGamePanel(List<string> games)
        {
            var text = "";
            foreach (string g in games)
            {
                text += g.ToString() + "\n";
            }
            return text;
        }

		/// <summary>
		/// Checks each running process to match to our user's game list.
		/// </summary>
		/// <param name="state"></param>
		/// <param name="args"></param>
		private void CheckProcesses( object state, ElapsedEventArgs args ) {
			Process[] processCheck = Process.GetProcesses();

			// Loop through each game.
			for( int g = 0; g < gameProcesses.Count; g++ ) {

				// Loop through each process.
				foreach( Process process in processCheck ) {

					/*
					 * If we get a match from a running process, set the current game and break out of loop.
					 */
					if( process.ProcessName == gameProcesses[g] ) {
						currentGame = gameName[g];      
						playingGame = true;
						break;
					}

					// If no game found.
					else {
						playingGame = false;
					}
				}

				// Exit loop if game is found.
				if( playingGame ) break;
			}

			// If entire loop finishes and playingGame still == false, execute stoppedplaying method to reset currentGame variable
			if( !playingGame ) StoppedPlaying();
		}

		/// <summary>
		/// Clears all gameplay flags and states. Resets program back to defaults.
		/// </summary>
		private void StoppedPlaying() {

			playingGame = false;
			appRunning = "Stopped";
			currentGame = " ";
		}
	}
}

