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

        Button b1 = new Button();
        Button b2 = new Button();
        Button b3 = new Button();
        Button b4 = new Button();
        Button b5 = new Button();
        Button b6 = new Button();
        Button b7 = new Button();
        Button b8 = new Button();

        private void Form1_Load(object sender, EventArgs e)
        {


            screens = Screen.AllScreens;
            currentScreen = Screen.FromControl(this);
            StartPosition = FormStartPosition.Manual;
            Height = Screen.PrimaryScreen.Bounds.Height  - calculateTaskbarHeight();

            displayButtons();
            initializeButtonEvent();

            loadSettings();


        }

        /// <summary>
        /// Lädt die Settings und überträgt Daten an Form.
        /// </summary>
        private void loadSettings()
        {
            settings = settings.load();

            b1.Text = settings.Buttons[0].name;
            b2.Text = settings.Buttons[1].name;
            b3.Text = settings.Buttons[2].name;
            b4.Text = settings.Buttons[3].name;
            b5.Text = settings.Buttons[4].name;
            b6.Text = settings.Buttons[5].name;
            b7.Text = settings.Buttons[6].name;
            b8.Text = settings.Buttons[7].name;


        }


        private void processTimer_Tick(object sender, EventArgs e)
        {

            Process sftb = Process.GetCurrentProcess();
            Process cur = WindowHelper.getCurrentProcess();

            if (sftb.MainWindowTitle != cur.MainWindowTitle)
            {
                currentProcess = cur;

            }


        }


        private void b1_Click(Object sender, MouseEventArgs e)
        {

            if(e.Button != MouseButtons.Right)
            {
                WindowHelper.BringProcessToFront(currentProcess);

                Settings.ButtonSetting b1S = settings.Buttons[0];

                string keystring = generateSendKeysString(b1S.hotkey, b1S.strg, b1S.alt, b1S.shift);

                SendKeys.Send(keystring);


            }else
            {

                Settings.ButtonSetting oldb1Settings = settings.Buttons[0];

                EditButton Edit_b1 = new EditButton("Button 1", oldb1Settings.name, oldb1Settings.hotkey, oldb1Settings.strg, oldb1Settings.alt, oldb1Settings.shift);
                Edit_b1.ShowDialog();

                Settings.ButtonSetting newb1Settings = new Settings.ButtonSetting();

                newb1Settings.name = Edit_b1.tbName.Text;

                newb1Settings.hotkey = (Keys)Enum.Parse(typeof(Keys), Edit_b1.bHotkey.Text);
                newb1Settings.alt = Edit_b1.checkAlt.Checked;
                newb1Settings.strg = Edit_b1.checkStrg.Checked;
                newb1Settings.shift = Edit_b1.checkShift.Checked;

                settings.Buttons[0] = newb1Settings;

                settings.save();

            }




        }
        private void b2_Click(Object sender, MouseEventArgs e)
        {

 

            WindowHelper.BringProcessToFront(currentProcess);
            SendKeys.Send("b");


        }
        private void b3_Click(Object sender, MouseEventArgs e)
        {

            //WindowHelper.BringProcessToFront(currentProcess);
            //SendKeys.Send("HI There!");


        }
        private void b4_Click(Object sender, MouseEventArgs e)
        {

            WindowHelper.BringProcessToFront(currentProcess);
            SendKeys.Send("HI There!");




        }
        private void b5_Click(Object sender, MouseEventArgs e)
        {

            WindowHelper.BringProcessToFront(currentProcess);
            SendKeys.Send("HI There!");


        }
        private void b6_Click(Object sender, MouseEventArgs e)
        {

            WindowHelper.BringProcessToFront(currentProcess);
            SendKeys.Send("HI There!");


        }
        private void b7_Click(Object sender, MouseEventArgs e)
        {

            WindowHelper.BringProcessToFront(currentProcess);
            SendKeys.Send("HI There!");


        }
        private void b8_Click(Object sender, MouseEventArgs e)
        {

            WindowHelper.BringProcessToFront(currentProcess);
            SendKeys.Send("HI There!");


        }

        private string generateSendKeysString(Keys hotkey, bool strg, bool alt, bool shift)
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
        private Button generateBarButton()
        {
            Button newBarButton = new Button();

            newBarButton.Width = this.Width;
            newBarButton.Height = Height / 8;
            newBarButton.FlatStyle = FlatStyle.Flat;
            newBarButton.Font = new Font(FontFamily.GenericSansSerif,10.0F);

            return newBarButton;
        }

        /// <summary>
        /// initialisisert SurfaceTouchBar-Button-Click-Events
        /// </summary>
        private void initializeButtonEvent()
        {
            b1.MouseDown += new MouseEventHandler(this.b1_Click);
            b2.MouseDown += new MouseEventHandler(this.b2_Click);
            b3.MouseDown += new MouseEventHandler(this.b3_Click);
            b4.MouseDown += new MouseEventHandler(this.b4_Click);
            b5.MouseDown += new MouseEventHandler(this.b5_Click);
            b6.MouseDown += new MouseEventHandler(this.b6_Click);
            b7.MouseDown += new MouseEventHandler(this.b7_Click);
            b8.MouseDown += new MouseEventHandler(this.b8_Click);

        }

        /// <summary>
        /// Gibt die Höhe der Taskbar zurück.
        /// </summary>
        /// <returns></returns>
        private static int calculateTaskbarHeight()
        {
            return Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
        }

        /// <summary>
        /// Dispalys the Buttons.
        /// </summary>
        private void displayButtons()
        {
            b1 = generateBarButton();
            Controls.Add(b1);
            b2 = generateBarButton();
            b2.Location = new Point(0, Height / 8);
            Controls.Add(b2);
            b3 = generateBarButton();
            b3.Location = new Point(0, (Height / 8) * 2);
            Controls.Add(b3);
            b4 = generateBarButton();
            b4.Location = new Point(0, (Height / 8) * 3);
            Controls.Add(b4);
            b5 = generateBarButton();
            b5.Location = new Point(0, (Height / 8) * 4);
            Controls.Add(b5);
            b6 = generateBarButton();
            b6.Location = new Point(0, (Height / 8) * 5);
            Controls.Add(b6);
            b7 = generateBarButton();
            b7.Location = new Point(0, (Height / 8) * 6);
            Controls.Add(b7);
            b8 = generateBarButton();
            b8.Location = new Point(0, (Height / 8) * 7);
            Controls.Add(b8);
        }
        




    }
}
