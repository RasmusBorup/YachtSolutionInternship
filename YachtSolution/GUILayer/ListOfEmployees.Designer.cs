namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class ListOfEmployees.
    /// </summary>
    partial class ListOfEmployees
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEmployees = new System.Windows.Forms.Panel();
            this.btnRefreshEmployees = new System.Windows.Forms.Button();
            this.lblSearchField = new System.Windows.Forms.Label();
            this.tbSearchField = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.panelEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmployees
            // 
            this.panelEmployees.Controls.Add(this.btnRefreshEmployees);
            this.panelEmployees.Controls.Add(this.lblSearchField);
            this.panelEmployees.Controls.Add(this.tbSearchField);
            this.panelEmployees.Controls.Add(this.btnUpdate);
            this.panelEmployees.Controls.Add(this.btnCreateEmployee);
            this.panelEmployees.Controls.Add(this.dgvEmployees);
            this.panelEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmployees.Location = new System.Drawing.Point(0, 0);
            this.panelEmployees.Name = "panelEmployees";
            this.panelEmployees.Size = new System.Drawing.Size(1008, 681);
            this.panelEmployees.TabIndex = 0;
            // 
            // btnRefreshEmployees
            // 
            this.btnRefreshEmployees.Location = new System.Drawing.Point(540, 484);
            this.btnRefreshEmployees.Name = "btnRefreshEmployees";
            this.btnRefreshEmployees.Size = new System.Drawing.Size(225, 155);
            this.btnRefreshEmployees.TabIndex = 6;
            this.btnRefreshEmployees.Text = "Refresh List";
            this.btnRefreshEmployees.UseVisualStyleBackColor = true;
            this.btnRefreshEmployees.Click += new System.EventHandler(this.btnRefreshEmployees_Click);
            // 
            // lblSearchField
            // 
            this.lblSearchField.AutoSize = true;
            this.lblSearchField.Location = new System.Drawing.Point(12, 504);
            this.lblSearchField.Name = "lblSearchField";
            this.lblSearchField.Size = new System.Drawing.Size(204, 13);
            this.lblSearchField.TabIndex = 5;
            this.lblSearchField.Text = "Search using name, job title, ssn or e-mail ";
            // 
            // tbSearchField
            // 
            this.tbSearchField.Location = new System.Drawing.Point(12, 520);
            this.tbSearchField.Name = "tbSearchField";
            this.tbSearchField.Size = new System.Drawing.Size(522, 20);
            this.tbSearchField.TabIndex = 4;
            this.tbSearchField.TextChanged += new System.EventHandler(this.tbSearchField_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(771, 565);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(225, 75);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Employee";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(771, 484);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(225, 75);
            this.btnCreateEmployee.TabIndex = 1;
            this.btnCreateEmployee.Text = "Register New Employee";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.Size = new System.Drawing.Size(984, 467);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellDoubleClick);
            // 
            // ListOfEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.panelEmployees);
            this.Name = "ListOfEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management";
            this.panelEmployees.ResumeLayout(false);
            this.panelEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmployees;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbSearchField;
        private System.Windows.Forms.Label lblSearchField;
        private System.Windows.Forms.Button btnRefreshEmployees;
    }
}