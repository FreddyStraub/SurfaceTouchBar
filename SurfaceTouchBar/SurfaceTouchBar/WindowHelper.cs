using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceTouchBar
{
    public class WindowHelper
    {

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private const int SW_RESTORE = 9;

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr handle, int nCmdShow);
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool IsIconic(IntPtr handle);

        /// <summary>
        /// Setzt den Focus auf den übergebenen Process
        /// </summary>
        /// <param name="process">Process, der den Focus bekommen soll.</param>
        public static void BringProcessToFront(Process process)
        {
            IntPtr handle = process.MainWindowHandle;
            if (IsIconic(handle))
            {
                ShowWindow(handle, SW_RESTORE);
            }

            SetForegroundWindow(handle);
        }

        /// <summary>
        /// Gibt ein Process-objekt mit dem aktuell im focus-stehenden Programm zurück.
        /// </summary>
        /// <returns></returns>
        public static Process getCurrentProcess()
        {
            IntPtr hWnd = GetForegroundWindow();
            uint procId = 0;
            GetWindowThreadProcessId(hWnd, out procId);
            Process proc = Process.GetProcessById((int)procId);

            return proc;
        }

    }
}
