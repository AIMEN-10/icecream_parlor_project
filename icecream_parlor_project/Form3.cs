using Business_layer;
using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace icecream_parlor_project
{
    public partial class Form3 : Form
    {
        Logic obj = new Logic();
        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public Form3()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int index;
                //if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty || textBox4.Text == String.Empty || pictureBox1.Image == null)
                //{
                //    MessageBox.Show("Please enter complete credentials...");
                //    return;
                //}
             if (!Regex.IsMatch(textBox1.Text, "^[A-Z ]{5,100}$") )
            {
                label12.Text = "The input must be 5 to 100 uppercase letters.";
                label12.ForeColor = System.Drawing.Color.Red;
                label12.Visible = true;
                textBox1.Focus();
            }
            else if (!Regex.IsMatch(textBox2.Text, "^[0-9]{1,}$"))
            {
                label13.Text = "Please enter digits only";
                label13.ForeColor = System.Drawing.Color.Red;
                label13.Visible = true;
                textBox2.Focus();
            }
            else if (!Regex.IsMatch(textBox3.Text, "^[0-9]{1,}$"))
            {
                label14.Text = "Please enter digits only";
                label14.ForeColor = System.Drawing.Color.Red;
                label14.Visible = true;
                textBox3.Focus();
            }
            else if (!Regex.IsMatch(textBox4.Text, "^[0-9]{1,}$"))
            {
                label15.Text = "Please enter digits only";
                label15.ForeColor = System.Drawing.Color.Red;
                label15.Visible = true;
                textBox4.Focus();
            }
            else
                {
                try
                {
                    Product p1 = new Product
                    {
                        name = textBox1.Text,
                        singleP = int.Parse(textBox2.Text),
                        doubleP = int.Parse(textBox3.Text),
                        familyP = int.Parse(textBox4.Text),
                        Path = openFileDialog1.FileName,
                    };
                    var parameters = new Dictionary<string, object>
        {
            { "@name",p1.name },
            { "@singleP", p1.singleP },
            { "@doubleP", p1.doubleP },
            { "@familyP", p1.familyP },
            { "@Path", p1.Path },
        };
                    obj.SaveProduct(parameters);
                   
                    DataTable r = obj.showproduct(parameters);
                    if (r.Rows[0]["name"] == null)
                    {
                        MessageBox.Show("Mismatch catgory...Please enter correct spelling...");

                    }
                    else
                    {
                        index = guna2DataGridView1.Rows.Add();
                        guna2DataGridView1[0, index].Value = r.Rows[0]["name"];
                        guna2DataGridView1[1, index].Value = r.Rows[0]["singleP"];
                        guna2DataGridView1[2, index].Value = r.Rows[0]["doubleP"];
                        guna2DataGridView1[3, index].Value = r.Rows[0]["familyP"];
                        guna2DataGridView1[4, index].Value = r.Rows[0]["path"];
                    }
                }
                catch(Exception ex)
                {
                    
                    MessageBox.Show("Mismatch catgory...Please enter correct spelling...");
                   
                }


            }
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    string Path = openFileDialog1.FileName;

                    pictureBox1.Image = System.Drawing.Image.FromFile(Path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            int index;
            //if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty || textBox4.Text == String.Empty || pictureBox1.Image == null)
            //{
            //    MessageBox.Show("Please enter complete credentials...");
            //    return;
            //}
            if (!Regex.IsMatch(textBox1.Text, "^[A-Z ]{5,100}$"))
            {
                label12.Text = "The input must be 5 to 100 uppercase letters.";
                label12.ForeColor = System.Drawing.Color.Red;
                label12.Visible = true;
                textBox1.Focus();
            }
            else if (!Regex.IsMatch(textBox2.Text, "^[0-9]{1,}$"))
            {
                label13.Text = "Please enter digits only";
                label13.ForeColor = System.Drawing.Color.Red;
                label13.Visible = true;
                textBox2.Focus();
            }
            else if (!Regex.IsMatch(textBox3.Text, "^[0-9]{1,}$"))
            {
                label14.Text = "Please enter digits only";
                label14.ForeColor = System.Drawing.Color.Red;
                label14.Visible = true;
                textBox3.Focus();
            }
            else if (!Regex.IsMatch(textBox4.Text, "^[0-9]{1,}$"))
            {
                label15.Text = "Please enter digits only";
                label15.ForeColor = System.Drawing.Color.Red;
                label15.Visible = true;
                textBox4.Focus();
            }
            else
            {
                try
                {
                    Product p1 = new Product
                    {
                        name = textBox1.Text,
                        singleP = int.Parse(textBox2.Text),
                        doubleP = int.Parse(textBox3.Text),
                        familyP = int.Parse(textBox4.Text),
                        Path = openFileDialog1.FileName,
                    };
                    var p_parameters = new Dictionary<string, object>
        {
            { "@name",p1.name },
            { "@singleP", p1.singleP },
            { "@doubleP", p1.doubleP },
            { "@familyP", p1.familyP },
            { "@Path", p1.Path }

        };
                    obj.Updateproduct(p_parameters);
                    DataTable r = obj.showproduct(p_parameters);
                    if (r.Rows[0]["name"] == null)
                    {
                        MessageBox.Show("Mismatch catgory...Please enter correct spelling...");

                    }
                    else
                    {
                        index = guna2DataGridView1.Rows.Add();
                        guna2DataGridView1[0, index].Value = r.Rows[0]["name"];
                        guna2DataGridView1[1, index].Value = r.Rows[0]["singleP"];
                        guna2DataGridView1[2, index].Value = r.Rows[0]["doubleP"];
                        guna2DataGridView1[3, index].Value = r.Rows[0]["familyP"];
                        guna2DataGridView1[4, index].Value = r.Rows[0]["path"];
                    }
                }
                catch(Exception es)
                {
                    
                    MessageBox.Show("Mismatch catgory...Please enter correct spelling...");

                }


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           
            if (textBox5.Text == String.Empty)
            {
                MessageBox.Show("Please enter name...It is mendatory to delete product");
                return;
            }
            else
            {
                try
                {

                    string name = textBox5.Text;
                    var parameters = new Dictionary<string, object>
        {
            { "@name",name },
           

        };
                    
                    int r=obj.delete(parameters);
                    if (r == -1)
                    {
                        MessageBox.Show("Product not Found!");
                    }
                    else
                    {
                        for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
                        {

                            if (guna2DataGridView1[0, i].Value == null || guna2DataGridView1[0, i].Value.ToString() == string.Empty)
                            {

                                MessageBox.Show("Product deleted...");
                                break;
                            }
                            else if (guna2DataGridView1[0, i].Value.ToString() == name)
                            {
                                guna2DataGridView1.Rows.RemoveAt(i);
                                MessageBox.Show("Product deleted...");
                                break;
                            }
                        }
                    }  
                    
                }
                catch (Exception es)
                {
                    
                    MessageBox.Show(es.Message);

                }


            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f=new Form7();
            f.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
