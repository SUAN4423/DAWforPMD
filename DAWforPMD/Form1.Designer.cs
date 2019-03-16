namespace DAWforPMD
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ATTACKRATE4 = new System.Windows.Forms.ComboBox();
            this.ATTACKRATE3 = new System.Windows.Forms.ComboBox();
            this.ATTACKRATE2 = new System.Windows.Forms.ComboBox();
            this.ATTACKRATE1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FEEDBACK = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ALGORITHM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NOTES = new System.Windows.Forms.Panel();
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
            this.MENU.Controls.Add(this.label8);
            this.MENU.Controls.Add(this.label7);
            this.MENU.Controls.Add(this.label6);
            this.MENU.Controls.Add(this.label5);
            this.MENU.Controls.Add(this.ATTACKRATE4);
            this.MENU.Controls.Add(this.ATTACKRATE3);
            this.MENU.Controls.Add(this.ATTACKRATE2);
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
            // ATTACKRATE1
            // 
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
            this.label4.Location = new System.Drawing.Point(204, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "AR";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FEEDBACK
            // 
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
            this.FEEDBACK.Location = new System.Drawing.Point(102, 3);
            this.FEEDBACK.Name = "FEEDBACK";
            this.FEEDBACK.Size = new System.Drawing.Size(40, 20);
            this.FEEDBACK.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "FB";
            // 
            // ALGORITHM
            // 
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
            this.ALGORITHM.Location = new System.Drawing.Point(30, 3);
            this.ALGORITHM.Name = "ALGORITHM";
            this.ALGORITHM.Size = new System.Drawing.Size(40, 20);
            this.ALGORITHM.TabIndex = 1;
            this.ALGORITHM.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
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
    }
}