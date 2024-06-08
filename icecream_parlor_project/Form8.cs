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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace icecream_parlor_project
{
    public partial class Form8 : Form
    {
        public DataTable r;
        public DataTable r1;
        public List<Display> name = new List<Display>();
        public List<Display> name1 = new List<Display>();
        Logic obj = new Logic();
        public Form8()
        {
            InitializeComponent();
            label7.Visible = false;

            var o_parameters = new Dictionary<string, object>
                {
                  { "@a", "order_time" },
                  { "@b", "order_id" }
                };

            r = obj.AdminView(o_parameters);
            listView1.Items.Clear();

            foreach (DataRow row in r.Rows)
            {
                var parameters = new Dictionary<string, object>
                {
                  { "@a", int.Parse(row["order_id"].ToString()) }

                };
                r1 = obj.AdminViewOrdername(parameters);
                List<Display> name = new List<Display>();

                foreach (DataRow row1 in r1.Rows)
                {
                    Display d = new Display()
                    {
                        name = row1["name"].ToString(),
                        detail = row1["detail"].ToString(),
                        quantity = int.Parse(row1["quantity"].ToString()),
                    };
                    name.Add(d);

                }

                foreach (var names in name)
                {

                    ListViewItem itemlist = new ListViewItem(row["order_time"].ToString());
                    itemlist.SubItems.Add(row["order_id"].ToString());

                    itemlist.SubItems.Add(names.name);
                    itemlist.SubItems.Add(names.detail);
                    itemlist.SubItems.Add(names.quantity.ToString());

                    listView1.Items.Add(itemlist);

                }




            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 F = new Form7();
            F.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            
            label7.Visible = true;
            label7.Text = "";
            listView1.Items.Clear();
            foreach (DataRow row in r.Rows)
            {
                if (int.Parse(s) == int.Parse(row["order_id"].ToString()))
                {
                    label7.Text = "Total Bill :" + row["bill"].ToString();
                    //ListViewItem itemlist = new ListViewItem(row["order_time"].ToString());
                    //itemlist.SubItems.Add(row["order_id"].ToString());

                    //listView1.Items.Add(itemlist);
               
                var parameters = new Dictionary<string, object>
                {
                  { "@a", s.ToString()}

                };
                r1 = obj.AdminViewOrdername(parameters);

                name1.Clear();
                foreach (DataRow row1 in r1.Rows)
                {
                
                    Display d = new Display()
                    {
                        name = row1["name"].ToString(),
                        detail = row1["detail"].ToString(),
                        quantity = int.Parse(row1["quantity"].ToString()),
                    };
                    name1.Add(d);

                }

                foreach (var names in name1)
                {
                        ListViewItem subItemList = new ListViewItem(row["order_time"].ToString());
                        subItemList.SubItems.Add(row["order_id"].ToString());

                    //    ListViewItem subItemList = new ListViewItem("");
                    //subItemList.SubItems.Add("");
                    subItemList.SubItems.Add(names.name);
                    subItemList.SubItems.Add(names.detail);
                    subItemList.SubItems.Add(names.quantity.ToString());

                    
                    listView1.Items.Add(subItemList);

                }
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
