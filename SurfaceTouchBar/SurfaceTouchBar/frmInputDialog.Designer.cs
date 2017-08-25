namespace SurfaceTouchBar
{
    partial class frmInputDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInputDialog));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.tbName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bAbbrechen = new System.Windows.Forms.Button();
            this.bErstellen = new System.Windows.Forms.Button();
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
            this.bunifuImageButton1.Location = new System.Drawing.Point(740, 23);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(70, 67);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // HeaderBar
            // 
            this.HeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HeaderBar.Controls.Add(this.bunifuImageButton1);
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(830, 113);
            this.HeaderBar.TabIndex = 3;
            this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
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
            this.tbName.Location = new System.Drawing.Point(8, 156);
            this.tbName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(812, 85);
            this.tbName.TabIndex = 5;
            this.tbName.Text = "Name";
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bAbbrechen
            // 
            this.bAbbrechen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAbbrechen.ForeColor = System.Drawing.Color.White;
            this.bAbbrechen.Location = new System.Drawing.Point(564, 317);
            this.bAbbrechen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bAbbrechen.Name = "bAbbrechen";
            this.bAbbrechen.Size = new System.Drawing.Size(246, 75);
            this.bAbbrechen.TabIndex = 6;
            this.bAbbrechen.Text = "Abbrechen";
            this.bAbbrechen.UseVisualStyleBackColor = true;
            this.bAbbrechen.Click += new System.EventHandler(this.bAbbrechen_Click);
            // 
            // bErstellen
            // 
            this.bErstellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bErstellen.ForeColor = System.Drawing.Color.White;
            this.bErstellen.Location = new System.Drawing.Point(306, 317);
            this.bErstellen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bErstellen.Name = "bErstellen";
            this.bErstellen.Size = new System.Drawing.Size(246, 75);
            this.bErstellen.TabIndex = 7;
            this.bErstellen.Text = "Erstellen";
            this.bErstellen.UseVisualStyleBackColor = true;
            this.bErstellen.Click += new System.EventHandler(this.bErstellen_Click);
            // 
            // frmInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(830, 433);
            this.Controls.Add(this.bErstellen);
            this.Controls.Add(this.bAbbrechen);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.HeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInputDialog";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.HeaderBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel HeaderBar;
        public Bunifu.Framework.UI.BunifuMaterialTextbox tbName;
        public System.Windows.Forms.Button bAbbrechen;
        public System.Windows.Forms.Button bErstellen;
    }
}