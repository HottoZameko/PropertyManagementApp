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
using System.Text.RegularExpressions;

namespace PropertyManagementApp
{
    public partial class ucPropertyType : UserControl
    {
        public ucPropertyType()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool validate = false;

            PropertyType type = new PropertyType();

            if (string.IsNullOrEmpty(txtPropertyTypeDescription.Text))
            {
                errType.SetError(txtPropertyTypeDescription, "Enter valid description, use letters of alphabeths!");
                validate = false;
            }
            else
                validate = true;

            if (validate)
            {
                type.PropertyTypeDescription = txtPropertyTypeDescription.Text;


                int x = bll.InsertPropertyType(type);

                if (x > 0)
                {
                    MessageBox.Show("Property type successfully added... click ok to continue");
                    txtPropertyTypeDescription.Clear();
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvType.DataSource = bll.GetPropertyType();
        }

        private void ucPropertyType_Load(object sender, EventArgs e)
        {

        }

        private void dgvType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvType.SelectedRows.Count > 0)
            {
                txtPropertyTypeID.Text = dgvType.SelectedRows[0].Cells["PropertyTypeID"].Value.ToString();
                txtPropertyTypeDescription.Text = dgvType.SelectedRows[0].Cells["PropertyTypeDescription"].Value.ToString();
            }
        }
    }
}
