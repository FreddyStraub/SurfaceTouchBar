namespace SurfaceTouchBar
{
    partial class EditButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditButton));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.lbButtonSettings = new System.Windows.Forms.Label();
            this.tbName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bHotkey = new System.Windows.Forms.Button();
            this.checkStrg = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbStrg = new System.Windows.Forms.Label();
            this.lbAlt = new System.Windows.Forms.Label();
            this.checkAlt = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbShift = new System.Windows.Forms.Label();
            this.checkShift = new Bunifu.Framework.UI.BunifuCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.HeaderBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(384, 12);
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
            this.HeaderBar.Controls.Add(this.lbButtonSettings);
            this.HeaderBar.Controls.Add(this.bunifuImageButton1);
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(431, 59);
            this.HeaderBar.TabIndex = 1;
            this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // lbButtonSettings
            // 
            this.lbButtonSettings.AutoSize = true;
            this.lbButtonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbButtonSettings.ForeColor = System.Drawing.Color.White;
            this.lbButtonSettings.Location = new System.Drawing.Point(12, 22);
            this.lbButtonSettings.Name = "lbButtonSettings";
            this.lbButtonSettings.Size = new System.Drawing.Size(150, 20);
            this.lbButtonSettings.TabIndex = 2;
            this.lbButtonSettings.Text = "Buttoneinstellugen: ";
            this.lbButtonSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.lbButtonSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // tbName
            // 
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.HintForeColor = System.Drawing.Color.Empty;
            this.tbName.HintText = "";
            this.tbName.isPassword = false;
            this.tbName.LineFocusedColor = System.Drawing.Color.White;
            this.tbName.LineIdleColor = System.Drawing.Color.Black;
            this.tbName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbName.LineThickness = 3;
            this.tbName.Location = new System.Drawing.Point(13, 85);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(406, 44);
            this.tbName.TabIndex = 4;
            this.tbName.Text = "Name";
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bHotkey
            // 
            this.bHotkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHotkey.ForeColor = System.Drawing.Color.White;
            this.bHotkey.Location = new System.Drawing.Point(155, 217);
            this.bHotkey.Name = "bHotkey";
            this.bHotkey.Size = new System.Drawing.Size(123, 39);
            this.bHotkey.TabIndex = 5;
            this.bHotkey.Text = "Hotkey";
            this.bHotkey.UseVisualStyleBackColor = true;
            this.bHotkey.Click += new System.EventHandler(this.bHotkey_Click);
            // 
            // checkStrg
            // 
            this.checkStrg.BackColor = System.Drawing.Color.White;
            this.checkStrg.ChechedOffColor = System.Drawing.Color.Black;
            this.checkStrg.Checked = true;
            this.checkStrg.CheckedOnColor = System.Drawing.Color.White;
            this.checkStrg.ForeColor = System.Drawing.Color.Black;
            this.checkStrg.Location = new System.Drawing.Point(67, 163);
            this.checkStrg.Name = "checkStrg";
            this.checkStrg.Size = new System.Drawing.Size(20, 20);
            this.checkStrg.TabIndex = 6;
            // 
            // lbStrg
            // 
            this.lbStrg.AutoSize = true;
            this.lbStrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStrg.ForeColor = System.Drawing.Color.White;
            this.lbStrg.Location = new System.Drawing.Point(93, 163);
            this.lbStrg.Name = "lbStrg";
            this.lbStrg.Size = new System.Drawing.Size(35, 18);
            this.lbStrg.TabIndex = 7;
            this.lbStrg.Text = "Strg";
            // 
            // lbAlt
            // 
            this.lbAlt.AutoSize = true;
            this.lbAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlt.ForeColor = System.Drawing.Color.White;
            this.lbAlt.Location = new System.Drawing.Point(212, 163);
            this.lbAlt.Name = "lbAlt";
            this.lbAlt.Size = new System.Drawing.Size(24, 18);
            this.lbAlt.TabIndex = 9;
            this.lbAlt.Text = "Alt";
            // 
            // checkAlt
            // 
            this.checkAlt.BackColor = System.Drawing.Color.White;
            this.checkAlt.ChechedOffColor = System.Drawing.Color.Black;
            this.checkAlt.Checked = true;
            this.checkAlt.CheckedOnColor = System.Drawing.Color.White;
            this.checkAlt.ForeColor = System.Drawing.Color.Black;
            this.checkAlt.Location = new System.Drawing.Point(186, 163);
            this.checkAlt.Name = "checkAlt";
            this.checkAlt.Size = new System.Drawing.Size(20, 20);
            this.checkAlt.TabIndex = 8;
            // 
            // lbShift
            // 
            this.lbShift.AutoSize = true;
            this.lbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShift.ForeColor = System.Drawing.Color.White;
            this.lbShift.Location = new System.Drawing.Point(310, 163);
            this.lbShift.Name = "lbShift";
            this.lbShift.Size = new System.Drawing.Size(37, 18);
            this.lbShift.TabIndex = 11;
            this.lbShift.Text = "Shift";
            // 
            // checkShift
            // 
            this.checkShift.BackColor = System.Drawing.Color.White;
            this.checkShift.ChechedOffColor = System.Drawing.Color.Black;
            this.checkShift.Checked = true;
            this.checkShift.CheckedOnColor = System.Drawing.Color.White;
            this.checkShift.ForeColor = System.Drawing.Color.Black;
            this.checkShift.Location = new System.Drawing.Point(284, 163);
            this.checkShift.Name = "checkShift";
            this.checkShift.Size = new System.Drawing.Size(20, 20);
            this.checkShift.TabIndex = 10;
            // 
            // EditButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(431, 295);
            this.Controls.Add(this.lbShift);
            this.Controls.Add(this.checkShift);
            this.Controls.Add(this.lbAlt);
            this.Controls.Add(this.checkAlt);
            this.Controls.Add(this.lbStrg);
            this.Controls.Add(this.checkStrg);
            this.Controls.Add(this.bHotkey);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.HeaderBar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "EditButton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditButton";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditButton_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditButton_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.HeaderBar.ResumeLayout(false);
            this.HeaderBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel HeaderBar;
        private System.Windows.Forms.Label lbStrg;
        private System.Windows.Forms.Label lbAlt;
        private System.Windows.Forms.Label lbShift;
        private System.Windows.Forms.Label lbButtonSettings;
        public Bunifu.Framework.UI.BunifuMaterialTextbox tbName;
        public System.Windows.Forms.Button bHotkey;
        public Bunifu.Framework.UI.BunifuCheckbox checkStrg;
        public Bunifu.Framework.UI.BunifuCheckbox checkAlt;
        public Bunifu.Framework.UI.BunifuCheckbox checkShift;
    }
}