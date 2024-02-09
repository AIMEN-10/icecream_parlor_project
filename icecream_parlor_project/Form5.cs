using Business_layer;
using Business_Layer;
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
    public partial class Form5 : Form
    {
        BindingList<Customer> customers = new BindingList<Customer>();

        Logic obj = new Logic();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            foreach(Control ctr in Controls)
            {
                if(ctr is MdiClient)
                {
                    ctr.BackColor=Color.Bisque;
                   
                }
            }
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6(customers);
            f.Show();
        }

        private void uSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6(customers);
            f.Show();
        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CustomGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6(customers);
            f.Show();
        }
    }
}
