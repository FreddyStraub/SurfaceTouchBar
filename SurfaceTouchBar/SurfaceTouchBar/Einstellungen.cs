using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            Height = 640;
            Width = 420;

            bProfile.ForeColor = Color.FromArgb(255, 25, 25, 25);
            bProfile.BackColor = Color.White;

            label8.Text = "V"+Application.ProductVersion.ToString();
           

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

        /// <summary>
        /// Löscht das ausgewählte Profile.
        /// </summary>
        private void deleteProifle()
        {

            if (listProfile.Items.Count != 1)
            {

                if (MessageBox.Show("Willst du " + listProfile.SelectedItem.ToString() + " wirklich löschen?", "SurfaceTouchBar - Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Profiles.Remove(Profiles[listProfile.SelectedIndex]);
                    listProfile.Items.Remove(listProfile.SelectedItem);

                    if (Profiles.IndexOf(SelectedProfile) == -1)
                    {
                        SelectedProfile = Profiles[0];
                    }

                    selectProfile();

                }
            }
            else
            {
                MessageBox.Show("Es muss mindestens ein Profile vorhanden sein!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        /// <summary>
        /// Öffnet einen Dialog um das aktuelle Profile zu bearbeiten.
        /// </summary>
        private void editProfile()
        {

            frmInputDialog frmInputDialog = new frmInputDialog();
            frmInputDialog.tbName.Text = listProfile.SelectedItem.ToString();

            if (frmInputDialog.ShowDialog() == DialogResult.OK)
            {

                int index = listProfile.SelectedIndex;
                string newName = frmInputDialog.tbName.Text;

                Profiles[index].Name = newName;

                loadlistProfileItems();
                selectProfile();

            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Einstellungen_Load(object sender, EventArgs e)
        {

            loadlistProfileItems();

            selectProfile();
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

            selectProfile();

        }

        /// <summary>
        /// Selection des zuvor ausgewählten Profiels
        /// </summary>
        private void selectProfile()
        {

            int index = Profiles.IndexOf(SelectedProfile);
            listProfile.SelectedItem = listProfile.Items[index];

        }

        private void listProfile_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Legt das SelectedProfile anhand der Listenauswahl des Users fest.
            int ProfileIndex = listProfile.SelectedIndex;

            if (ProfileIndex == -1)
            {
                SelectedProfile = Profiles[0];

            }
            else
            {
                SelectedProfile = Profiles[ProfileIndex];

            }


        }

        private void neuesProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createProfil();
        }

        private void profilLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteProifle();
        }

        private void profilBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editProfile();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bNeu_Click(object sender, EventArgs e)
        {
            createProfil();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            editProfile();
        }

        private void bLöschen_Click(object sender, EventArgs e)
        {
            deleteProifle();
        }

        private void bProfile_Click(object sender, EventArgs e)
        {

            //Infopanel verschieben
            panel1.Location = new Point(915, 222);
            bunifuTransition1.Show(panelProfiles);
            panelProfiles.Visible = true;
      
            //Tabbuttons color ändern.
            bProfile.ForeColor = Color.FromArgb(255, 25, 25, 25);
            bProfile.BackColor = Color.White;

            bInfos.ForeColor = Color.White;
            bInfos.BackColor = Color.FromArgb(255, 25, 25, 25);


        }

        private void bInfos_Click(object sender, EventArgs e)
        {

            //Infopannel verschieben
            panel1.Visible = false;

            panel1.Location = panelProfiles.Location;


            bunifuTransition1.Show(panel1);
            panel1.Visible = true;

            panelProfiles.Visible = false;

            //Tabbuttons color ändern.
            bInfos.ForeColor = Color.FromArgb(255, 25, 25, 25);
            bInfos.BackColor = Color.White;

            bProfile.ForeColor = Color.White;
            bProfile.BackColor = Color.FromArgb(255, 25, 25, 25);


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://wolf066lp.de/");
                    
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://wolf066lp.de/tools/surfacetouchbar/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://youtube.streamlabs.com/wolf066lp");
        }

         private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
