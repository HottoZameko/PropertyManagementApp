
namespace PropertyManagementApp
{
    partial class ucReports
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnEndedRentals = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCities = new System.Windows.Forms.Button();
            this.btnPropTypes = new System.Windows.Forms.Button();
            this.btnAllUsers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.btnTypesAndProperties = new System.Windows.Forms.GroupBox();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnProvinces = new System.Windows.Forms.Button();
            this.btnSuburbs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.btnTypesAndProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuburbs);
            this.groupBox1.Controls.Add(this.btnProvinces);
            this.groupBox1.Controls.Add(this.btnPrice);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.btnEndedRentals);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCities);
            this.groupBox1.Controls.Add(this.btnPropTypes);
            this.groupBox1.Controls.Add(this.btnAllUsers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbUsers);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(14, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Reports";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(716, 54);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 27);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // btnEndedRentals
            // 
            this.btnEndedRentals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEndedRentals.FlatAppearance.BorderSize = 0;
            this.btnEndedRentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndedRentals.Location = new System.Drawing.Point(798, 16);
            this.btnEndedRentals.Name = "btnEndedRentals";
            this.btnEndedRentals.Size = new System.Drawing.Size(150, 32);
            this.btnEndedRentals.TabIndex = 6;
            this.btnEndedRentals.Text = "Ended Rentals";
            this.btnEndedRentals.UseVisualStyleBackColor = false;
            this.btnEndedRentals.Click += new System.EventHandler(this.btnEndedRentals_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search Rental Price:";
            // 
            // btnCities
            // 
            this.btnCities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCities.FlatAppearance.BorderSize = 0;
            this.btnCities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCities.Location = new System.Drawing.Point(329, 16);
            this.btnCities.Name = "btnCities";
            this.btnCities.Size = new System.Drawing.Size(117, 32);
            this.btnCities.TabIndex = 4;
            this.btnCities.Text = "Cities";
            this.btnCities.UseVisualStyleBackColor = false;
            this.btnCities.Click += new System.EventHandler(this.btnCities_Click);
            // 
            // btnPropTypes
            // 
            this.btnPropTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPropTypes.FlatAppearance.BorderSize = 0;
            this.btnPropTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPropTypes.Location = new System.Drawing.Point(560, 16);
            this.btnPropTypes.Name = "btnPropTypes";
            this.btnPropTypes.Size = new System.Drawing.Size(243, 32);
            this.btnPropTypes.TabIndex = 3;
            this.btnPropTypes.Text = "Properties and Property Type";
            this.btnPropTypes.UseVisualStyleBackColor = false;
            this.btnPropTypes.Click += new System.EventHandler(this.btnPropTypes_Click);
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAllUsers.FlatAppearance.BorderSize = 0;
            this.btnAllUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllUsers.Location = new System.Drawing.Point(442, 16);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(122, 32);
            this.btnAllUsers.TabIndex = 2;
            this.btnAllUsers.Text = "All Users";
            this.btnAllUsers.UseVisualStyleBackColor = false;
            this.btnAllUsers.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Users:";
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(108, 57);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(250, 29);
            this.cmbUsers.TabIndex = 0;
            this.cmbUsers.Text = "-Select User To View-";
            // 
            // btnTypesAndProperties
            // 
            this.btnTypesAndProperties.Controls.Add(this.dgvReports);
            this.btnTypesAndProperties.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypesAndProperties.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTypesAndProperties.Location = new System.Drawing.Point(14, 164);
            this.btnTypesAndProperties.Name = "btnTypesAndProperties";
            this.btnTypesAndProperties.Size = new System.Drawing.Size(953, 218);
            this.btnTypesAndProperties.TabIndex = 1;
            this.btnTypesAndProperties.TabStop = false;
            this.btnTypesAndProperties.Text = "View Reports";
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(16, 20);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.Size = new System.Drawing.Size(931, 188);
            this.dgvReports.TabIndex = 0;
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.Color.Green;
            this.btnPrice.Location = new System.Drawing.Point(822, 54);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(126, 27);
            this.btnPrice.TabIndex = 10;
            this.btnPrice.Text = "Search Price";
            this.btnPrice.UseVisualStyleBackColor = false;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnProvinces
            // 
            this.btnProvinces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProvinces.FlatAppearance.BorderSize = 0;
            this.btnProvinces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvinces.Location = new System.Drawing.Point(216, 16);
            this.btnProvinces.Name = "btnProvinces";
            this.btnProvinces.Size = new System.Drawing.Size(117, 32);
            this.btnProvinces.TabIndex = 11;
            this.btnProvinces.Text = "Provinces";
            this.btnProvinces.UseVisualStyleBackColor = false;
            this.btnProvinces.Click += new System.EventHandler(this.btnProvinces_Click);
            // 
            // btnSuburbs
            // 
            this.btnSuburbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuburbs.FlatAppearance.BorderSize = 0;
            this.btnSuburbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuburbs.Location = new System.Drawing.Point(108, 16);
            this.btnSuburbs.Name = "btnSuburbs";
            this.btnSuburbs.Size = new System.Drawing.Size(117, 32);
            this.btnSuburbs.TabIndex = 12;
            this.btnSuburbs.Text = "Suburbs";
            this.btnSuburbs.UseVisualStyleBackColor = false;
            this.btnSuburbs.Click += new System.EventHandler(this.btnSuburbs_Click);
            // 
            // ucReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.btnTypesAndProperties);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucReports";
            this.Size = new System.Drawing.Size(1035, 422);
            this.Load += new System.EventHandler(this.ucReports_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.btnTypesAndProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAllUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.GroupBox btnTypesAndProperties;
        private System.Windows.Forms.Button btnPropTypes;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnEndedRentals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCities;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnSuburbs;
        private System.Windows.Forms.Button btnProvinces;
    }
}
