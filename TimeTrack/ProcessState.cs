using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TimeTrack
{
    public static class GetProcessRunning
    {

        // Following MSDN article on GetForegroundWindow function used to assist with getting process name
        // https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-getforegroundwindow

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);


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

        private static Process GetProcessByHandle(IntPtr hwnd)
        {
            try
            {
                uint processID;
                GetWindowThreadProcessId(hwnd, out processID);
                return Process.GetProcessById((int)processID);
            }
            catch { return null; }
        }

    }
}
