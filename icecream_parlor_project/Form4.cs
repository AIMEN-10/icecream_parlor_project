
using Business_layer;
using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace icecream_parlor_project
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                Logic obj = new Logic();

                if (!Regex.IsMatch(textBox1.Text, "^[a-zA-Z0-9@]{3,30}$") || !textBox1.Text.Contains("@"))
                {
                    label8.Text = "Please enter a valid Email address";
                    label8.ForeColor = System.Drawing.Color.Red;
                    label8.Visible = true;
                    textBox1.Focus();
                }
                else if (!Regex.IsMatch(textBox3.Text, "^[A-Z0-9]{3,30}$"))
                {
                    label9.Text = "Username " +
                        "should contain digits and uppercase case alphabets. ";
                    label9.ForeColor = System.Drawing.Color.Red;
                    label9.Visible = true;
                    textBox3.Focus();
                }
                else if (!Regex.IsMatch(textBox2.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,}$"))
                {
                    label10.Text = "Invalid password format. " +
                        "Please use at least\n 8 characters, including" +
                        " at least one lowercase\n letter, one uppercase " +
                        "letter, and one digit.";
                    label10.ForeColor = System.Drawing.Color.Red;
                    label10.Visible = true;
                    textBox2.Focus();
                }

                else
                {
                    Admin a = new Admin
                    {
                        email = textBox1.Text,
                        username = textBox2.Text,
                        password = textBox3.Text,
                    };
                    //obj.SaveAdmin(a);
                    var parameters = new Dictionary<string, object>
        {
            { "@Email", a.email },
            { "@username", a.username },
            { "@password", a.password }
        };
                    obj.SaveAdmin( parameters);
                    MessageBox.Show("WELCOME");
                    this.Hide();
                    Form5 f = new Form5();
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f = new Form7();
            f.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
