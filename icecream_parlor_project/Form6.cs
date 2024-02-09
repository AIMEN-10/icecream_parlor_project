using Business_layer;
using Business_Layer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace icecream_parlor_project
{
    public partial class Form6 : Form
    {
        public static string name;
        public static string cmbxval;
        public static int quant;
        public static string value;
        BindingList<Customer> customers = new BindingList<Customer>();
        BindingList<AdminDisplay> admin = new BindingList<AdminDisplay>();


        Logic obj=new Logic();
        public Form6(BindingList<Customer> receivedList)
        {
            InitializeComponent();
            guna2GradientButton1.PerformClick();
            foreach (var item in receivedList)
            {
                customers.Add(item);
            }
           
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Label[] labelcoll = { label1, label2, label3, label4, label5, label6 };
            for (int i = 0; i < labelcoll.Length; i++)
            {
                labelcoll[i].Text = 0.ToString();
            }
            Label[] label = {  label7, label8,  label9, label10, label11, label12 };
            ComboBox[] comboBox= { guna2ComboBox1, guna2ComboBox2, guna2ComboBox3,
            guna2ComboBox4,guna2ComboBox5,guna2ComboBox6};
            PictureBox[] pic = {guna2PictureBox1,guna2PictureBox2,guna2PictureBox3,
            guna2PictureBox4,guna2PictureBox5,guna2PictureBox6};

            for (int i = 0; i < label.Length; i++)
            {
                comboBox[i].Items.Clear();
            }
            DataTable r = obj.blizzard("sandwitch");
            int j = 0;
            
            for (int i = 0; i < label.Length; i++)
            {

                label[i].Text = r.Rows[j]["name"].ToString();
                
                comboBox[i].Items.Add("Single Platter (RS."+r.Rows[j]["singlep"].ToString()+")");
                comboBox[i].Items.Add("Double Platter (RS." + r.Rows[j]["doublep"].ToString() + ")");
                comboBox[i].Items.Add("Family Platter (RS." + r.Rows[j]["familyp"].ToString() + ")");
                comboBox[i].SelectedIndex = 0;

                pic[i].Image = Image.FromFile(r.Rows[j]["path"].ToString());
                j++;
            }
            
        }

        

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            int quant=int.Parse(label1.Text);
            quant++;
            label1.Text=quant.ToString();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {

            int quant = int.Parse(label1.Text);
            quant--;
            if (quant >= 0)
            {
                label1.Text = quant.ToString();
            }
            else
            {
                label1.Text = 0.ToString();
            }
        }



        private void guna2TileButton6_Click(object sender, EventArgs e)
        {
            int quant = int.Parse(label2.Text);
            quant++;
            label2.Text = quant.ToString();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Label[] labelcoll = { label1, label2, label3, label4, label5, label6 };
            for(int i = 0; i < labelcoll.Length; i++)
            {
                labelcoll[i].Text = 0.ToString();
            }
            Label[] label = { label7, label8, label9, label10, label11, label12 };
            ComboBox[] comboBox = { guna2ComboBox1, guna2ComboBox2, guna2ComboBox3,
            guna2ComboBox4,guna2ComboBox5,guna2ComboBox6};
            PictureBox[] pic = {guna2PictureBox1,guna2PictureBox2,guna2PictureBox3,
            guna2PictureBox4,guna2PictureBox5,guna2PictureBox6};
            for (int i = 0; i < comboBox.Length; i++)
            {
                comboBox[i].Items.Clear();
            }
            DataTable r = obj.blizzard("cone");
            int j = 0;
            for (int i = 0; i < label.Length; i++)
            {

                label[i].Text = r.Rows[j]["name"].ToString();

                comboBox[i].Items.Add("Single Platter (RS." + r.Rows[j]["singlep"].ToString() + ")");
                comboBox[i].Items.Add("Double Platter (RS." + r.Rows[j]["doublep"].ToString() + ")");
                comboBox[i].Items.Add("Family Platter (RS." + r.Rows[j]["familyp"].ToString() + ")");
                comboBox[i].SelectedIndex = 0;

                pic[i].Image= Image.FromFile(r.Rows[j]["path"].ToString());
                j++;
            }
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f=new Form1(customers,admin);
            f.Show();
        }

        private void guna2TileButton13_Click(object sender, EventArgs e)
        {
            int quant = int.Parse(label3.Text);
            quant--;
            if (quant >= 0)
            {
                label3.Text = quant.ToString();
            }
            else
            {
                label3.Text = 0.ToString();
            }
        }

        private void guna2TileButton15_Click(object sender, EventArgs e)
        {
            int quant = int.Parse(label2.Text);
            quant--;
            if (quant >= 0)
            {
                label2.Text = quant.ToString();
            }
            else
            {
                label2.Text = 0.ToString();
            }
        }

        private void guna2TileButton14_Click(object sender, EventArgs e)
        {
            int quant = int.Parse(label3.Text);
            quant++;
            label3.Text = quant.ToString();
        }

        private void guna2TileButton6_Click_1(object sender, EventArgs e)
        {
            int quant = int.Parse(label4.Text);
            quant++;
            label4.Text = quant.ToString();
        }

        private void guna2TileButton5_Click(object sender, EventArgs e)
        {
            int quant = int.Parse(label4.Text);
            quant--;
            if (quant >= 0)
            {
                label4.Text = quant.ToString();
            }
            else
            {
                label4.Text = 0.ToString();
            }
        }

        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            int quant = int.Parse(label5.Text);
            quant++;
            label5.Text = quant.ToString();
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            int quant = int.Parse(label5.Text);
            quant--;
            if (quant >= 0)
            {
                label5.Text = quant.ToString();
            }
            else
            {
                label5.Text = 0.ToString();
            }
        }

        private void guna2TileButton17_Click(object sender, EventArgs e)
        {
            int quant = int.Parse(label6.Text);
            quant--;
            if (quant >= 0)
            {
                label6.Text = quant.ToString();
            }
            else
            {
                label6.Text = 0.ToString();
            }
        }

        private void guna2TileButton18_Click(object sender, EventArgs e)
        {
            int quant = int.Parse(label6.Text);
            quant++;
            label6.Text = quant.ToString();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Label[] labelcoll = { label1, label2, label3, label4, label5, label6 };
            for (int i = 0; i < labelcoll.Length; i++)
            {
                labelcoll[i].Text = 0.ToString();
            }
            Label[] label = { label7, label8, label9, label10, label11, label12 };
            ComboBox[] comboBox = { guna2ComboBox1, guna2ComboBox2, guna2ComboBox3,
            guna2ComboBox4,guna2ComboBox5,guna2ComboBox6};
            PictureBox[] pic = {guna2PictureBox1,guna2PictureBox2,guna2PictureBox3,
            guna2PictureBox4,guna2PictureBox5,guna2PictureBox6};

            for (int i = 0; i < comboBox.Length; i++)
            {
                comboBox[i].Items.Clear();
            }
            DataTable r = obj.blizzard("blizzard");
            int j = 0;
            for (int i = 0; i < label.Length; i++)
            {

                label[i].Text = r.Rows[j]["name"].ToString();

                comboBox[i].Items.Add("Single Platter (RS." + r.Rows[j]["singlep"].ToString() + ")");
                comboBox[i].Items.Add("Double Platter (RS." + r.Rows[j]["doublep"].ToString() + ")");
                comboBox[i].Items.Add("Family Platter (RS." + r.Rows[j]["familyp"].ToString() + ")");
                comboBox[i].SelectedIndex = 0;

                pic[i].Image = Image.FromFile(r.Rows[j]["path"].ToString());
                j++;
            }

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            Label[] labelcoll = { label1, label2, label3, label4, label5, label6 };
            for (int i = 0; i < labelcoll.Length; i++)
            {
                labelcoll[i].Text = 0.ToString();
            }
            Label[] label = { label7, label8, label9, label10, label11, label12 };
            ComboBox[] comboBox = { guna2ComboBox1, guna2ComboBox2, guna2ComboBox3,
            guna2ComboBox4,guna2ComboBox5,guna2ComboBox6};
            PictureBox[] pic = {guna2PictureBox1,guna2PictureBox2,guna2PictureBox3,
            guna2PictureBox4,guna2PictureBox5,guna2PictureBox6};

            for (int i = 0; i < comboBox.Length ; i++)
            {
                comboBox[i].Items.Clear();
            }
            DataTable r = obj.blizzard("sundae");
            int j = 0;
            for (int i = 0; i < label.Length; i++)
            {

                label[i].Text = r.Rows[j]["name"].ToString();

                comboBox[i].Items.Add("Single Platter (RS." + r.Rows[j]["singlep"].ToString() + ")");
                comboBox[i].Items.Add("Double Platter (RS." + r.Rows[j]["doublep"].ToString() + ")");
                comboBox[i].Items.Add("Family Platter (RS." + r.Rows[j]["familyp"].ToString() + ")");
                comboBox[i].SelectedIndex = 0;

                pic[i].Image = Image.FromFile(r.Rows[j]["path"].ToString());
                j++;
            }
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Label[] labelcoll = { label1, label2, label3, label4, label5, label6 };
            for (int i = 0; i < labelcoll.Length; i++)
            {
                labelcoll[i].Text = 0.ToString();
            }
            Label[] label = { label7, label8, label9, label10, label11, label12 };
            ComboBox[] comboBox = { guna2ComboBox1, guna2ComboBox2, guna2ComboBox3,
            guna2ComboBox4,guna2ComboBox5,guna2ComboBox6};
            PictureBox[] pic = {guna2PictureBox1,guna2PictureBox2,guna2PictureBox3,
            guna2PictureBox4,guna2PictureBox5,guna2PictureBox6};

            for (int i = 0; i < comboBox.Length ; i++)
            {
                comboBox[i].Items.Clear();
            }
            DataTable r = obj.blizzard("cup");
            int j = 0;
            for (int i = 0; i < label.Length; i++)
            {

                label[i].Text = r.Rows[j]["name"].ToString();

                comboBox[i].Items.Add("Single Platter (RS." + r.Rows[j]["singlep"].ToString() + ")");
                comboBox[i].Items.Add("Double Platter (RS." + r.Rows[j]["doublep"].ToString() + ")");
                comboBox[i].Items.Add("Family Platter (RS." + r.Rows[j]["familyp"].ToString() + ")");
                comboBox[i].SelectedIndex = 0;

                pic[i].Image = Image.FromFile(r.Rows[j]["path"].ToString());
                j++;
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Label[] labelcoll = { label1, label2, label3, label4, label5, label6 };
            for (int i = 0; i < labelcoll.Length; i++)
            {
                labelcoll[i].Text = 0.ToString();
            }
            Label[] label = { label7, label8, label9, label10, label11, label12 };
            ComboBox[] comboBox = { guna2ComboBox1, guna2ComboBox2, guna2ComboBox3,
            guna2ComboBox4,guna2ComboBox5,guna2ComboBox6};
            PictureBox[] pic = {guna2PictureBox1,guna2PictureBox2,guna2PictureBox3,
            guna2PictureBox4,guna2PictureBox5,guna2PictureBox6};

            for (int i = 0; i < comboBox.Length; i++)
            {
                comboBox[i].Items.Clear();
            }
            DataTable r = obj.diff();
            int j = 0;
            for (int i = 0; i < label.Length; i++)
            {

                label[i].Text = r.Rows[j]["name"].ToString();

                comboBox[i].Items.Add("Single Platter (RS." + r.Rows[j]["singlep"].ToString() + ")");
                comboBox[i].Items.Add("Double Platter (RS." + r.Rows[j]["doublep"].ToString() + ")");
                comboBox[i].Items.Add("Family Platter (RS." + r.Rows[j]["familyp"].ToString() + ")");
                comboBox[i].SelectedIndex = 0;

                pic[i].Image = Image.FromFile(r.Rows[j]["path"].ToString());
                j++;
            }
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            Label[] labelcoll = { label1, label2, label3, label4, label5, label6 };
            for (int i = 0; i < labelcoll.Length; i++)
            {
                labelcoll[i].Text = 0.ToString();
            }
            Label[] label = { label7, label8, label9, label10, label11, label12 };
            ComboBox[] comboBox = { guna2ComboBox1, guna2ComboBox2, guna2ComboBox3,
            guna2ComboBox4,guna2ComboBox5,guna2ComboBox6};
            PictureBox[] pic = {guna2PictureBox1,guna2PictureBox2,guna2PictureBox3,
            guna2PictureBox4,guna2PictureBox5,guna2PictureBox6};

            for (int i = 0; i < comboBox.Length; i++)
            {
                comboBox[i].Items.Clear();
            }
            DataTable r = obj.novelties();
            int j = 0;
            for (int i = 0; i < label.Length; i++)
            {

                label[i].Text = r.Rows[j]["name"].ToString();

                comboBox[i].Items.Add("Single Platter (RS." + r.Rows[j]["singlep"].ToString() + ")");
                comboBox[i].Items.Add("Double Platter (RS." + r.Rows[j]["doublep"].ToString() + ")");
                comboBox[i].Items.Add("Family Platter (RS." + r.Rows[j]["familyp"].ToString() + ")");
                comboBox[i].SelectedIndex = 0;

                pic[i].Image = Image.FromFile(r.Rows[j]["path"].ToString());
                j++;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (label1.Text == 0.ToString())
            {
                MessageBox.Show("Please choose quantity");
            }
            else
            {
                int price;
                name = label7.Text;
                value = guna2ComboBox1.Text;
                string[] num = guna2ComboBox1.Text.Split('.');
                string secondpart = num[1];
                string price1 = secondpart.Substring(0, 3);
                bool containsWord = price1.Contains(")");
                if (containsWord)
                {
                    price1 = secondpart.Substring(0, 2);
                    price = int.Parse(price1);
                }
                else
                {
                    price1 = secondpart.Substring(0, 3);
                    price = int.Parse(price1);

                }
                quant = int.Parse(label1.Text);
                cmbxval = (price * quant).ToString();
                Customer c = new Customer()
                {
                    ORDER_NAME = name,
                    PRICE = cmbxval,
                };
                customers.Add(c);
                AdminDisplay a = new AdminDisplay()
                {
                    Howmuch = value,
                    Quantity = int.Parse(label1.Text),

                };
                admin.Add(a);
            }

           
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            if (label2.Text == 0.ToString())
            {
                MessageBox.Show("Please choose quantity");
            }
            else
            {
                int price;
                name = label8.Text;
                value = guna2ComboBox2.Text;
                string[] num = guna2ComboBox2.Text.Split('.');
                string secondpart = num[1];
                string price1 = secondpart.Substring(0, 3);
                bool containsWord = price1.Contains(")");
                if (containsWord)
                {
                    price1 = secondpart.Substring(0, 2);
                    price = int.Parse(price1);
                }
                else
                {
                    price1 = secondpart.Substring(0, 3);
                    price = int.Parse(price1);

                }
                quant = int.Parse(label2.Text);
                cmbxval = (price * quant).ToString();
                Customer c = new Customer()
                {
                    ORDER_NAME = name,
                    PRICE = cmbxval,
                };
                customers.Add(c);
                AdminDisplay a = new AdminDisplay()
                {
                    Howmuch = value,
                    Quantity = quant,

                };
                admin.Add(a);
            }
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            if (label3.Text == 0.ToString())
            {
                MessageBox.Show("Please choose quantity");
            }
            else
            {
                int price;
                name = label9.Text;
                value = guna2ComboBox3.Text;
                string[] num = guna2ComboBox3.Text.Split('.');
                string secondpart = num[1];
                string price1 = secondpart.Substring(0, 3);
                bool containsWord = price1.Contains(")");
                if (containsWord)
                {
                    price1 = secondpart.Substring(0, 2);
                    price = int.Parse(price1);
                }
                else
                {
                    price1 = secondpart.Substring(0, 3);
                    price = int.Parse(price1);

                }
                quant = int.Parse(label3.Text);
                cmbxval = (price * quant).ToString();
                Customer c = new Customer()
                {
                    ORDER_NAME = name,
                    PRICE = cmbxval,
                };
                customers.Add(c);
                AdminDisplay a = new AdminDisplay()
                {
                    Howmuch = value,
                    Quantity = quant,

                };
                admin.Add(a);
            }

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (label4.Text == 0.ToString())
            {
                MessageBox.Show("Please choose quantity");
            }
            else
            {
                int price;
                name = label10.Text;
                value = guna2ComboBox4.Text;
                string[] num = guna2ComboBox4.Text.Split('.');
                string secondpart = num[1];
                string price1 = secondpart.Substring(0, 3);
                bool containsWord = price1.Contains(")");
                if (containsWord)
                {
                    price1 = secondpart.Substring(0, 2);
                    price = int.Parse(price1);
                }
                else
                {
                    price1 = secondpart.Substring(0, 3);
                    price = int.Parse(price1);

                }
                quant = int.Parse(label4.Text);
                cmbxval = (price * quant).ToString();
                Customer c = new Customer()
                {
                    ORDER_NAME = name,
                    PRICE = cmbxval,
                };
                customers.Add(c);
                AdminDisplay a = new AdminDisplay()
                {
                    Howmuch = value,
                    Quantity = quant,

                };
                admin.Add(a);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (label5.Text == 0.ToString())
            {
                MessageBox.Show("Please choose quantity");
            }
            else
            {
                int price;
                name = label11.Text;
                value = guna2ComboBox5.Text;
                string[] num = guna2ComboBox5.Text.Split('.');
                string secondpart = num[1];
                string price1 = secondpart.Substring(0, 3);
                bool containsWord = price1.Contains(")");
                if (containsWord)
                {
                     price1 = secondpart.Substring(0, 2);
                     price = int.Parse(price1);
                }
                else
                {
                     price1 = secondpart.Substring(0, 3);
                     price = int.Parse(price1);

                }
                
                quant = int.Parse(label5.Text);
                cmbxval = (price * quant).ToString();
                Customer c = new Customer()
                {
                    ORDER_NAME = name,
                    PRICE = cmbxval,
                };
                customers.Add(c);
                AdminDisplay a = new AdminDisplay()
                {
                    Howmuch = value,
                    Quantity = quant,

                };
                admin.Add(a);
            }
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            if (label6.Text == 0.ToString())
            {
                MessageBox.Show("Please choose quantity");
            }
            else
            {
                int price;
                name = label12.Text;
                value = guna2ComboBox6.Text;
                string[] num = guna2ComboBox6.Text.Split('.');
                string secondpart = num[1];
                string price1 = secondpart.Substring(0, 3);
                bool containsWord = price1.Contains(")");
                if (containsWord)
                {
                    price1 = secondpart.Substring(0, 2);
                    price = int.Parse(price1);
                }
                else
                {
                    price1 = secondpart.Substring(0, 3);
                    price = int.Parse(price1);

                }
                quant = int.Parse(label6.Text);
                cmbxval = (price * quant).ToString();
                Customer c = new Customer()
                {
                    ORDER_NAME = name,
                    PRICE = cmbxval,
                };
                customers.Add(c);
                AdminDisplay a = new AdminDisplay()
                {
                    Howmuch = value,
                    Quantity = quant,

                };
                admin.Add(a);
            }
        }

        private void guna2TileButton16_Click(object sender, EventArgs e)
        {
            int quant = int.Parse(label2.Text);
            quant++;
            label2.Text = quant.ToString();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
   
}


