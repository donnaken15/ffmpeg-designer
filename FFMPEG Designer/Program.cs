using System;
using System.Windows.Forms;

namespace FFMPEG_Designer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            Application.Run(new designer());
        }
    }
}
