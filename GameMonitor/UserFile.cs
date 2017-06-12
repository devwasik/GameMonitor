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

using System.Collections.Generic;
using System.IO;


namespace GameMonitor {

	/// <summary>
	/// File IO management helper class. Contains the info necessary to perform file operations.
	/// </summary>
	class UserFile
    {
        #region Variables

        private string filePath;
        private List<string> games;
        private List<string> hours;

        #endregion

        #region Properties

        public string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
            }
        }


        public List<string> Games
        {
            get
            {
                return games;
            }
            set
            {
                games = value;
            }
        }

        public List<string> Hours
        {
            get
            {
                return hours;
            }
            set
            {
                hours = value;
            }
        }
        #endregion


        public void LoadUserFile(string fpath)
        {
            StreamReader sr = new StreamReader(fpath);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Games.Add(line);       //Games will only show up in the users log if they have played it before. Therefor, all gameProcesses will have hours > 0
                Hours.Add(line);       //Game hours will be entered after the gameProcesses line
            }
        }

        //CheckGameExists()         //See if game is in the the users hours log yet - if not create a new entry
        //StartLoggingHours             //Start logging time
        //StopLoggingHours          //Stop logging time
    }
}
