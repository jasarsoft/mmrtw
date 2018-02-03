
namespace Jasarsoft.ModManager.RomeTotalWar
{
    internal sealed class IconName
    {
        private readonly string iconRTW;
        private readonly string iconRTWBI;
        private readonly string iconRTWALX;


        public IconName()
        {
            this.iconRTW = "rtw.png";
            this.iconRTWBI = "rtwbi.png";
            this.iconRTWALX = "rtwalx.png";
        }


        public string IconRTW
        {
            get { return this.iconRTW; }
        }

        public string IconRTWBI
        {
            get { return this.iconRTWBI; }
        }

        public string IconRTWALX
        {
            get { return this.iconRTWALX; }
        }
    }
}
