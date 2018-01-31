using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;

namespace Jasarsoft.ModManager.RomeTotalWar
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Game.Title gameTitle = new Game.Title();
            //Game.Available gameAvailable = new Game.Available();

            comboGame.Items.Clear();

            //if (gameAvailable.Rtw)
            //{
            //    comboGame.Items.Add(gameTitle.Rtw);
            //}
            //else
            //{
            //    string msgTitle;
            //    string msgText;

            //    msgTitle = "Mod Manager: Rome Total War";
            //    msgText = "Rome Total War game is not in the working directory.";
            //    msgText += Environment.NewLine;
            //    msgText += "Mod Manager is not property installed or set up correctly.";
            //    msgText += Environment.NewLine;
            //    msgText += "Please place the application in the folder where your game.";
            //    MessageBox.Show(msgText, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Close();
            //}

            //if (gameAvailable.RtwBi)
            //{
            //    comboGame.Items.Add(gameTitle.RtwBi);
            //}
            //if (gameAvailable.RtwAlx)
            //{
            //    comboGame.Items.Add(gameTitle.RtwAlx);
            //}

            //Options.Default options = new Options.Default();
            //checkListOptions.Items.Clear();
            //foreach (string data in options.Name)
            //{
            //    checkListOptions.Items.Add(data);
            //}






            //test;
            Mod mod = new Mod();
            foreach (string modName in mod.Name)
                comboMod.Items.Add(modName);

            GameRTW game = new GameRTW();
            foreach (string gameName in game.NameList)
                comboGame.Items.Add(gameName);










            //Properties.Settings.Default.Game = "2";
            //Properties.Settings.Default.Save();
            //Properties.Settings.Default.Upgrade();






            //Settings.Options section = ConfigurationManager.GetSection("example") as Settings.Options;
            //if (section != null)
            //{
            //    MessageBox.Show(section.Title00);
            //}




            //XmlFile xml = new XmlFile();
            //xml.WriteTest();
            //xml.ReadTest();

            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);


            Options opt = new Options();
            for (int i = 0; i < opt.Number; i++)
            {
                checkListOptions.Items.Add(opt.Name[i]);
                if (opt.State[i])
                    checkListOptions.SetItemCheckState(i, CheckState.Checked);
            }


            mod.ReadInfo("eb2");
            //richTextModInfo.Clear();
            //foreach (string line in info.Text)
            //{
            //    richTextModInfo.Text += line + "\n";
            //}






            //GameAvaliable gameAvaliable;
            //gameAvaliable = new GameAvaliable();
            //if (gameAvaliable.RTW)
            //    ;
        }

        private void comboGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            IconCheck icon = new IconCheck();
            
            if (comboGame.SelectedIndex == 0 && icon.CheckRTW())
                buttonPlay.Image = Image.FromFile(icon.IconRTW);
            if (comboGame.SelectedIndex == 1 && icon.CheckRTWBI())
                buttonPlay.Image = Image.FromFile(icon.IconRTWBI);
            if (comboGame.SelectedIndex == 2 && icon.CheckRTWALX())
                buttonPlay.Image = Image.FromFile(icon.IconRTWALX);

            string path = System.IO.Directory.GetCurrentDirectory();
            DirectoryInfo info = Directory.GetParent(path);
            
            

            MessageBox.Show(info.FullName);
        }

        
        
        
    }
}
