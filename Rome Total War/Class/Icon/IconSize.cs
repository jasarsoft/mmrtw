
namespace Jasarsoft.ModManager.RomeTotalWar
{
    internal sealed class IconSize
    {
        private readonly int iconWidth;
        private readonly int iconHeight;


        public IconSize()
        {
            this.iconWidth = 48;
            this.iconHeight = 48;
        }


        public int Width
        {
            get { return this.iconWidth; }
        }

        public int Height
        {
            get { return this.iconHeight; }
        }
    }
}
