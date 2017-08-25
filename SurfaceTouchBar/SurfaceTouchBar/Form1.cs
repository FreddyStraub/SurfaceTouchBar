using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurfaceTouchBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TopMost = true;

        }

        Screen[] screens;
        Screen currentScreen;

        Process currentProcess;

        Settings settings = new Settings();

        public Profile selectedProfile;

        Button b1 = new Button();
        Button b2 = new Button();
        Button b3 = new Button();
        Button b4 = new Button();
        Button b5 = new Button();
        Button b6 = new Button();
        Button b7 = new Button();
        Button b8 = new Button();

        Button bEinstellungen = new Button();

        bool screenoreantation;

        int theScreenRectHeight;
        int theScreenRectWidth;

        private void Form1_Load(object sender, EventArgs e)
        {
            screenoreantation = isLandscape();


            screens = Screen.AllScreens;
            currentScreen = Screen.FromControl(this);
            StartPosition = FormStartPosition.Manual;
            Height = Screen.PrimaryScreen.Bounds.Height  - CalculateTaskbarHeight();

            DisplayButtons();
            InitializeButtonEvent();

            LoadSettings();


        }

        /// <summary>
        /// Lädt die Settings und überträgt Daten an Form.
        /// </summary>
        private void LoadSettings()
        {

            if(!System.IO.File.Exists(Application.StartupPath + "\\Settings.wolf"))
            {
                Settings newStandartSettings = new Settings();
                newStandartSettings.SetStandartValues();
                newStandartSettings.Save();
            }


            try
            {
                settings = settings.Load();
                selectedProfile = settings.SelectedProfile;

            }
            catch
            {

                if(System.IO.File.Exists(Application.StartupPath + "\\Settings.wolf"))
                {
                    System.IO.File.Delete(Application.StartupPath + "\\Settings.wolf");
                }

                Settings newStandartSettings = new Settings();
                newStandartSettings.SetStandartValues();
                newStandartSettings.Save();

                LoadSettings();

            }

            selectedProfile = settings.SelectedProfile;

            b1.Text = selectedProfile.Buttons[0].name;
            b2.Text = selectedProfile.Buttons[1].name;
            b3.Text = selectedProfile.Buttons[2].name;
            b4.Text = selectedProfile.Buttons[3].name;
            b5.Text = selectedProfile.Buttons[4].name;
            b6.Text = selectedProfile.Buttons[5].name;
            b7.Text = selectedProfile.Buttons[6].name;
            b8.Text = selectedProfile.Buttons[7].name;
            
        }

        private void ProcessTimer_Tick(object sender, EventArgs e)
        {

            Process sftb = Process.GetCurrentProcess();
            Process cur = WindowHelper.getCurrentProcess();

            if (sftb.MainWindowTitle != cur.MainWindowTitle)
            {
                currentProcess = cur;

            }

            //Setting Screen Params
           theScreenRectHeight = Screen.PrimaryScreen.Bounds.Height;
           theScreenRectWidth = Screen.PrimaryScreen.Bounds.Width;

            //Set SurfaceTouchBar to new oreantation.
            if(screenoreantation != isLandscape())
            {

                screenoreantation = isLandscape();

                Thread.Sleep(1000);

                Console.WriteLine(screenoreantation.ToString());
     
                StartPosition = FormStartPosition.Manual;
                Height = Screen.PrimaryScreen.Bounds.Height - CalculateTaskbarHeight();

                this.Controls.Clear();

                DisplayButtons();
                InitializeButtonEvent();

                LoadSettings();
            }


            

        }

        /// <summary>
        /// Detect if device-screen is landscape or not.
        /// </summary>
        /// <returns></returns>
        private bool isLandscape()
        {
            if (theScreenRectHeight > theScreenRectWidth)
            {
                // Run the application in portrait, as in:
              return false;
            }
            else
            {
                // Run the application in landscape, as in:
                return true;
            }
        }

        private void B1_Click(Object sender, MouseEventArgs e)
        {

            if(e.Button != MouseButtons.Right)
            {
                if(currentProcess != null)
                {
                    WindowHelper.BringProcessToFront(currentProcess);

                    ButtonSetting b1S = selectedProfile.Buttons[0];

                    SendKeys.Send(GenerateSendKeysString(b1S.hotkey, b1S.strg, b1S.alt, b1S.shift));

                }

            }
            else
            {

                EditButtonSettings(0);

            }


        }
        private void B2_Click(Object sender, MouseEventArgs e)
        {


            if (e.Button != MouseButtons.Right)
            {
                if (currentProcess != null)
                {
                    WindowHelper.BringProcessToFront(currentProcess);

                    ButtonSetting b2S = selectedProfile.Buttons[1];

                    SendKeys.Send(GenerateSendKeysString(b2S.hotkey, b2S.strg, b2S.alt, b2S.shift));

                }

            }
            else
            {

                EditButtonSettings(1);

            }
        }
        private void B3_Click(Object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Right)
            {
                if (currentProcess != null)
                {
                    WindowHelper.BringProcessToFront(currentProcess);

                    ButtonSetting b3S = selectedProfile.Buttons[2];

                    SendKeys.Send(GenerateSendKeysString(b3S.hotkey, b3S.strg, b3S.alt, b3S.shift));

                }

            }
            else
            {

                EditButtonSettings(2);

            }
        }
        private void B4_Click(Object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Right)
            {
                if (currentProcess != null)
                {
                    WindowHelper.BringProcessToFront(currentProcess);

                    ButtonSetting b4S = selectedProfile.Buttons[3];

                    SendKeys.Send(GenerateSendKeysString(b4S.hotkey, b4S.strg, b4S.alt, b4S.shift));

                }

            }
            else
            {

                EditButtonSettings(3);

            }


        }
        private void B5_Click(Object sender, MouseEventArgs e)
        {


            if (e.Button != MouseButtons.Right)
            {
                if (currentProcess != null)
                {
                    WindowHelper.BringProcessToFront(currentProcess);

                    ButtonSetting b5S = selectedProfile.Buttons[4];

                    SendKeys.Send(GenerateSendKeysString(b5S.hotkey, b5S.strg, b5S.alt, b5S.shift));

                }

            }
            else
            {

                EditButtonSettings(4);

            }

        }
        private void B6_Click(Object sender, MouseEventArgs e)
        {


            if (e.Button != MouseButtons.Right)
            {
                if (currentProcess != null)
                {
                    WindowHelper.BringProcessToFront(currentProcess);

                    ButtonSetting b6S = selectedProfile.Buttons[5];

                    SendKeys.Send(GenerateSendKeysString(b6S.hotkey, b6S.strg, b6S.alt, b6S.shift));

                }

            }
            else
            {

                EditButtonSettings(5);

            }

        }
        private void B7_Click(Object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Right)
            {
                if (currentProcess != null)
                {
                    WindowHelper.BringProcessToFront(currentProcess);

                    ButtonSetting b7S = selectedProfile.Buttons[6];

                    SendKeys.Send(GenerateSendKeysString(b7S.hotkey, b7S.strg, b7S.alt, b7S.shift));

                }

            }
            else
            {

                EditButtonSettings(6);

            }

        }
        private void B8_Click(Object sender, MouseEventArgs e)
        {


            if (e.Button != MouseButtons.Right)
            {
                if (currentProcess != null)
                {
                    WindowHelper.BringProcessToFront(currentProcess);

                    ButtonSetting b8S = selectedProfile.Buttons[7];

                    SendKeys.Send(GenerateSendKeysString(b8S.hotkey, b8S.strg, b8S.alt, b8S.shift));

                }

            }
            else
            {

                EditButtonSettings(7);

            }

        }

        private void bEinstellungen_Click(Object sender, EventArgs e)
        {
            Einstellungen frmEinstellungen = new Einstellungen(settings.Profiles, selectedProfile);
            frmEinstellungen.ShowDialog();

            List<Profile> newProfiles = frmEinstellungen.Profiles;

            settings.SelectedProfile = frmEinstellungen.SelectedProfile;
            settings.Profiles = newProfiles;
            settings.Save();

            LoadSettings();
        }

        /// <summary>
        /// Ermöglicht das editieren des angegebenen Buttons
        /// </summary>
        /// <param name="buttonIndex">index des Buttons in settings.Buttons</param>
        private void EditButtonSettings(int buttonIndex)
        {
            ButtonSetting oldButtonSettings = selectedProfile.Buttons[buttonIndex];

            EditButton EditButton = new EditButton(oldButtonSettings, "Button " + (buttonIndex + 1));
            EditButton.ShowDialog();

            ButtonSetting newButtonSettings = new ButtonSetting()
            {
                name = EditButton.tbName.Text,

                hotkey = (Keys)Enum.Parse(typeof(Keys), EditButton.bHotkey.Text),
                alt = EditButton.checkAlt.Checked,
                strg = EditButton.checkStrg.Checked,
                shift = EditButton.checkShift.Checked
            };

            selectedProfile.Buttons[buttonIndex] = newButtonSettings;

            settings.Save();

            LoadSettings();
        }

        /// <summary>
        /// Generiert aus Parametern einen SendKeys.Send() -  String.
        /// </summary>
        /// <param name="hotkey">Keysobjekt mit hotkey</param>
        /// <param name="strg">Soll Steuerung gedrückt werden.</param>
        /// <param name="alt">Soll Alt gedrückt werden.</param>
        /// <param name="shift">Soll Shift gedrückt werden.</param>
        /// <returns>String der in Sendkeys.Send() verwendet werden kann.</returns>
        private string GenerateSendKeysString(Keys hotkey, bool strg, bool alt, bool shift)
        {
            string keystring = "";

            if (strg)
                keystring += "^";
            if (alt)
                keystring += "%";
            if (shift)
                keystring += "+";

            keystring += hotkey.ToString();

            keystring = keystring.ToLower();

            return keystring;


        }

        /// <summary>
        /// Creates perfect SurfaceTouchBar - Button.
        /// </summary>
        /// <param name="buttonText">Button Text</param>
        /// <returns>SurfaceTouchBar - Button</returns>
        private Button GenerateBarButton()
        {
            Button newBarButton = new Button()
            {
                Width = this.Width,
                Height = Height / 8,
                FlatStyle = FlatStyle.Flat,
                Font = new Font(FontFamily.GenericSansSerif, 10.0F)
            };
            return newBarButton;
        }

        /// <summary>
        /// initialisisert SurfaceTouchBar-Button-Click-Events
        /// </summary>
        private void InitializeButtonEvent()
        {
            b1.MouseDown += new MouseEventHandler(this.B1_Click);
            b2.MouseDown += new MouseEventHandler(this.B2_Click);
            b3.MouseDown += new MouseEventHandler(this.B3_Click);
            b4.MouseDown += new MouseEventHandler(this.B4_Click);
            b5.MouseDown += new MouseEventHandler(this.B5_Click);
            b6.MouseDown += new MouseEventHandler(this.B6_Click);
            b7.MouseDown += new MouseEventHandler(this.B7_Click);
            b8.MouseDown += new MouseEventHandler(this.B8_Click);

            bEinstellungen.Click += new EventHandler(this.bEinstellungen_Click);

        }

        /// <summary>
        /// Gibt die Höhe der Taskbar zurück.
        /// </summary>
        /// <returns></returns>
        private static int CalculateTaskbarHeight()
        {
            return Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
        }

        /// <summary>
        /// Dispalys the Buttons.
        /// </summary>
        private void DisplayButtons()
        {

            //Höhe des Platzes indem die belegbare Buttons angezeigt werden (ohne Einstelungen Buttons).
            int definedHeight = Height - 70;

            //Einzelne belegbare Buttons
            b1 = GenerateBarButton();
            Controls.Add(b1);
            b2 = GenerateBarButton();
            b2.Location = new Point(0, definedHeight / 8);
            Controls.Add(b2);
            b3 = GenerateBarButton();
            b3.Location = new Point(0, (definedHeight / 8) * 2);
            Controls.Add(b3);
            b4 = GenerateBarButton();
            b4.Location = new Point(0, (definedHeight / 8) * 3);
            Controls.Add(b4);
            b5 = GenerateBarButton();
            b5.Location = new Point(0, (definedHeight / 8) * 4);
            Controls.Add(b5);
            b6 = GenerateBarButton();
            b6.Location = new Point(0, (definedHeight / 8) * 5);
            Controls.Add(b6);
            b7 = GenerateBarButton();
            b7.Location = new Point(0, (definedHeight / 8) * 6);
            Controls.Add(b7);
            b8 = GenerateBarButton();
            b8.Location = new Point(0, (definedHeight / 8) * 7);
            Controls.Add(b8);

            //Einstellungen Button
            bEinstellungen = GenerateBarButton();
            bEinstellungen.Location = new Point(0, (definedHeight / 8) * 8);
            bEinstellungen.Height = Height - definedHeight;
            bEinstellungen.Text = "Einstellungen";
            bEinstellungen.BackColor = Color.Black;
            Controls.Add(bEinstellungen);
        }
        




    }
}
