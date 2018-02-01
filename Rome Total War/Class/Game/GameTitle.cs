
namespace Jasarsoft.ModManager.RomeTotalWar
{
    internal sealed class GameTitle
    {
        private readonly string titleRTW;
        private readonly string titleRTWBI;
        private readonly string titleRTWALX;
        
        public GameTitle()
        {
            this.titleRTW = "Rome: Total War™";
            this.titleRTWBI = "Rome: Total War™ - Barbarian Invasion";
            this.titleRTWALX = "Rome: Total War™ - Alexander";
        } 


        public string TitleRTW
        {
            get { return this.titleRTW; }
        }

        public string TitleRTWBI
        {
            get { return this.titleRTWBI; }
        }

        public string TitleRTWALX
        {
            get { return this.titleRTWALX; }
        }
    }
}
