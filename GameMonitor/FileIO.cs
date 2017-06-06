using System.IO;

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

namespace GameMonitor {

	/// <summary>
	/// File IO management helper class. Contains the info necessary to perform file operations.
	/// </summary>
	class FileIO
    {

        public void LoadUserFile(string fpath)
        {
            User user = new User();
            StreamReader sr = new StreamReader(fpath);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                user.Games.Add(line);       //Games will only show up in the users log if they have played it before. Therefor, all games will have hours > 0
                user.Hours.Add(line);       //Game hours will be entered after the games line
            }
        }

        //CheckGameExists()         //See if game is in the the users hours log yet - if not create a new entry
        //StartLoggingHours             //Start logging time
        //StopLoggingHours          //Stop logging time
    }
}
