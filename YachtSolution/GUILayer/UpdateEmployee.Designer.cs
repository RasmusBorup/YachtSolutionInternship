namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class UpdateEmployee.
    /// </summary>
    partial class UpdateEmployee
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
            this.panelUpdateEmployee = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbSSN = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.cbJobRole = new System.Windows.Forms.ComboBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelUpdateEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUpdateEmployee
            // 
            this.panelUpdateEmployee.Controls.Add(this.btnDelete);
            this.panelUpdateEmployee.Controls.Add(this.btnCancel);
            this.panelUpdateEmployee.Controls.Add(this.btnUpdate);
            this.panelUpdateEmployee.Controls.Add(this.btnAddPhoto);
            this.panelUpdateEmployee.Controls.Add(this.pbPhoto);
            this.panelUpdateEmployee.Controls.Add(this.tbPassWord);
            this.panelUpdateEmployee.Controls.Add(this.tbSalary);
            this.panelUpdateEmployee.Controls.Add(this.lblPassWord);
            this.panelUpdateEmployee.Controls.Add(this.lblSalary);
            this.panelUpdateEmployee.Controls.Add(this.tbUserName);
            this.panelUpdateEmployee.Controls.Add(this.lblUserName);
            this.panelUpdateEmployee.Controls.Add(this.tbSSN);
            this.panelUpdateEmployee.Controls.Add(this.lblSSN);
            this.panelUpdateEmployee.Controls.Add(this.cbJobRole);
            this.panelUpdateEmployee.Controls.Add(this.tbPhone);
            this.panelUpdateEmployee.Controls.Add(this.lblPhone);
            this.panelUpdateEmployee.Controls.Add(this.tbEmail);
            this.panelUpdateEmployee.Controls.Add(this.lblEmail);
            this.panelUpdateEmployee.Controls.Add(this.lblRole);
            this.panelUpdateEmployee.Controls.Add(this.tbName);
            this.panelUpdateEmployee.Controls.Add(this.lblName);
            this.panelUpdateEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUpdateEmployee.Location = new System.Drawing.Point(0, 0);
            this.panelUpdateEmployee.Name = "panelUpdateEmployee";
            this.panelUpdateEmployee.Size = new System.Drawing.Size(589, 364);
            this.panelUpdateEmployee.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(337, 283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(240, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Employee";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 329);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(221, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(336, 329);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(241, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Register Changes";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(337, 235);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(241, 23);
            this.btnAddPhoto.TabIndex = 9;
            this.btnAddPhoto.Text = "Add A Photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.ErrorImage = null;
            this.pbPhoto.InitialImage = null;
            this.pbPhoto.Location = new System.Drawing.Point(337, 12);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(241, 217);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 1;
            this.pbPhoto.TabStop = false;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(12, 296);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(224, 20);
            this.tbPassWord.TabIndex = 8;
            this.tbPassWord.UseSystemPasswordChar = true;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(12, 219);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(224, 20);
            this.tbSalary.TabIndex = 6;
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Location = new System.Drawing.Point(12, 280);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(53, 13);
            this.lblPassWord.TabIndex = 11;
            this.lblPassWord.Text = "Password";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(12, 203);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 11;
            this.lblSalary.Text = "Salary";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(12, 257);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(224, 20);
            this.tbUserName.TabIndex = 7;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 241);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "User name";
            // 
            // tbSSN
            // 
            this.tbSSN.Location = new System.Drawing.Point(12, 180);
            this.tbSSN.Name = "tbSSN";
            this.tbSSN.Size = new System.Drawing.Size(224, 20);
            this.tbSSN.TabIndex = 5;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(12, 164);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(29, 13);
            this.lblSSN.TabIndex = 9;
            this.lblSSN.Text = "SSN";
            // 
            // cbJobRole
            // 
            this.cbJobRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobRole.FormattingEnabled = true;
            this.cbJobRole.Location = new System.Drawing.Point(12, 63);
            this.cbJobRole.Name = "cbJobRole";
            this.cbJobRole.Size = new System.Drawing.Size(224, 21);
            this.cbJobRole.TabIndex = 2;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(12, 141);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(224, 20);
            this.tbPhone.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 125);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(12, 103);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(224, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 87);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(12, 48);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(44, 13);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Job role";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(224, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 364);
            this.Controls.Add(this.panelUpdateEmployee);
            this.Name = "UpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Employee";
            this.panelUpdateEmployee.ResumeLayout(false);
            this.panelUpdateEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUpdateEmployee;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox tbSSN;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.ComboBox cbJobRole;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblUserName;
    }
}