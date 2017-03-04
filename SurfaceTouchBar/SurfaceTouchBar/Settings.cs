using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurfaceTouchBar
{
    [Serializable]
    public class Settings
    {

        public List<ButtonSetting> Buttons;

        public Settings()
        {
            Buttons = new List<ButtonSetting>();
        }

        /// <summary>
        /// Speichert die Einstellungen.
        /// </summary>
        public void save()
        {

            System.IO.FileStream FS = new System.IO.FileStream(Application.StartupPath + "\\Settings.wolf", System.IO.FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();

            BF.Serialize(FS, this);

            FS.Dispose();

        }

        /// <summary>
        /// Lädt die Einstellungen.
        /// </summary>
        /// <returns>Objekt mit geldenen Einstellungen.</returns>
        public Settings load()
        {

            Settings newSettings = new Settings();


            System.IO.FileStream FS = new System.IO.FileStream(Application.StartupPath + "\\Settings.wolf", System.IO.FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();

            newSettings = (Settings)BF.Deserialize(FS);

            FS.Dispose();


            return newSettings;

        }

        /// <summary>
        /// Setzt die Settings auf den Standartwert.
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

        [Serializable]
        public class ButtonSetting
        {

            public string name;

            public Keys hotkey;

            public bool strg;
            public bool alt;
            public bool shift;

        }

    }
}
