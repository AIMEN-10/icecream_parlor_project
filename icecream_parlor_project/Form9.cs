using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace icecream_parlor_project
{
    public partial class Form9 : Form
    {
        public Form9(int sum)
        {
            InitializeComponent();
            bunifuCustomLabel2.Text = sum.ToString();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
        }
    }
}
