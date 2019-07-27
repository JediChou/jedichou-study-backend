using System;
using System.Runtime.InteropServices;

namespace CSLab.Study201502091325
{
    public class Win32
    {
        /// <summary>
        /// Call Win32 API
        /// </summary>
        /// <param name="hwnd">Windows Form handler</param>
        /// <param name="text">Message content</param>
        /// <param name="caption">Form title</param>
        /// <param name="type">Form type</param>
        /// <returns>Form</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hwnd, String text, String caption, uint type);
    }

    public class Execute
    {
        public static void Run()
        {
            // Notice charset property
            Win32.MessageBox(0, "Hello world", "Platform Invoke sample", 0);
        }
    }
}
