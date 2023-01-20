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
    public partial class Form4 : Form
    {
        public Form4(DataTable dt)
        {
            InitializeComponent();
            ultraGrid1.DataSource = dt;
            ultraGrid1.Refresh();
        }

        public Form4()
        {
            InitializeComponent();

        }

        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {

        }

        private void ultraDataSource1_CellDataRequested(object sender, Infragistics.Win.UltraWinDataSource.CellDataRequestedEventArgs e)
        {

        }
    }
}
