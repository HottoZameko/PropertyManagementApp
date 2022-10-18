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
using System.IO;

namespace PropertyManagementApp
{
    public partial class ucProperties : UserControl
    {
        public ucProperties()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fld = new OpenFileDialog();
                {
                    string fileName = fld.FileName;
                    if (fld.ShowDialog() == DialogResult.OK)
                    {
                        picProperty.Image = Image.FromFile(fld.FileName);
                    }
                }
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show("Invalid Selection, select pictures only!!");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
                bool validate = false;

                MemoryStream ms = new MemoryStream();
                picProperty.Image.Save(ms, picProperty.Image.RawFormat);

                Property property = new Property();

               

                if (string.IsNullOrEmpty(txtDescription.Text))
                {
                    errProperty.SetError(txtDescription, "Enter property description");
                    validate = false;
                }
                else if (string.IsNullOrEmpty(txtPrice.Text) || (!Regex.IsMatch(txtPrice.Text, @"^\d{0,8}(\.\d{1,4})?$")))
                {
                    errProperty.SetError(txtPrice, "Enter a valid price, numerical values only!");
                    validate = false;
                }
                else
                    validate = true;
            if (validate)
            {
                property.Description = txtDescription.Text;
                property.Price = int.Parse(txtPrice.Text);
                property.Image = ms.ToArray();
                property.PropertyTypeID = int.Parse(cmbPropertyType.SelectedValue.ToString());
                property.Status = cmbStatus.SelectedItem.ToString();
                property.SuburbID = int.Parse(cmbSurbub.SelectedValue.ToString());

                int x = bll.InsertProperty(property);
                if (x > 0)
                {
                    MessageBox.Show("Successfully added... click ok to continue!");
                    txtDescription.Clear();
                    txtPrice.Clear();
                    picProperty.Image = null;
                    errProperty.Clear();
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            LoadProperty();
        }
        public void LoadProperty()
        {
            dgvProperties.RowTemplate.Height = 40;
            dgvProperties.DataSource = bll.GetProperty();
            DataGridViewImageColumn image = new DataGridViewImageColumn();
            image.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void ucProperties_Load(object sender, EventArgs e)
        {

            LoadType();
            LoadSuburb();

            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Not available");
        }
        public void LoadType()
        {
            cmbPropertyType.DataSource = bll.GetPropertyType();
            cmbPropertyType.DisplayMember = "PropertyTypeDescription";
            cmbPropertyType.ValueMember = "PropertyTypeID";
        }
        public void LoadSuburb()
        {
            cmbSurbub.DataSource = bll.GetSuburb();
            cmbSurbub.DisplayMember = "Suburb Description";
            cmbSurbub.ValueMember = "Suburb ID";
        }

        private void dgvProperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (dgvProperties.SelectedRows.Count > 0)
                {
                    txtID.Text = dgvProperties.SelectedRows[0].Cells["Property ID"].Value.ToString();
                    txtDescription.Text = dgvProperties.SelectedRows[0].Cells["Property Description"].Value.ToString();
                    txtPrice.Text = dgvProperties.SelectedRows[0].Cells["Price"].Value.ToString();
                    MemoryStream ms = new MemoryStream((byte[])dgvProperties.SelectedRows[0].Cells["Image"].Value);
                    picProperty.Image = Image.FromStream(ms);
                    cmbPropertyType.Text = dgvProperties.SelectedRows[0].Cells["Property Type Description"].Value.ToString();
                    cmbStatus.Text = dgvProperties.SelectedRows[0].Cells["Status"].Value.ToString();
                    cmbSurbub.Text = dgvProperties.SelectedRows[0].Cells["Suburb Description"].Value.ToString();
                }
            }
            catch (System.InvalidCastException)
            {
                MessageBox.Show("Invalid column selected!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Property property = new Property();
                
                property.PropertyID = int.Parse(txtID.Text);

                int x = bll.DeleteProperty(property);

                if (x > 0)
                {
                    MessageBox.Show("Successfully DELETED... click OK to continue!");
                    LoadProperty();
                    txtDescription.Clear();
                    txtPrice.Clear();
                    picProperty.Image = null;
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("This information is active on Property agent, you cannot delete!");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Choose a column to delete");
            }
        }
         
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Property property = new Property();

                

                property.PropertyID = int.Parse(txtID.Text);
                property.PropertyTypeID = int.Parse(cmbPropertyType.SelectedValue.ToString());
                property.Price = int.Parse(txtPrice.Text);
                property.Status = cmbStatus.SelectedItem.ToString();

                int x = bll.UpdateProperty(property);

                if (x > 0)
                {
                    MessageBox.Show("Property has been Successfully UPDATED... click OK to continue!");
                    LoadProperty();
                    txtID.Clear();
                    txtDescription.Clear();
                    txtPrice.Clear();
                    picProperty.Image = null;

                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("There's a missing information... you cannot update, SORRY!!");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Select a column to update");
            }
        }
    }
}
