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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//This class will be used for the gameProcesses.txt file
//Will allow user to edit, add, and remove items

namespace GameMonitor
{
    class GameFile
    {
        #region Objects
        private static List<string> gameProcesses = new List<string>();
        private static List<string> gameName = new List<string>();
        private static string gameFilePath = "gameProcesses.txt";
        #endregion

        #region Properties
        public static List<string> GameProcesses
        {
            get
            {
                return gameProcesses;
            }
            set
            {
                gameProcesses = value;
            }
        }

        public static List<string> GameName
        {
            get
            {
                return gameName;
            }
            set
            {
                gameName = value;
            }
        }

        #endregion

        public static List<string> LoadGameList()
        {
            try
            {
                /*
				 * Create stream reader and read the whole file, line by line, adding each line to game list.
				 */
                StreamReader sr = new StreamReader(gameFilePath);
                string line = "";

                //Read each line and take the process name / game name seperated by commas

                while ((line = sr.ReadLine()) != null)
                {
                    string[] csv;
                    csv = line.Split(',');
                    //First item in the line is the process name
                    gameProcesses.Add(csv[0]);
                    //After processName there is a comma then -> game name
                    gameName.Add(csv[1]);
                }
            }

            catch (Exception e)
            {

                Console.WriteLine(e);
                //Need to generate exception window
            }

            return gameProcesses;
        }

        public static string BuildEditGamePanel()
        {
            gameName.Sort();
            var text = "";
            foreach (string g in gameName)
            {
                text += g.ToString() + "\n";
            }
            return text;
        }


        public static void DoesGameExist(string zGameName, string zProcessName)
        {
            if (gameName.IndexOf(zGameName) > -1)
            {
                AddToGamesFile(zGameName, zProcessName);
            }
            else
            {
                MessageBox.Show("Game already exists");
            }
        }

        public static void AddToGamesFile(string zGameName, string zProcessName)
        {

        }

        public static void EditGamesFile(string zGameName, string zProcessName)
        {

        }

        public void DeleteFromGamesFile(string zGameName, string zProcessName)
        {

        }
    }
}
