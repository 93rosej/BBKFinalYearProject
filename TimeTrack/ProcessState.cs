using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TimeTrack
{
    public static class ProcessState
    {

        // Following MSDN article on GetForegroundWindow function used to assist with getting process name
        // https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-getforegroundwindow

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);


        public static string GetActiveProcess()
        {
            IntPtr hwnd = GetForegroundWindow();
            if (hwnd == null)
                return "";

            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);

            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
            {
                if (p.Id == pid)
                {
                    return p.ProcessName.ToString();
                }
            }

            return "Unknown";
        }

        public static string GetActiveWindowTitle()
        {
            const int noOfChars = 256;
            StringBuilder Buff = new StringBuilder(noOfChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, noOfChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

    }
}
