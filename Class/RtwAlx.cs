using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Jasarsoft.ModManager.RTW
{
    public class RtwAlx
    {
        private const string name = "RomeTW-ALX.exe";
        private const string title = "Rome: Total War™ - Alexander";
        private const string folder = @"alexander\data";

        //default constructor
        public RtwAlx()
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
