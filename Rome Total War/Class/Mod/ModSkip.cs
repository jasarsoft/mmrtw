using System;

namespace Jasarsoft.ModManager.RomeTotalWar
{
    internal sealed class ModSkip
    {
        private string[] modNames;


        public ModSkip()
        {
            modNames = new string[]
            {
                "alexander",
                "bi",
                "data",
                "manager",
                "miles",
                "preferences",
                "saves",
                "temp",
                "uninstall"
            };
        }


        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= modNames.Length)
                    throw new ArgumentOutOfRangeException();

                return modNames[index];
            }
        }
    }
}
