using System;
using System.Windows.Forms;

namespace SurfaceTouchBar
{
  
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
