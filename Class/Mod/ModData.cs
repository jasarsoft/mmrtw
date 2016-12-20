
namespace Jasarsoft.ModManager.RTW
{
    public sealed class ModData
    {
        private struct Data
        {
            public const string info = "modinfo";
            public const string title = "title";
            public const string author = "author";
            public const string version = "version";
            public const string platform = "platform";
            public const string platformVer = "platformver";
            public const string folder = "folder";
            public const string folderName = "foldername";
            public const string map = "map";
            public const string era = "era";
            public const string type = "type";
            public const string compaign = "compaign";
            public const string website = "website";
            public const string twcWiki = "twcwiki";
            public const string twcForum = "twcforum";
        }

        //property
        public string Info
        {
            get { return Data.info; }
        }

        public string Title
        {
            get { return Data.title; }
        }

        public string Author
        {
            get { return Data.author; }
        }

        public string Version
        {
            get { return Data.version; }
        }

        public string Platform
        {
            get { return Data.platform; }
        }

        public string PlatformVer
        {
            get { return Data.platformVer; }
        }

        public string Folder
        {
            get { return Data.folder; }
        }

        public string FolderName
        {
            get { return Data.folderName; }
        }

        public string Map
        {
            get { return Data.map; }
        }

        public string Era
        {
            get { return Data.era; }
        }

        public string Type
        {
            get { return Data.type; }
        }

        public string Compaign
        {
            get { return Data.compaign; }
        }

        public string Website
        {
            get { return Data.website; }
        }

        public string TwcWiki
        {
            get { return Data.twcWiki; }
        }
        
        public string TwcForum
        {
            get { return Data.twcForum; }
        }
    }
}
