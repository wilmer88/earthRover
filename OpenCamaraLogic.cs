using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace earth_rover
{
    internal class OpenCamaraLogic
    {
        public OpenCamaraLogic() {

            int hwnd = 0;
            IntPtr hwndChild = IntPtr.Zero;
            [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
            static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);
            hwnd = (int)FindWindowByCaption((IntPtr)null, "Camera");
            if (hwnd == 0)
            {
                if (MessageBox.Show("Couldn't find the calculator" +
                                   " application. Do you want to start it?",
                                   "TestWinAPI",
                                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("microsoft.windows.camera:");
                }
           /*     else
                {

                    [DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
                    static extern IntPtr FindWindowEx(IntPtr ZeroOnly, IntPtr zero, string lpWindowName, string v);

                    //Get a handle for the "1" button
                    hwndChild = FindWindowEx((IntPtr)hwnd, IntPtr.Zero, "Button", "1");

                    //send BN_CLICKED message
                    SendMessage((int)hwndChild, BN_CLICKED, 0, IntPtr.Zero);

                    *//*  //Get a handle for the "+" button
                      hwndChild = FindWindowEx((IntPtr)hwnd, IntPtr.Zero, "Button", "+");

                      //send BN_CLICKED message
                      SendMessage((int)hwndChild, BN_CLICKED, 0, IntPtr.Zero);

                      //Get a handle for the "2" button
                      hwndChild = FindWindowEx((IntPtr)hwnd, IntPtr.Zero, "Button", "2");

                      //send BN_CLICKED message
                      SendMessage((int)hwndChild, BN_CLICKED, 0, IntPtr.Zero);

                      //Get a handle for the "=" button
                      hwndChild = FindWindowEx((IntPtr)hwnd, IntPtr.Zero, "Button", "=");

                      //send BN_CLICKED message
                      SendMessage((int)hwndChild, BN_CLICKED, 0, IntPtr.Zero);*//*

                }*/
            }
        }    
    }
}
