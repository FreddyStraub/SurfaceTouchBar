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
    public partial class Settings
    {

        //public List<ButtonSetting> Buttons;

        public List<Profile> Profiles;

        public Profile SelectedProfile { get; set; }

       private string settingspath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SurfaceTouchBar\\";

        public Settings()
        {
            Profiles = new List<Profile>();
        }

        /// <summary>
        /// Speichert die Einstellungen.
        /// </summary>
        public void Save()
        {

            System.IO.FileStream FS = new System.IO.FileStream(settingspath + "Settings.wolf", System.IO.FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();

            BF.Serialize(FS, this);

            FS.Dispose();

        }

        /// <summary>
        /// Lädt die Einstellungen.
        /// </summary>
        /// <returns>Objekt mit geldenen Einstellungen.</returns>
        public Settings Load()
        {

            Settings newSettings = new Settings();


            System.IO.FileStream FS = new System.IO.FileStream(settingspath + "Settings.wolf", System.IO.FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();

            newSettings = (Settings)BF.Deserialize(FS);

            FS.Dispose();


            return newSettings;

        }

        /// <summary>
        /// Setzt die Settings auf den Standartwert.
        /// </summary>
        public void SetStandartValues()
        {

            Profile Profile = new Profile()
            {
                Buttons = new List<ButtonSetting>(),
                Name = "Standart"
                
            };

            Profile.setStandartValues();

            Profiles.Add(Profile);

            SelectedProfile = Profiles[0];

        }

    }
}
