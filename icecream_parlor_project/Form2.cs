using Business_layer;
using System;

using System.Linq;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace icecream_parlor_project
{
    public partial class Form2 : Form
    {

        public Form2()
        {

            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

       

       

       

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string username1 = textBox1.Text;
            string password1 = textBox2.Text;

            if (username1 == String.Empty || password1 == String.Empty)
            {
                MessageBox.Show("Please fill the empty spaces");
            }
            else
            {
                Logic obj = new Logic();
                DataTable r = obj.loginAdmin(username1);

                if (r != null && r.Rows.Count > 0)
                {
                    string storedPassword = r.Rows[0]["password"].ToString();

                    if (storedPassword == password1)
                    {
                        this.Hide();
                        Form7 f = new Form7();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }
                }
                else
                {
                    MessageBox.Show("Username not found!");
                }



            }


            }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string username1 = textBox1.Text;
                string password1 = textBox2.Text;
                if (username1 == String.Empty || password1 == String.Empty)
                {
                    MessageBox.Show("Please fill the empty spaces");
                }
                else
                {
                    Logic obj = new Logic();
                    DataTable r = obj.loginAdmin(username1);

                    if (r != null && r.Rows.Count > 0)
                    {
                        string storedPassword = r.Rows[0]["password"].ToString();

                        if (storedPassword == password1)
                        {
                            this.Hide();
                            Form7 f = new Form7();
                            f.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username not found!");
                    }





                }
            }
        }
    }
    }

