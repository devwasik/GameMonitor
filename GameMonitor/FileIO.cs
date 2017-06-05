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
	class FileIO {

		private string fpath = " ";

		public string Fpath {
			get {
				return fpath;
			}
			set {
				fpath = value;
			}
		}
		//CheckGameExists()         //See if game is in the the users hours log yet - if not create a new entry
		//StartLogHours             //Start logging time
		//StopLoggingHours          //Stop logging time
	}
}
