using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace ClassEditor
{
    public partial class Form1 : Form
    {
        Mem m = new Mem();

        bool attached = false;

        int[] perks = { 148, 151, 150, 149, 152, 157, 155, 156, 153, 154, 158, 161, 159, 162, 160, 163 };
        string[] classOffsets = { "02F9AFFA", "02F9B028", "02F9B029", "02F9B02A", "02F9B008",
        "02F9B02B", "02F9B02C", "02F9B02D", "02F9B016", "02F9B017",
        "02F9B018","02F9B019", "02F9B01A", "02F9B01B", "02F9B01C",
        "02F9B024", "02F9B025", "02F9B026"};

        int[] weaponValues = { 189, 197, 201, 193, 129, 113, 109, 117, 125, 101, 121, 97, 105, 53, 61, 73, 69, 65, 57, 77, 229, 173, 177, 169, 181, 145, 149, 153, 157, 12, 6, 8, 10, 4, 116, 118, 106, 108, 110 };

        string[] weapons = { "M27", "SCAR-H", "SMR", "M8A1", "AN-94", "MP7", "PDW-57", "Vector K10", "MSMC", "Chicom CQB", "Skorpion EVO", "Peacekeeper", "Assault Shield", "SVU-AS", "DSR 50", "Ballista", "XPR-50", "Mk 48", "QBB LSW", "LSAT", "HAMR", "Five-seven", "Tac-45", "B23R", "Executioner", "KAP-40", "Crossbow", "Ballistic Knife", "SMAW", "FHJ-18 AA", "RPG" };

        string[] shotgunAttachments = { "Reflex", "Long Barrel", "Fast Mag", "Laser Sight", "Stock", "Suppressor", "Extended Clip", "Quickdraw", "MMS" };
        string[] assaultRiflesAttachments = { "Reflex", "Quickdraw", "Fast Mag", "ACOG", "Force Grip", "Stock", "Target Finder", "Laser Sight", "Select Fire", "EOTech", "Suppressor", "FMJ", "Hybrid Optic", "Extended Clip", "Launcher", "MMS" };
        string[] submachineGunAttachments = { "Reflex", "Laser Sight", "Suppressor", "Fast Mag", "EOTech", "Force Grip", "Quickdraw", "FMJ", "Long Barrel", "Target Finder", "Stock", "Extended Clip", "Select Fire", "Rapid Fire", "MMS" };
        string[] sniperRifleAttachments = { "Suppressor", "Ballsitic CPU", "Zoom", "Fast Mag", "FMJ", "ACOG", "Extended Clip", "Laser Sight", "Dual Band" };
        string[] LMGAttachments = { "EOTech", "Fore Grip", "FMJ", "Reflex", "Quickdraw", "Target Finder", "Stock", "ACOG", "Laser Sight", "Suppressor", "Zoom", "Extended Clip", "Hybrid Optic", "Rapid Fire", "Dual Band" };
        string[] pistolAttachments = { "Reflex", "Extended Clip", "Laser Sight", "Long Barrel", "FMJ", "Fast Mag", "Suppressor", "Knife", "Dual Wield"};
        string[] executionerAttachments = { "Reflex", "Laser Sight", "Long Barrel", "FMJ", "Fast Mag", "Suppressor", "Knife", "Dual Wield" };
        string[] specialAttachments = { "Reflex", "ACOG", "Dual Band", "Zoom", "Tri-Bolt"};
        string[] launcherAttachments = { };
        byte[][] selectedSet = { new byte[] { 0, 0 }, new byte[] { 64, 0 }, new byte[] { 128, 0 }, new byte[] { 192, 0 }, new byte[] { 0, 1 }, new byte[] { 64, 1 }, new byte[] { 128, 1 }, new byte[] { 192, 1 }, new byte[] { 0, 2 }, new byte[] { 64, 2 } };

        public Form1()
        {
            InitializeComponent();
        }

        private void enableAll(bool b)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Label) { } else 
                {
                    c.Enabled = b;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enableAll(false);
            classNamesCB.SelectedIndex = 0;
            foreach (ComboBox cb in new ComboBox[] { perksCB/*, perks1CB, perks2CB */}) {
                cb.SelectedIndex = 0;
            }
            //MessageBox.Show(m.ReadByte(classOffsets[8]).ToString());
            /*for (int i = 0;  i < perks.Length; i++)
            {
                if ((m.ReadByte(classOffsets[8])) == perks[i])
                {
                    perks1CB.SelectedIndex = i;
                }
                if ((m.ReadByte(classOffsets[11])) == perks[i])
                {
                    perks2CB.SelectedIndex = i;
                }
            }*/
        }

        private void perksCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = perksCB.SelectedIndex;
            bool perk1 = false;
            bool perk2 = false;
            for (int i = 0; i < perks.Length; i++)
            {
                if ((m.ReadByte(classOffsets[8 + index])) == perks[i])
                {
                    perks1CB.SelectedIndex = i;
                    perk1 = true;
                }
                if ((m.ReadByte(classOffsets[11 + index])) == perks[i])
                {
                    perks2CB.SelectedIndex = i;
                    perk2 = true;
                }
            }
            if (!perk1)
            {
                perks1CB.SelectedIndex = -1;
            }
            if (!perk2)
            {
                perks2CB.SelectedIndex = -1;
            }
        }

        private void perkChange(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            int index = perksCB.SelectedIndex;
            ComboBox[] cbs = new ComboBox[] { perks1CB, perks2CB };
            int[] values = new int[] { 8, 11 };

            for (int i = 0; i < cbs.Length; i++)
            {
                if (cbs[i] == combo)
                {
                    if (combo.SelectedIndex == -1)
                        return;
                    m.WriteMemory(classOffsets[values[i] + index], "byte", perks[combo.SelectedIndex].ToString("X2"));
                }
            }
        }

        private void attachmentComboBox(int index, ComboBox[] comboBoxes)
        {
            string[] items = { };
            foreach (ComboBox cb in comboBoxes)
            {
                cb.Items.Clear();
                if (index >= 0 && index <= 3) //shotguns
                {
                    items = shotgunAttachments;
                }

                if (index >= 4 && index <= 12) //ars
                {
                    items = assaultRiflesAttachments;
                }

                if (index >= 13 && index <= 19) //smgs
                {
                    items = submachineGunAttachments;
                }

                if (index == 20)
                {
                    items = new string[] { };
                }

                if (index >= 21 && index <= 24) //snipers
                {
                    items = sniperRifleAttachments;
                }

                if (index >= 25 && index <= 28) //lmgs
                {
                    items = LMGAttachments;
                }

                if (index >= 29 && index <= 33) //pistols
                {
                    items = pistolAttachments;
                }

                if (index == 32)//executioner
                {
                    items = executionerAttachments;
                }

                if (index == 34) //specials - crossbow
                {
                    items = specialAttachments;
                }

                if (index == 35) //ballistic knife
                {
                    items = launcherAttachments;
                }

                if (index >= 36 && index <= 38) //launchers
                {
                    items = launcherAttachments;
                }

                cb.Items.AddRange(items);
            }
        }

        private void primaryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = primaryCB.SelectedIndex;
            int value;
            if (index == -1)
                return;

            attachmentComboBox(index, new ComboBox[] { pAttachment1CB, pAttachment2CB, pAttachment3CB });

            if (index <= 28)
                value = weaponValues[index];
            else
                value = (weaponValues[index]) * 2;
            m.WriteMemory(classOffsets[0], "byte", value.ToString("X2"));
        }

        private void secondaryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = secondaryCB.SelectedIndex;
            int value;
            if (index == -1)
                return;

            attachmentComboBox(index, new ComboBox[] { sAttachment1CB, sAttachment2CB });

            if (index >= 28)
                value = weaponValues[index];
            else
                value = (weaponValues[index]) / 2;
            m.WriteMemory(classOffsets[4], "byte", value.ToString("X2"));
        }

        private byte[] indexBytes(int index)
        {
            int value = (index * 64) + 64;
            int value2 = 0;
            while (value > 192)
            {
                value = value - 256;
                value2 = value2 + 1;
            }
            return new byte[] { Convert.ToByte(value), Convert.ToByte(value2)};
        }

        private void pAttachment(object sender, EventArgs e)
        {
            byte[] a1 = indexBytes(pAttachment1CB.SelectedIndex);
            byte[] a2 = indexBytes(pAttachment2CB.SelectedIndex);
            byte[] a3 = indexBytes(pAttachment3CB.SelectedIndex);
            byte[] s1 = indexBytes(sAttachment1CB.SelectedIndex);
            a2[0] += a1[1];
            a3[0] += a2[1];
            a3[1] += s1[0];
            m.WriteBytes((0x02F9B027).ToString("X8"), new byte[] { a1[0], a2[0], a3[0], a3[1] });
        }

        private void sAttachment(object sender, EventArgs e)
        {
            byte[] a3 = indexBytes(pAttachment3CB.SelectedIndex);
            byte[] s1 = indexBytes(sAttachment1CB.SelectedIndex);
            byte[] s2 = indexBytes(sAttachment2CB.SelectedIndex);
            s1[0] += a3[1];
            s2[0] += s1[1];
            m.WriteBytes((0x02F9B02A).ToString("X8"), new byte[] { s1[0], s2[0], s2[1] });
        }

        int setSelected = 0;

        private void gameCheckTimer_Tick(object sender, EventArgs e)
        {
            Process[] proc = Process.GetProcessesByName("plutonium-bootstrapper-win32");
            if (proc.Length == 0)
            {
                //MessageBox.Show("Plutonium is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status("Game is not open", Color.Red);
                attached = false;
                enableAll(false);
                return;
            }

            if (!attached)
            {
                foreach (Process p in proc)
                {
                    if (p.MainWindowTitle != "")
                    {
                        m.OpenProcess(p.Id);
                        //MessageBox.Show("Oppened Plutonium");
                        switch (m.ReadString("13689BEC", "", 16))
                        {
                            case "t6mp":
                                status("Attached", Color.Green);
                                enableAll(true);
                                attached = true;
                                return;
                            case "t6zm":
                                status("T6 Zombies is not supported.", Color.Red);
                                return;
                            case "iw5mp":
                                status("IW5 is not supported.", Color.Red);
                                return;
                            case "t5mp":
                                status("T5 is not supported.", Color.Red);
                                return;
                            case "t5zm":
                                status("T5 is not supported.", Color.Red);
                                return;
                            case "t4mp":
                                status("T4 is not supported.", Color.Red);
                                return;
                            case "t4zm":
                                status("T4 is not supported.", Color.Red);
                                return;
                        }
                        break;
                    }
                }
            }
        }

        public void status(string message, Color color)
        {
            statusTextLabel.ForeColor = color;
            statusTextLabel.Text = message;
        }

        private void exportClassesButton_Click(object sender, EventArgs e)
        {
            byte[] bytes = m.ReadBytes("02F9AFFA", 519);
            string code = Convert.ToBase64String(bytes);
            Clipboard.SetText(code);
            MessageBox.Show("Class set copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void importClassesButton_Click(object sender, EventArgs e)
        {
            string code = Clipboard.GetText();
            if (code.Length != 692)
            {
                MessageBox.Show("Clipboard is not a valid class set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to import from clipboard?\nThis wil overwrite the selected class set and if the data is malformed it may cause your game to crash.\nThis can NOT be undone.", "Waring!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                byte[] bytes = Convert.FromBase64String(code);
                m.WriteBytes("02F9AFFA", bytes);
            }
        }

        private async void ghostButton_Click(object sender, EventArgs e)
        {
            m.WriteMemory("02F9B00E", "byte", "82");
            m.WriteMemory("02F9B000", "bytes", "4 65");
            m.WriteMemory("02F9B02D", "bytes", "40 50");
        }

        private void classSetsButton_Click(object sender, EventArgs e)
        {
            byte[] bytes = m.ReadBytes("02F9AFF8", 2);
            for (int i = 0; i < selectedSet.Length; i++)
            {
                int value = 0x02FB4BB7 + (i * 701);
                if (bytes[0] == selectedSet[i][0] && bytes[1] == selectedSet[i][1])
                {
                    string name = classSetNameTB.Text.Trim();
                    m.WriteMemory(value.ToString("X"), "bytes", "0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0");
                    m.WriteMemory(value.ToString("X"), "string", name);
                }
            }
        }

        private void tacticalCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tacticalCB.SelectedIndex == -1) 
                return;
            int lethal = 0;
            if (m.ReadByte((0x02F9B01E - 1).ToString("X8")) == 1) 
                lethal = 1;
            if (m.ReadByte((0x02F9B01E - 1).ToString("X8")) == 2)
                lethal = 3;
            byte b = Convert.ToByte((tacticalCB.SelectedIndex * 8) + lethal);
            byte[] bytes = { b, 10, 8 };
            if (m.ReadByte((0x02F9B01E + 1).ToString("X8")) != 0)
            {
                m.WriteMemory(0x02F9B01E.ToString("X8"), "byte", b.ToString("X"));
                return;
            }/*
            if (m.ReadBytes((0x02F9B01E).ToString("X8"), 2) == new byte[] { 0, 0})
            {
                bytes[1] = 0;
                bytes[2] = 0;
            }*/
            m.WriteBytes(0x02F9B01E.ToString("X8"), bytes);
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                if (Process.GetProcessesByName("plutonium-bootstrapper-win32").Length == 0)
                    return;
                int primary = m.ReadByte(classOffsets[0]);
                int secondary = m.ReadByte(classOffsets[4]);

                byte[] bytes = m.ReadBytes("02F9AFF8", 2); //selected class set

                for (int i = 0; i < selectedSet.Length; i++)
                {
                    if (bytes[0] == selectedSet[i][0] && bytes[1] == selectedSet[i][1])
                    {
                        setSelected = i;
                        if (groupBox1.Text != "Class Set " + (i + 1).ToString())
                        {
                            groupBox1.Text = "Class Set " + (i + 1).ToString();
                            int value = 0x02FB4BB7 + (i * 701);
                            classSetNameTB.Text = m.ReadString(value.ToString("X"), "", 16);
                            classNameTB.Text = m.ReadString((0x02FB4DD4 + ((setSelected * 701) + (classNamesCB.SelectedIndex * 16))).ToString("X8"), "", 16);

                            for (int n = 0; n < weaponValues.Length; n++)
                            {
                                if (weaponValues[n] == primary && primaryCB.SelectedIndex != n)
                                {
                                    primaryCB.SelectedIndex = n;
                                    break;
                                }
                                else if (n == weaponValues.Length - 1)
                                {
                                    primaryCB.SelectedIndex = -1;
                                    break;
                                }
                            }
                            for (int s = 0; s < weaponValues.Length; s++)
                            {
                                if (s >= 28)
                                    value = weaponValues[s];
                                else
                                    value = (weaponValues[s]) / 2;
                                if (value == secondary && secondaryCB.SelectedIndex != s)
                                {
                                    secondaryCB.SelectedIndex = s;
                                    break;
                                }
                                else if (s == weaponValues.Length - 1)
                                {
                                    secondaryCB.SelectedIndex = -1;
                                    break;
                                }
                            }

                            int[] values = { 8, 11 };
                            ComboBox[] cb = new ComboBox[] { perks1CB, perks2CB};
                            for (int n = 0; n < cb.Length; n++)
                            {
                                for (int p = 0; p < perks.Length; p++)
                                {
                                    int slot = m.ReadByte(classOffsets[values[n] + perksCB.SelectedIndex]);

                                    if (slot == perks[p])
                                    {
                                        cb[n].SelectedIndex = p;
                                        break;
                                    }
                                    else if (p == perks.Length - 1)
                                    {
                                        cb[n].SelectedIndex = -1;
                                        break;
                                    }
                                }
                            }
                            for (int t = 0; t < 5; t++)
                            {
                                byte[] tactical = m.ReadBytes(0x02F9B01E.ToString("X8"), 2);
                                int v = t * 8;
                                if (tactical[0] >= v && tactical[0] <= v + 7 && tactical[1] != 0)
                                {
                                    tacticalCB.SelectedIndex = t;
                                    break;
                                } else if (t == 4)
                                {
                                    tacticalCB.SelectedIndex = -1;
                                }
                            }
                        }
                        break;
                    }
                }
            }
        }

        private void classNameButton_Click(object sender, EventArgs e)
        {
            classNameTimer.Start();
            MessageBox.Show("You need to switch to a different class set for the name to apply.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        byte[] previousSet = new byte[] { 1, 1};

        private void classNameTimer_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                byte[] bytes = m.ReadBytes("02F9AFF8", 2);
                if (previousSet[0] == 1 && previousSet[1] == 1)
                {
                    previousSet[0] = bytes[0];
                    previousSet[1] = bytes[1];
                }
                if (previousSet[0] != bytes[0] || previousSet[1] != bytes[1])
                {
                    string value = (0x02FB4DD4 + (setSelected * 701) + (classNamesCB.SelectedIndex * 16)).ToString("X8");
                    m.WriteMemory(value, "bytes", "0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0");
                    m.WriteMemory(value, "string", classNameTB.Text);
                    classNameTimer.Stop();
                    previousSet = new byte[] { 1, 1};
                    return;
                }
                previousSet[0] = bytes[0];
                previousSet[1] = bytes[1];
            }
        }

        private void classNamesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = (0x02FB4DD4 + (setSelected * 701) + (classNamesCB.SelectedIndex * 16)).ToString("X8");
            classNameTB.Text = m.ReadString(value, "", 16);
        }

        private void exportClassButton_Click(object sender, EventArgs e)
        {
            byte[] bytes = m.ReadBytes("02F9AFFA", 51);
            string code = Convert.ToBase64String(bytes);
            Clipboard.SetText(code);
            MessageBox.Show("Class set copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void importClassButton_Click(object sender, EventArgs e)
        {
            string code = Clipboard.GetText();
            MessageBox.Show(code.Length.ToString());
            if (code.Length != 68)
            {
                MessageBox.Show("Clipboard is not a valid class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to import from clipboard?\nThis wil overwrite the selected class set if the data is malformed it may cause your game to crash.\nThis can NOT be undone.", "Waring!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                byte[] bytes = Convert.FromBase64String(code);
                m.WriteBytes("02F9AFFA", bytes);
            }
        }
    }
}
