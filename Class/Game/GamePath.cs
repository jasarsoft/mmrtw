using System;
using System.Collections.Generic;
using System.Text;

namespace Jasarsoft.ModManager.RTW
{
    public sealed class GamePath
    {
        //field
        private string path;

        //constructor
        public GamePath()
        {
            path = Environment.CurrentDirectory;

            if (path.EndsWith("manager"))
                path = path.Substring(0, path.Length - 7);
            else
                path = @"..\";
        }


        //property
        public string Path
        {
            get { return path; }
        }


        //method
        public bool Valid()
        {
            if (path == @"..\")
                return false;

            return true;
        }
    }
}
