using System;
using System.Collections.Generic;
using System.Text;

namespace Jasarsoft.ModManager.RTW
{
    public sealed class OptionHeader
    {
        //field
        private string[] comment;


        //constructor
        public OptionHeader()
        {
            comment = new string[]
            {
                "Mod Manager: Rome Total War | User Options XML File",
                "Please read the instructions to modify this file in the help."
            };
        }


        //property
        public string[] Comment
        {
            get { return comment; }
        }
    }
}
