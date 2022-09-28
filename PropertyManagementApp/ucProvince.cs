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
    public partial class ucProvince : UserControl
    {
        public ucProvince()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool validate = false;

            Province province = new Province();

            if (string.IsNullOrEmpty(txtDescription.Text) || (!Regex.IsMatch(txtDescription.Text, @"^[a-zA-Z\s]+$")))
            {
                errProvince.SetError(txtDescription, "Enter a valid province!!");
                validate = false;
            }
            else
                validate = true;
            if (validate)
            {
                province.ProvinceDescription = txtDescription.Text;

                int x = bll.InsertProvince(province);
                if (x > 0)
                {
                    MessageBox.Show("Province successfully added... click ok to continue!!");
                    txtDescription.Clear();
                    errProvince.Clear();
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvProvince.DataSource = bll.GetProvince();
        }

        private void ucProvince_Load(object sender, EventArgs e)
        {

        }
    }
}
