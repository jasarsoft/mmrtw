using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Jasarsoft.ModManager.RomeTotalWar
{
    internal class IconRTW
    {
        private const string iconPath = @"manager\icons\";

        private struct IconName
        {
            public const string pngRTW = "rtw.png";
            public const string pngRTWBI = "rtwbi.png";
            public const string pngRTWALX = "rtwalx.png";
        }

        private struct IconSize
        {
            public const int pngWidth = 48;
            public const int pngHeight = 48;
        }


        public string NameRTW
        {
            get { return iconPath + IconName.pngRTW; }
        }

        public string NameRTWBI
        {
            get { return iconPath + IconName.pngRTWBI; }
        }

        public string NameRTWALX
        {
            get { return iconPath + IconName.pngRTWALX; }
        }



        private bool Check(string fileName)
        {
            if(File.Exists(fileName))
            {
                Image pngImage = Image.FromFile(fileName);
                if (pngImage.Width == IconSize.pngWidth && pngImage.Height == IconSize.pngHeight)
                    if (pngImage.RawFormat.Equals(ImageFormat.Png))
                        return true;
            }

            return false;
        }

        public bool CheckRTW()
        {
            return this.Check(iconPath + IconName.pngRTW);
        }

        public bool CheckRTWBI()
        {
            return this.Check(iconPath + IconName.pngRTWBI);
        }

        public bool CheckRTWALX()
        {
            return this.Check(iconPath + IconName.pngRTWALX);
        }
    }
}
