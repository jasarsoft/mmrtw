using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Jasarsoft.ModManager.RTW
{
    public sealed class OptionPath
    {
        //field
        private string path;


        //constructor
        public OptionPath()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            path += @"\Jasarsoft\Mod Manager\Rome Total War\";
        }

        //property
        public string Path
        {
            get { return path; }
        }


        //methods
        public bool Create()
        {
            if (Directory.Exists(path))
                return true;
            else
            {
                try
                {
                    Directory.CreateDirectory(path);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool Valid()
        {
            if (Directory.Exists(path))
                return true;
            else
                return false;
        }
    }
}
