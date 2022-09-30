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
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
             
        }

        private void btnPropertyType_Click(object sender, EventArgs e)
        {
            ucPropertyType1.BringToFront();
            lblNewTex.Text = "Manage Property type";

        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            ucProperties1.BringToFront();
            lblNewTex.Text = "Manage Properties";

            ucProperties1.LoadSuburb();
            ucProperties1.LoadType();

        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            ucProvince1.BringToFront();
            lblNewTex.Text = "Manage Province";
            
        }

        private void btnCities_Click(object sender, EventArgs e)
        {
            ucCities1.BringToFront();
            lblNewTex.Text = "Manage City";

            ucCities1.LoadProvince();

        }

        private void btnSurbub_Click(object sender, EventArgs e)
        {
            ucSurbub1.BringToFront();
            lblNewTex.Text = "Manage Suburb";

            ucSurbub1.LoadCity();

        }

        private void btnAgencies_Click(object sender, EventArgs e)
        {
            
            ucAgency1.BringToFront();
            lblNewTex.Text = "Manage Agency";

            ucAgency1.LoadSuburb();
            
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            ucAgent1.BringToFront();
            lblNewTex.Text = "Manage Agent";

            ucAgent1.LoadAgency();

        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            ucTenant1.BringToFront();
            lblNewTex.Text = "Manage Tenant";
        }


        
        private void btnPropertyAgent_Click(object sender, EventArgs e)
        {
            ucPropertyAgent1.LoadProperty();
            ucPropertyAgent1.LoadAgent();

            ucPropertyAgent1.BringToFront();
            lblNewTex.Text = "Manage Property Agent";
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            ucRental1.BringToFront();
            lblNewTex.Text = "Manage Rental";

            ucRental1.LoadPropertyAgent();
            ucRental1.LoadTenant();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            ucAdministrator1.BringToFront();
            lblNewTex.Text = "Adminnistrator";
            
        }

        private void btnReports_MouseClick(object sender, MouseEventArgs e)
        {
            ucReports1.BringToFront();
        }

        private void frmMenu_Activated(object sender, EventArgs e)
        {
           
        }

        private void ucReports1_Load(object sender, EventArgs e)
        {

        }
    }
}
