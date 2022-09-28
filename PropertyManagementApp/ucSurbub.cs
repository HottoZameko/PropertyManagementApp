using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace PropertyManagementApp
{
    public partial class ucSurbub : UserControl
    {
        public ucSurbub()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool validate = false;

            Suburb suburb = new Suburb();


            if (string.IsNullOrEmpty(txtSurbubDescription.Text))
            {
                errSubub.SetError(txtSurbubDescription, "Enter a Suburb description");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtPostalCode.Text))
            {
                errSubub.SetError(txtPostalCode, "Enter a valid postal code");
                validate = false;
            }
            else
                validate = true;
            if (validate)
            {
                suburb.SurbubDescription = txtSurbubDescription.Text;
                suburb.PostalCode = int.Parse(txtPostalCode.Text);
                suburb.CityID = int.Parse(cmbCity.SelectedValue.ToString());

                int x = bll.InsertSuburb(suburb);

                if(x > 0)
                {
                    MessageBox.Show("Suburb has been successfully added.");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            LoadSuburb();
        }
        public void LoadSuburb()
        {
            dgvSurbub.DataSource = bll.GetSuburb();
        }

        private void ucSurbub_Load(object sender, EventArgs e)
        {
            LoadCity();
        }
        public void LoadCity()
        {
            cmbCity.DataSource = bll.GetCity();
            cmbCity.DisplayMember = "City Description";
            cmbCity.ValueMember = "City ID";
        }
    }
}
