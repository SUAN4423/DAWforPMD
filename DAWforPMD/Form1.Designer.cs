﻿namespace DAWforPMD
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CHANNEL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MENU = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.FMNUM = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ATTACKRATE4 = new System.Windows.Forms.ComboBox();
            this.ATTACKRATE3 = new System.Windows.Forms.ComboBox();
            this.ATTACKRATE2 = new System.Windows.Forms.ComboBox();
            this.SUSTAINRATE4 = new System.Windows.Forms.ComboBox();
            this.RELEASERATE3 = new System.Windows.Forms.ComboBox();
            this.DECAYRATE4 = new System.Windows.Forms.ComboBox();
            this.SUSTAINRATE3 = new System.Windows.Forms.ComboBox();
            this.RELEASERATE2 = new System.Windows.Forms.ComboBox();
            this.DECAYRATE3 = new System.Windows.Forms.ComboBox();
            this.SUSTAINRATE2 = new System.Windows.Forms.ComboBox();
            this.RELEASERATE1 = new System.Windows.Forms.ComboBox();
            this.DECAYRATE2 = new System.Windows.Forms.ComboBox();
            this.SUSTAINRATE1 = new System.Windows.Forms.ComboBox();
            this.DECAYRATE1 = new System.Windows.Forms.ComboBox();
            this.ATTACKRATE1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FEEDBACK = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ALGORITHM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NOTES = new System.Windows.Forms.Panel();
            this.RELEASERATE4 = new System.Windows.Forms.ComboBox();
            this.MENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CHANNEL
            // 
            this.CHANNEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CHANNEL.FormattingEnabled = true;
            this.CHANNEL.Items.AddRange(new object[] {
            "FM1",
            "FM2",
            "FM3",
            "FM4",
            "FM5",
            "FM6",
            "SSG1",
            "SSG2",
            "SSG3",
            "ADPCM",
            "RHYTHM"});
            this.CHANNEL.Location = new System.Drawing.Point(63, 0);
            this.CHANNEL.Name = "CHANNEL";
            this.CHANNEL.Size = new System.Drawing.Size(74, 20);
            this.CHANNEL.TabIndex = 3;
            this.CHANNEL.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "使用音源";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MENU
            // 
            this.MENU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MENU.BackColor = System.Drawing.SystemColors.Window;
            this.MENU.Controls.Add(this.button2);
            this.MENU.Controls.Add(this.button1);
            this.MENU.Controls.Add(this.label10);
            this.MENU.Controls.Add(this.FMNUM);
            this.MENU.Controls.Add(this.label11);
            this.MENU.Controls.Add(this.label12);
            this.MENU.Controls.Add(this.label9);
            this.MENU.Controls.Add(this.label8);
            this.MENU.Controls.Add(this.label7);
            this.MENU.Controls.Add(this.label6);
            this.MENU.Controls.Add(this.label5);
            this.MENU.Controls.Add(this.ATTACKRATE4);
            this.MENU.Controls.Add(this.ATTACKRATE3);
            this.MENU.Controls.Add(this.ATTACKRATE2);
            this.MENU.Controls.Add(this.SUSTAINRATE4);
            this.MENU.Controls.Add(this.RELEASERATE4);
            this.MENU.Controls.Add(this.RELEASERATE3);
            this.MENU.Controls.Add(this.DECAYRATE4);
            this.MENU.Controls.Add(this.SUSTAINRATE3);
            this.MENU.Controls.Add(this.RELEASERATE2);
            this.MENU.Controls.Add(this.DECAYRATE3);
            this.MENU.Controls.Add(this.SUSTAINRATE2);
            this.MENU.Controls.Add(this.RELEASERATE1);
            this.MENU.Controls.Add(this.DECAYRATE2);
            this.MENU.Controls.Add(this.SUSTAINRATE1);
            this.MENU.Controls.Add(this.DECAYRATE1);
            this.MENU.Controls.Add(this.ATTACKRATE1);
            this.MENU.Controls.Add(this.label4);
            this.MENU.Controls.Add(this.FEEDBACK);
            this.MENU.Controls.Add(this.label3);
            this.MENU.Controls.Add(this.ALGORITHM);
            this.MENU.Controls.Add(this.label2);
            this.MENU.Location = new System.Drawing.Point(0, 25);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(1264, 150);
            this.MENU.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "DEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "FM音源番号";
            // 
            // FMNUM
            // 
            this.FMNUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FMNUM.FormattingEnabled = true;
            this.FMNUM.Location = new System.Drawing.Point(75, 3);
            this.FMNUM.Name = "FMNUM";
            this.FMNUM.Size = new System.Drawing.Size(49, 20);
            this.FMNUM.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(262, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "DR";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(374, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "RR";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "SR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "Operator 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Operator 3";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Operator 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Operator 1";
            // 
            // ATTACKRATE4
            // 
            this.ATTACKRATE4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ATTACKRATE4.FormattingEnabled = true;
            this.ATTACKRATE4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.ATTACKRATE4.Location = new System.Drawing.Point(191, 119);
            this.ATTACKRATE4.Name = "ATTACKRATE4";
            this.ATTACKRATE4.Size = new System.Drawing.Size(50, 20);
            this.ATTACKRATE4.TabIndex = 8;
            // 
            // ATTACKRATE3
            // 
            this.ATTACKRATE3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ATTACKRATE3.FormattingEnabled = true;
            this.ATTACKRATE3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.ATTACKRATE3.Location = new System.Drawing.Point(191, 93);
            this.ATTACKRATE3.Name = "ATTACKRATE3";
            this.ATTACKRATE3.Size = new System.Drawing.Size(50, 20);
            this.ATTACKRATE3.TabIndex = 7;
            // 
            // ATTACKRATE2
            // 
            this.ATTACKRATE2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ATTACKRATE2.FormattingEnabled = true;
            this.ATTACKRATE2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.ATTACKRATE2.Location = new System.Drawing.Point(191, 67);
            this.ATTACKRATE2.Name = "ATTACKRATE2";
            this.ATTACKRATE2.Size = new System.Drawing.Size(50, 20);
            this.ATTACKRATE2.TabIndex = 6;
            // 
            // SUSTAINRATE4
            // 
            this.SUSTAINRATE4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SUSTAINRATE4.FormattingEnabled = true;
            this.SUSTAINRATE4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.SUSTAINRATE4.Location = new System.Drawing.Point(303, 119);
            this.SUSTAINRATE4.Name = "SUSTAINRATE4";
            this.SUSTAINRATE4.Size = new System.Drawing.Size(50, 20);
            this.SUSTAINRATE4.TabIndex = 5;
            // 
            // RELEASERATE3
            // 
            this.RELEASERATE3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RELEASERATE3.FormattingEnabled = true;
            this.RELEASERATE3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.RELEASERATE3.Location = new System.Drawing.Point(359, 93);
            this.RELEASERATE3.Name = "RELEASERATE3";
            this.RELEASERATE3.Size = new System.Drawing.Size(50, 20);
            this.RELEASERATE3.TabIndex = 5;
            this.RELEASERATE3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // DECAYRATE4
            // 
            this.DECAYRATE4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DECAYRATE4.FormattingEnabled = true;
            this.DECAYRATE4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DECAYRATE4.Location = new System.Drawing.Point(247, 119);
            this.DECAYRATE4.Name = "DECAYRATE4";
            this.DECAYRATE4.Size = new System.Drawing.Size(50, 20);
            this.DECAYRATE4.TabIndex = 5;
            // 
            // SUSTAINRATE3
            // 
            this.SUSTAINRATE3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SUSTAINRATE3.FormattingEnabled = true;
            this.SUSTAINRATE3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.SUSTAINRATE3.Location = new System.Drawing.Point(303, 93);
            this.SUSTAINRATE3.Name = "SUSTAINRATE3";
            this.SUSTAINRATE3.Size = new System.Drawing.Size(50, 20);
            this.SUSTAINRATE3.TabIndex = 5;
            // 
            // RELEASERATE2
            // 
            this.RELEASERATE2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RELEASERATE2.FormattingEnabled = true;
            this.RELEASERATE2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.RELEASERATE2.Location = new System.Drawing.Point(359, 67);
            this.RELEASERATE2.Name = "RELEASERATE2";
            this.RELEASERATE2.Size = new System.Drawing.Size(50, 20);
            this.RELEASERATE2.TabIndex = 5;
            this.RELEASERATE2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // DECAYRATE3
            // 
            this.DECAYRATE3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DECAYRATE3.FormattingEnabled = true;
            this.DECAYRATE3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DECAYRATE3.Location = new System.Drawing.Point(247, 93);
            this.DECAYRATE3.Name = "DECAYRATE3";
            this.DECAYRATE3.Size = new System.Drawing.Size(50, 20);
            this.DECAYRATE3.TabIndex = 5;
            // 
            // SUSTAINRATE2
            // 
            this.SUSTAINRATE2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SUSTAINRATE2.FormattingEnabled = true;
            this.SUSTAINRATE2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.SUSTAINRATE2.Location = new System.Drawing.Point(303, 67);
            this.SUSTAINRATE2.Name = "SUSTAINRATE2";
            this.SUSTAINRATE2.Size = new System.Drawing.Size(50, 20);
            this.SUSTAINRATE2.TabIndex = 5;
            // 
            // RELEASERATE1
            // 
            this.RELEASERATE1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RELEASERATE1.FormattingEnabled = true;
            this.RELEASERATE1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.RELEASERATE1.Location = new System.Drawing.Point(359, 41);
            this.RELEASERATE1.Name = "RELEASERATE1";
            this.RELEASERATE1.Size = new System.Drawing.Size(50, 20);
            this.RELEASERATE1.TabIndex = 5;
            this.RELEASERATE1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // DECAYRATE2
            // 
            this.DECAYRATE2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DECAYRATE2.FormattingEnabled = true;
            this.DECAYRATE2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DECAYRATE2.Location = new System.Drawing.Point(247, 67);
            this.DECAYRATE2.Name = "DECAYRATE2";
            this.DECAYRATE2.Size = new System.Drawing.Size(50, 20);
            this.DECAYRATE2.TabIndex = 5;
            // 
            // SUSTAINRATE1
            // 
            this.SUSTAINRATE1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SUSTAINRATE1.FormattingEnabled = true;
            this.SUSTAINRATE1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.SUSTAINRATE1.Location = new System.Drawing.Point(303, 41);
            this.SUSTAINRATE1.Name = "SUSTAINRATE1";
            this.SUSTAINRATE1.Size = new System.Drawing.Size(50, 20);
            this.SUSTAINRATE1.TabIndex = 5;
            // 
            // DECAYRATE1
            // 
            this.DECAYRATE1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DECAYRATE1.FormattingEnabled = true;
            this.DECAYRATE1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DECAYRATE1.Location = new System.Drawing.Point(247, 41);
            this.DECAYRATE1.Name = "DECAYRATE1";
            this.DECAYRATE1.Size = new System.Drawing.Size(50, 20);
            this.DECAYRATE1.TabIndex = 5;
            // 
            // ATTACKRATE1
            // 
            this.ATTACKRATE1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ATTACKRATE1.FormattingEnabled = true;
            this.ATTACKRATE1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.ATTACKRATE1.Location = new System.Drawing.Point(191, 41);
            this.ATTACKRATE1.Name = "ATTACKRATE1";
            this.ATTACKRATE1.Size = new System.Drawing.Size(50, 20);
            this.ATTACKRATE1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "AR";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FEEDBACK
            // 
            this.FEEDBACK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FEEDBACK.DropDownWidth = 40;
            this.FEEDBACK.FormattingEnabled = true;
            this.FEEDBACK.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.FEEDBACK.Location = new System.Drawing.Point(63, 96);
            this.FEEDBACK.Name = "FEEDBACK";
            this.FEEDBACK.Size = new System.Drawing.Size(40, 20);
            this.FEEDBACK.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "FB";
            // 
            // ALGORITHM
            // 
            this.ALGORITHM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ALGORITHM.DropDownWidth = 40;
            this.ALGORITHM.FormattingEnabled = true;
            this.ALGORITHM.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.ALGORITHM.Location = new System.Drawing.Point(12, 96);
            this.ALGORITHM.Name = "ALGORITHM";
            this.ALGORITHM.Size = new System.Drawing.Size(40, 20);
            this.ALGORITHM.TabIndex = 1;
            this.ALGORITHM.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "AG";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NOTES
            // 
            this.NOTES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NOTES.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NOTES.Location = new System.Drawing.Point(0, 180);
            this.NOTES.Name = "NOTES";
            this.NOTES.Size = new System.Drawing.Size(1264, 500);
            this.NOTES.TabIndex = 0;
            // 
            // RELEASERATE4
            // 
            this.RELEASERATE4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RELEASERATE4.FormattingEnabled = true;
            this.RELEASERATE4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.RELEASERATE4.Location = new System.Drawing.Point(359, 119);
            this.RELEASERATE4.Name = "RELEASERATE4";
            this.RELEASERATE4.Size = new System.Drawing.Size(50, 20);
            this.RELEASERATE4.TabIndex = 5;
            this.RELEASERATE4.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.NOTES);
            this.Controls.Add(this.MENU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CHANNEL);
            this.Name = "Form1";
            this.Text = "DAWforPMD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MENU.ResumeLayout(false);
            this.MENU.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox CHANNEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MENU;
        private System.Windows.Forms.Panel NOTES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ALGORITHM;
        private System.Windows.Forms.ComboBox FEEDBACK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ATTACKRATE4;
        private System.Windows.Forms.ComboBox ATTACKRATE3;
        private System.Windows.Forms.ComboBox ATTACKRATE2;
        private System.Windows.Forms.ComboBox ATTACKRATE1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox FMNUM;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox DECAYRATE1;
        private System.Windows.Forms.ComboBox DECAYRATE4;
        private System.Windows.Forms.ComboBox DECAYRATE3;
        private System.Windows.Forms.ComboBox DECAYRATE2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox SUSTAINRATE4;
        private System.Windows.Forms.ComboBox SUSTAINRATE3;
        private System.Windows.Forms.ComboBox SUSTAINRATE2;
        private System.Windows.Forms.ComboBox SUSTAINRATE1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox RELEASERATE3;
        private System.Windows.Forms.ComboBox RELEASERATE2;
        private System.Windows.Forms.ComboBox RELEASERATE1;
        private System.Windows.Forms.ComboBox RELEASERATE4;
    }
}