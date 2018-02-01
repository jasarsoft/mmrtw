using System;
using System.Collections.Generic;
using System.Text;

namespace Jasarsoft.ModManager.RomeTotalWar
{
    internal sealed class GamePath
    {
        private readonly string pathRTW;
        private readonly string pathRTWBI;
        private readonly string pathRTWALX;


        public GamePath()
        {
            this.pathRTW = @"\data";
            this.pathRTWBI = @"\bi\data";
            this.pathRTWALX = @"\alexander\data";
        }


        public string PathRTW
        {
            get { return this.pathRTW; }
        }

        public string PathRTWBI
        {
            get { return this.pathRTWBI; }
        }

        public string PathRTWALX
        {
            get { return this.pathRTWALX; }
        }
    }
}
