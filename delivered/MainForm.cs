using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using delivered.Forms;

namespace delivered
{
    public partial class MainForm : Form
    {
        public static Panel MainPanel;
        public MainForm()
        {
            InitializeComponent();
            MainPanel = panel1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Form5 form5=new Form5();
            form5.Dock = DockStyle.Fill;
            form5.TopLevel=false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form5);
            form5.Show();

        }
    }
}
