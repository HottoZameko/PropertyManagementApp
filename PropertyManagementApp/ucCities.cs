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
using BLL;
using DAL;

namespace PropertyManagementApp
{
    public partial class ucCities : UserControl
    {
        public ucCities()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void ucCities_Load(object sender, EventArgs e)
        {
            LoadProvince();
        }
        public void LoadProvince()
        {
            cmbProvince.DataSource = bll.GetProvince();

            cmbProvince.DisplayMember = "ProvinceDescription";
            cmbProvince.ValueMember = "ProvinceID";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool validate = false;

            City city = new City();

            if (string.IsNullOrEmpty(txtDescription.Text) || (!Regex.IsMatch(txtDescription.Text, @"^[a-zA-Z\s]+$")))
            {
                errCity.SetError(txtDescription, "Please Enter a valid city");
                validate = false;
            }
            else
                validate = true;
            if (validate)
            {
                city.CityDescription = txtDescription.Text;
                city.ProvinceID = int.Parse(cmbProvince.SelectedValue.ToString());

                int x = bll.InsertCity(city);

                if (x > 0)
                {
                    MessageBox.Show("Successfully added... click ok to continue!");
                    txtDescription.Clear();
                    errCity.Clear();
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            LoadCity();
        }
        public void LoadCity()
        {
            dgvCities.DataSource = bll.GetCity();
        }
    }
}
