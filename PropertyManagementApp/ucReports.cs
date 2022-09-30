using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PropertyManagementApp
{
    public partial class ucReports : UserControl
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();
        public ucReports()
        {
            InitializeComponent();
        }

        private void ucReports_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            PriceSearch search = new PriceSearch();

            search.price = double.Parse(txtPrice.Text);

            dgvReports.DataSource =  bll.GetRentalsByPrice(search);
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEndedRentals_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = bll.EndedRentals();
        }

        private void btnCities_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = bll.GetCity();
        }

        private void btnProvinces_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = bll.GetProvince();
        }

        private void btnSuburbs_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = bll.GetSuburb();
        }

        private void btnPropTypes_Click(object sender, EventArgs e)
        {
            LoadPropType();
        }
        public void LoadPropType()
        {
            dgvReports.DataSource = bll.GetPropertyAndPropertyType();
        }
    }
}
