using System;
using System.Collections.Generic;
using System.Text;

namespace Jasarsoft.ModManager.RTW
{
    public sealed class ModPath
    {
        //field
        private string path;

        //constructor
        public ModPath()
        {
            path = Environment.CurrentDirectory + @"\mods\";
        }

        //property
        public string Path
        {
            get { return path; }
        }
    }
}
