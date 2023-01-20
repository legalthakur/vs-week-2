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
    public partial class Allocation : Form
    {

        public Allocation(DataTable aloc , DataTable unaloc)
        {
            InitializeComponent();
            ultraGrid1.DataSource = unaloc;
            ultraGrid2.DataSource = aloc;
            ultraGrid1.Refresh();
            ultraGrid2.Refresh();
        }
        public Allocation()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
