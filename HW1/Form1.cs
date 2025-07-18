using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
    public partial class Form1 : Form
    {
        public int o = 0;
        public Form1()
        {
            InitializeComponent();
           // listBox1.Items.Add(textBox1.Text);
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
                textBox1.Clear();
            }
            if (listBox2.SelectedIndex != -1)
            {

                listBox2.Items[listBox2.SelectedIndex] = textBox2.Text;
                textBox2.Clear();
            }
            if (listBox3.SelectedIndex != -1)
            {
                listBox3.Items[listBox3.SelectedIndex] = textBox3.Text;
                textBox3.Clear();
            }
            if (listBox4.SelectedIndex != -1){

                listBox4.Items[listBox4.SelectedIndex] = textBox4.Text;
                textBox4.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int t5 = Convert.ToInt32(textBox5.Text) -1;

            if (t5 > listBox1.Items.Count-1)
            {
                MessageBox.Show("the valu Eroor", "erooor",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                listBox1.SelectedIndex = listBox2.SelectedIndex = listBox3.SelectedIndex = listBox4.SelectedIndex = t5;


            }




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();

            listBox2.Items.Add(textBox2.Text);
            textBox2.Clear();

            listBox3.Items.Add(textBox3.Text);
            textBox3.Clear();

            listBox4.Items.Add(textBox4.Text);
            textBox4.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            if (listBox2.SelectedIndex != -1)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);


            }
            if (listBox3.SelectedIndex != -1)
            {
                listBox3.Items.RemoveAt(listBox3.SelectedIndex);

            }
            if (listBox4.SelectedIndex != -1)
            {
                listBox4.Items.RemoveAt(listBox4.SelectedIndex);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
