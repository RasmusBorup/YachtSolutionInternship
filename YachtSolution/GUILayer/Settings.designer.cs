namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class Settings.
    /// </summary>
    partial class Settings
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
            this.panelLogout = new System.Windows.Forms.Panel();
            this.gbAdministration = new System.Windows.Forms.GroupBox();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.tbNewRole = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chbEmployees = new System.Windows.Forms.CheckBox();
            this.chbInventory = new System.Windows.Forms.CheckBox();
            this.chbJobs = new System.Windows.Forms.CheckBox();
            this.chbLogbook = new System.Windows.Forms.CheckBox();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFillDatabase = new System.Windows.Forms.Button();
            this.btnRemoveUnusedImages = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelLogout.SuspendLayout();
            this.gbAdministration.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.gbAdministration);
            this.panelLogout.Controls.Add(this.btnLogout);
            this.panelLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogout.Location = new System.Drawing.Point(0, 0);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(1008, 682);
            this.panelLogout.TabIndex = 0;
            // 
            // gbAdministration
            // 
            this.gbAdministration.Controls.Add(this.btnAddRole);
            this.gbAdministration.Controls.Add(this.tbNewRole);
            this.gbAdministration.Controls.Add(this.btnDelete);
            this.gbAdministration.Controls.Add(this.btnSave);
            this.gbAdministration.Controls.Add(this.chbEmployees);
            this.gbAdministration.Controls.Add(this.chbInventory);
            this.gbAdministration.Controls.Add(this.chbJobs);
            this.gbAdministration.Controls.Add(this.chbLogbook);
            this.gbAdministration.Controls.Add(this.cbRoles);
            this.gbAdministration.Controls.Add(this.label1);
            this.gbAdministration.Controls.Add(this.btnFillDatabase);
            this.gbAdministration.Controls.Add(this.btnRemoveUnusedImages);
            this.gbAdministration.Location = new System.Drawing.Point(12, 12);
            this.gbAdministration.Name = "gbAdministration";
            this.gbAdministration.Size = new System.Drawing.Size(984, 255);
            this.gbAdministration.TabIndex = 3;
            this.gbAdministration.TabStop = false;
            this.gbAdministration.Text = "Administration";
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(388, 48);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(203, 23);
            this.btnAddRole.TabIndex = 11;
            this.btnAddRole.Text = "Add New Role";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // tbNewRole
            // 
            this.tbNewRole.Location = new System.Drawing.Point(388, 19);
            this.tbNewRole.Name = "tbNewRole";
            this.tbNewRole.Size = new System.Drawing.Size(203, 20);
            this.tbNewRole.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(388, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(203, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Selected Role";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(203, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chbEmployees
            // 
            this.chbEmployees.AutoSize = true;
            this.chbEmployees.Location = new System.Drawing.Point(215, 165);
            this.chbEmployees.Name = "chbEmployees";
            this.chbEmployees.Size = new System.Drawing.Size(137, 17);
            this.chbEmployees.TabIndex = 7;
            this.chbEmployees.Text = "Employee Management";
            this.chbEmployees.UseVisualStyleBackColor = true;
            // 
            // chbInventory
            // 
            this.chbInventory.AutoSize = true;
            this.chbInventory.Location = new System.Drawing.Point(215, 142);
            this.chbInventory.Name = "chbInventory";
            this.chbInventory.Size = new System.Drawing.Size(70, 17);
            this.chbInventory.TabIndex = 6;
            this.chbInventory.Text = "Inventory";
            this.chbInventory.UseVisualStyleBackColor = true;
            // 
            // chbJobs
            // 
            this.chbJobs.AutoSize = true;
            this.chbJobs.Location = new System.Drawing.Point(215, 119);
            this.chbJobs.Name = "chbJobs";
            this.chbJobs.Size = new System.Drawing.Size(113, 17);
            this.chbJobs.TabIndex = 5;
            this.chbJobs.Text = "Maintenance Jobs";
            this.chbJobs.UseVisualStyleBackColor = true;
            // 
            // chbLogbook
            // 
            this.chbLogbook.AutoSize = true;
            this.chbLogbook.Location = new System.Drawing.Point(215, 96);
            this.chbLogbook.Name = "chbLogbook";
            this.chbLogbook.Size = new System.Drawing.Size(68, 17);
            this.chbLogbook.TabIndex = 4;
            this.chbLogbook.Text = "Logbook";
            this.chbLogbook.UseVisualStyleBackColor = true;
            // 
            // cbRoles
            // 
            this.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(6, 94);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(203, 21);
            this.cbRoles.TabIndex = 3;
            this.cbRoles.TextChanged += new System.EventHandler(this.cbRoles_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Role";
            // 
            // btnFillDatabase
            // 
            this.btnFillDatabase.Location = new System.Drawing.Point(6, 19);
            this.btnFillDatabase.Name = "btnFillDatabase";
            this.btnFillDatabase.Size = new System.Drawing.Size(203, 23);
            this.btnFillDatabase.TabIndex = 1;
            this.btnFillDatabase.Text = "Fill Database";
            this.btnFillDatabase.UseVisualStyleBackColor = true;
            this.btnFillDatabase.Click += new System.EventHandler(this.btnFillDatabase_Click);
            // 
            // btnRemoveUnusedImages
            // 
            this.btnRemoveUnusedImages.Location = new System.Drawing.Point(6, 48);
            this.btnRemoveUnusedImages.Name = "btnRemoveUnusedImages";
            this.btnRemoveUnusedImages.Size = new System.Drawing.Size(203, 23);
            this.btnRemoveUnusedImages.TabIndex = 2;
            this.btnRemoveUnusedImages.Text = "Remove unused images from database";
            this.btnRemoveUnusedImages.UseVisualStyleBackColor = true;
            this.btnRemoveUnusedImages.Click += new System.EventHandler(this.btnRemoveUnusedImages_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(319, 550);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(367, 92);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.panelLogout);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.panelLogout.ResumeLayout(false);
            this.gbAdministration.ResumeLayout(false);
            this.gbAdministration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFillDatabase;
        private System.Windows.Forms.Button btnRemoveUnusedImages;
        private System.Windows.Forms.GroupBox gbAdministration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chbEmployees;
        private System.Windows.Forms.CheckBox chbInventory;
        private System.Windows.Forms.CheckBox chbJobs;
        private System.Windows.Forms.CheckBox chbLogbook;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.TextBox tbNewRole;
        private System.Windows.Forms.Button btnDelete;
    }
}