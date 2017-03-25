using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurfaceTouchBar
{
    [Serializable]
    public class Profile
    {

        public Profile()
        {
            Buttons = new List<ButtonSetting>();

        }

        public string Name { get; set; }

        public List<ButtonSetting> Buttons { get; set; }

       // public Process SelectedProgramm { get; set; }

        /// <summary>
        /// Setzt die Buttons auf die Standartwerte
        /// </summary>
        public void setStandartValues()
        {
            List<ButtonSetting> standartButtons = new List<ButtonSetting>();

            #region B1

            ButtonSetting b1 = new ButtonSetting()
            {
                name = "Zeiger",
                hotkey = Keys.V,
                alt = false,
                shift = false,
                strg = false


            };

            standartButtons.Add(b1);

            #endregion

            #region B2

            ButtonSetting b2 = new ButtonSetting()
            {
                name = "Pinsel",
                hotkey = Keys.B,
                alt = false,
                shift = false,
                strg = false

            };

            standartButtons.Add(b2);

            #endregion

            #region B3

            ButtonSetting b3 = new ButtonSetting()
            {
                name = "Radiergummi",
                hotkey = Keys.E,
                alt = false,
                shift = false,
                strg = false

            };

            standartButtons.Add(b3);

            #endregion

            #region B4

            ButtonSetting b4 = new ButtonSetting()
            {
                name = "Schritt Zurück",
                hotkey = Keys.Z,
                alt = true,
                shift = false,
                strg = true

            };

            standartButtons.Add(b4);

            #endregion

            #region B5

            ButtonSetting b5 = new ButtonSetting()
            {
                name = "Schritt Vor",
                hotkey = Keys.Z,
                alt = false,
                shift = true,
                strg = true

            };

            standartButtons.Add(b5);

            #endregion

            #region B6

            ButtonSetting b6 = new ButtonSetting()
            {
                name = "Füllwerkzeug",
                hotkey = Keys.G,
                alt = false,
                shift = false,
                strg = false

            };

            standartButtons.Add(b6);

            #endregion

            #region B7

            ButtonSetting b7 = new ButtonSetting()
            {
                name = "Lasso",
                hotkey = Keys.L,
                alt = false,
                shift = false,
                strg = false

            };

            standartButtons.Add(b7);

            #endregion

            #region B8

            ButtonSetting b8 = new ButtonSetting()
            {
                name = "Rotieren",
                hotkey = Keys.R,
                alt = false,
                shift = false,
                strg = false

            };

            standartButtons.Add(b8);

            #endregion


            Buttons = standartButtons;

        }

    }
}
