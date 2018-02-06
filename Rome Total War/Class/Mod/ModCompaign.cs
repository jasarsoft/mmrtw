using System;

namespace Jasarsoft.ModManager.RomeTotalWar
{
    internal sealed class ModCompaign
    {
        private string modName;
        private CompaignType modType;


        public enum CompaignType
        {
            CompaingNo,
            CompaingYes
        };


        public ModCompaign(CompaignType type, string name)
        {
            this.modType = type;
            this.modName = name;
        }

        public string Name
        {
            get { return this.modName; }
        }

        public CompaignType Type
        {
            get { return this.modType; }
        }


        public override string ToString()
        {
            if(this.modType == CompaignType.CompaingNo)
            {
                return String.Format("Yes: {0}", this.modName);
            }
            else
            {
                return String.Format("No: {0}", this.modName);
            }
        }
    }
}
