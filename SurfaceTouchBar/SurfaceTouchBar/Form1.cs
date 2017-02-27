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
        }

        Screen[] screens;
        Screen currentScreen;

        Button b1;
        Button b2;
        Button b3;
        Button b4;
        Button b5;
        Button b6;
        Button b7;
        Button b8;

        private void Form1_Load(object sender, EventArgs e)
        {

            screens = Screen.AllScreens;
            currentScreen = Screen.FromControl(this);

            StartPosition = FormStartPosition.Manual;

            Height = Screen.PrimaryScreen.Bounds.Height  - calculateTaskbarHeight();

            displayButtons();

            b1.Click += new EventHandler(this.b1_Click);
        }


        private void b1_Click(Object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Creates perfect SurfaceTouchBar - Button.
        /// </summary>
        /// <param name="buttonText">Button Text</param>
        /// <returns>SurfaceTouchBar - Button</returns>
        private Button generateBarButton(string buttonText)
        {
            Button newBarButton = new Button();

            newBarButton.Width = this.Width;
            newBarButton.Text = buttonText;
            newBarButton.Height = Height / 8;
            newBarButton.FlatStyle = FlatStyle.Flat;

            return newBarButton;
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
            b1 = generateBarButton("Guten Morgen!");
            Controls.Add(b1);
            b2 = generateBarButton("Guten Morgen!");
            b2.Location = new Point(0, Height / 8);
            Controls.Add(b2);
            b3 = generateBarButton("Guten Morgen!");
            b3.Location = new Point(0, (Height / 8) * 2);
            Controls.Add(b3);
            b4 = generateBarButton("Guten Morgen!");
            b4.Location = new Point(0, (Height / 8) * 3);
            Controls.Add(b4);
            b5 = generateBarButton("Guten Morgen!");
            b5.Location = new Point(0, (Height / 8) * 4);
            Controls.Add(b5);
            b6 = generateBarButton("Guten Morgen!");
            b6.Location = new Point(0, (Height / 8) * 5);
            Controls.Add(b6);
            b7 = generateBarButton("Guten Morgen!");
            b7.Location = new Point(0, (Height / 8) * 6);
            Controls.Add(b7);
            b8 = generateBarButton("Guten Morgen!");
            b8.Location = new Point(0, (Height / 8) * 7);
            Controls.Add(b8);
        }

    }
}
