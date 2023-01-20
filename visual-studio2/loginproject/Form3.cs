using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginproject
{

    public partial class Form3 : Form
    {
        

        public static int count = 0;
        public static DataTable dt;
        public static DataTable unaloc;
        public static DataTable aloc;
    
       


        public Form3()
        {
            InitializeComponent();
        }

        public static DataTable getTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Symbol",typeof(string));
            dt.Columns.Add("Side", typeof(string));
            dt.Columns.Add("Account", typeof(string));
            dt.Columns.Add("AvgPrice", typeof(string));
            dt.Columns.Add("Quantity", typeof(string));
            dt.Columns.Add("RemainingQuantity", typeof(string));
            dt.Columns.Add("OrderStatus", typeof(string));
            dt.Columns.Add("CLOrderID", typeof(string));
            dt.Columns.Add("ParentCLOrderID", typeof(string));
            dt.Columns.Add("StagedOrderID", typeof(string));
            dt.Columns.Add("OriginalCLOrderID", typeof(string));
            

            return dt;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            
            if (count == 1)
            {
                dt =  getTable();
                unaloc = getTable();
                aloc = getTable();
                dt.Rows.Add(symbolBox.Text, comboBox1.Text, comboBox2.Text, textBox2.Text, textBox3.Text, null , null , null , null,null , null);
                Form4 f = new Form4(dt);
                f.Show();
                if (comboBox2.Text == "Unallocated")
                {
                    unaloc.Rows.Add(symbolBox.Text, comboBox1.Text, comboBox2.Text, textBox2.Text, textBox3.Text, null, null, null, null, null, null);
                    Allocation allocation = new Allocation(aloc, unaloc);
                    allocation.Show();
                }
                else
                {
                    aloc.Rows.Add(symbolBox.Text, comboBox1.Text, comboBox2.Text, textBox2.Text, textBox3.Text, null, null, null, null, null, null);
                    Allocation allocation = new Allocation( aloc ,  unaloc);
                    allocation.Show();
                }
                
                
            }
            else
            {
                dt.Rows.Add(symbolBox.Text, comboBox1.Text, comboBox2.Text, textBox2.Text, textBox3.Text, null, null, null, null, null, null);
                Form4 f = new Form4(dt);
                if (comboBox2.Text == "Unallocated")
                {
                    unaloc.Rows.Add(symbolBox.Text, comboBox1.Text, comboBox2.Text, textBox2.Text, textBox3.Text, null, null, null, null, null, null);
                    Allocation allocation = new Allocation(aloc, unaloc);
                    
                }
                else
                {
                    aloc.Rows.Add(symbolBox.Text, comboBox1.Text, comboBox2.Text, textBox2.Text, textBox3.Text, null, null, null, null, null, null);
                    Allocation allocation = new Allocation(aloc, unaloc);
                    
                }

            }
            string text = "Your order is placed";
            MessageBox.Show(text, "Success Message");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text2 = "Your order is placed";
            MessageBox.Show(text2, "Success Message");
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Select Side")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Select Side";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            if(comboBox2.Text=="Select Account")
            {
                comboBox2.Text = "";
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                comboBox2.Text = "Select Account";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);        
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)&& !(e.KeyChar=='.');
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            
        }
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
