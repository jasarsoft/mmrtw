
namespace Jasarsoft.ModManager.RTW
{
    public sealed class ModSkip
    {
        string[] names;

        //constructor
        public ModSkip()
        {
            names = new string[] 
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

        //property
        public string[] Names
        {
            get { return names; }
        }
    }
}
