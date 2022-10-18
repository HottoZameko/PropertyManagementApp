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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.UserName = cmbUser.SelectedItem.ToString() + ": Registration";
            frm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUser.SelectedItem.ToString() == "Admin")
                {
                    DataTable dt = bll.AdminLogin(txtUsername.Text, txtPassword.Text);

                    if (dt.Rows.Count > 0)
                    {
                        frmMenu frm = new frmMenu();
                        frm.UserName = cmbUser.SelectedItem.ToString();
                        frm.Show();
                        this.Hide();

                    }
                    else
                        lblIncorrect.Visible = true;

                }

                else if (cmbUser.SelectedItem.ToString() == "Tenant")
                {
                    DataTable dt = bll.TenantLogin(txtUsername.Text, txtPassword.Text);

                    if (dt.Rows.Count > 0)
                    {
                        frmMenu frm = new frmMenu();
                        frm.UserName = cmbUser.SelectedItem.ToString();
                        frm.Show();
                        this.Hide();
                    }
                    else
                        lblIncorrect.Visible = true;
                }
                else if (cmbUser.SelectedItem.ToString() == "Agent")
                {
                    DataTable dt = bll.AgentLogin(txtUsername.Text, txtPassword.Text);

                    if (dt.Rows.Count > 0)
                    {
                        frmMenu frm = new frmMenu();
                        frm.UserName = cmbUser.SelectedItem.ToString();
                        frm.Show();
                        this.Hide();
                    }
                    else
                        lblIncorrect.Visible = true;
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Please select user Role.");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
