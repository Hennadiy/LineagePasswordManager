using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PasswordManager.Utilities
{
    public class ProcessUtility
    {
        private readonly string _enterKey = "{ENTER}";

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

        public Process[] GetProcesses(string windowTitle)
        {
            return Process.GetProcesses()
                            .Where(proc => proc.MainWindowTitle.Contains(windowTitle))
                            .OrderBy(proc => proc.StartTime)
                            .ToArray();
        }

        public void StartNewWindowAndLogin(string path, Credential credential)
        {
            try
            {
                var proc = Process.Start(path);
                proc.WaitForInputIdle();
                if (proc.MainWindowTitle.Equals("Warning")) //skip warning
                {
                    proc.CloseMainWindow();
                }
                proc.WaitForInputIdle();
                InputCreds(proc.MainWindowHandle, credential);
            }
            catch (Exception ex)
            {
                if (ex.Message != "The operation was canceled by the user")
                {
                    throw;
                }
            }
        }

        public void InputCreds(IntPtr handle, Credential credential)
        {
            SetForegroundWindow(handle);
            Thread.Sleep(200);
            ShowWindow(handle, 1);
            Thread.Sleep(1000);

            SendKeys.SendWait(credential.Login);
            Thread.Sleep(100);
            SendKeys.SendWait("\t");
            Thread.Sleep(100);
            SendKeys.SendWait(credential.Password);
            Thread.Sleep(100);
            SendKeys.SendWait(_enterKey);
            Thread.Sleep(500);
            SendKeys.SendWait(_enterKey);
            Thread.Sleep(500);
            SendKeys.SendWait(_enterKey);
        }
    }
}
