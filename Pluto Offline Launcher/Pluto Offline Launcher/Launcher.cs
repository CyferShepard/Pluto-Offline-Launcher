using System;

using System.Diagnostics;

using System.IO;
using System.Net;
using System.Windows.Forms;
using AutoUpdaterDotNET;


// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Pluto_Offline_Launcher
{
    public partial class Launcher : Form
    {
        //Variables
        string gameloc = "";
        string plutolauncherlink = "https://fastcache.plutonium.pw/r372.zip";
        private static string loc = Path.GetDirectoryName(Application.ExecutablePath) + "\\";



        //methods
        public void create_player_files()
        {
            //---------------------Player Name File-------------------------------
            if (!Directory.Exists(gameloc + "t6r\\player"))
            {
                Directory.CreateDirectory(gameloc + "t6r\\player");
               
            }
            if (!File.Exists(loc + "t6r\\player\\user.name"))
            {
                
                StreamWriter fileout = new StreamWriter(gameloc + "t6r\\player\\user.name");

                fileout.Write("Player");
                fileout.Close();
            }

            //----------------------------------------------------------------------

        }

        public void create_system_files()
        {

            //---------------------Config Files-------------------------------------
            if (!File.Exists(loc + "Config\\path.config"))
            {
                if (!Directory.Exists(loc + "Config"))
                {
                    Directory.CreateDirectory(loc + "Config");
                }
                StreamWriter nFile = new StreamWriter(loc + "Config\\path.config");

                nFile.Write("Locate Game Executable");
                nFile.Close();
            }
            //-----------------------------------------------------------------------

        }


        public void getusername()
        {
                 try
                     {
                        string un = File.ReadAllText(gameloc + "t6r\\player\\user.name");
                        if (!un.Equals(""))
                         {
                           txt_Username.Text = un;
                         }
                        else
                         {
                           MessageBox.Show("Username Not Set.", "Set Username.",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                     }
                 catch
                    {
                        if(!gameloc.Equals("Locate Game Executable"))
                         {
                           create_player_files();
                         }   
                     }
        }

        public void setusername()
        {
           

            try
            {
                if (!txt_Username.Text.Equals(""))
                {
                    File.WriteAllText(gameloc + "t6r\\player\\user.name", txt_Username.Text);
                    MessageBox.Show("Username Saved.", "Success",
   MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Username Cannot Be Blank.", "Enter a Username.",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch
            {
                MessageBox.Show("Username Not Set.", "Error Setting Username.",
   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public bool autolocate()
        {
            bool found = false;
            if (File.Exists(loc+ "t6rmp.exe"))
                {
                lbl_Location.Text = loc;

                found = true;
               
                setpath(loc.Substring(0,loc.Length-1));
            }
            return found;

             

        }




        public void checkgame()
        {
            if (File.Exists(gameloc + "t6rmp.exe"))
            {
                btn_MP.Enabled = true;
            }
            if (File.Exists(gameloc + "t6rzm.exe"))
            {
                btn_ZM.Enabled = true;
            }
          
        }

        public void Get_Latest_Version_Plutonium_Client()
        {
            WebClient client = new WebClient();
            try
            {
                string reply = client.DownloadString("https://raw.githubusercontent.com/CyferShepard/Pluto-Offline-Launcher/master/vcheck/plutoversion.xml");
                if (reply != null)
                {
                    if (!File.Exists(loc + "Config\\plutoversion.xml"))
                    {
                        if (!Directory.Exists(loc + "Config"))
                        {
                            Directory.CreateDirectory(loc + "Config");
                        }
                        StreamWriter nFile = new StreamWriter(loc + "Config\\plutoversion.xml");

                        nFile.Write(reply);
                        nFile.Close();
                    }
                }

            }
            catch
            {

            }
           
           
        }

        public void updatelabel()
        {
            try
            {

                string v = "R372-Default";
                string un = File.ReadAllText(loc + "Config\\plutoversion.xml");

                    string[] xmlconf = un.Split('<','>','=');
                    v = xmlconf[2];
                    plutolauncherlink = xmlconf[5];
                    linkLabel1.Text = "Use with Latest Patch Only ("+v+" - Click to Download)";
            }
            catch
            {
              
            }
         
        }

        public void getpath()
        {
          
            try
            {
                string path = File.ReadAllText(loc + "Config\\path.config");
                if (!path.Equals("Locate Game Executable"))
                {

                    lbl_Location.Text = path;
                    gameloc = path.Replace("\\", "\\\\");
                }
                else
                {
                    lbl_Location.Text = "Locate Game Executable";
                }
            }
            catch
            {
                MessageBox.Show("path.config not found.", "Error: File Not Found.",
MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public void setpath(string fileloc)
        {
            if(!lbl_Location.Text.Equals("Locate Game Executable"))
            {
                File.WriteAllText(loc + "Config\\path.config", fileloc+"\\");
                getpath();
            }
            else
            {
                MessageBox.Show("Game Directory Not Set.", "Locate Game Executable.",
MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
        public bool usernameExists()
        {
            bool e = false;
            string username = txt_Username.Text; ;
            if (!username.Equals("") && !username.Equals(null))
            {
                e = true;
            }
            return e;
        }

        public Launcher()
        {
            InitializeComponent();
            update();
            updatelabel();

            create_system_files();
            if (!autolocate())
            {
                getpath();
            }
            create_player_files();
            Get_Latest_Version_Plutonium_Client();

            getusername();
            checkgame();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  AutoUpdater.DownloadPath = Environment.CurrentDirectory;
         //   AutoUpdater.Start("https://github.com/CyferShepard/Pluto-Offline-Launcher/blob/master/vcheck/updater.xml");
          // MessageBox.Show("Thanks!");
        }
        public void update()
        {
            AutoUpdater.ReportErrors = false;
            AutoUpdater.DownloadPath = Environment.CurrentDirectory;
            AutoUpdater.Start("https://raw.githubusercontent.com/CyferShepard/Pluto-Offline-Launcher/master/vcheck/updater.xml");
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
             
            this.Close();
        }

        private void btn_Locate_Click(object sender, EventArgs e)
        {

            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Locate Game Root Directory";
            fdlg.InitialDirectory = @"c:\Program Files (x86)\";
            fdlg.Filter = "t6rmp.exe|*t6rmp.exe";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string file = fdlg.FileName;
  
                file = file.Substring(0, file.Length - 10);

                lbl_Location.Text = file;
                setpath(file);
               // storepathinmem();
                getusername();
                checkgame();

            }
        }

        private void btn_Setusername_Click(object sender, EventArgs e)
        {

                string un2 = File.ReadAllText(gameloc + "t6r\\player\\user.name");
                setusername();

        }

    
        private void btn_MP_Click(object sender, EventArgs e)
        {
            if(usernameExists())
            {
                Process.Start(gameloc + "t6rmp.exe");
            }
            else
            {
                MessageBox.Show("Username Cannot Be Blank. Set a Username Before Launching the Game.", "Enter a Username.",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_ZM_Click(object sender, EventArgs e)
        {
            if (usernameExists())
            {

                Process.Start(gameloc + "t6rzm.exe");

            }
            else
            {
                MessageBox.Show("Username Cannot Be Blank. Set a Username Before Launching the Game.", "Enter a Username.",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(plutolauncherlink);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/CyferShepard");
        }

        private void Btn_help_Click(object sender, EventArgs e)
        {
            //help h = new help();
            //h.Show();
           // Get_Latest_Version_Plutonium_Client();
        }


    }
}
