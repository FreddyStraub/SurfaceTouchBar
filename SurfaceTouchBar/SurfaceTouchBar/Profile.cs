using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
