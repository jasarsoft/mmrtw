using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace Jasarsoft.ModManager.RTW
{
    public class Options
    {
        private int number;
        private string path;

        private bool[] state;
        private string[] name;
        private string[] info;
        private string[] param;
        
        private struct Data
        {
            public const string SLASH = @"\";
            public const string NAME = "name";
            public const string INFO = "info";
            public const string PARAM = "param";
            public const string STATE = "state";
            public const string NUMBER = "number";
            public const string OPTIONS = "options";
            public const string FILENAME = "options.xml";
        }

   

        //default constructor
        public Options()
        {
            number = 0;
            path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Jasarsoft\Mod Manager\Rome Total War";
        }


        //property
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Path
        {
            get { return path; }
        }

        public string FileName
        {
            get { return Data.FILENAME; }
        }

        public string[] Name
        {
            get { return name; }
            set { name = value; }
        }
        public string[] Info
        {
            get { return info; }
            set { info = value; }
        }
        public string[] Param
        {
            get { return param; }
            set { param = value; }
        }
        public bool[] State
        {
            get { return state; }
            set { state = value; }
        }
        

        public bool Check()
        {
            if (File.Exists(path + Data.SLASH + Data.FILENAME))
                return true;
            else
                return false;
        }

        public bool Read()
        {
            using (XmlReader xr = XmlReader.Create(path + Data.SLASH + Data.FILENAME))
            {
                if (!xr.IsStartElement(Data.OPTIONS) || !xr.HasAttributes || !xr.MoveToAttribute(Data.NUMBER)) return false;
                try { number = Int32.Parse(xr.GetAttribute(0)); } catch { return false; }

                name = new string[number];
                info = new string[number];
                param = new string[number];
                state = new bool[number];

                for (int i = 0; i < number; i++)
                {
                    if (!xr.ReadToFollowing(Data.NUMBER + i.ToString())) return false;
                    //name
                    if (xr.ReadToFollowing(Data.NAME)) name[i] = xr.ReadString(); else return false;
                    //info
                    if (xr.ReadToFollowing(Data.INFO)) info[i] = xr.ReadString(); else return false;
                    //param
                    if (xr.ReadToFollowing(Data.PARAM)) param[i] = xr.ReadString(); else return false;
                    //state
                    if (xr.ReadToFollowing(Data.STATE)) try { state[i] = bool.Parse(xr.ReadString()); } catch { return false; } else return false;
                }    
            }
            
            return true;
        }

        public bool Write()
        {
            string[] header = new string[2];
            header[0] = "Mod Manager: Rome Total War | User Options XML File";
            header[1] = "Please read the instructions to modify this file in the readme file.";

            XmlWriterSettings xmlSettings;
            xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;

            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            try
            {
                using (XmlWriter xw = XmlWriter.Create(path + Data.SLASH + Data.FILENAME, xmlSettings))
                {
                    xw.WriteStartDocument();
                    foreach (string comment in header) xw.WriteComment(comment);
                    xw.WriteStartElement(Data.OPTIONS);
                    xw.WriteAttributeString(Data.NUMBER, number.ToString());

                    for (int i = 0; i < number; i++)
                    {
                        xw.WriteStartElement(Data.NUMBER + i.ToString());
                        xw.WriteElementString(Data.NAME, name[i]);
                        xw.WriteElementString(Data.INFO, info[i]);
                        xw.WriteElementString(Data.PARAM, param[i]);
                        xw.WriteElementString(Data.STATE, state[i].ToString());
                        xw.WriteEndElement();
                    }

                    xw.WriteEndElement();
                    xw.WriteEndDocument();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Default()
        {
            number = 11;

            name = new string[number];
            info = new string[number];
            param = new string[number];
            state = new bool[number];

            //number 0
            name[0] = "Show Error Message";
            info[0] = "This tells the game to display an error message when it crashes, making it the most helpful switch there is.";
            param[0] = "show_err";
            state[0] = true;
            //number 1
            name[1] = "No Use Aleaxnder";
            info[1] = "Runs the mod with alexander expansion but not use alexander data for base.";
            param[1] = "noalexander";
            state[1] = false;
            //number 2
            name[2] = "Disable Intro Movie";
            info[2] = "This stands for No Movies. As the name implies it disables the videos in the game. From the intro movies to the background menu video. This switch can decrease load times significantly.";
            param[2] = "nm";
            state[2] = false;
            //number 3
            name[3] = "Disable All Video";
            info[3] = "Runs the game with no video at all, only sounds.";
            param[3] = "sw";
            state[3] = false;
            //number 4
            name[4] = "Disable All Audio";
            info[4] = "Disables the audio.";
            param[4] = "na";
            state[4] = false;
            //number 5
            name[5] = "Enable Window Mode";
            info[5] = "This runs the game in Windowed Mode rather than Full Screen. It can be handy for people who go back and forth from the game to their desktop.";
            param[5] = "ne";
            state[5] = false;
            //number 6
            name[6] = "Enable Battle Editor";
            info[6] = "This turns on the Historical Battle Editor. To run the Editor, start the game and go to Options, then Battle Editor.";
            param[6] = "enable_editor";
            state[6] = false;
            //number 7
            name[7] = "Enable Movie Camera";
            info[7] = "This command line lets you use the movie cam, often used for getting screenshots at exclusive angles, generally below head height. Once added, play a custom battle, save the replay, then watch the replay. You should now be watching it with a lot of blue text on the screen.";
            param[7] = "movie_cam";
            state[7] = false;
            //number 8
            name[8] = "AI Control Factions";
            info[8] = "When you start a campaign, this switch gives the AI control over all factions. This allows you to watch how all the factions progress without human intervention.";
            param[8] = "ai";
            state[8] = false;
            //number 9
            name[9] = "Multirun Instance Game";
            info[9] = "This allows you to run more than one instance of the game at a time.";
            param[9] = "multirun";
            state[9] = false;
            //number 10
            name[10] = "Generate Sprite Script";
            info[10] = "This is used to generate sprites. A complete tutorial on how to create sprites can be found HeavenGames.";
            param[10] = "sprite_script";
            state[10] = false;
        }

    }
}
