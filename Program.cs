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
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FLEditor editor = new FLEditor();

            try
            {
                if (args.Length == 1)
                {
                    editor.openFile(args[0]);
                }
                else if (args.Length >= 2)
                {
                    editor.multiOpen(args);
                }
                else
                {
                    Application.Run(editor);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "FLNotepad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception($"Error opening file: {e.Message}");
            }
        }
    }
}
