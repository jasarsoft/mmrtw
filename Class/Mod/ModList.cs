using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Jasarsoft.ModManager.RTW
{
    class ModList
    {
        private List<string> list;

        //constructor
        public ModList()
        {
            list = new List<string>();
        }


        public List<string> List
        {
            get { return list; }
        }


        //method
        public void Read()
        {
            string[] dirs = Directory.GetDirectories(@"..\");

            //rtw
            list.Clear();
            ListAdd(dirs);

            //bi
            if (Directory.Exists(@"..\bi"))
            {
                dirs = Directory.GetDirectories(@"..\bi");
                ListAdd(dirs);
            }
            
            //alx
            if (Directory.Exists(@"..\alexander"))
            {
                dirs = Directory.GetDirectories(@"..\alexander");
                ListAdd(dirs);
            }
        }

        private void ListAdd(string[] dirs)
        {
            bool value = false;
            ModSkip skip = new ModSkip();

            foreach (string dir in dirs)
            {
                value = false;
                DirectoryInfo info = new DirectoryInfo(dir);

                foreach (string name in skip.Names)
                {
                    if (name == info.Name.ToLower())
                    {
                        value = true;
                        break;
                    }
                }

                if (!value && Directory.Exists(dir + @"\data"))
                {
                    list.Add(info.Name);
                }
            }
        }
    }
}
