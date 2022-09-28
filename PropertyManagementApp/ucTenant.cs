using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DAL;
using BLL;

namespace PropertyManagementApp
{
    public partial class ucTenant : UserControl
    {
        public ucTenant()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool validate = false;

            Tenant tenant = new Tenant();

            if (string.IsNullOrEmpty(txtName.Text) || (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z\s]+$")))
            {
                errName.SetError(txtName, "Enter a valid name!");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtSurname.Text) || (!Regex.IsMatch(txtSurname.Text, @"^[a-zA-Z\s]+$")))
            {
                errSurname.SetError(txtSurname, "Enter a valid Surname!");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text) || (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {
                errEmail.SetError(txtEmail, "Enter a valid Email!");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text) || (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$")))
            {
                errPassword.SetError(txtPassword, "Your password must incude Special characters, Capital letters and at least one numerical value!");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtPhone.Text) || (!Regex.IsMatch(txtPhone.Text, @"^(\+27|0)[6-8][0-9]{8}$")))
            {
                errPhone.SetError(txtPhone, "Enter valid phone number!");
                validate = false;
            }
            else
                validate = true;
            if (validate)
            {
                tenant.Name = txtName.Text;
                tenant.Surname = txtSurname.Text;
                tenant.Email = txtEmail.Text;
                tenant.Password = txtPassword.Text;
                tenant.Phone = int.Parse(txtPhone.Text);
                tenant.Status = cmbStatus.SelectedItem.ToString();

                int x = bll.InsertTenant(tenant);

                if (x > 0)
                {
                    MessageBox.Show("Tenant successfully added... click OK to continue");
                    txtName.Clear();
                    txtSurname.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();
                    txtPhone.Clear();
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            LoadTenant();

        }
        public void LoadTenant()
        {
            dgvTenant.DataSource = bll.GetTenant();
        }

        private void ucTenant_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Not-Active");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Tenant tenant = new Tenant();

                tenant.TenantID = int.Parse(txtID.Text);
                tenant.Email = txtEmail.Text;
                tenant.Phone = int.Parse(txtPhone.Text);
                tenant.Status = cmbStatus.SelectedItem.ToString();

                int x = bll.UpdateTenant(tenant);

                if (x > 0)
                {
                    MessageBox.Show("Tenant UPDATED Successfully!");
                    LoadTenant();

                    txtName.Clear();
                    txtSurname.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();
                    txtPhone.Clear();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Select a column to update");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                Tenant tenant = new Tenant();

                tenant.TenantID = int.Parse(txtID.Text);

                int x = bll.DeleteTenant(tenant);

                if (x > 0)
                {
                    MessageBox.Show("Tenant DELETED Successfully!");
                    LoadTenant();

                    txtName.Clear();
                    txtSurname.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();
                    txtPhone.Clear();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Select a column to DELETE!!");
            }
        }

        private void dgvTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTenant.SelectedRows.Count > 0)
            {
                txtID.Text = dgvTenant.SelectedRows[0].Cells["TenantID"].Value.ToString();
                txtName.Text = dgvTenant.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvTenant.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvTenant.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvTenant.SelectedRows[0].Cells["Password"].Value.ToString();
                txtPhone.Text = dgvTenant.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmbStatus.Text = dgvTenant.SelectedRows[0].Cells["Status"].Value.ToString(); 
            }
        }
    }
}
