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
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.HeaderBar.SuspendLayout();
            this.cmsProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(417, 59);
            this.HeaderBar.TabIndex = 2;
            this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // lbEinstellungen
            // 
            this.lbEinstellungen.AutoSize = true;
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
            this.listProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProfile.ForeColor = System.Drawing.Color.White;
            this.listProfile.FormattingEnabled = true;
            this.listProfile.ItemHeight = 20;
            this.listProfile.Location = new System.Drawing.Point(12, 123);
            this.listProfile.Margin = new System.Windows.Forms.Padding(7);
            this.listProfile.Name = "listProfile";
            this.listProfile.Size = new System.Drawing.Size(393, 340);
            this.listProfile.TabIndex = 3;
            this.listProfile.SelectedIndexChanged += new System.EventHandler(this.listProfile_SelectedIndexChanged);
            // 
            // cmsProfile
            // 
            this.cmsProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cmsProfile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesProfilToolStripMenuItem,
            this.profilBearbeitenToolStripMenuItem,
            this.profilLöschenToolStripMenuItem});
            this.cmsProfile.Name = "cmsProfile";
            this.cmsProfile.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsProfile.Size = new System.Drawing.Size(255, 128);
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
            this.profilLöschenToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.profilLöschenToolStripMenuItem.Text = "Profil löschen";
            this.profilLöschenToolStripMenuItem.Click += new System.EventHandler(this.profilLöschenToolStripMenuItem_Click);
            // 
            // lbProfile
            // 
            this.lbProfile.AutoSize = true;
            this.lbProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfile.ForeColor = System.Drawing.Color.White;
            this.lbProfile.Location = new System.Drawing.Point(12, 87);
            this.lbProfile.Name = "lbProfile";
            this.lbProfile.Size = new System.Drawing.Size(57, 20);
            this.lbProfile.TabIndex = 3;
            this.lbProfile.Text = "Profile:";
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(417, 474);
            this.Controls.Add(this.lbProfile);
            this.Controls.Add(this.listProfile);
            this.Controls.Add(this.HeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Einstellungen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.Einstellungen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.HeaderBar.ResumeLayout(false);
            this.HeaderBar.PerformLayout();
            this.cmsProfile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}