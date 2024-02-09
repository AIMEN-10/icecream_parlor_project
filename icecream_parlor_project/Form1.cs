using Business_layer;
using Business_Layer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace icecream_parlor_project
{
    public partial class Form1 : Form
    {
        BindingList<Customer> customer=new BindingList<Customer>();
        BindingList<AdminDisplay> temp = new BindingList<AdminDisplay>();

        public Form1(BindingList<Customer> receivedList, BindingList<AdminDisplay> receivedList1)
        {
            InitializeComponent();
            DateTime curr = DateTime.Now;
            label4.Text = curr.ToString();
            guna2DataGridView1.DataSource = receivedList;
            //TODO: remove
            //listView1.Columns.Add("Name");
            //listView1.Columns.Add("ID");
            //listView1.View = View.Details;
            //foreach (var adminDisplayItem in receivedList1)
            //{
            //    ListViewItem listViewItem = new ListViewItem(adminDisplayItem.howmuch);
            //    listViewItem.SubItems.Add(adminDisplayItem.quantity.ToString());
            //    listView1.Items.Add(listViewItem);
            //}
            temp = receivedList1;

        }




        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < guna2DataGridView1.RowCount; i++)
            {


                string name = guna2DataGridView1.Rows[i].Cells[0].Value?.ToString();
                string price = guna2DataGridView1.Rows[i].Cells[1].Value?.ToString();

                Customer newCustomer = new Customer
                {
                    ORDER_NAME = name,
                    PRICE= price,
                    
                };

                customer.Add(newCustomer);
            }
            this.Hide();
            Form6 f=new Form6(customer);
            f.Show();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
              
                guna2DataGridView1.Rows.RemoveAt(e.RowIndex);
                temp.RemoveAt(e.RowIndex);
            }
            
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            int sum=0;
            List<int> list = new List<int>();
            for(int i = 0; i < guna2DataGridView1.RowCount; i++)
            {
                sum += int.Parse(guna2DataGridView1.Rows[i].Cells[1].Value.ToString());
            }
            List<string> customer = new List<string>();
            for (int i = 0; i < guna2DataGridView1.RowCount; i++)
            {
                string name = guna2DataGridView1.Rows[i].Cells[0].Value?.ToString();

                customer.Add(name);
            }
            Logic obj = new Logic();

            int id= int.Parse(label3.Text);
            DateTime date = DateTime.Parse(label4.Text);
            obj.order(date,id,sum);
           
            for (int i = 0; i < guna2DataGridView1.Rows.Count ; i++)
            {
                string val = guna2DataGridView1.Rows[i].Cells[0].Value?.ToString();
                string detail = temp[i].Howmuch;
                int quant= temp[i].Quantity;
                obj.order_name(id,val,detail,quant);
            }
            this.Hide();
            Form9 f = new Form9(sum);
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Logic obj = new Logic();
            try
            {
                DataTable r = obj.id();
                if (r == null)
                {
                    label3.Text = 1.ToString();
                }
                else
                {

                    string id1 = r.Rows[0]["order_id"].ToString();
                    int or_id = int.Parse(id1);
                    int temp_orid = or_id+1;
                    label3.Text = temp_orid.ToString();
                }
            }
            catch 
            {
                label3.Text = 1.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
