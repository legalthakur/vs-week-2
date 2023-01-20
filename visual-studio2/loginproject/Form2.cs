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
    public partial class Form2 : Form
    {
        public Form2(DataTable dt)
        {
            InitializeComponent();
            DataTable dt2 = dt;

        }
        public Form2()
        {
            InitializeComponent();
            
        }

        private void tradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void blotterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = Form3.dt;
            Form4 form4 = new Form4(dt);
            form4.Show();
        }

        private void allocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable aloc = Form3.aloc;
            DataTable unaloc = Form3.unaloc;
            Allocation allocation = new Allocation(aloc , unaloc);
            allocation.Show();
        }
    }
}
