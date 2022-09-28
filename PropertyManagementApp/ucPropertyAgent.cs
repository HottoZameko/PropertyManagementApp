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
    public partial class ucPropertyAgent : UserControl
    {
        public ucPropertyAgent()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            PropertyAgent property = new PropertyAgent();
            //int PropertyAg;
            //Int32.TryParse(cmbProperty.SelectedValue.ToString(), out PropertyAg);
            property.PropertyID = int.Parse(cmbProperty.SelectedValue.ToString());
            property.AgentID = int.Parse(cmbAgent.SelectedValue.ToString());
            property.Date = dtpDate.Value.ToString();

            int x = bll.InsertPropertyAgent(property);

            if(x > 0)
            {
                MessageBox.Show("Successfully ADDED... click OK to continue!");

            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            LoadPropertyAgent();
        }
        public void LoadPropertyAgent()
        {
            dgvPropertyAgent.DataSource = bll.GetPropertyAgent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                PropertyAgent property = new PropertyAgent();
                //int PropertyAg;
                //Int32.TryParse(cmbProperty.SelectedItem.ToString(), out PropertyAg);
                property.PropertyAgentID = int.Parse(txtPropertyAgentID.Text);
                property.PropertyID = int.Parse(cmbProperty.SelectedValue.ToString());
                property.AgentID = int.Parse(cmbAgent.SelectedValue.ToString());
                property.Date = dtpDate.Value.ToString();

                int x = bll.UpdatePropertyAgent(property);

                if (x > 0)
                {
                    MessageBox.Show("Successfully UPDATED... click OK to continue!");
                    LoadPropertyAgent();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Select a column you want update!");
            }
        }
        private void ucPropertyAgent_Load(object sender, EventArgs e)
        {
            LoadAgent();
            LoadProperty();
        }
        public void LoadAgent()
        {
            cmbAgent.DataSource = bll.GetAgent();
            cmbAgent.DisplayMember = "Name";
            cmbAgent.ValueMember = "Agent ID";
        }
        public void LoadProperty()
        {
            cmbProperty.DataSource = bll.GetProperty();
            cmbProperty.DisplayMember = "Property Description";
            cmbProperty.ValueMember = "Property ID";
        }

        private void dgvPropertyAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPropertyAgent.SelectedRows.Count > 0)
            {
                txtPropertyAgentID.Text = dgvPropertyAgent.SelectedRows[0].Cells["Property Agent ID"].Value.ToString();
                cmbProperty.Text = dgvPropertyAgent.SelectedRows[0].Cells["Property Description"].Value.ToString();
                cmbAgent.Text = dgvPropertyAgent.SelectedRows[0].Cells["Agent Name"].Value.ToString();
                dtpDate.Text = dgvPropertyAgent.SelectedRows[0].Cells["Date"].Value.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
