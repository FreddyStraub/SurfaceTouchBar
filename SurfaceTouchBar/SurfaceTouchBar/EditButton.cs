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
        /// Erstellt neue EditForm
        /// </summary>
        /// <param name="settingsstrnig">String der im Titel des Fensters angezeigt wird.</param>
        /// <param name="name">Name der im Button angezeigt wird.</param>
        /// <param name="hotkey">Hotkey der gesendet wird.</param>
        /// <param name="strg">Gibt an ob Steuerung gedrückt wird</param>
        /// <param name="alt">Gibt an ob Alt gedrückt wird</param>
        /// <param name="shift">Gibt an ob Shift gedrückt wird</param>
        public EditButton(string settingsstrnig, string name, Keys hotkey, bool strg, bool alt, bool shift)
        {
            InitializeComponent();

            tbName.Text = name;

            checkStrg.Checked = strg;
            checkAlt.Checked = alt;
            checkShift.Checked = shift;

            bHotkey.Text = hotkey.ToString();

            lbButtonSettings.Text += " " + settingsstrnig;
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
