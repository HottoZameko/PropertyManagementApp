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
    public partial class ucRental : UserControl
    {
        public ucRental()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtRentalID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucRental_Load(object sender, EventArgs e)
        {
            LoadTenant();
            LoadPropertyAgent();
        }
        public void LoadTenant()
        {
            cmbTenant.DataSource = bll.GetTenant();
            cmbTenant.DisplayMember = "Name";
            cmbTenant.ValueMember = "TenantID";
        }
        public void LoadPropertyAgent()
        {
            cmbPropertyAgent.DataSource = bll.GetPropertyAgent();
            cmbPropertyAgent.DisplayMember = "Property Agent ID";
            cmbPropertyAgent.ValueMember = "Property Agent ID";
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Rental rental = new Rental();

            int PropertyAge;
            Int32.TryParse(cmbPropertyAgent.SelectedValue.ToString(), out PropertyAge);

            rental.PropertyAgentID = int.Parse(cmbPropertyAgent.SelectedValue.ToString());
            rental.TenantID = int.Parse(cmbTenant.SelectedValue.ToString());
            rental.StartDate = dtpStartDate.Value.ToString();
            rental.EndDate = dtpStartDate.Value.ToString();

            int x = bll.InsertRental(rental);

            if (x > 0)
            {
                MessageBox.Show("Successfully added... click ok to continue!");

            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            LoadRental();
        }
        public void LoadRental()
        {
            dgvRental.DataSource = bll.GetRental();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Rental rental = new Rental();

                rental.RentalID = int.Parse(txtRentalID.Text);
                rental.StartDate = dtpStartDate.Value.ToString();
                rental.EndDate = dtpEndDate.Value.ToString();

                int x = bll.UpdateRental(rental);

                if (x > 0)
                {
                    MessageBox.Show("Updated successfully... click OK to continue!!");
                    LoadRental();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Select a column to update");
            }
        }

        private void dgvRental_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRental.SelectedRows.Count > 0)
            {
                txtRentalID.Text = dgvRental.SelectedRows[0].Cells["Rental ID"].Value.ToString();
                cmbPropertyAgent.Text = dgvRental.SelectedRows[0].Cells["PropertyAgentID"].Value.ToString();
                cmbTenant.Text = dgvRental.SelectedRows[0].Cells["Tenant Name"].Value.ToString();
                dtpStartDate.Text = dgvRental.SelectedRows[0].Cells["Start Date"].Value.ToString();
                dtpEndDate.Text = dgvRental.SelectedRows[0].Cells["End Date"].Value.ToString();
            }
        }
    }
}
