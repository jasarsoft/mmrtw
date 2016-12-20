using System;
using System.Collections.Generic;
using System.Text;

namespace Jasarsoft.ModManager.RTW
{
    public sealed class OptionDefault
    {
        //fields
        private int number;
        private string[] name;
        private string[] info;
        private string[] param;
        private bool[] state;


        //constructor
        public OptionDefault()
        {
            number = 11;

            name = new string[number];
            info = new string[number];
            param = new string[number];
            state = new bool[number];


            //The following text is taken from the web address: http://rtw.heavengames.com/rtw/mods/tutorials/command_line/index.shtml
            //RTW Command Line Switche By SubRosa (subrosa_florens@comcast.net) & Primo (marcus@frontier27.com)
            //Copyright © 1997–2016 HeavenGames LLC. All Rights Reserved.
            
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


        //properties
        public int Number
        {
            get { return number; }
        }

        public string[] Name
        {
            get { return name; }
        }

        public string[] Info
        {
            get { return info; }
        }

        public string[] Param
        {
            get { return param; }
        }

        public bool[] State
        {
            get { return state; }
        }
    }
}
