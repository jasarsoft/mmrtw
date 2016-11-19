using System;
using System.Collections.Generic;
using System.Text;

namespace Jasarsoft.ModManager.RTW
{
    public class Path
    {
        private string app;
        private string game;
        private string icon;

        //constructor
        public Path()
        {
            Read();
        }


        public string App
        {
            get { return app; }
        }

        public string Game
        {
            get { return game; }
        }

        public string Icon
        {
            get { return icon; }
        }


        public bool Check()
        {
            string path = Environment.CurrentDirectory;

            if (path.EndsWith("manager"))
                return true;
            else
                return false;
        }

        public bool Read()
        {
            string path = Environment.CurrentDirectory;

            if (Check())
            {
                app = path + @"\";
                game = path.Substring(0, path.Length - 7);
                icon = path + @"\icons\";

                return true;
            }
            else
            {
                app = path + @"\";
                game = @"..\";
                icon = app + @"icons\";

                return false;
            }
        }
    }
}
