using System;

namespace FLNotePad
{
    /// <summary>
    /// Miscellaneous support functions. This class will go away eventually.
    /// </summary>
    public class Miscellaneous
    {
        System.Collections.Queue fileSet;


        /// <summary>
        /// Decodes an encoded Freelancer string; for example,
        /// "005400720065006E0074" returns "Trent"
        /// </summary>
        /// <param name="encodedName"></param>
        /// <returns></returns>
        public string DecodeName(string encodedName) {
            if (encodedName.Length % 4 != 0) { return (""); }
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < encodedName.Length; i += 4) {
                sb.Append((char)(System.Int32.Parse((encodedName.Substring(i, 4)),
                 System.Globalization.NumberStyles.HexNumber)));
            }
            return sb.ToString();
        }

        /// <summary>
        /// encodes text into a hex representation suitable for persisted Unicode,
        /// consisting of a 4-byte hex numeric for each character in the text string.
        /// For example, EncodeName takes "Trent" and returns
        /// "005400720065006E0074"
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string EncodeName(string name) {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            char[] c = name.ToCharArray();
            for (int i = 0; i < c.Length; i += 1) {
                sb.Append(((int)c[i]).ToString("x").PadLeft(4, '0'));
            }
            return sb.ToString();
        }

        /// <summary>
        /// Given a base folder and a file ending, returns all matching files
        /// within the folder structure in a queue built from a breadth-first search.
        /// </summary>
        /// <param name="basePath">base folder</param>
        /// <param name="fileSuffix">File termination, such as "thn" or "ini"</param>
        /// <returns></returns>
        public void EnumerateFiles(string basePath, string fileSuffix) {
            fileSet = new System.Collections.Queue();
            System.IO.DirectoryInfo baseDirectory =
                new System.IO.DirectoryInfo(basePath);
            // begin recursion process
            RecurseDirectory(baseDirectory, fileSuffix);

        }

        /// <summary>
        /// Handles the business of recursively enumerating folders and adding files to the queue
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="fileSuffix"></param>
        private void RecurseDirectory(System.IO.DirectoryInfo directory, string fileSuffix) {
            fileSet.Enqueue(directory.GetFiles("*." + fileSuffix));
            foreach (System.IO.DirectoryInfo dir in directory.GetDirectories()) {
                RecurseDirectory(dir, fileSuffix);
            }
        }

        /// <summary>
        /// Files selected by EnumerateFiles
        /// </summary>
        public object FileSet {
            get {
                return fileSet;
            }
        }
    }
}
