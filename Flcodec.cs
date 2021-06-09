using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;

namespace FLNotePad
{
    /// <summary>
    /// Manipulates character state data such as that available in a
    /// saved game file.
    /// To allow easy manipulation, the class exposes information as
    /// clearly understandable text wherever possible. There are limitations
    /// to this - hashes and nicknames are used for most list elements.
    /// </summary>
    public class Flcodec
    {
        public Flcodec() {
            pilotStream = new MemoryStream();
        }
        public MemoryStream PilotStream { get { return pilotStream; } }

        private MemoryStream pilotStream;
        private string MySourceFile;

        /// <summary>
        /// Returns a raw UTF-7 string representation of the pilot's state.
        /// </summary>
        public string RawData {
            get {
                return new StreamReader(pilotStream).ReadToEnd();
            }
        }

        public PilotInformation GetPilotInformation() {
            PilotInformation pi = new PilotInformation();
            pi.FromStream(this.pilotStream);
            pi.FileName = this.MyBaseFileName;
            pi.AccountFolder = this.MyAccountFolder;
            return pi;
        }

        /// <summary>
        /// Returns list of all FL files.
        /// </summary>
        /// <param name="targetFolder"></param>
        /// <returns></returns>
        public static System.Collections.ArrayList FlFileList() {
            System.Collections.ArrayList files = new ArrayList();
            // This method of calculating the source path desperately needs a change.
            // It will almost certainly FAIL on non-English language systems.
            string sourcePath =
                Path.Combine(
                    System.Environment.ExpandEnvironmentVariables("%homepath%"),
                    "My Documents\\My Games\\Freelancer\\Accts\\SinglePlayer");


            // subSource is a subfolder containing all characters for an account.
            foreach (string subSource in Directory.GetDirectories(sourcePath)) {
                // here we go ahead and decode each of the target files.
                foreach (string sourceFile in Directory.GetFiles(subSource)) {
                    if (System.IO.Path.GetExtension(sourceFile).ToLower() == ".fl") {
                        files.Add(Path.GetFullPath(sourceFile));
                    }
                }
            }
            return files;
        }





        /// <summary>
        /// Attempts batch decoding of all Freelancer FL files on the computer.
        /// </summary>
        /// <param name="targetFolder"></param>
        /// <returns></returns>
        public bool BatchDecode(string targetFolder) {

            bool success = true;
            // This method of calculating the source path desperately needs a change.
            // It will almost certainly FAIL on non-English language systems.
            string sourcePath =
                Path.Combine(
                    System.Environment.ExpandEnvironmentVariables("%homepath%"),
                    "My Documents\\My Games\\Freelancer\\Accts\\SinglePlayer");
            if (targetFolder.Length == 0) { targetFolder = sourcePath; }
            // we fail if this doesn't return an existing folder.
            if (!Directory.Exists(sourcePath)) { return false; }
            if (!Directory.Exists(targetFolder)) {
                try {
                    Directory.CreateDirectory(targetFolder);
                }
                catch {
                    // we return false and exit if we can't create the target.
                    return false;
                }
            }
            // At this point, source exists and so does target folder.

            // subSource is a subfolder containing all characters for an account.
            foreach (string subSource in Directory.GetDirectories(sourcePath)) {
                // subTarget is the target subfolder for this account.
                string subTarget =
                    Path.Combine(targetFolder, Path.GetFileName(subSource));

                // now we have to create the subfolder if it doesn't exist.
                if (!Directory.Exists(subTarget)) {
                    try {
                        Directory.CreateDirectory(subTarget);
                    }
                    catch {
                        // we note a glitch if this fails, but don't exit.
                        success = false;
                    }
                }

                // here we go ahead and decode each of the target files.
                foreach (string sourceFile in Directory.GetFiles(subSource)) {
                    string targetPath =
                        Path.Combine(subTarget, Path.GetFileName(sourceFile));
                    this.Load(sourceFile);
                    this.SaveTo(targetPath);
                }
            }
            return success;

        }


        // Get line from file, decoded as list of words
        // Code pinched from "flcodec" by Jor <flcodec@jors.net>
        /// <summary>
        /// Decodes data from a Freelancer .fl save game file
        /// </summary>
        /// <param name="filepath">Path to the savegame file.</param>
        /// <returns>human-readable content of the savegame file.</returns>
        public string Load(string filepath) {
            // read the entire raw file as a character array;
            // we immediately strip out the FLS1 using Substring(4).
            MySourceFile = Path.GetFullPath(filepath);
            MyAccountFolder = Path.GetFileName(Path.GetDirectoryName(filepath));
            MyBaseFileName = Path.GetFileNameWithoutExtension(filepath);

            //open the source file...
            StreamReader dataSource =
                new StreamReader(MySourceFile, System.Text.Encoding.UTF7);

            int StartIndex = 0; bool isFLS1File = false;
            if ((dataSource).Peek() == 'F') { StartIndex = 4; isFLS1File = true; }
            char[] data = (dataSource).ReadToEnd().Substring(StartIndex).ToCharArray();
            // close the char file immediately so we can either write back to it OR
            // so other processes can access it.
            dataSource.Close();

            // We SHOULD only be reading encoded files;
            // just in case some are decoded, though, we test.
            if (isFLS1File) {
                char[] gene = "Gene".ToCharArray();
                for (int i = 0; i < data.GetLength(0); i++) {
                    pilotStream.WriteByte((byte)(data[i] ^ (((gene[i % 4] + i) % 256) | 0x80)));
                }
            }
            else {
                for (int i = 0; i < data.GetLength(0); i++) {
                    pilotStream.WriteByte((byte)(data[i]));
                }
            }
            pilotStream.Position = 0;
            return this.RawData.ToString();
        }

        /// <summary>
        /// Saves the loaded game data back to the original FL file.
        /// If it cannot be saved for some reason, this method returns False.
        /// </summary>
        /// <returns></returns>
        public bool Save() {
            return this.SaveTo(MySourceFile);
        }

        /// <summary>
        /// Saves data to a file
        /// </summary>
        /// <param name="newPath">Path to the new file</param>
        /// <returns>true if successful, otherwise false.</returns>
        public bool SaveTo(string newPath) {
            try {
                FileStream target =
                    new FileStream(newPath,
                                   FileMode.Create,
                                   FileAccess.Write);
                pilotStream.WriteTo(target);
                target.Flush();
                target.Close();
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Name of the folder where the pilot's file is stored.
        /// </summary>
        public string AccountFolder { get { return null; } }
        private string MyAccountFolder;

        /// <summary>
        /// Base name (without the .fl) of the file where the pilot is stored.
        /// </summary>
        public string BaseFileName { get { return null; } }
        private string MyBaseFileName;

    }

    public class PilotInformation
    {

        public string Name { get { return MyName; } }
        private string MyName;
        public ArrayList Equipment { get { return MyEquipment; } }
        private ArrayList MyEquipment;
        public ArrayList Cargo { get { return MyCargo; } }
        private ArrayList MyCargo;
        public string Ship { get { return MyShip; } }
        private string MyShip;
        private StringCollection MultiTypeNames; // these are "types" that may occur several times
        private StringCollection UnparsedData;
        private bool MySkipVisits = true;
        private bool MyTerminateAtVisits = true;
        private StringDictionary MyProperties;
        private StringDictionary MyVisits;
        private StringDictionary MyHouses;
        private StringCollection MyVisitedSystems;
        private StringCollection MyVisitedHoles;
        private StringCollection MyVisitedBases;
        private StringCollection MyNpcLockedGates;
        private StringCollection MyLockedGates;
        private System.Collections.ArrayList MyEquippedItems;
        public ArrayList EquippedItems { get { return MyEquippedItems; } }




        public PilotInformation() {
            this.MyEquipment = new ArrayList();
            this.MyCargo = new ArrayList();
            this.MyProperties = new StringDictionary();
            this.MultiTypeNames = new StringCollection();
            this.UnparsedData = new StringCollection();
            this.MultiTypeNames.Add("base_cargo"); this.MultiTypeNames.Add("base_equip");
            this.MultiTypeNames.Add("base_visited"); this.MultiTypeNames.Add("cargo");
            this.MultiTypeNames.Add("equip"); this.MultiTypeNames.Add("holes_visited");
            this.MultiTypeNames.Add("house"); this.MultiTypeNames.Add("locked_gate");
            this.MultiTypeNames.Add("sys_visited"); this.MultiTypeNames.Add("wg");
            this.MultiTypeNames.Add("visit");
            this.MyVisits = new StringDictionary();
            this.MyHouses = new StringDictionary();
            this.MyVisitedSystems = new StringCollection();
            this.MyVisitedHoles = new StringCollection();
            this.MyVisitedBases = new StringCollection();
            this.MyNpcLockedGates = new StringCollection();
            this.MyLockedGates = new StringCollection();
            this.MyEquippedItems = new ArrayList();
        }


        public void FromStream(MemoryStream dataStream) {
            TextReader tr = new StreamReader(dataStream);
            //TextReader tr = new StringReader(dataStream.ToString());
            char[] delimiters = "=,".ToCharArray();
            while (tr.Peek() != -1) {
                string datum = tr.ReadLine();
                int commentPosition = datum.IndexOf(";");
                if (commentPosition == 0) {
                    continue;
                }
                else if (commentPosition > 1) {
                    datum = datum.Substring(0, commentPosition);
                }
                string[] data = datum.Split(delimiters);
                data[0] = data[0].Trim();
                //MyEquipment.Add(data);
                if (datum.IndexOf("=") == -1) {
                    // this is bogus data; for now just call it unparsed.
                    UnparsedData.Add(datum);
                }
                else if (data[0] == "name") {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    string name = datum.Substring(datum.IndexOf("=") + 1).Trim();
                    try {
                        for (int i = 0; i < name.Length; i += 4) {
                            sb.Append((char)int.Parse(name.Substring(i, 4), System.Globalization.NumberStyles.HexNumber));
                        }
                        this.MyName = sb.ToString();
                    }
                    catch {
                        this.MyName = name;
                    }
                }
                else if (MultiTypeNames.Contains(data[0])) {
                    if (data[0] == "visit") {
                        if (this.MySkipVisits) { /*do nothing at present*/}
                        else if (this.MyTerminateAtVisits) { break; }
                        else {
                            // we need to add visit info. This is in form
                            // visit = 2242919488, 41
                            this.MyVisits[data[1].Trim()] = data[2].Trim();
                        }
                    }
                    else if ((data[0] == "equip") | (data[0] == "base_equip")) {
                        EquippedItem ei = new EquippedItem();
                        MyEquipment.Add(data[1].Trim());
                        if (data.Length < 3) {
                            MyEquippedItems.Add(ei.FromData(data[1].Trim()));
                        }
                        else {
                            MyEquippedItems.Add(ei.FromData(data[1].Trim(), data[2].Trim()));
                        }

                    }
                    else if ((data[0] == "cargo") | (data[0] == "base_cargo")) {
                        MyEquipment.Add(data[1].Trim());
                    }
                    else if (data[0] == "house") {
                        this.MyHouses[data[2].Trim()] = data[1].Trim();
                    }
                    else if (data[0] == "sys_visited") {
                        this.MyVisitedSystems.Add(data[1].Trim());
                    }
                    else if (data[0] == "base_visited") {
                        this.MyVisitedBases.Add(data[1].Trim());
                    }
                    else if (data[0] == "holes_visited") {
                        this.MyVisitedHoles.Add(data[1].Trim());
                    }
                    else if (data[0] == "npc_locked_gate") {
                        this.MyNpcLockedGates.Add(data[1].Trim());
                    }
                    else if (data[0] == "locked_gate") {
                        this.MyLockedGates.Add(data[1].Trim());
                    }



                }

                // The following are all single-instance items
                else {
                    if (data[0] == "ship_archetype") {
                        MyShip = data[1].Trim();
                        MyEquipment.Add(MyShip);
                    }
                }
            }
        }

        /// <summary>
        /// base name of the file containing the pilot information
        /// </summary>
        public string FileName {
            get { return MyFileName; }
            set { MyFileName = value; }
        }private string MyFileName;

        /// <summary>
        /// Base name of the folder containing the pilot's information.
        /// </summary>
        public string AccountFolder {
            get { return MyBaseFolder; }
            set { MyBaseFolder = value; }
        }private string MyBaseFolder;

        /// <summary>
        /// If true, we skip recording the visit lines
        /// </summary>
        public bool SkipVisits {
            get { return MySkipVisits; }
            set { MySkipVisits = value; }
        }

        /// <summary>
        /// If true (default) then when we hit the first visit line we quit processing.
        /// </summary>
        public bool TerminateAtVisits {
            get { return true; }
            set { MyTerminateAtVisits = value; }
        }

    }

    public struct EquippedItem
    {
        public string Hardpoint; public string Id;
        public EquippedItem FromData(string hp, string id) {
            Hardpoint = hp; Id = id;
            return this;
        }
        public EquippedItem FromData(string id) {
            Hardpoint = string.Empty; Id = id;
            return this;
        }

    }

    /*SINGLE-INSTANCE
base
base_hull_status
body
can_dock
can_tl
com_body
com_head
com_lefthand
com_righthand
description
head
interface
last_base
lefthand
money
name
num_kills
num_misn_failures
num_misn_successes
rank
rep_group
righthand
rm_completed
ship_archetype
ship_type_killed
system
total_cash_earned
total_time_played
tstamp
voiceinterface

MULTI-INSTANCE
base_cargo
base_equip
X base_visited
cargo
equip
X holes_visited
X house
X locked_gate
X npc_locked_gate
X sys_visited
wg
X visit
     */



}
