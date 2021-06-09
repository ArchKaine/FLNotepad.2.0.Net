using System;
using System.Windows.Forms;

namespace FLNotePad
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FLEditor());

            FLEditor editor = new FLEditor();
            if (args.Length == 1) {
                editor.openFile(args[0]);
            }
            if (args.Length >= 2) {
                editor.multiOpen(args);
                //editor.Show();
            }
            else {
                Application.Run(editor);
            }
        }
    }
}
