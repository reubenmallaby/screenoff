using System;
using System.Runtime.InteropServices;

namespace ScreenOff
{
    class Program
    {        
        [DllImport("user32.dll")]
        static extern IntPtr PostMessage(int hWnd, int msg, int wParam, int lParam);

        private const int WmSyscommand = 0x0112;
        private const int ScMonitorpower = 0xF170;
        private const int MonitorShutoff = 2;
        
        static void Main(string[] args)
        {
            PostMessage(-1, WmSyscommand, ScMonitorpower, MonitorShutoff);
        }
    }
}
