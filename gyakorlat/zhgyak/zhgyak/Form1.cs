using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zhgyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
        }
        Random Random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("szoftverből kattintittak");

        }

        private void label1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
                 
            label1.BackColor = Color.FromArgb(colorDialog1.Color.ToArgb()) ;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.BackColor = Color.FromArgb(Random.Next(0, 256), Random.Next(0, 256), Random.Next(0, 256));
                
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDown1.Value = vScrollBar1.Value;
        }
        int k = 0;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 10)
            {
                k++;
                listBox1.Items.Add(k.ToString());
                

         
            }
            else
            {
                k++;
                textBox1.Text += " " + k.ToString();
                
                  
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
