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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            Logic obj = new Logic();

           
            DataTable r = obj.AdminView();
            listView1.Items.Clear();

            foreach (DataRow row in r.Rows)
            {
                
                DataTable r1 = obj.AdminViewOrdername(int.Parse(row["order_id"].ToString()));
                List<Display> name = new List<Display>(); 

                foreach (DataRow row1 in r1.Rows)
                {
                    Display d = new Display()
                    {
                        name = row1["name"].ToString(),
                        detail= row1["detail"].ToString(),
                        quantity= int.Parse(row1["quantity"].ToString()),
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
            List<ListViewItem> matchingItems = new List<ListViewItem>();

            foreach (ListViewItem item in listView1.Items)
            {
                // Compare the text of the first sub-item (index 0) with the search text
                if (item.SubItems.Count > 0 && item.SubItems[1].Text.ToLower() == s)
                {
                    matchingItems.Add(item); // Add matching items to the list
                }
            }
            listView1.Items.Clear();

            // Add matching items back to the ListView
            foreach (var matchingItem in matchingItems)
            {
                listView1.Items.Add(matchingItem);
            }

            // Ensure the ListView displays the selected item (if found)
            if (listView1.Items.Count > 0)
            {
                listView1.Items[0].Selected = true;
                listView1.Items[0].EnsureVisible();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }
    }
}
