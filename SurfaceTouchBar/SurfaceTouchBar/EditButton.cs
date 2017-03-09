using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurfaceTouchBar
{
    public partial class EditButton : Form
    {
        
        /// <summary>
        /// Erstellt neue EditButton - Form
        /// </summary>
        /// <param name="buttonSettings">Einstellungen die in der Form angezeigt werden sollen.</param>
        /// <param name="settingsstring">String der im Titel der Form angezeigt wird.</param>
        public EditButton(ButtonSetting buttonSettings, string settingsstring)
        {
            InitializeComponent();

            tbName.Text = buttonSettings.name;

            checkStrg.Checked = buttonSettings.strg;
            checkAlt.Checked = buttonSettings.alt;
            checkShift.Checked = buttonSettings.shift;

            bHotkey.Text = buttonSettings.hotkey.ToString();

            lbButtonSettings.Text += " " + settingsstring;
        }

        #region Move Form

        private Point mouseposition;

        private void HeaderBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseposition.X, mouseposition.Y);
                Location = mousePos;
            }
        }

        private void HeaderBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseposition = new Point(-e.X, -e.Y);
        }

        #endregion


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            
            Close();
        }

        private void bHotkey_Click(object sender, EventArgs e)
        {

            if(bHotkey.Text != "...")
            {
                bHotkey.Text = "...";
            }

        }

        private void EditButton_KeyDown(object sender, KeyEventArgs e)
        {

            if(bHotkey.Text == "...")
            {
                bHotkey.Text = e.KeyCode.ToString();
            }

        }

        private void EditButton_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(bHotkey.Text == "...")
            {
                DialogResult = DialogResult.None;

                MessageBox.Show("Bitte gib einen Hotkey ein!", "FEHLER!!! ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
        }
    }
}
