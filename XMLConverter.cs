using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FLNotePad
{
    public partial class XMLConverter : Form
    {
        public XMLConverter() {
            InitializeComponent();
            shipTypeSelector();
        }

        protected void shipTypeSelector() {
            if (shipTypeComboBox.Text.Equals("")
                ^ (!shipTypeComboBox.Text.Equals("")
                && !shipTypeComboBox.Text.Equals("FIGHTER")
                && !shipTypeComboBox.Text.Equals("FREIGHTER")
                && !shipTypeComboBox.Text.Equals("TRANSPORT")
                && !shipTypeComboBox.Text.Equals("GUNBOAT")
                && !shipTypeComboBox.Text.Equals("CRUISER")
                && !shipTypeComboBox.Text.Equals("CAPITAL"))) {
                this.shipTypeComboBox.Text = "FIGHTER";
            }
            if (shipTypeComboBox.Text.Equals("FIGHTER")) {
                this.gunCountNumericUpDown.Minimum = 0;
                this.gunCountNumericUpDown.Maximum = 8;
                this.turretCountNumericUpDown.Minimum = 0;
                this.turretCountNumericUpDown.Maximum = 8;
                this.torpCountNumericUpDown.Minimum = 0;
                this.torpCountNumericUpDown.Maximum = 4;
                this.missileCountNumericUpDown.Minimum = 0;
                this.missileCountNumericUpDown.Maximum = 8;
                this.maxCargoNumericUpDown.Minimum = 20;
                this.maxCargoNumericUpDown.Maximum = 250;
                this.maxCargoNumericUpDown.Increment = 5;
                this.maxShieldMountsNumericUpDown.Minimum = 0;
                this.maxShieldMountsNumericUpDown.Maximum = 2;
                this.maxDisruptorCountNumericUpDown.Minimum = 0;
                this.maxDisruptorCountNumericUpDown.Maximum = 4;
                this.counterMeasureCounterNumericUpDown.Minimum = 0;
                this.counterMeasureCounterNumericUpDown.Maximum = 2;
                this.mineCounterNumericUpDown.Minimum = 0;
                this.mineCounterNumericUpDown.Maximum = 2;
                this.maxArmorNumericUpDown.Minimum = 1000;
                this.maxArmorNumericUpDown.Maximum = 30000;
            }
            else if (shipTypeComboBox.Text.Equals("FREIGHTER")) {
                this.gunCountNumericUpDown.Minimum = 3;
                this.gunCountNumericUpDown.Maximum = 5;
                this.turretCountNumericUpDown.Minimum = 3;
                this.turretCountNumericUpDown.Maximum = 5;
                this.torpCountNumericUpDown.Minimum = 0;
                this.torpCountNumericUpDown.Maximum = 2;
                this.missileCountNumericUpDown.Minimum = 0;
                this.missileCountNumericUpDown.Maximum = 4;
                this.maxCargoNumericUpDown.Minimum = 750;
                this.maxCargoNumericUpDown.Maximum = 1000;
                this.maxCargoNumericUpDown.Increment = 5;
                this.maxShieldMountsNumericUpDown.Minimum = 1;
                this.maxShieldMountsNumericUpDown.Maximum = 2;
                this.maxDisruptorCountNumericUpDown.Minimum = 0;
                this.maxDisruptorCountNumericUpDown.Maximum = 0;
                this.counterMeasureCounterNumericUpDown.Minimum = 0;
                this.counterMeasureCounterNumericUpDown.Maximum = 2;
                this.mineCounterNumericUpDown.Minimum = 0;
                this.mineCounterNumericUpDown.Maximum = 1;
                this.maxArmorNumericUpDown.Minimum = 1000;
                this.maxArmorNumericUpDown.Maximum = 30000;
            }
            else if (shipTypeComboBox.Text.Equals("TRANSPORT")) {
                this.gunCountNumericUpDown.Minimum = 0;
                this.gunCountNumericUpDown.Maximum = 0;
                this.turretCountNumericUpDown.Minimum = 0;
                this.turretCountNumericUpDown.Maximum = 12;
                this.torpCountNumericUpDown.Minimum = 0;
                this.torpCountNumericUpDown.Maximum = 0;
                this.missileCountNumericUpDown.Minimum = 0;
                this.missileCountNumericUpDown.Maximum = 0;
                this.maxCargoNumericUpDown.Minimum = 750000;
                this.maxCargoNumericUpDown.Maximum = 1000000;
                this.maxCargoNumericUpDown.Increment = 500;
                this.maxShieldMountsNumericUpDown.Minimum = 0;
                this.maxShieldMountsNumericUpDown.Maximum = 2;
                this.maxDisruptorCountNumericUpDown.Minimum = 0;
                this.maxDisruptorCountNumericUpDown.Maximum = 0;
                this.counterMeasureCounterNumericUpDown.Minimum = 0;
                this.counterMeasureCounterNumericUpDown.Maximum = 2;
                this.mineCounterNumericUpDown.Minimum = 0;
                this.mineCounterNumericUpDown.Maximum = 0;
                this.maxArmorNumericUpDown.Minimum = 100000;
                this.maxArmorNumericUpDown.Maximum = 300000;
            }
            else if (shipTypeComboBox.Text.Equals("GUNBOAT")) {
                this.gunCountNumericUpDown.Minimum = 0;
                this.gunCountNumericUpDown.Maximum = 10;
                this.turretCountNumericUpDown.Minimum = 0;
                this.turretCountNumericUpDown.Maximum = 8;
                this.torpCountNumericUpDown.Minimum = 0;
                this.torpCountNumericUpDown.Maximum = 2;
                this.missileCountNumericUpDown.Minimum = 0;
                this.missileCountNumericUpDown.Maximum = 4;
                this.maxCargoNumericUpDown.Minimum = 7500;
                this.maxCargoNumericUpDown.Maximum = 10000;
                this.maxCargoNumericUpDown.Increment = 50;
                this.maxShieldMountsNumericUpDown.Minimum = 0;
                this.maxShieldMountsNumericUpDown.Maximum = 2;
                this.maxDisruptorCountNumericUpDown.Minimum = 0;
                this.maxDisruptorCountNumericUpDown.Maximum = 2;
                this.counterMeasureCounterNumericUpDown.Minimum = 0;
                this.counterMeasureCounterNumericUpDown.Maximum = 2;
                this.mineCounterNumericUpDown.Minimum = 0;
                this.mineCounterNumericUpDown.Maximum = 0;
                this.maxArmorNumericUpDown.Minimum = 100000;
                this.maxArmorNumericUpDown.Maximum = 500000;
            }
            else if (shipTypeComboBox.Text.Equals("CRUISER")) {
                this.gunCountNumericUpDown.Minimum = 0;
                this.gunCountNumericUpDown.Maximum = 15;
                this.turretCountNumericUpDown.Minimum = 0;
                this.turretCountNumericUpDown.Maximum = 16;
                this.torpCountNumericUpDown.Minimum = 0;
                this.torpCountNumericUpDown.Maximum = 0;
                this.missileCountNumericUpDown.Minimum = 0;
                this.missileCountNumericUpDown.Maximum = 0;
                this.maxCargoNumericUpDown.Minimum = 75000;
                this.maxCargoNumericUpDown.Maximum = 100000;
                this.maxCargoNumericUpDown.Increment = 500;
                this.maxShieldMountsNumericUpDown.Minimum = 0;
                this.maxShieldMountsNumericUpDown.Maximum = 3;
                this.maxDisruptorCountNumericUpDown.Minimum = 0;
                this.maxDisruptorCountNumericUpDown.Maximum = 0;
                this.counterMeasureCounterNumericUpDown.Minimum = 0;
                this.counterMeasureCounterNumericUpDown.Maximum = 0;
                this.mineCounterNumericUpDown.Minimum = 0;
                this.mineCounterNumericUpDown.Maximum = 0;
                this.maxArmorNumericUpDown.Minimum = 1000000;
                this.maxArmorNumericUpDown.Maximum = 3000000;
            }
            else if (shipTypeComboBox.Text.Equals("CAPITAL")) {
                this.gunCountNumericUpDown.Minimum = 0;
                this.gunCountNumericUpDown.Maximum = 20;
                this.turretCountNumericUpDown.Minimum = 12;
                this.turretCountNumericUpDown.Maximum = 22;
                this.torpCountNumericUpDown.Minimum = 0;
                this.torpCountNumericUpDown.Maximum = 6;
                this.missileCountNumericUpDown.Minimum = 0;
                this.missileCountNumericUpDown.Maximum = 6;
                this.maxCargoNumericUpDown.Minimum = 750000;
                this.maxCargoNumericUpDown.Maximum = 1000000;
                this.maxCargoNumericUpDown.Increment = 500;
                this.maxShieldMountsNumericUpDown.Minimum = 1;
                this.maxShieldMountsNumericUpDown.Maximum = 6;
                this.maxDisruptorCountNumericUpDown.Minimum = 0;
                this.maxDisruptorCountNumericUpDown.Maximum = 6;
                this.counterMeasureCounterNumericUpDown.Minimum = 0;
                this.counterMeasureCounterNumericUpDown.Maximum = 2;
                this.mineCounterNumericUpDown.Minimum = 0;
                this.mineCounterNumericUpDown.Maximum = 6;
                this.maxArmorNumericUpDown.Minimum = 3000000;
                this.maxArmorNumericUpDown.Maximum = 9000000;
            }
            if (shipClassNumericUpDown.Value.Equals(0)) {
                string shieldType1 = "fighter"; //shields use this one
                string shieldType2 = "fighter"; //power uses this one
                shieldTypeTextBox1.Text = shieldType1.ToString();
                shieldTypeTextBox2.Text = shieldType2.ToString();
            }
            else if (shipClassNumericUpDown.Value.Equals(1)) {
                string shieldType1 = "elite";
                string shieldType2 = "fighter";
                shieldTypeTextBox1.Text = shieldType1.ToString();
                shieldTypeTextBox2.Text = shieldType2.ToString();
            }
            else if (shipClassNumericUpDown.Value.Equals(2)) {
                string shieldType1 = "freighter";
                string shieldType2 = "freighter";
                shieldTypeTextBox1.Text = shieldType1.ToString();
                shieldTypeTextBox2.Text = shieldType2.ToString();
            }
            else if (shipClassNumericUpDown.Value.Equals(3)) {
                string shieldType1 = "elite";
                string shieldType2 = "elite";
                shieldTypeTextBox1.Text = shieldType1.ToString();
                shieldTypeTextBox2.Text = shieldType2.ToString();
            }
            CalculateManeuverability();
        }

        /// <summary>
        /// Generates FLMM XML string for a Freelancer item.
        /// </summary>
        /// <param name="displayName">In-game display name for the item.</param>
        /// <param name="Other">Read the comments by the variable definitions...</param>
        /// <returns>FLMM XML-formatted string ready for parsing by FLMM to insert into Freelancer.</returns>
        public string MakeFLMMString(string idsName,       //Example: Sigrún
                                     string shipModel,     //Example: 76-AKRM-H5
                                     string shipDesc,      //Example: Rheinland Light Fighter
                                     string shipDetails,   //Example: The biggest baddest ship ever made...
                                     string gMount,        //Gun Mounts
                                     string tMount,        //Turret Mounts
                                     string missile,       //Missile Mounts
                                     string torp,          //Torpedo mounts
                                     string armor,         //Amount of armor
                                     string maxCap,        //Max number of Capacitors
                                     string maxBot,        //Max number of Nanobots
                                     string cargo,         //Max Cargo
                                     string optEquip,      //Most efficient weapon level (base configuration)
                                     string maxEquip,      //Max weapon level
                                     string auxComp,       //Additional components that can be installed
                                     string mine,          //Max mines mountable (if any)
                                     string counter,       //Max countermeasures mountable (if any)
                                     string disruptor)     //Max Disruptors mountable (if any)
        {
            StringBuilder sb = new StringBuilder();
            shipTypeSelector();
            CalculateManeuverability();
            sb.Append("<script>\n");
            sb.Append("<scriptversion>\n");
            sb.Append("1.4\n");
            sb.Append("</scriptversion>\n");
            sb.Append("<data file=\"data\\ships\\shiparch.ini\" method=\"append\">\n");
            sb.Append("<source>\n");
            sb.Append(";////////////////////////////////////////////////////ADDED BY XMLConverter\n");
            sb.Append(";/////////////////////////////////////////////////////////////By ArchKaine\n");
            sb.Append("[Ship]\n");
            sb.Append("ids_name = 0 ;GENERATESTRRES(\"" + idsName + "\")\n");
            sb.Append("ids_info = 0 ;GENERATEXMLRES(\"<xml><RDL><PUSH/><TEXT> </TEXT><PARA/>");
            sb.Append("<TRA data=\"1\" mask=\"1\" def=\"-2\"/><JUST loc=\"center\"/><TEXT>Stats</TEXT><PARA/>");
            sb.Append("<TRA data=\"0\" mask=\"1\" def=\"-1\"/><JUST loc=\"left\"/><TEXT> </TEXT><PARA/>");
            sb.Append("<TEXT>Gun/Turret Mounts: " + gMount + "/" + tMount + "</TEXT><PARA/>");
            sb.Append("<TEXT>Ordinance Mounts: " + missile + "/" + torp + "</TEXT><PARA/>");
            sb.Append("<TEXT>Armor: " + armor + "</TEXT><PARA/>");
            sb.Append("<TEXT>Max Capacitors/Nanobots: " + maxCap + "/" + maxBot + "</TEXT><PARA/>");
            sb.Append("<TEXT>Cargo Capacity: " + cargo);
            sb.Append("</TEXT><PARA/>");
            sb.Append("<TEXT>Optimal/Max Equip. Lvl: " + optEquip + "/" + maxEquip);
            sb.Append("</TEXT><PARA/>");
            sb.Append("<TEXT>Auxiliary Components: " + auxComp);
            sb.Append("</TEXT><PARA/>");
            sb.Append("<TEXT>Additional Equipment: M(" + mine + "),CM(" + counter + "),CD(" + disruptor);
            sb.Append(")</TEXT>");
            sb.Append("<PARA/>");
            sb.Append("<PARA/>");
            sb.Append("<POP/></RDL></xml>\")\n;//////////SPACER\n");
            sb.Append("ids_info1 = 0 ;GENERATEXMLRES(\"<xml><RDL><PUSH/>");
            sb.Append("<TRA data=\"1\" mask=\"1\" def=\"-2\"/><JUST loc=\"center\"/>");
            sb.Append("<TEXT>" + shipModel + " \"" + idsName + "\" " + shipDesc);
            sb.Append("</TEXT><PARA/>");
            sb.Append("<TRA data=\"0\" mask=\"1\" def=\"-1\"/><JUST loc=\"left\"/><TEXT> </TEXT><PARA/>");
            sb.Append("<TEXT>" + shipDetails);
            sb.Append("</TEXT><PARA/>");
            sb.Append("<POP/></RDL></xml>\")\n;//////////SPACER\n");
            sb.Append("ids_info2 = 0 ;GENERATEXMLRES(\"<xml><RDL><PUSH/><TEXT> </TEXT><PARA/>");
            sb.Append("<TEXT>Gun/Turret Mounts: </TEXT><PARA/>");
            sb.Append("<TEXT>Ordinance Mounts: </TEXT><PARA/>");
            sb.Append("<TEXT>Armor: </TEXT><PARA/>");
            sb.Append("<TEXT>Max Capacitors/Nanobots: </TEXT><PARA/>");
            sb.Append("<TEXT>Cargo Capacity: </TEXT><PARA/>");
            sb.Append("<TEXT>Optimal/Max Equip. Lvl: </TEXT><PARA/>");
            sb.Append("<TEXT>Auxiliary Components: </TEXT><PARA/>");
            sb.Append("<TEXT>Additional Equipment: </TEXT>");
            sb.Append("<POP/></RDL></xml>\")\n;//////////SPACER\n");
            sb.Append("ids_info3 = 0 ;GENERATEXMLRES(\"<xml><RDL><PUSH/><TEXT> </TEXT><PARA/>");
            sb.Append("<TEXT>" + gMount + "/" + tMount);
            sb.Append("</TEXT><PARA/>");
            sb.Append("<TEXT>" + missile + "/" + torp);
            sb.Append("</TEXT><PARA/>");
            sb.Append("<TEXT>" + armor);
            sb.Append("</TEXT><PARA/>");
            sb.Append("<TEXT>" + maxCap + "/" + maxBot);
            sb.Append("</TEXT><PARA/>");
            sb.Append("<TEXT>" + cargo);
            sb.Append("</TEXT><PARA/>");
            sb.Append("<TEXT>" + optEquip + "/" + maxEquip);
            sb.Append("</TEXT><PARA/>");
            sb.Append("<TEXT>" + auxComp);
            sb.Append("</TEXT><PARA/>");
            sb.Append("<TEXT>M(" + mine + "),CM(" + counter + "),CD(" + disruptor);
            sb.Append(")</TEXT>");
            sb.Append("<POP/></RDL></xml>\")\n;//////////SPACER\n");
            sb.Append("ship_class = " + shipClassNumericUpDown.Text + "\n");
            sb.Append("nickname = " + shipArchNickNameTextBox.Text + "\n");
            sb.Append("msg_id_prefix = " + messageIDComboBox.Text + "\n");
            sb.Append("mission_property = can_use_berths\n");
            sb.Append("LODranges = 0, 25000\n");
            sb.Append("type = " + shipTypeComboBox.Text + "\n");
            sb.Append(@";///////////////////////////////////////////////////////////\n");
            sb.Append(";/////////////////////////////////CMP, MAT, and cockpit info\n");
            sb.Append(";///////////////////////////////////////////////////////////\n");
            try {
                sb.Append("DA_archetype = " + cmpFilePathTextBox.Text.Substring(49, cmpFilePathTextBox.Text.Length - 49) + "\n");
                sb.Append("material_library = " + matFilePathTextBox.Text.Substring(49, matFilePathTextBox.Text.Length - 49) + "\n");
            }
            catch (Exception) {

                //throw;
            }
            sb.Append("material_library = fx\\envmapbasic.mat\n");
            sb.Append("envmap_material = envmapbasic\n");
            try {
                sb.Append("cockpit = " + cockpitIniFilePathTextBox.Text.Substring(49, cockpitIniFilePathTextBox.Text.Length - 49) + "\n");
            }
            catch (Exception) {

                //throw;
            }
            sb.Append("pilot_mesh = " + pilotMeshComboBox.Text + "\n");
            sb.Append(";///////////////////////////////////////////////////////////\n");
            sb.Append(";///////////////////////////////////////////Bots, Bats, Info\n");
            sb.Append(";///////////////////////////////////////////////////////////\n");
            sb.Append("nanobot_limit = " + maxCapacitorTextBox.Text + "\n");
            sb.Append("shield_battery_limit = " + maxNanobotTextBox.Text + "\n");
            sb.Append(";///////////////////////////////////////////////////////////\n");
            sb.Append(";////////////////////////////////////Ship Mass and Hold Size\n");
            sb.Append(";///////////////////////////////////////////////////////////\n");
            sb.Append("mass = " + shipMassNumericUpDown.Value + "\n");
            sb.Append("hold_size = " + maxCargoNumericUpDown.Value + "\n");
            sb.Append("linear_drag = 1.000000\n");
            sb.Append(";///////////////////////////////////////////////////////////\n");
            sb.Append("fuse = intermed_damage_smallship01, 0.000000, 400\n");
            sb.Append("fuse = intermed_damage_smallship02, 0.000000, 200\n");
            sb.Append("fuse = intermed_damage_smallship03, 0.000000, 133\n");
            sb.Append(";///////////////////////////////////////////////////////////\n");
            sb.Append(";/////////////////////////////////////////////Max Bank Angle\n");
            sb.Append(";///////////////////////////////////////////////////////////\n");
            sb.Append("max_bank_angle = " + maxBankAngleNumericUpDown.Text + "\n");
            sb.Append(@";///////////////////////////////////////////////////////////\n");
            sb.Append("camera_offset = 13, 47\n");
            sb.Append("camera_angular_acceleration = 0.050000\n");
            sb.Append("camera_horizontal_turn_angle = 17\n");
            sb.Append("camera_vertical_turn_up_angle = 5\n");
            sb.Append("camera_vertical_turn_down_angle = 25\n");
            sb.Append("camera_turn_look_ahead_slerp_amount = 1.000000\n");
            sb.Append(";///////////////////////////////////////////////////////////\n");
            sb.Append(";////////////////////////////////////////Hits and Expl. Info\n");
            sb.Append(";///////////////////////////////////////////////////////////\n");
            sb.Append("hit_pts = " + maxArmorNumericUpDown.Value + "\n");
            sb.Append("explosion_arch = explosion_li_freighter\n");
            sb.Append(";///////////////////////////////////////////////////////////\n");
            sb.Append("surface_hit_effects = 0, small_hull_hit_light01, small_hull_hit_light02, small_hull_hit_light03\n");
            sb.Append("surface_hit_effects = 150, small_hull_hit_medium01, small_hull_hit_medium02, small_hull_hit_medium03\n");
            sb.Append("surface_hit_effects = 300, small_hull_hit_heavy01, small_hull_hit_heavy02, small_hull_hit_heavy03\n");
            sb.Append(";///////////////////////////////////////////////////////////\n");
            sb.Append(";//////////////////////////////////////////Maneuvering Stats\n");
            sb.Append(";////////////////////////Determined by a spreadsheet by Arch\n");
            sb.Append(";///////////////////////////////////////////////////////////\n");
            sb.Append("steering_torque = " + torqueNumericUpDown.Text + "," + torqueNumericUpDown.Text + "," + torqueNumericUpDown.Text + "\n");
            sb.Append("angular_drag = " + dragNumericUpDown.Text + "," + dragNumericUpDown.Text + "," + dragNumericUpDown.Text + "\n");
            sb.Append("rotation_inertia = " + inertiaNumericUpDown.Text + "," + inertiaNumericUpDown.Text + "," + inertiaNumericUpDown.Text + "\n");
            sb.Append(";///////////////////////////////////////////////////////////\n");
            sb.Append("nudge_force = 90000\n");
            sb.Append("strafe_force = 94000\n");
            sb.Append("strafe_power_usage = 2\n");
            sb.Append("bay_door_anim = Sc_open baydoor\n");
            sb.Append("bay_doors_open_snd = cargo_doors_open\n");
            sb.Append("bay_doors_close_snd = cargo_doors_close\n");
            sb.Append("HP_bay_surface = HpBayDoor01\n");
            sb.Append("HP_bay_external = HpBayDoor02\n");
            sb.Append("HP_tractor_source = HpTractor_Source\n");

            sb.Append("num_exhaust_nozzles = " + engineCountNumericUpDown.Value + "\n");

            string sType1 = shieldTypeTextBox1.Text;
            string sType2 = shieldTypeTextBox2.Text;
            sb.Append("shield_link = l_" + sType1 + "_shield01");
            sb.Append(", HpMount");
            if (maxShieldMountsNumericUpDown.Value > 0)
                for (int j = 1; j < maxShieldMountsNumericUpDown.Value + 1; ++j) {
                    sb.Append(", ");
                    sb.Append("HpShield");
                    if (j < 10) { sb.Append("0"); }
                    sb.Append(j);
                }
            if (maxSpecialMountsNumericUpDown.Value > 0)
                for (int j = 1; j < maxSpecialMountsNumericUpDown.Value + 1; ++j) {
                    sb.Append(", ");
                    sb.Append("HpSpecial");
                    if (j < 10) { sb.Append("0"); }
                    sb.Append(j);
                }
            if (canMountPowerGenCheckBox.Checked) {
                sb.Append(", SpConnect01");
            }
            sb.Append("\n");
            sb.Append("hp_type = hp_" + sType2 + "_shield_generator");
            sb.Append(", HpCloak");
            if (maxSpecialMountsNumericUpDown.Value > 0) {
                for (int j = 1; j < maxSpecialMountsNumericUpDown.Value + 1; ++j) {
                    sb.Append(", ");
                    sb.Append("HpSpecial");
                    if (j < 10) { sb.Append("0"); }
                    sb.Append(j);
                }
            }
            sb.Append("\n");



            if (maxShieldMountsNumericUpDown.Value > 0) {
                for (decimal i = maxShieldLevelNumericUpDown.Value; i > 0; --i) {
                    //StringBuilder sb = new StringBuilder();
                    sb.Append("hp_type = hp_" + sType1 + "_shield_special_" + i);
                    for (int j = 1; j < maxShieldMountsNumericUpDown.Value + 1; ++j) {
                        sb.Append(", ");
                        sb.Append("HpShield");
                        if (j < 10) { sb.Append("0"); }
                        sb.Append(j);
                    }
                    sb.Append("\n");
                    //return (sb.ToString());
                }
            }
            if (adminShipCheckBox.Checked) {
                //This is for the admin shields that only admin ships can mount
                sb.Append("hp_type = hp_freighter_shield_special_3");
                for (int j = 1; j < maxShieldMountsNumericUpDown.Value + 1; ++j) {
                    sb.Append(", ");
                    sb.Append("HpShield");
                    if (j < 10) { sb.Append("0"); }
                    sb.Append(j);
                }
                sb.Append("\n");
            }

            if (canMountPowerGenCheckBox.Checked) {
                sb.Append(@"hp_type = hp_fighter_shield_special_2, SpConnect01" + "\n");
            }

            if (gunCountNumericUpDown.Value > 0) {
                decimal k = 0;
                if (maxEquipComboBox.Text.Equals("")) { k = 2; } else if (maxEquipComboBox.Text.Equals("Lght")) { k = 2; } else if (maxEquipComboBox.Text.Equals("Med")) { k = 4; } else if (maxEquipComboBox.Text.Equals("Hvy")) { k = 6; } else if (maxEquipComboBox.Text.Equals("Vhvy")) { k = 8; } else if (maxEquipComboBox.Text.Equals("Aslt")) { k = 10; }
                for (decimal i = k; i > 0; --i) {
                    sb.Append("hp_type = hp_gun_special_" + i);
                    for (int j = 1; j < gunCountNumericUpDown.Value + 1; ++j) {
                        sb.Append(", ");
                        sb.Append("HpWeapon");
                        if (j < 10) { sb.Append("0"); }
                        sb.Append(j);
                    }
                    sb.Append("\n");
                }
            }
            if (turretCountNumericUpDown.Value > 0) {
                decimal m = 0;
                if (maxEquipComboBox.Text.Equals("")) { m = 2; } else if (maxEquipComboBox.Text.Equals("Lght")) { m = 2; } else if (maxEquipComboBox.Text.Equals("Med")) { m = 4; } else if (maxEquipComboBox.Text.Equals("Hvy")) { m = 6; } else if (maxEquipComboBox.Text.Equals("Vhvy")) { m = 8; } else if (maxEquipComboBox.Text.Equals("Aslt")) { m = 10; }
                for (decimal i = m; i > 0; --i) {
                    sb.Append("hp_type = hp_turret_special_" + i);
                    for (int j = 1; j < turretCountNumericUpDown.Value + 1; ++j) {
                        sb.Append(", ");
                        sb.Append("HpTurret");
                        if (j < 10) { sb.Append("0"); }
                        sb.Append(j);
                    }
                    sb.Append("\n");
                }
            }

            if (torpCountNumericUpDown.Value > 0) {
                for (int i = 2; i > 0; --i) {
                    sb.Append("hp_type = hp_torpedo_special_" + i);
                    for (int j = 1; j < torpCountNumericUpDown.Value + 1; ++j) {
                        sb.Append(", ");
                        sb.Append("HpTorpedo");
                        if (j < 10) { sb.Append("0"); }
                        sb.Append(j);
                    }
                    sb.Append("\n");
                }
            }

            if (thrusterCountNumericUpDown.Value > 0) {
                sb.Append("hp_type = hp_thruster");
                for (int j = 1; j < thrusterCountNumericUpDown.Value + 1; ++j) {
                    sb.Append(", ");
                    sb.Append("HpThruster");
                    if (j < 10) { sb.Append("0"); }
                    sb.Append(j);
                }
                sb.Append("\n");
            }

            if (mineCounterNumericUpDown.Value > 0) {
                sb.Append("hp_type = hp_mine_dropper");
                for (int j = 1; j < mineCounterNumericUpDown.Value + 1; ++j) {
                    sb.Append(", ");
                    sb.Append("HpMine");
                    if (j < 10) { sb.Append("0"); }
                    sb.Append(j);
                }
                sb.Append("\n");
            }

            if (counterMeasureCounterNumericUpDown.Value > 0) {
                sb.Append("hp_type = hp_countermeasure_dropper");
                for (int j = 1; j < mineCounterNumericUpDown.Value + 1; ++j) {
                    sb.Append(", ");
                    sb.Append("HpCM");
                    if (j < 10) { sb.Append("0"); }
                    sb.Append(j);
                }
                sb.Append("\n");
            }
            sb.Append("</source>\n");
            sb.Append("</data>\n");
            return (sb.ToString());
        }
        protected bool CalculateManeuverability() {
            decimal guns = gunCountNumericUpDown.Value;
            decimal turrets = turretCountNumericUpDown.Value;
            decimal missiles = missileCountNumericUpDown.Value;
            decimal torps = torpCountNumericUpDown.Value;
            decimal mines = mineCounterNumericUpDown.Value;
            decimal cm = counterMeasureCounterNumericUpDown.Value;
            decimal cargo = maxCargoNumericUpDown.Value;
            decimal shields = maxShieldMountsNumericUpDown.Value;
            decimal hits = maxArmorNumericUpDown.Value;
            decimal power = (guns + turrets + missiles + torps + mines + cm) * 4;
            decimal mass = (guns * 4) + (turrets * 4) + (torps * 8) + (power / 25) + (hits / 250) + cargo + (shields * 75);
            if (spaceSuperiorityCheckBox.Checked & mass > shipMassNumericUpDown.Minimum) {
                int I = 0;
                //mass = shipMassNumericUpDown.Value / 2;
                //decimal mass2 = mass;
                shipMassNumericUpDown.Value = mass / 2;
                I++;
            }
            else if (mass < shipMassNumericUpDown.Minimum) {
                mass = shipMassNumericUpDown.Minimum;
            }
            else if (mass > shipMassNumericUpDown.Maximum) {
                mass = shipMassNumericUpDown.Maximum;
            }
            else {
                decimal mass2 = mass;
                shipMassNumericUpDown.Value = mass2;
            }

            int base_torque = 2000000;
            int base_drag = 1000000;
            int base_inertia = 100000;
            if (shipTypeComboBox.Text.Equals("")) {
                decimal mass2 = shipMassNumericUpDown.Value;
                decimal steering_torque = base_torque - (mass2 * 500);
                decimal angular_drag = base_drag;
                decimal rotation_inertia = base_inertia;
                torqueNumericUpDown.Text = steering_torque.ToString();
                dragNumericUpDown.Text = angular_drag.ToString();
                inertiaNumericUpDown.Text = rotation_inertia.ToString();
            }
            else if (shipTypeComboBox.Text.Equals("FIGHTER")) {
                decimal mass2 = shipMassNumericUpDown.Value;
                decimal steering_torque = base_torque - (mass2 * 500);
                decimal angular_drag = base_drag;
                decimal rotation_inertia = base_inertia;
                torqueNumericUpDown.Text = steering_torque.ToString();
                dragNumericUpDown.Text = angular_drag.ToString();
                inertiaNumericUpDown.Text = rotation_inertia.ToString();
            }
            else if (shipTypeComboBox.Text.Equals("FREIGHTER")) {
                decimal mass2 = shipMassNumericUpDown.Value;
                decimal steering_torque = base_torque - (mass2 * 650);
                decimal angular_drag = base_drag;
                decimal rotation_inertia = base_inertia;
                torqueNumericUpDown.Text = steering_torque.ToString();
                dragNumericUpDown.Text = angular_drag.ToString();
                inertiaNumericUpDown.Text = rotation_inertia.ToString();
            }
            else if (shipTypeComboBox.Text.Equals("TRANSPORT")) {
                decimal mass2 = shipMassNumericUpDown.Value;
                decimal steering_torque = base_torque * 1000 - (mass2 * 700);
                decimal angular_drag = base_drag * 1000;
                decimal rotation_inertia = base_inertia * 1000;
                torqueNumericUpDown.Text = steering_torque.ToString();
                dragNumericUpDown.Text = angular_drag.ToString();
                inertiaNumericUpDown.Text = rotation_inertia.ToString();
            }
            else if (shipTypeComboBox.Text.Equals("GUNBOAT")) {
                decimal mass2 = shipMassNumericUpDown.Value;
                decimal steering_torque = base_torque * 100 - (mass2 * 5850);
                decimal angular_drag = base_drag * 100;
                decimal rotation_inertia = base_inertia * 100;
                torqueNumericUpDown.Text = steering_torque.ToString();
                dragNumericUpDown.Text = angular_drag.ToString();
                inertiaNumericUpDown.Text = rotation_inertia.ToString();
            }
            else if (shipTypeComboBox.Text.Equals("CRUISER")) {
                decimal mass2 = shipMassNumericUpDown.Value;
                decimal steering_torque = base_torque * 100 - (mass2 * 750);
                decimal angular_drag = base_drag * 100;
                decimal rotation_inertia = base_inertia * 100;
                torqueNumericUpDown.Text = steering_torque.ToString();
                dragNumericUpDown.Text = angular_drag.ToString();
                inertiaNumericUpDown.Text = rotation_inertia.ToString();
            }
            else if (shipTypeComboBox.Text.Equals("CAPITAL")) {
                decimal mass2 = shipMassNumericUpDown.Value;
                decimal steering_torque = base_torque * 1000 - (mass2 * 750);
                decimal angular_drag = base_drag * 1000;
                decimal rotation_inertia = base_inertia * 1000;
                torqueNumericUpDown.Text = steering_torque.ToString();
                dragNumericUpDown.Text = angular_drag.ToString();
                inertiaNumericUpDown.Text = rotation_inertia.ToString();
            }
            return (true);
        }

        private void UpdateShipSelectionButton_Click(object sender, EventArgs e) {
            shipTypeSelector();
        }

        private void button1_Click(object sender, EventArgs e) {
            string idsName = shipNameTextBox.Text;
            string ShipModel = shipModelTextBox.Text;
            string ShipDesc = shipRoleTextBox.Text;
            string ShipDetails = shipDetailsTextBox.Text;
            string GMount = gunCountNumericUpDown.Text;
            string TMount = turretCountNumericUpDown.Text;
            string Missile = missileCountNumericUpDown.Text;
            string Torp = torpCountNumericUpDown.Text;
            string Armor = maxArmorNumericUpDown.Text;
            string MaxCap = maxCapacitorTextBox.Text;
            string MaxBot = maxNanobotTextBox.Text;
            string Cargo = maxCargoNumericUpDown.Text;
            string OptEquip = optEquipComboBox.Text;
            string MaxEquip = maxEquipComboBox.Text;
            string AuxComp = auxComponentsTextBox.Text;
            string Mine = mineCounterNumericUpDown.Text;
            string Counter = counterMeasureCounterNumericUpDown.Text;
            string Disruptor = maxDisruptorCountNumericUpDown.Text;

            searchableRichTextBox1.Text = this.MakeFLMMString(
                idsName,       //Example: Sigrún
                ShipModel,     //Example: 76-AKRM-H5
                ShipDesc,      //Example: Rheinland Light Fighter
                ShipDetails,   //Example: The biggest baddest ship ever made...
                GMount,        //Gun Mounts
                TMount,        //Turret Mounts
                Missile,       //Missile Mounts
                Torp,          //Torpedo mounts
                Armor,         //Amount of armor
                MaxCap,        //Max number of Capacitors
                MaxBot,        //Max number of Nanobots
                Cargo,         //Max Cargo
                OptEquip,      //Most efficient weapon level (base configuration)
                MaxEquip,      //Max weapon level
                AuxComp,       //Additional components that can be installed
                Mine,          //Max mines mountable (if any)
                Counter,       //Max countermeasures mountable (if any)
                Disruptor);    //Max Disruptors mountable (if any)
        }

        private void button2_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                cmpFilePathTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                matFilePathTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                cockpitIniFilePathTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                pilotMeshComboBox.Text = openFileDialog1.FileName;
            }
        }
    }
}
