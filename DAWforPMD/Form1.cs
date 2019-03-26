using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAWforPMD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.FMNUM.Items.AddRange(new object[] { this.FMNUM.Items.Count.ToString() });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int temp2 = this.FMNUM.SelectedIndex;
            if (temp2 != -1)
            {
                this.FMNUM.Items.RemoveAt(this.FMNUM.SelectedIndex);
                for (int i = 0; i < this.FMNUM.Items.Count; i++)
                {
                    this.FMNUM.SelectedIndex = i;
                    //Console.Write(i.ToString() + " " + this.FMNUM.SelectedItem.ToString() + "\n");
                    if (i.ToString() != this.FMNUM.SelectedItem.ToString())
                    {
                        this.FMNUM.Items.Insert(i, i.ToString());
                        this.FMNUM.Items.RemoveAt(i + 1);
                        //Console.Write(i.ToString() + " " + this.FMNUM.SelectedItem.ToString() + "\n");
                    }
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
