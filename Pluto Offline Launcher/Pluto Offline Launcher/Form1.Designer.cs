namespace Pluto_Offline_Launcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_Close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.btn_Locate = new System.Windows.Forms.Button();
            this.btn_Setusername = new System.Windows.Forms.Button();
            this.btn_MP = new System.Windows.Forms.Button();
            this.btn_ZM = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.Btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_Close.FlatAppearance.BorderSize = 2;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.Location = new System.Drawing.Point(915, 9);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(32, 32);
            this.Btn_Close.TabIndex = 4;
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.btn_minimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.btn_minimize.FlatAppearance.BorderSize = 2;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.Location = new System.Drawing.Point(877, 9);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(32, 32);
            this.btn_minimize.TabIndex = 5;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Username.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.txt_Username.Location = new System.Drawing.Point(12, 110);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(700, 26);
            this.txt_Username.TabIndex = 6;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Username.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lbl_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.lbl_Username.Location = new System.Drawing.Point(9, 80);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(86, 18);
            this.lbl_Username.TabIndex = 7;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Location.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Location.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.lbl_Location.Location = new System.Drawing.Point(12, 490);
            this.lbl_Location.MaximumSize = new System.Drawing.Size(700, 13);
            this.lbl_Location.MinimumSize = new System.Drawing.Size(700, 26);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lbl_Location.Size = new System.Drawing.Size(700, 26);
            this.lbl_Location.TabIndex = 8;
            this.lbl_Location.Text = "Locate Game Executable";
            // 
            // btn_Locate
            // 
            this.btn_Locate.BackColor = System.Drawing.Color.Black;
            this.btn_Locate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Locate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.btn_Locate.FlatAppearance.BorderSize = 2;
            this.btn_Locate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Locate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Locate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.btn_Locate.Location = new System.Drawing.Point(847, 490);
            this.btn_Locate.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Locate.Name = "btn_Locate";
            this.btn_Locate.Size = new System.Drawing.Size(100, 26);
            this.btn_Locate.TabIndex = 9;
            this.btn_Locate.Text = "Locate Game";
            this.btn_Locate.UseVisualStyleBackColor = false;
            this.btn_Locate.Click += new System.EventHandler(this.btn_Locate_Click);
            // 
            // btn_Setusername
            // 
            this.btn_Setusername.BackColor = System.Drawing.Color.Black;
            this.btn_Setusername.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.btn_Setusername.FlatAppearance.BorderSize = 2;
            this.btn_Setusername.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Setusername.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Setusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.btn_Setusername.Location = new System.Drawing.Point(847, 109);
            this.btn_Setusername.Name = "btn_Setusername";
            this.btn_Setusername.Size = new System.Drawing.Size(100, 26);
            this.btn_Setusername.TabIndex = 11;
            this.btn_Setusername.Text = "Set Username";
            this.btn_Setusername.UseVisualStyleBackColor = false;
            this.btn_Setusername.Click += new System.EventHandler(this.btn_Setusername_Click);
            // 
            // btn_MP
            // 
            this.btn_MP.BackColor = System.Drawing.Color.Gold;
            this.btn_MP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_MP.Enabled = false;
            this.btn_MP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_MP.FlatAppearance.BorderSize = 2;
            this.btn_MP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MP.Image = ((System.Drawing.Image)(resources.GetObject("btn_MP.Image")));
            this.btn_MP.Location = new System.Drawing.Point(12, 191);
            this.btn_MP.Name = "btn_MP";
            this.btn_MP.Size = new System.Drawing.Size(460, 215);
            this.btn_MP.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btn_MP, "Click to Launch Multiplayer");
            this.btn_MP.UseVisualStyleBackColor = false;
            this.btn_MP.Click += new System.EventHandler(this.btn_MP_Click);
            // 
            // btn_ZM
            // 
            this.btn_ZM.BackColor = System.Drawing.Color.Firebrick;
            this.btn_ZM.Enabled = false;
            this.btn_ZM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ZM.FlatAppearance.BorderSize = 2;
            this.btn_ZM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ZM.ForeColor = System.Drawing.Color.Aquamarine;
            this.btn_ZM.Image = ((System.Drawing.Image)(resources.GetObject("btn_ZM.Image")));
            this.btn_ZM.Location = new System.Drawing.Point(487, 191);
            this.btn_ZM.Name = "btn_ZM";
            this.btn_ZM.Size = new System.Drawing.Size(460, 215);
            this.btn_ZM.TabIndex = 13;
            this.toolTip2.SetToolTip(this.btn_ZM, "Click to Launch Zombies Mode");
            this.btn_ZM.UseVisualStyleBackColor = false;
            this.btn_ZM.Click += new System.EventHandler(this.btn_ZM_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Black;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.linkLabel1.Location = new System.Drawing.Point(9, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(298, 15);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Use with Latest Patch Only (r353 - Click to Download)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Black;
            this.linkLabel2.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this.linkLabel2.Location = new System.Drawing.Point(9, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(209, 16);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Created By CyferShepard v1.0.4";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_ZM);
            this.Controls.Add(this.btn_MP);
            this.Controls.Add(this.btn_Setusername);
            this.Controls.Add(this.btn_Locate);
            this.Controls.Add(this.lbl_Location);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.Btn_Close);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Button btn_Locate;
        private System.Windows.Forms.Button btn_Setusername;
        private System.Windows.Forms.Button btn_MP;
        private System.Windows.Forms.Button btn_ZM;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

