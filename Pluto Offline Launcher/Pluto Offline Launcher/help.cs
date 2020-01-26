using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Pluto_Offline_Launcher
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
            getip();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getip()
        {
            
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST

            // Get the IP
            string myIP = Dns.GetHostEntry(hostName).AddressList[2].ToString();
            txtip.Text = myIP;
        }

    }
}
