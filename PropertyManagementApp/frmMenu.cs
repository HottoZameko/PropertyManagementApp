using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PropertyManagementApp
{
    public partial class frmMenu : Form
    {
        public string UserName { get; set; }
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
             
        }

        private void btnPropertyType_Click(object sender, EventArgs e)
        {
            if (lblLoginInfo.Text == "Admin")
            {
                ucPropertyType1.BringToFront(); 
                lblNewTex.Text = "Manage Property type";
            }
            else
                MessageBox.Show("You need to login as Admin to have an access!!");
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            if (lblLoginInfo.Text == "Admin" || lblLoginInfo.Text == "Agent")
            {
                ucProperties1.BringToFront();
                lblNewTex.Text = "Manage Properties";
                ucProperties1.LoadSuburb();
                ucProperties1.LoadType();
            }
            else
                MessageBox.Show("You need to login as Admin or Agent to have an access!!");
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {if (lblLoginInfo.Text == "Admin")
            {
                ucProvince1.BringToFront();
                lblNewTex.Text = "Manage Province";
            }
            else
                MessageBox.Show("You need to login as Admin to have an access!!");
        }

        private void btnCities_Click(object sender, EventArgs e)
        {if (lblLoginInfo.Text == "Admin")
            {
                ucCities1.BringToFront();
                lblNewTex.Text = "Manage City";
                ucCities1.LoadProvince();
            }
            else
                MessageBox.Show("You need to login as Admin to have an access!!");
        }

        private void btnSurbub_Click(object sender, EventArgs e)
        {
            if (lblLoginInfo.Text == "Admin")
            {
                ucSurbub1.BringToFront();
                lblNewTex.Text = "Manage Suburb";
                ucSurbub1.LoadCity();
            }
            else
                MessageBox.Show("You need to login as Admin to have an access!!");
        }

        private void btnAgencies_Click(object sender, EventArgs e)
        {
            if (lblLoginInfo.Text == "Admin")
            {
                ucAgency1.BringToFront();
                lblNewTex.Text = "Manage Agency";
                ucAgency1.LoadSuburb();
            }
            else
                MessageBox.Show("You need to login as Admin to have an access!!");
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            if(lblLoginInfo.Text == "Agent")
            {
                ucAgent1.BringToFront();
                lblNewTex.Text = "Manage Agent";

                ucAgent1.LoadAgency();
            }
            else
                MessageBox.Show("You need to login as Admin to have an access!!");
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            if (lblLoginInfo.Text == "Tenant")
            {
                ucTenant1.BringToFront();
                lblNewTex.Text = "Manage Tenant";
            }
            else
                MessageBox.Show("You need to login as a Tenant to have an access");
        }

        private void btnPropertyAgent_Click(object sender, EventArgs e)
        {
            if (lblLoginInfo.Text == "Admin" || lblLoginInfo.Text == "Agent")
            {

                ucPropertyAgent1.LoadProperty();
                ucPropertyAgent1.LoadAgent();

                ucPropertyAgent1.BringToFront();
                lblNewTex.Text = "Manage Property Agent";
            }
            else
                MessageBox.Show("You need to login as Admin or Agent to have an access!!");

        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            if (lblLoginInfo.Text == "Tenant" || lblLoginInfo.Text == "Agent")
            {
                ucRental1.BringToFront();
                lblNewTex.Text = "Manage Rental";

                ucRental1.LoadPropertyAgent();
                ucRental1.LoadTenant();
            }
            else
                MessageBox.Show("You need to login as Tenant or Agent to have an access!!");
           
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblLoginInfo.Text = UserName;
            ucReports1.Enabled = false;
        }
        
        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            if (lblLoginInfo.Text == "Admin")
            {
                ucAdministrator1.BringToFront();
                lblNewTex.Text = "Administrator";
            }
            else
                MessageBox.Show("You need to login as Admin to have an access!!");

        }

        private void btnReports_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (lblLoginInfo.Text == "Admin")
            {
                ucReports1.BringToFront();
                lblNewTex.Text = "Reports Viewing For Properties";
                ucReports1.Enabled = true;
            }
            else
            {
                
                MessageBox.Show("You need to login as Admin to have an access!!");
            }
               
               

        }

        private void frmMenu_Activated(object sender, EventArgs e)
        {
           
        }

        private void ucReports1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }
    }
}
