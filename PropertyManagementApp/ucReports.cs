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
            try
            {
                PriceSearch search = new PriceSearch();

                search.price = double.Parse(txtPrice.Text);

                dgvReports.DataSource = bll.GetRentalsByPrice(search);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Enter property price you want to view!!...click OK to continue!");
            }
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
            dgvReports.DataSource = bll.FullLocation();
        }

        //private void btnProvinces_Click(object sender, EventArgs e)
        //{
        //    dgvReports.DataSource = bll.GetProvince();
        //}

        //private void btnSuburbs_Click(object sender, EventArgs e)
        //{
        //    dgvReports.DataSource = bll.GetSuburb();
        //}

        private void btnPropTypes_Click(object sender, EventArgs e)
        {
            LoadPropType();
        }
        public void LoadPropType()
        {
            dgvReports.DataSource = bll.GetPropertyAndPropertyType();
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            ViewRentals();
        }
        public void ViewRentals()
        {
            dgvReports.DataSource = bll.ViewRentals();
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem.ToString() == "Admins")
            {
                dgvReports.DataSource = bll.ViewAdmin();
            }
            else if (cmbUsers.SelectedItem.ToString() == "Tenants")
            {
                dgvReports.DataSource = bll.ViewTenant();
            }
            else if (cmbUsers.SelectedItem.ToString() == "Agents")
            {
                dgvReports.DataSource = bll.ViewAgent();
            }
            else
                MessageBox.Show("Invalid user Selected!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvReports.DataSource = bll.MostManagingAgent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucExtraReports uc = new ucExtraReports();
            uc.BringToFront();
        }
    }
}
