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
    public partial class ucAgent : UserControl
    {
        public ucAgent()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool validate = false;
            Agent agent = new Agent();

            if (string.IsNullOrEmpty(txtName.Text) || (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z\s]+$")))
            {
                errName.SetError(txtName, "Enter a valid name!");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtSurname.Text) || (!Regex.IsMatch(txtSurname.Text, @"^[a-zA-Z\s]+$")))
            {
                errSurname.SetError(txtSurname, "Enter a valid Surname!");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text) || (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {
                errEmail.SetError(txtEmail, "Enter a valid Email!");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text) || (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$")))
            {
                errPassword.SetError(txtPassword, "Your password must incude Special characters, Capital letters and at least one numerical value!");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtPhone.Text) || (!Regex.IsMatch(txtPhone.Text, @"^(\+27|0)[6-8][0-9]{8}$")))
            {
                errphone.SetError(txtPhone, "Enter valid phone number!");
                validate = false;
            }
            else
                validate = true;

            if (validate)
            {
                agent.Name = txtName.Text;
                agent.Surname = txtSurname.Text;
                agent.Email = txtEmail.Text;
                agent.Password = txtPassword.Text;
                agent.Phone = int.Parse(txtPhone.Text);
                agent.Status = cmbStatus.SelectedItem.ToString();
                agent.AgencyID = int.Parse(cmbAgency.SelectedValue.ToString());

                int x = bll.InsertAgent(agent);

                if(x > 0)
                {
                    MessageBox.Show("Successfully added... click OK to continue!");
                    txtName.Clear();
                    txtSurname.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();
                    txtPhone.Clear();

                    errEmail.Clear();
                    errName.Clear();
                    errPassword.Clear();
                    errphone.Clear();
                    errSurname.Clear();
                }
            }
        }

        private void ucAgent_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Not available");
            LoadAgency();
        }
        public void LoadAgency()
        {
            cmbAgency.DataSource = bll.GetAgency();
            cmbAgency.DisplayMember = "Agency Name";
            cmbAgency.ValueMember = "Agency ID";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Agent agent = new Agent();

                agent.AgentID = int.Parse(txtID.Text);
                agent.Email = txtEmail.Text;
                agent.Phone = int.Parse(txtPhone.Text);
                agent.Status = cmbStatus.SelectedItem.ToString();

                int x = bll.UpdateAgent(agent);

                if (x > 0)
                {
                    MessageBox.Show("Agent updated Successfully!!");
                    LoadAgent();

                    txtName.Clear();
                    txtSurname.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();
                    txtPhone.Clear();
                }
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Please select a column to UPDATE!!");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            LoadAgent();
        }
        public void LoadAgent()
        {
            dgvAgent.DataSource = bll.GetAgent();
        }

        private void dgvAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvAgent.SelectedRows.Count > 0)
            {
                txtID.Text = dgvAgent.SelectedRows[0].Cells["Agent ID"].Value.ToString();
                txtName.Text = dgvAgent.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvAgent.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvAgent.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvAgent.SelectedRows[0].Cells["Password"].Value.ToString();
                txtPhone.Text = dgvAgent.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmbStatus.Text = dgvAgent.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbAgency.Text = dgvAgent.SelectedRows[0].Cells["Agency Name"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Agent agent = new Agent();

                agent.AgentID = int.Parse(txtID.Text);

                int x = bll.DeleteAgent(agent);

                if (x > 0)
                {
                    MessageBox.Show("Agent has been DELETED Successfully!");
                    LoadAgent();

                    txtName.Clear();
                    txtSurname.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();
                    txtPhone.Clear();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please select a column to DELETE!!");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("This information might be active, SORRY you cannot delete!!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
