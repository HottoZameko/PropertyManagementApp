using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DAL;
using BLL;

namespace PropertyManagementApp
{
    public partial class ucAdministrator : UserControl
    {
        public ucAdministrator()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool validate = false;

            Administrator admin = new Administrator();
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
            else
                validate = true;
            if (validate)
            {
                admin.Name = txtName.Text;
                admin.Surname = txtSurname.Text;
                admin.Email = txtEmail.Text;
                admin.Password = txtPassword.Text;
                admin.Status = cmbStatus.SelectedItem.ToString();

                int x = bll.InsertAdmin(admin);

                if(x > 0)
                {
                    MessageBox.Show("Admin Info. has been captured Successfully!!");

                    txtAdminID.Clear();
                    txtName.Clear();
                    txtSurname.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();
                    errEmail.Clear();
                    errName.Clear();
                    errPassword.Clear();
                    errSurname.Clear();
                }
            }
        }

        private void ucAdministrator_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In-activae");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            LoadAdmin();
        }
        public void LoadAdmin()
        {
            dgvAdmin.DataSource = bll.GetAdmin();
        }
    }
}
