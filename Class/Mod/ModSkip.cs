
namespace Jasarsoft.ModManager.RTW
{
    public sealed class ModSkip
    {
        //field
        private string[] names;

        //constructor
        public ModSkip()
        {
            names = new string[] 
            { 
                "alexander",
                "bi",
                "custom",
                "data",
                "manager",
                "miles",
                "preferences",
                "replays",
                "saves",
                "temp",
                "uninstall"
            };
        }

        //property
        public string[] Names
        {
            get { return names; }
        }
    }
}
