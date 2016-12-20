using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Text;

namespace Jasarsoft.ModManager.RTW
{
    class ModInfo
    {
        //fields
        private Info info;
    
        private struct Info
        {
            public string title;
            public string author;
            public string version;
            public string platform;
            public string platformVer;
            public string folder;
            public string folderName;
            public string map;
            public string era;
            public string type;
            public string compaign;
            public string website;
            public string twcWiki;
            public string twcForum;
        }


        //constructor
        public ModInfo()
        {
            info.title = null;
            info.author = null;
            info.version = null;
            info.platform = null;
            info.platformVer = null;
            info.folder = null;
            info.folderName = null;
            info.map = null;
            info.era = null;
            info.type = null;
            info.compaign = null;
            info.website = null;
            info.twcWiki = null;
            info.twcForum = null;
        }

        //properties
        public string Title
        {
            get { return info.title; }
        }

        public string Author
        {
            get { return info.author; }
        }

        public string Version
        {
            get { return info.version; }
        }

        public string Platform
        {
            get { return info.platform; }
        }

        public string PlatformVer
        {
            get { return info.platformVer; }
        }

        public string Folder
        {
            get { return info.folder; }
        }

        public string FolderName
        {
            get { return info.folderName; }
        }

        public string Map
        {
            get { return info.map; }
        }

        public string Era
        {
            get { return info.era; }
        }

        public string Type
        {
            get { return info.type; }
        }

        public string Compaign
        {
            get { return info.compaign; }
        }

        public string Website
        {
            get { return info.website; }
        }

        public string TwcWiki
        {
            get { return info.twcWiki; }
        }

        public string TwcForum
        {
            get { return info.twcForum; }
        }

        
        //methods
        public bool Read(string modName)
        {
            ModPath path = new ModPath();
            modName = path.Path + modName + ".xml";

            if(File.Exists(modName))
            {
                ModData data = new ModData();

                using (XmlReader xr = XmlReader.Create(modName))
                {
                    if (xr.IsStartElement(data.Info))
                    {
                        try
                        {
                            while (xr.Read())
                            {
                                if (xr.NodeType == XmlNodeType.Element)
                                {
                                    if (xr.Name == data.Title)                      //Title
                                        info.title = xr.ReadElementString();
                                    else if (xr.Name == data.Author)                //Author
                                        info.author = xr.ReadElementString();
                                    else if (xr.Name == data.Version)               //Version
                                        info.version = xr.ReadElementString();
                                    else if (xr.Name == data.Platform)              //Platform
                                        info.platform = xr.ReadElementString();
                                    else if (xr.Name == data.PlatformVer)           //Platform Version
                                        info.platformVer = xr.ReadElementString();
                                    else if (xr.Name == data.Folder)                //Folder
                                        info.folder = xr.ReadElementString();
                                    else if (xr.Name == data.FolderName)            //Folder Name
                                        info.folderName = xr.ReadElementString();   
                                    else if (xr.Name == data.Map)                   //Map
                                        info.map = xr.ReadElementString();
                                    else if (xr.Name == data.Era)                   //Era
                                        info.era = xr.ReadElementString();
                                    else if (xr.Name == data.Type)                  //Type
                                        info.type = xr.ReadElementString();
                                    else if (xr.Name == data.Compaign)              //Compaign
                                        info.compaign = xr.ReadElementString();
                                    else if (xr.Name == data.Website)               //Website
                                        info.website = xr.ReadElementString();
                                    else if (xr.Name == data.TwcWiki)               //TWC Wiki
                                        info.twcWiki = xr.ReadElementString();
                                    else if (xr.Name == data.TwcForum)              //TWC Forum
                                        info.twcForum = xr.ReadElementString();
                                }
                            }
                            //successfull read
                            return true;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                }
            }

            return false;
        }


    }
}
