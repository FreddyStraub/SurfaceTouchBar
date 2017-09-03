namespace SurfaceTouchBar
{
    partial class Einstellungen
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Einstellungen));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.lbEinstellungen = new System.Windows.Forms.Label();
            this.listProfile = new System.Windows.Forms.ListBox();
            this.cmsProfile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.neuesProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbProfile = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProfiles = new System.Windows.Forms.Panel();
            this.bLöschen = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bNeu = new System.Windows.Forms.Button();
            this.holdTimer = new System.Windows.Forms.Timer(this.components);
            this.bProfile = new System.Windows.Forms.Button();
            this.bInfos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.HeaderBar.SuspendLayout();
            this.cmsProfile.SuspendLayout();
            this.panelProfiles.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(370, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // HeaderBar
            // 
            this.HeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HeaderBar.Controls.Add(this.lbEinstellungen);
            this.HeaderBar.Controls.Add(this.bunifuImageButton1);
            this.bunifuTransition1.SetDecoration(this.HeaderBar, BunifuAnimatorNS.DecorationType.None);
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(918, 59);
            this.HeaderBar.TabIndex = 2;
            this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // lbEinstellungen
            // 
            this.lbEinstellungen.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbEinstellungen, BunifuAnimatorNS.DecorationType.None);
            this.lbEinstellungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEinstellungen.ForeColor = System.Drawing.Color.White;
            this.lbEinstellungen.Location = new System.Drawing.Point(12, 21);
            this.lbEinstellungen.Name = "lbEinstellungen";
            this.lbEinstellungen.Size = new System.Drawing.Size(105, 20);
            this.lbEinstellungen.TabIndex = 2;
            this.lbEinstellungen.Text = "Einstellungen";
            this.lbEinstellungen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.lbEinstellungen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // listProfile
            // 
            this.listProfile.BackColor = System.Drawing.Color.Black;
            this.listProfile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listProfile.ContextMenuStrip = this.cmsProfile;
            this.bunifuTransition1.SetDecoration(this.listProfile, BunifuAnimatorNS.DecorationType.None);
            this.listProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProfile.ForeColor = System.Drawing.Color.White;
            this.listProfile.FormattingEnabled = true;
            this.listProfile.ItemHeight = 20;
            this.listProfile.Location = new System.Drawing.Point(3, 46);
            this.listProfile.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.listProfile.Name = "listProfile";
            this.listProfile.Size = new System.Drawing.Size(393, 320);
            this.listProfile.TabIndex = 3;
            this.listProfile.SelectedIndexChanged += new System.EventHandler(this.listProfile_SelectedIndexChanged);
            // 
            // cmsProfile
            // 
            this.cmsProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bunifuTransition1.SetDecoration(this.cmsProfile, BunifuAnimatorNS.DecorationType.None);
            this.cmsProfile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsProfile.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesProfilToolStripMenuItem,
            this.profilBearbeitenToolStripMenuItem,
            this.profilLöschenToolStripMenuItem});
            this.cmsProfile.Name = "cmsProfile";
            this.cmsProfile.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsProfile.Size = new System.Drawing.Size(255, 106);
            // 
            // neuesProfilToolStripMenuItem
            // 
            this.neuesProfilToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.neuesProfilToolStripMenuItem.Name = "neuesProfilToolStripMenuItem";
            this.neuesProfilToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.neuesProfilToolStripMenuItem.Text = "Neues Profil...";
            this.neuesProfilToolStripMenuItem.Click += new System.EventHandler(this.neuesProfilToolStripMenuItem_Click);
            // 
            // profilBearbeitenToolStripMenuItem
            // 
            this.profilBearbeitenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.profilBearbeitenToolStripMenuItem.Name = "profilBearbeitenToolStripMenuItem";
            this.profilBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.profilBearbeitenToolStripMenuItem.Text = "Profil bearbeiten...";
            this.profilBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.profilBearbeitenToolStripMenuItem_Click);
            // 
            // profilLöschenToolStripMenuItem
            // 
            this.profilLöschenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.profilLöschenToolStripMenuItem.Name = "profilLöschenToolStripMenuItem";
            this.profilLöschenToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.profilLöschenToolStripMenuItem.Text = "Profil löschen";
            this.profilLöschenToolStripMenuItem.Click += new System.EventHandler(this.profilLöschenToolStripMenuItem_Click);
            // 
            // lbProfile
            // 
            this.lbProfile.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbProfile, BunifuAnimatorNS.DecorationType.None);
            this.lbProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfile.ForeColor = System.Drawing.Color.White;
            this.lbProfile.Location = new System.Drawing.Point(3, 12);
            this.lbProfile.Name = "lbProfile";
            this.lbProfile.Size = new System.Drawing.Size(57, 20);
            this.lbProfile.TabIndex = 3;
            this.lbProfile.Text = "Profile:";
            // 
            // bClose
            // 
            this.bunifuTransition1.SetDecoration(this.bClose, BunifuAnimatorNS.DecorationType.None);
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.ForeColor = System.Drawing.Color.White;
            this.bClose.Location = new System.Drawing.Point(218, 452);
            this.bClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(181, 53);
            this.bClose.TabIndex = 4;
            this.bClose.Text = "Programm beenden";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 381);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Copyright ©  2017 - Wolf066LP";
            // 
            // panelProfiles
            // 
            this.panelProfiles.Controls.Add(this.bLöschen);
            this.panelProfiles.Controls.Add(this.bEdit);
            this.panelProfiles.Controls.Add(this.bNeu);
            this.panelProfiles.Controls.Add(this.lbProfile);
            this.panelProfiles.Controls.Add(this.listProfile);
            this.panelProfiles.Controls.Add(this.bClose);
            this.bunifuTransition1.SetDecoration(this.panelProfiles, BunifuAnimatorNS.DecorationType.None);
            this.panelProfiles.Location = new System.Drawing.Point(6, 115);
            this.panelProfiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelProfiles.Name = "panelProfiles";
            this.panelProfiles.Size = new System.Drawing.Size(408, 562);
            this.panelProfiles.TabIndex = 6;
            // 
            // bLöschen
            // 
            this.bunifuTransition1.SetDecoration(this.bLöschen, BunifuAnimatorNS.DecorationType.None);
            this.bLöschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLöschen.ForeColor = System.Drawing.Color.White;
            this.bLöschen.Location = new System.Drawing.Point(271, 381);
            this.bLöschen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bLöschen.Name = "bLöschen";
            this.bLöschen.Size = new System.Drawing.Size(125, 53);
            this.bLöschen.TabIndex = 7;
            this.bLöschen.Text = "Löschen";
            this.bLöschen.UseVisualStyleBackColor = true;
            this.bLöschen.Click += new System.EventHandler(this.bLöschen_Click);
            // 
            // bEdit
            // 
            this.bunifuTransition1.SetDecoration(this.bEdit, BunifuAnimatorNS.DecorationType.None);
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEdit.ForeColor = System.Drawing.Color.White;
            this.bEdit.Location = new System.Drawing.Point(138, 381);
            this.bEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(125, 53);
            this.bEdit.TabIndex = 6;
            this.bEdit.Text = "Bearbeiten...";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bNeu
            // 
            this.bunifuTransition1.SetDecoration(this.bNeu, BunifuAnimatorNS.DecorationType.None);
            this.bNeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNeu.ForeColor = System.Drawing.Color.White;
            this.bNeu.Location = new System.Drawing.Point(3, 381);
            this.bNeu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bNeu.Name = "bNeu";
            this.bNeu.Size = new System.Drawing.Size(125, 53);
            this.bNeu.TabIndex = 5;
            this.bNeu.Text = "Neu...";
            this.bNeu.UseVisualStyleBackColor = true;
            this.bNeu.Click += new System.EventHandler(this.bNeu_Click);
            // 
            // holdTimer
            // 
            this.holdTimer.Interval = 10;
            // 
            // bProfile
            // 
            this.bunifuTransition1.SetDecoration(this.bProfile, BunifuAnimatorNS.DecorationType.None);
            this.bProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProfile.ForeColor = System.Drawing.Color.White;
            this.bProfile.Location = new System.Drawing.Point(0, 63);
            this.bProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bProfile.Name = "bProfile";
            this.bProfile.Size = new System.Drawing.Size(125, 43);
            this.bProfile.TabIndex = 8;
            this.bProfile.Text = "Profile";
            this.bProfile.UseVisualStyleBackColor = true;
            this.bProfile.Click += new System.EventHandler(this.bProfile_Click);
            // 
            // bInfos
            // 
            this.bunifuTransition1.SetDecoration(this.bInfos, BunifuAnimatorNS.DecorationType.None);
            this.bInfos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInfos.ForeColor = System.Drawing.Color.White;
            this.bInfos.Location = new System.Drawing.Point(125, 63);
            this.bInfos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bInfos.Name = "bInfos";
            this.bInfos.Size = new System.Drawing.Size(125, 43);
            this.bInfos.TabIndex = 9;
            this.bInfos.Text = "Infos";
            this.bInfos.UseVisualStyleBackColor = true;
            this.bInfos.Click += new System.EventHandler(this.bInfos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(458, 116);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 562);
            this.panel1.TabIndex = 10;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.linkLabel3, BunifuAnimatorNS.DecorationType.None);
            this.linkLabel3.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(99, 320);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(37, 20);
            this.linkLabel3.TabIndex = 13;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Hier";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.linkLabel2, BunifuAnimatorNS.DecorationType.None);
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(99, 289);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(294, 20);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "http://wolf066lp.de/tools/surfacetouchbar/";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.linkLabel1, BunifuAnimatorNS.DecorationType.None);
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(99, 257);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 21);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Wolf066LP";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "SurfaceTouchBar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Spenden:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Website:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Entwickler:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Infos:";
            // 
            // button4
            // 
            this.bunifuTransition1.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(218, 452);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 53);
            this.button4.TabIndex = 4;
            this.button4.Text = "Programm beenden";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Version:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(99, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "V1.0";
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(918, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bInfos);
            this.Controls.Add(this.bProfile);
            this.Controls.Add(this.panelProfiles);
            this.Controls.Add(this.HeaderBar);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Einstellungen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.Einstellungen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.HeaderBar.ResumeLayout(false);
            this.HeaderBar.PerformLayout();
            this.cmsProfile.ResumeLayout(false);
            this.panelProfiles.ResumeLayout(false);
            this.panelProfiles.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel HeaderBar;
        private System.Windows.Forms.Label lbEinstellungen;
        private System.Windows.Forms.ListBox listProfile;
        private System.Windows.Forms.Label lbProfile;
        private System.Windows.Forms.ContextMenuStrip cmsProfile;
        private System.Windows.Forms.ToolStripMenuItem neuesProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilLöschenToolStripMenuItem;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelProfiles;
        private System.Windows.Forms.Timer holdTimer;
        private System.Windows.Forms.Button bLöschen;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bNeu;
        private System.Windows.Forms.Button bProfile;
        private System.Windows.Forms.Button bInfos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}