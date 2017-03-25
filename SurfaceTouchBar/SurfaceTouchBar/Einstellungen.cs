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
    public partial class Einstellungen : Form
    {
        public List<Profile> Profiles { get; }

        public Profile SelectedProfile { get; private set; }

        public Einstellungen(List<Profile> profiles, Profile selectedProfile)
        {
            InitializeComponent();
            Profiles = profiles;
            SelectedProfile = selectedProfile;
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

        /// <summary>
        /// Öffnet Dialog zum erstellen eines neuen Profiles
        /// </summary>
        private void createProfil()
        {

            frmInputDialog frmInputDialog = new frmInputDialog();

            if (frmInputDialog.ShowDialog() == DialogResult.OK)
            {



                Profile newProfile = new Profile()
                {
                    Name = frmInputDialog.tbName.Text
                
            };

            newProfile.setStandartValues();

            Profiles.Add(newProfile);

            loadlistProfileItems();

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
                
        private void Einstellungen_Load(object sender, EventArgs e)
        {

            loadlistProfileItems();

            //Selection des zuvor ausgewählten Profiels
            int index = Profiles.IndexOf(SelectedProfile);
            listProfile.SelectedItem = listProfile.Items[index];


        }
        /// <summary>
        /// Befüllung der listProfile
        /// </summary>
        private void loadlistProfileItems()
        {

            listProfile.Items.Clear();

            foreach (Profile p in Profiles)
            {
                listProfile.Items.Add(p.Name);
            }

            //Selection des zuvor ausgewählten Profiels
            int index = Profiles.IndexOf(SelectedProfile);
            listProfile.SelectedItem = listProfile.Items[index];

        }

        private void listProfile_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Legt das SelectedProfile anhand der Listenauswahl des Users fest.
            int ProfileIndex = listProfile.SelectedIndex;
            SelectedProfile = Profiles[ProfileIndex];

        }

        private void neuesProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createProfil();
        }
    }
}
