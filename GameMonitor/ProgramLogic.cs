using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;
using System.IO;
using System.Net;
using System.Text;

namespace GameMonitor {

	/// <summary>
	/// Manages the background services thread that check system processes for running game applications.
	/// </summary>
	class ProgramLogic {
	

		#region Properties
					
         
		
        public ProgramLogic()
        {
            GameManager.LoadGameList();
            Timer timer = new Timer(5000);
            timer.Interval = 5000;
            timer.Elapsed += new ElapsedEventHandler(CheckProcesses);
            timer.Enabled = true;
            timer.AutoReset = true;

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
		/// <summary>Title of the currently running game.</summary>
		private string currentGame = "Not in game";
        /// <summary>Private flag indicating if a game is running or not. Default = False.</summary>
		private bool playingGame = false;

 

        #endregion

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
			currentGame = "Not in game";
		}

        public void LogHoursInterval(string newTime, string user)
        {
            //Make sure username is set
            if (user != "")
            {
                WebRequest request = WebRequest.Create("http://www.devwasik.net/logHours.php");
                // Set the Method property of the request to POST.
                request.Method = "POST";
                // Create POST data and convert it to a byte array.
                string postData = "username=" + user + "&currentGame=" + CurrentGame;
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
        //Submit to server every 1min in case app crashes during a long session

        //StartLoggingHours() When a game instance is detected beging collecting data
        //CheckIfPlayedBefore() Called within start logging hours - query db and see if played before, if not insert game


    }
}

