﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delivered.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }






        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Dock = DockStyle.Fill;
            form1.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form1);
            form1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.Dock = DockStyle.Fill;
            form2.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form2);
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Dock = DockStyle.Fill;
            form3.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form3);
            form3.Show();
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Dock = DockStyle.Fill;
            form4.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form4);
            form4.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Dock = DockStyle.Fill;
            form5.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form5);
            form5.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Dock = DockStyle.Fill;
            form6.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form6);
            form6.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Dock = DockStyle.Fill;
            form7.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form7);
            form7.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Dock = DockStyle.Fill;
            form8.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form8);
            form8.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Dock = DockStyle.Fill;
            form9.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(form9);
            form9.Show();
        }
    }
}
