using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;

namespace FLNotePad
{
    /// <summary>
    /// Manipulates Freelancer saved game information.
    /// </summary>
    public class SavedGame
    {
        // Get line from file, decoded as list of words
        // Code pinched from "flcodec" by Jor <flcodec@jors.net>
        /// <summary>
        /// Decodes data from a Freelancer .fl save game file.
        /// Altered from original code by sirlancelot.
        /// Additional code provided by Watercooler Warrior.
        /// Final code modified by Brian E Turner (ArchKaine)
        /// </summary>
        /// <param name="filepath">Path to the savegame file.</param>
        /// <returns>human-readable content of the savegame file.</returns>
        public string DecodeCharacter(string filepath) {
            string MySourceFile = Path.GetFullPath(filepath);
            string MyAccountFolder = Path.GetFileName(Path.GetDirectoryName(filepath));
            string MyBaseFileName = Path.GetFileNameWithoutExtension(filepath);

            //open the source file...
            StreamReader dataSource =
                new StreamReader(MySourceFile, System.Text.Encoding.UTF7);

            // read the entire raw file as a character array;
            // we check to see if the file is encoded, if so then
            // we immediately strip out the FLS1 using Substring(4).
            // If the file isn't encoded, we go ahead and read 
            // it into a string builder, then send it out to the user.
            int StartIndex = 0; bool isFLS1File = false;
            if ((dataSource).Peek() == 'F') { StartIndex = 4; isFLS1File = true; }
            char[] data = (new System.IO.StreamReader(filepath, System.Text.Encoding.UTF7)).
                ReadToEnd().Substring(StartIndex).ToCharArray();
            dataSource.Close();
            // We SHOULD only be reading encoded files;
            // just in case some are decoded, though, we test.
            if (isFLS1File) {
                // create a pre-sized stringbuilder.
                System.Text.StringBuilder sb =
                    new System.Text.StringBuilder(data.Length);
                char[] gene = "Gene".ToCharArray();
                for (int i = 0; i < data.GetLength(0); i++) {
                    sb.Append((char)(data[i] ^ (((gene[i % 4] + i) % 256) | 0x80)));
                }
                return (sb.ToString());
            }
            else if (!isFLS1File) {
                // create a pre-sized stringbuilder.
                System.Text.StringBuilder sb =
                    new System.Text.StringBuilder(data.Length);
                char[] gene = "Gene".ToCharArray();
                for (int i = 0; i < data.GetLength(0); i++) {
                    sb.Append((char)(data[i]));
                }
                return (sb.ToString());
            }
            return ("");
        }
    }
}
