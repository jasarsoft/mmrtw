using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace Jasarsoft.ModManager.RomeTotalWar
{
    internal abstract class GameTW
    {
        private string gameName;
        private string gamePath;
        private GameType gameType;
        private string gameTitle;
        private long gameSize;
        private string gameVersion;


        public GameTW()
        {
            //default constructor
        }

        protected string Name
        {
            get { return this.gameName; }
            set { this.gameName = value; }
        }

        protected string Path
        {
            get { return this.gamePath; }
            set { this.gamePath = value; }
        }

        protected GameType Type
        {
            get { return this.gameType; }
            set { this.gameType = value; }
        }

        protected string Title
        {
            get { return this.gameTitle; }
            set { this.gameTitle = value; }
        }

        protected long Size
        {
            get { return this.gameSize; }
            set { this.gameSize = value; }
        }

        protected string Version
        {
            get { return this.gameVersion; }
            set { this.gameVersion = value; }
        }


        protected string GetVersion()
        {
            string path = String.Format(@".\{0}", gameName);

            if (File.Exists(path))
            {
                FileVersionInfo exeInfo = FileVersionInfo.GetVersionInfo(path);
                return exeInfo.ProductVersion.Remove(4).Replace(",", ".").Replace(" ", "");
            }

            return String.Empty;
        }

        protected long GetSize()
        {
            if(Directory.Exists(gamePath))
            {
                long size = 0;
                string[] files = Directory.GetFiles(gamePath, "*.*", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    FileInfo info = new FileInfo(file);
                    size += info.Length;
                }

                return size;
            }

            return 0L;
        }
    }
}
