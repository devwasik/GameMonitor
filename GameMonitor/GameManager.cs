using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using HtmlAgilityPack;


namespace GameMonitor
{
    class GameManager
    {
        #region Objects
        private static List<string> gameProcesses = new List<string>();
        private static List<string> gameName = new List<string>();
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
            var html = @"http://devwasik.net/gamelist.php/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);

            //Build array of nodes and find gamename nodes with xpath
            HtmlNode[] gameNodes = htmlDoc.DocumentNode.SelectNodes("//td[@id='gamename']").ToArray();

            //Iterate the node array and add each item to game list
            foreach (HtmlNode gnode in gameNodes)
            {
                gameName.Add(gnode.InnerText);
            }

            HtmlNode[] processNodes = htmlDoc.DocumentNode.SelectNodes("//td[@id='processname']").ToArray();

            foreach (HtmlNode pnode in processNodes)
            {
                gameProcesses.Add(pnode.InnerText);
            }

            return gameName;
            


        }

     
    }
}