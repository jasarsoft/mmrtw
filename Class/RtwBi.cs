using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Jasarsoft.ModManager.RTW
{
    public class RtwBi
    {
        private const string name = "RomeTW-BI.exe";
        private const string title = "Rome: Total War™ - Barbarian Invasion";
        private const string folder = @"bi\data";

        //default constructor
        public RtwBi()
        {
            //null;
        }


        public string Name
        {
            get { return name; }
        }

        public string Title
        {
            get { return title; }
        }

        public string Folder
        {
            get { return folder; }
        }


        public bool Check()
        {
            Path path = new Path();

            if (path.Check())
            {
                if (File.Exists(path.Game + name) && Directory.Exists(path.Game + folder))
                    return true;
            }

            return false;
        }
    }
}
