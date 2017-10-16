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
	

		#region Properties

		/// <summary>
		/// Public property that indicates if a game application is running.
		/// Valid values are "Paused" or "Running"
		/// todo: I would suggest changing this to an enum.
		/// </summary>
		public bool AppRunning {
			get {
				return appRunning;
			}
			set {
				appRunning = value;
				/*
				 * If the new value being set is "Running", perform the operations to enable the timer.
				 * todo: Move all of the timer setup stuff to the Constructor, you only need to enable the timer here.
				 */
				if( appRunning == true ) {
					Timer timer = new Timer(5000);
					timer.Interval = 5000;
					timer.Elapsed += new ElapsedEventHandler( CheckProcesses );
					timer.Enabled = true;
					timer.AutoReset = true;
                }
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
        private bool appRunning = false;
		/// <summary>Title of the currently running game.</summary>
		private string currentGame = "Not in game";
        /// <summary>Private flag indicating if a game is running or not. Default = False.</summary>
		private bool playingGame = false;

 

        #endregion

        /// <summary>
        /// Default constructor. Here we will load game list text file via constructor and eventually a user file here as well
        /// </summary>
        public ProgramLogic() {
            GameManager.LoadGameList();
		}

		/// <summary>
		/// Loads the list of gameProcesses from the game list file.
		/// </summary>
		/// <returns></returns>
		
		/// <summary>
		/// Checks each running process to match to our user's game list.
		/// </summary>
		/// <param name="state"></param>
		/// <param name="args"></param>
		private void CheckProcesses( object state, ElapsedEventArgs args ) {
			Process[] processCheck = Process.GetProcesses();

			// Loop through each game.
			for( int g = 0; g < GameManager.GameProcesses.Count; g++ ) {

				// Loop through each process.
				foreach( Process process in processCheck ) {

					/*
					 * If we get a match from a running process, set the current game and break out of loop.
					 */
					if( process.ProcessName == GameManager.GameProcesses[g] ) {
						currentGame = GameManager.GameName[g];      
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
			appRunning = true;
			currentGame = "Not in game";
		}
	}
}

