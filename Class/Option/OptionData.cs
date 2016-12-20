
namespace Jasarsoft.ModManager.RTW
{
    public sealed class OptionData
    {
        
        private struct Data
        {
            public const string name = "name";
            public const string info = "info";
            public const string param = "param";
            public const string state = "state";
            public const string number = "number";
            public const string options = "options";
        }


        public OptionData()
        {
            //null;
        }

        public string Name
        {
            get { return Data.name; }
        }

        public string Info
        {
            get { return Data.info; }
        }

        public string Param
        {
            get { return Data.param; }
        }

        public string State
        {
            get { return Data.state; }
        }

        public string Number
        {
            get { return Data.number; }
        }

        public string Options
        {
            get { return Data.options; }
        }
    }
}
