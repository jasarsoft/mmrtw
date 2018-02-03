using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Jasarsoft.ModManager.RomeTotalWar
{
    internal sealed class IconTW
    {
        private string iconName;
        private string iconPath;
        
        private readonly int iconWidth;
        private readonly int iconHeight;


        public IconTW(IconType type)
        {
            IconSize size = new IconSize();

            this.iconName = SwitchName(type);
            this.iconPath = String.Format(@"manager\icons\{0}", iconName);
            this.iconWidth = size.Width;
            this.iconHeight = size.Height;
        }


        public bool Valid()
        {
            if (File.Exists(iconPath))
            {
                Image pngImage = Image.FromFile(iconPath);
                if (pngImage.Width == iconWidth && pngImage.Height == iconHeight)
                    if (pngImage.RawFormat.Equals(ImageFormat.Png))
                        return true;
            }

            return false;
        }

        private string SwitchName(IconType type)
        {
            IconName name = new IconName();

            switch (type)
            {
                case IconType.IconTW:
                    return String.Empty;
                case IconType.IconRTW:
                    return name.IconRTW;
                case IconType.IconRTWBI:
                    return name.IconRTWBI;
                case IconType.IconRTWALX:
                    return name.IconRTWALX;
            }

            return String.Empty;
        }
    }
}
