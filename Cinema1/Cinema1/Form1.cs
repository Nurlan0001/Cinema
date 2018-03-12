using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema1
{
    public partial class Form1 : Form
    {
        bool checkStatus = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.Red;
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            listBox5.Items.Add(b.Text);

            if (checkStatus)
            {
                b.BackColor = Color.ForestGreen;
                checkStatus = false;

            }
            else
            {
                b.BackColor = Color.Red;
                checkStatus = true;
            }

        }



    }


}

