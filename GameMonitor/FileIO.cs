using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMonitor
{
    class FileIO
    {
        private string fpath = " ";


        public string Fpath
        {
            get
            {
                return fpath;
            }
            set
            {
                fpath = value;
            }
        }
        //CheckGameExists()         //See if game is in the the users hours log yet - if not create a new entry
        //StartLogHours             //Start logging time
        //StopLoggingHours          //Stop logging time
    }
}
