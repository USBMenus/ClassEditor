namespace ClassEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.perks1CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.perks2CB = new System.Windows.Forms.ComboBox();
            this.perksCB = new System.Windows.Forms.ComboBox();
            this.primaryCB = new System.Windows.Forms.ComboBox();
            this.secondaryCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pAttachment1CB = new System.Windows.Forms.ComboBox();
            this.pAttachment2CB = new System.Windows.Forms.ComboBox();
            this.pAttachment3CB = new System.Windows.Forms.ComboBox();
            this.sAttachment1CB = new System.Windows.Forms.ComboBox();
            this.sAttachment2CB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gameCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.exportSetButton = new System.Windows.Forms.Button();
            this.importClassesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ghostButton = new System.Windows.Forms.Button();
            this.importClassButton = new System.Windows.Forms.Button();
            this.exportClassButton = new System.Windows.Forms.Button();
            this.tacticalCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.classNameTB = new System.Windows.Forms.TextBox();
            this.classNameButton = new System.Windows.Forms.Button();
            this.classNamesCB = new System.Windows.Forms.ComboBox();
            this.classSetNameTB = new System.Windows.Forms.TextBox();
            this.classSetsButton = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.classNameTimer = new System.Windows.Forms.Timer(this.components);
            this.statusTextLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // perks1CB
            // 
            this.perks1CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perks1CB.FormattingEnabled = true;
            this.perks1CB.Items.AddRange(new object[] {
            "Lightweight",
            "Hardline",
            "Blind Eye",
            "Flak Jacket",
            "Ghost",
            "Toughness",
            "Cold Blooded",
            "Fast Hands",
            "Hard Wire",
            "Scavenger",
            "Dexterity",
            "Extreme Conditioning",
            "Engineer",
            "Tactical Mask",
            "Dead Silence",
            "Awareness"});
            this.perks1CB.Location = new System.Drawing.Point(88, 67);
            this.perks1CB.Name = "perks1CB";
            this.perks1CB.Size = new System.Drawing.Size(121, 21);
            this.perks1CB.TabIndex = 0;
            this.perks1CB.SelectedIndexChanged += new System.EventHandler(this.perkChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Perks:";
            // 
            // perks2CB
            // 
            this.perks2CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perks2CB.FormattingEnabled = true;
            this.perks2CB.Items.AddRange(new object[] {
            "Lightweight",
            "Hardline",
            "Blind Eye",
            "Flak Jacket",
            "Ghost",
            "Toughness",
            "Cold Blooded",
            "Fast Hands",
            "Hard Wire",
            "Scavenger",
            "Dexterity",
            "Extreme Conditioning",
            "Engineer",
            "Tactical Mask",
            "Dead Silence",
            "Awareness"});
            this.perks2CB.Location = new System.Drawing.Point(215, 67);
            this.perks2CB.Name = "perks2CB";
            this.perks2CB.Size = new System.Drawing.Size(121, 21);
            this.perks2CB.TabIndex = 0;
            this.perks2CB.SelectedIndexChanged += new System.EventHandler(this.perkChange);
            // 
            // perksCB
            // 
            this.perksCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perksCB.FormattingEnabled = true;
            this.perksCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.perksCB.Location = new System.Drawing.Point(49, 67);
            this.perksCB.Name = "perksCB";
            this.perksCB.Size = new System.Drawing.Size(33, 21);
            this.perksCB.TabIndex = 0;
            this.perksCB.SelectedIndexChanged += new System.EventHandler(this.perksCB_SelectedIndexChanged);
            // 
            // primaryCB
            // 
            this.primaryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.primaryCB.FormattingEnabled = true;
            this.primaryCB.Items.AddRange(new object[] {
            "R870 MCS",
            "S12",
            "KSG",
            "M1216",
            "MTAR",
            "Type 25",
            "SWAT-556",
            "FAL OSW",
            "M27",
            "SCAR-H",
            "SMR",
            "M8A1",
            "AN-94",
            "MP7",
            "PDW-57",
            "Vector K10",
            "MSMC",
            "Chicom CQB",
            "Skorpion EVO",
            "Peacekeeper",
            "Assault Shield",
            "SVU-AS",
            "DSR 50",
            "Ballista",
            "XPR-50",
            "Mk 48",
            "QBB LSW",
            "LSAT",
            "HAMR",
            "Five-seven",
            "Tac-45",
            "B23R",
            "Executioner",
            "KAP-40",
            "Crossbow",
            "Ballistic Knife",
            "SMAW",
            "FHJ-18 AA",
            "RPG"});
            this.primaryCB.Location = new System.Drawing.Point(88, 13);
            this.primaryCB.Name = "primaryCB";
            this.primaryCB.Size = new System.Drawing.Size(121, 21);
            this.primaryCB.TabIndex = 0;
            this.primaryCB.SelectedIndexChanged += new System.EventHandler(this.primaryCB_SelectedIndexChanged);
            // 
            // secondaryCB
            // 
            this.secondaryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secondaryCB.FormattingEnabled = true;
            this.secondaryCB.Items.AddRange(new object[] {
            "R870 MCS",
            "S12",
            "KSG",
            "M1216",
            "MTAR",
            "Type 25",
            "SWAT-556",
            "FAL OSW",
            "M27",
            "SCAR-H",
            "SMR",
            "M8A1",
            "AN-94",
            "MP7",
            "PDW-57",
            "Vector K10",
            "MSMC",
            "Chicom CQB",
            "Skorpion EVO",
            "Peacekeeper",
            "Assault Shield",
            "SVU-AS",
            "DSR 50",
            "Ballista",
            "XPR-50",
            "Mk 48",
            "QBB LSW",
            "LSAT",
            "HAMR",
            "Five-seven",
            "Tac-45",
            "B23R",
            "Executioner",
            "KAP-40",
            "Crossbow",
            "Ballistic Knife",
            "SMAW",
            "FHJ-18 AA",
            "RPG"});
            this.secondaryCB.Location = new System.Drawing.Point(88, 40);
            this.secondaryCB.Name = "secondaryCB";
            this.secondaryCB.Size = new System.Drawing.Size(121, 21);
            this.secondaryCB.TabIndex = 0;
            this.secondaryCB.SelectedIndexChanged += new System.EventHandler(this.secondaryCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Secondary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Attachments:";
            // 
            // pAttachment1CB
            // 
            this.pAttachment1CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pAttachment1CB.FormattingEnabled = true;
            this.pAttachment1CB.Location = new System.Drawing.Point(290, 13);
            this.pAttachment1CB.Name = "pAttachment1CB";
            this.pAttachment1CB.Size = new System.Drawing.Size(121, 21);
            this.pAttachment1CB.TabIndex = 0;
            this.pAttachment1CB.SelectedIndexChanged += new System.EventHandler(this.pAttachment);
            // 
            // pAttachment2CB
            // 
            this.pAttachment2CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pAttachment2CB.FormattingEnabled = true;
            this.pAttachment2CB.Location = new System.Drawing.Point(417, 13);
            this.pAttachment2CB.Name = "pAttachment2CB";
            this.pAttachment2CB.Size = new System.Drawing.Size(121, 21);
            this.pAttachment2CB.TabIndex = 0;
            this.pAttachment2CB.SelectedIndexChanged += new System.EventHandler(this.pAttachment);
            // 
            // pAttachment3CB
            // 
            this.pAttachment3CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pAttachment3CB.FormattingEnabled = true;
            this.pAttachment3CB.Location = new System.Drawing.Point(544, 13);
            this.pAttachment3CB.Name = "pAttachment3CB";
            this.pAttachment3CB.Size = new System.Drawing.Size(121, 21);
            this.pAttachment3CB.TabIndex = 0;
            this.pAttachment3CB.SelectedIndexChanged += new System.EventHandler(this.pAttachment);
            // 
            // sAttachment1CB
            // 
            this.sAttachment1CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sAttachment1CB.FormattingEnabled = true;
            this.sAttachment1CB.Location = new System.Drawing.Point(290, 40);
            this.sAttachment1CB.Name = "sAttachment1CB";
            this.sAttachment1CB.Size = new System.Drawing.Size(121, 21);
            this.sAttachment1CB.TabIndex = 0;
            this.sAttachment1CB.SelectedIndexChanged += new System.EventHandler(this.sAttachment);
            // 
            // sAttachment2CB
            // 
            this.sAttachment2CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sAttachment2CB.FormattingEnabled = true;
            this.sAttachment2CB.Location = new System.Drawing.Point(417, 40);
            this.sAttachment2CB.Name = "sAttachment2CB";
            this.sAttachment2CB.Size = new System.Drawing.Size(121, 21);
            this.sAttachment2CB.TabIndex = 0;
            this.sAttachment2CB.SelectedIndexChanged += new System.EventHandler(this.sAttachment);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Attachments:";
            // 
            // gameCheckTimer
            // 
            this.gameCheckTimer.Enabled = true;
            this.gameCheckTimer.Tick += new System.EventHandler(this.gameCheckTimer_Tick);
            // 
            // exportSetButton
            // 
            this.exportSetButton.Location = new System.Drawing.Point(336, 19);
            this.exportSetButton.Name = "exportSetButton";
            this.exportSetButton.Size = new System.Drawing.Size(163, 23);
            this.exportSetButton.TabIndex = 3;
            this.exportSetButton.Text = "Export Set To Clipboard";
            this.exportSetButton.UseVisualStyleBackColor = true;
            this.exportSetButton.Click += new System.EventHandler(this.exportClassesButton_Click);
            // 
            // importClassesButton
            // 
            this.importClassesButton.Location = new System.Drawing.Point(505, 19);
            this.importClassesButton.Name = "importClassesButton";
            this.importClassesButton.Size = new System.Drawing.Size(163, 23);
            this.importClassesButton.TabIndex = 3;
            this.importClassesButton.Text = "Import Set From Clipboard";
            this.importClassesButton.UseVisualStyleBackColor = true;
            this.importClassesButton.Click += new System.EventHandler(this.importClassesButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.classSetNameTB);
            this.groupBox1.Controls.Add(this.classSetsButton);
            this.groupBox1.Controls.Add(this.importClassesButton);
            this.groupBox1.Controls.Add(this.exportSetButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 244);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Class Set";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ghostButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.perks1CB);
            this.groupBox2.Controls.Add(this.importClassButton);
            this.groupBox2.Controls.Add(this.exportClassButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.primaryCB);
            this.groupBox2.Controls.Add(this.tacticalCB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pAttachment1CB);
            this.groupBox2.Controls.Add(this.pAttachment2CB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.sAttachment1CB);
            this.groupBox2.Controls.Add(this.perks2CB);
            this.groupBox2.Controls.Add(this.pAttachment3CB);
            this.groupBox2.Controls.Add(this.perksCB);
            this.groupBox2.Controls.Add(this.sAttachment2CB);
            this.groupBox2.Controls.Add(this.secondaryCB);
            this.groupBox2.Location = new System.Drawing.Point(0, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 150);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Class 1";
            // 
            // ghostButton
            // 
            this.ghostButton.Location = new System.Drawing.Point(9, 121);
            this.ghostButton.Name = "ghostButton";
            this.ghostButton.Size = new System.Drawing.Size(101, 23);
            this.ghostButton.TabIndex = 5;
            this.ghostButton.Text = "Ghosts Camo";
            this.ghostButton.UseVisualStyleBackColor = true;
            this.ghostButton.Click += new System.EventHandler(this.ghostButton_Click);
            // 
            // importClassButton
            // 
            this.importClassButton.Location = new System.Drawing.Point(508, 121);
            this.importClassButton.Name = "importClassButton";
            this.importClassButton.Size = new System.Drawing.Size(163, 23);
            this.importClassButton.TabIndex = 3;
            this.importClassButton.Text = "Import Class 1 From Clipboard";
            this.importClassButton.UseVisualStyleBackColor = true;
            this.importClassButton.Click += new System.EventHandler(this.importClassButton_Click);
            // 
            // exportClassButton
            // 
            this.exportClassButton.Location = new System.Drawing.Point(339, 121);
            this.exportClassButton.Name = "exportClassButton";
            this.exportClassButton.Size = new System.Drawing.Size(163, 23);
            this.exportClassButton.TabIndex = 3;
            this.exportClassButton.Text = "Export Class 1 To Clipboard";
            this.exportClassButton.UseVisualStyleBackColor = true;
            this.exportClassButton.Click += new System.EventHandler(this.exportClassButton_Click);
            // 
            // tacticalCB
            // 
            this.tacticalCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tacticalCB.FormattingEnabled = true;
            this.tacticalCB.Items.AddRange(new object[] {
            "Combat Axe",
            "Semtex",
            "C4",
            "Bouncing Betty",
            "Claymore"});
            this.tacticalCB.Location = new System.Drawing.Point(88, 94);
            this.tacticalCB.Name = "tacticalCB";
            this.tacticalCB.Size = new System.Drawing.Size(121, 21);
            this.tacticalCB.TabIndex = 0;
            this.tacticalCB.SelectedIndexChanged += new System.EventHandler(this.tacticalCB_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tactical:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.classNameTB);
            this.groupBox3.Controls.Add(this.classNameButton);
            this.groupBox3.Controls.Add(this.classNamesCB);
            this.groupBox3.Location = new System.Drawing.Point(0, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 196);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Class Names";
            // 
            // classNameTB
            // 
            this.classNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNameTB.Location = new System.Drawing.Point(51, 18);
            this.classNameTB.MaxLength = 16;
            this.classNameTB.Name = "classNameTB";
            this.classNameTB.Size = new System.Drawing.Size(166, 21);
            this.classNameTB.TabIndex = 6;
            // 
            // classNameButton
            // 
            this.classNameButton.Location = new System.Drawing.Point(223, 17);
            this.classNameButton.Name = "classNameButton";
            this.classNameButton.Size = new System.Drawing.Size(152, 23);
            this.classNameButton.TabIndex = 5;
            this.classNameButton.Text = "Set Class Name";
            this.classNameButton.UseVisualStyleBackColor = true;
            this.classNameButton.Click += new System.EventHandler(this.classNameButton_Click);
            // 
            // classNamesCB
            // 
            this.classNamesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classNamesCB.FormattingEnabled = true;
            this.classNamesCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.classNamesCB.Location = new System.Drawing.Point(6, 18);
            this.classNamesCB.Name = "classNamesCB";
            this.classNamesCB.Size = new System.Drawing.Size(39, 21);
            this.classNamesCB.TabIndex = 0;
            this.classNamesCB.SelectedIndexChanged += new System.EventHandler(this.classNamesCB_SelectedIndexChanged);
            // 
            // classSetNameTB
            // 
            this.classSetNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classSetNameTB.Location = new System.Drawing.Point(6, 21);
            this.classSetNameTB.MaxLength = 16;
            this.classSetNameTB.Name = "classSetNameTB";
            this.classSetNameTB.Size = new System.Drawing.Size(166, 21);
            this.classSetNameTB.TabIndex = 6;
            this.classSetNameTB.Text = "Made by: USBMenus";
            // 
            // classSetsButton
            // 
            this.classSetsButton.Location = new System.Drawing.Point(178, 20);
            this.classSetsButton.Name = "classSetsButton";
            this.classSetsButton.Size = new System.Drawing.Size(152, 23);
            this.classSetsButton.TabIndex = 5;
            this.classSetsButton.Text = "Set Class Set Name";
            this.classSetsButton.UseVisualStyleBackColor = true;
            this.classSetsButton.Click += new System.EventHandler(this.classSetsButton_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // classNameTimer
            // 
            this.classNameTimer.Tick += new System.EventHandler(this.classNameTimer_Tick);
            // 
            // statusTextLabel
            // 
            this.statusTextLabel.AutoSize = true;
            this.statusTextLabel.Location = new System.Drawing.Point(52, 259);
            this.statusTextLabel.Name = "statusTextLabel";
            this.statusTextLabel.Size = new System.Drawing.Size(17, 13);
            this.statusTextLabel.TabIndex = 2;
            this.statusTextLabel.Text = "//";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 259);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 276);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusTextLabel);
            this.Controls.Add(this.statusLabel);
            this.Name = "Form1";
            this.Text = "Plutonium T6 Class Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox perks1CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox perks2CB;
        private System.Windows.Forms.ComboBox perksCB;
        private System.Windows.Forms.ComboBox primaryCB;
        private System.Windows.Forms.ComboBox secondaryCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pAttachment1CB;
        private System.Windows.Forms.ComboBox pAttachment2CB;
        private System.Windows.Forms.ComboBox pAttachment3CB;
        private System.Windows.Forms.ComboBox sAttachment1CB;
        private System.Windows.Forms.ComboBox sAttachment2CB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer gameCheckTimer;
        private System.Windows.Forms.Button exportSetButton;
        private System.Windows.Forms.Button importClassesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ghostButton;
        private System.Windows.Forms.Button classSetsButton;
        private System.Windows.Forms.ComboBox tacticalCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox classSetNameTB;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.TextBox classNameTB;
        private System.Windows.Forms.Button classNameButton;
        private System.Windows.Forms.Timer classNameTimer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox classNamesCB;
        private System.Windows.Forms.Button importClassButton;
        private System.Windows.Forms.Button exportClassButton;
        private System.Windows.Forms.Label statusTextLabel;
        private System.Windows.Forms.Label statusLabel;
    }
}

