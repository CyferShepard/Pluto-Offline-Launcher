using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Pluto_Offline_Launcher
{
    public partial class Form1 : Form
    {
        //Variables
        string gameloc = "";
        private static string loc = Path.GetDirectoryName(Application.ExecutablePath) + "\\";



        //methods


        public string getusernameString()
        {

            getusername();
            return txt_Username.Text;
        }
            public void getusername()
        {
          
            try
            {
           
                string un = File.ReadAllText(gameloc + "\\t6r\\player\\user.name");
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
                    MessageBox.Show("user.name not found in '" + gameloc + "\\t6r\\player'", "Error: File Not Found.",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    
                }
               
            }

        }
        public void setusername()
        {
           

            try
            {
                if (!txt_Username.Text.Equals(""))
                {
                    File.WriteAllText(gameloc + "\\t6r\\player\\user.name", txt_Username.Text);
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

        public void createconfig()
        {
          StreamWriter File = new StreamWriter(loc + "Config\\path.config");

            File.Write("Locate Game Executable");
            File.Close();
        }
        public void firstruncheck()
        {
            try
            {
                string path = File.ReadAllText(loc + "Config\\exists.config");

            }
            catch
            {
                if (!Directory.Exists(loc + "Config"))
                {
                    Directory.CreateDirectory(loc + "Config");
                }
                StreamWriter Filesw = new StreamWriter(loc + "Config\\exists.config");

                Filesw.Write("True");
                Filesw.Close();
                createconfig();

            }
           
        }
        public void createunfile()
        {
            if (!Directory.Exists(gameloc + "\\t6r\\player"))
            {
                Directory.CreateDirectory(gameloc + "\\t6r\\player");
            }
            StreamWriter File = new StreamWriter(gameloc +"\\t6r\\player\\user.name");
            File.Close();
        }




        public void checkgame()
        {
            if(!gameloc.Equals("Locate Game Executable"))
            {
                btn_MP.Enabled = true;
                btn_ZM.Enabled = true;
            }
            else
            {
                btn_MP.Enabled = false;
                btn_ZM.Enabled = false;
            }
        }


        public void storepathinmem()
        {
            string lbl_loc = lbl_Location.Text;
            gameloc = lbl_loc.Replace("\\", "\\\\");
        }

        public void getpath()
        {
          
            try
            {
                string path = File.ReadAllText(loc + "Config\\path.config");
                if (!path.Equals("Locate Game Executable"))
                {

                    lbl_Location.Text = path;
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
                File.WriteAllText(loc + "Config\\path.config", fileloc);
            }
            else
            {
                MessageBox.Show("Game Directory Not Set.", "Locate Game Executable.",
MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        public Form1()
        {
            InitializeComponent();
            firstruncheck();


            getpath();
            storepathinmem();
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
                storepathinmem();
                getusername();
                checkgame();

            }
        }

        private void btn_Setusername_Click(object sender, EventArgs e)
        {
            try
            {
                string un2 = File.ReadAllText(gameloc + "\\t6r\\player\\user.name");
                setusername();
            }
            catch
            {
                createunfile();
                setusername();

            }
           
        }

        public bool usernameExists()
        {
            bool e = false;
            if(!getusernameString().Equals("") && !getusernameString().Equals(null))
            {
                e = true;
            }
            return e;
        }
        private void btn_MP_Click(object sender, EventArgs e)
        {
            if(usernameExists())
            {
                Process.Start(gameloc + "\\t6rmp.exe");
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
                Process.Start(gameloc + "\\t6rzm.exe");
            }
            else
            {
                MessageBox.Show("Username Cannot Be Blank. Set a Username Before Launching the Game.", "Enter a Username.",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://cache.plutonium.pw/r353.zip");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/CyferShepard");
        }
    }
}
