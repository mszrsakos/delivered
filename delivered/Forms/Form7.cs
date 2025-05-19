using System;
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
    public partial class Form7 : Form
    {
        private int timeLeft; // time left in seconds
        private const int countdownTime = 5 * 60; // 5 minutes in seconds
        public string szallitas = "";
        public Form7()
        {
            InitializeComponent();
            timeLeft = countdownTime;
            timer1.Interval = 1000; // 1 second
            //timer1.Tick += timer1_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                panel2.BackColor = color;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                UpdateLabel();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Lejárt az idő! A rendelést újra kell kezdened!");
                Application.Restart();
            }
        }

        private void UpdateLabel()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(timeLeft);
            label9.Text = timeSpan.ToString(@"mm\:ss"); // show mm:ss format
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            UpdateLabel();
            timer1.Start(); // Start countdown immediately on form load
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show($"Nem adtad meg a teljes nevedet! Kérlek írd be");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show($"Nem adtad meg a lakcímedet! Kérlek írd be");
            }
            else if (numericUpDown1.Value < 100000000 && numericUpDown1.Value > 1000000000)
            {
                MessageBox.Show($"Nem adtad meg a telefonszámodat! Kérlek írd be");
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Válassz cipőméretet!");
            }
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show($"Kérlek add hozzá a cipőt a listához mielőtt leadod a rendelést");

            }
            if (szallitas == "")
            {
                MessageBox.Show("Kérlek válassz ki egy szállítási módot");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int hazhoz = 1800;
            int csomagP = 800;

            if (radioButton1.Checked)
            {
                szallitas = "Házhozszállítás";
                listBox1.Items.Add("Teljes név:" + " " + textBox1.Text);
                listBox1.Items.Add("Lakcím:" + " " + textBox2.Text);
                listBox1.Items.Add("Telefonszám:" + " " + numericUpDown1.Value);
                listBox1.Items.Add("Cipő mérete:" + " " + comboBox1.SelectedItem.ToString());
                listBox1.Items.Add("Cipő színe:" + " " + colorDialog1.Color);
                listBox1.Items.Add("Szállítási mód:" + " " + szallitas);



            }
            else if (radioButton2.Checked)
            {
                szallitas = "Csomagpont";
                listBox1.Items.Add("Teljes név:" + " " + textBox1.Text);
                listBox1.Items.Add("Lakcím:" + " " + textBox2.Text);
                listBox1.Items.Add("Telefonszám:" + " " + numericUpDown1.Value);
                listBox1.Items.Add("Cipő mérete:" + " " + comboBox1.SelectedItem.ToString());
                listBox1.Items.Add("Cipő színe:" + " " + colorDialog1.Color);
                listBox1.Items.Add("Szállítási mód:" + " " + szallitas);
            }
            else if (radioButton3.Checked)

            {
                szallitas += "Személyes átvétel";
                listBox1.Items.Add("Teljes név:" + " " + textBox1.Text);
                listBox1.Items.Add("Lakcím:" + " " + textBox2.Text);
                listBox1.Items.Add("Telefonszám:" + " " + numericUpDown1.Value);
                listBox1.Items.Add("Cipő mérete:" + " " + comboBox1.SelectedItem.ToString());
                listBox1.Items.Add("Cipő színe:" + " " + colorDialog1.Color);
                listBox1.Items.Add("Szállítási mód:" + " " + szallitas);
            }
            else
            {
                MessageBox.Show($"Nem választottál ki szállítási módot! Válassz egyet ki kérlek");
            }
        }
    }
}
