using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace PropertyManagementApp
{
    public partial class ucExtraReports : UserControl
    {
        public ucExtraReports()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvExtra.DataSource = bll.SearchBetweenPrice(double.Parse(txtFrom.Text), double.Parse(txtTo.Text));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Enter a valid Price... click OK to continue...");
            }
        }
    }
}
