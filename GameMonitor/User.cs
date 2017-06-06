using System.Collections.Generic;

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

	class User {
        private string filePath;
        private List<string> games;
        private List<string> hours;

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
    }
}