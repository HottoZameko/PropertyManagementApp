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
    public partial class ucAgency : UserControl
    {
        public ucAgency()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool validate = false;

            Agency agency = new Agency();


            if (string.IsNullOrEmpty(txtName.Text) || (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z\s]+$")))
            {
                errAgency.SetError(txtName, "Enter a valid name, with no numbers!");
                validate = false;
            }
            else
                validate = true;
            if (validate)
            {
                agency.AgencyName = txtName.Text;
                agency.SurbubID = int.Parse(cmbSurbub.SelectedValue.ToString());

                int x = bll.InsertAgency(agency);
                
                if (x > 0)
                {
                    MessageBox.Show("Agency successfully added... click ok to continue!");
                    errAgency.Clear();
                    txtName.Clear();
                }
            }
        }

        private void ucAgency_Load(object sender, EventArgs e)
        {
            LoadSuburb();
        }
        public void LoadSuburb()
        {
            cmbSurbub.DataSource = bll.GetSuburb();
            cmbSurbub.DisplayMember = "Suburb Description";
            cmbSurbub.ValueMember = "Suburb ID";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            LoadAgency();
        }
        public void LoadAgency()
        {
            dgvAgency.DataSource = bll.GetAgency();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Agency ag = new Agency();

                ag.AgencyID = int.Parse(txtID.Text);

                int x = bll.DeleteAgency(ag);

                if (x > 0)
                {
                    MessageBox.Show("Agency has been DELETED!! Click ok to continue");
                    txtID.Clear();
                    txtName.Clear();
                    LoadAgency();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("This information might be active, SORRY you cannot delete!!");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Select a Column to DELETE!!");
            }
        }

        private void dgvAgency_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvAgency.SelectedRows.Count > 0)
            {
                txtID.Text = dgvAgency.SelectedRows[0].Cells["Agency ID"].Value.ToString();
                txtName.Text = dgvAgency.SelectedRows[0].Cells["Agency Name"].Value.ToString();
                cmbSurbub.Text = dgvAgency.SelectedRows[0].Cells["Suburb Description"].Value.ToString();
            }
        }
    }
}
