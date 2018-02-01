
namespace Jasarsoft.ModManager.RomeTotalWar
{
    internal sealed class GameName
    {
        private readonly string nameRTW;
        private readonly string nameRTWBI;
        private readonly string nameRTWALX;

        public GameName()
        {
            this.nameRTW = "RomeTW.exe";
            this.nameRTWBI = "RomeTW-BI.exe";
            this.nameRTWALX = "RomeTW-ALX.exe";
        }


        public string NameRTW
        {
            get { return this.nameRTW; }
        }

        public string NameRTWBI
        {
            get { return this.nameRTWBI; }
        }

        public string NameRTWALX
        {
            get { return this.nameRTWALX; }
        }
    }
}
