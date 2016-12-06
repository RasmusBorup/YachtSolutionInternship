namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class UpdateJob.
    /// </summary>
    partial class UpdateJob
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
            this.btnUpdateJob = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.chbJobDone = new System.Windows.Forms.CheckBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbWorker = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.cbLogItems = new System.Windows.Forms.ComboBox();
            this.lblFrequencyOfJob = new System.Windows.Forms.Label();
            this.lblLeave = new System.Windows.Forms.Label();
            this.btnUpdateGroup = new System.Windows.Forms.Button();
            this.btnNewGroup = new System.Windows.Forms.Button();
            this.lblSubGroup = new System.Windows.Forms.Label();
            this.cbSubGroup = new System.Windows.Forms.ComboBox();
            this.numTimeBetweenJobs = new System.Windows.Forms.NumericUpDown();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeBetweenJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateJob
            // 
            this.btnUpdateJob.Location = new System.Drawing.Point(432, 450);
            this.btnUpdateJob.Name = "btnUpdateJob";
            this.btnUpdateJob.Size = new System.Drawing.Size(192, 23);
            this.btnUpdateJob.TabIndex = 9;
            this.btnUpdateJob.Text = "Save Changes";
            this.btnUpdateJob.UseVisualStyleBackColor = true;
            this.btnUpdateJob.Click += new System.EventHandler(this.updateJobButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(192, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.Location = new System.Drawing.Point(221, 450);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(192, 23);
            this.btnDeleteJob.TabIndex = 10;
            this.btnDeleteJob.Text = "Delete Job";
            this.btnDeleteJob.UseVisualStyleBackColor = true;
            this.btnDeleteJob.Click += new System.EventHandler(this.btnDeleteJob_click);
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(315, 241);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(306, 23);
            this.btnAddPhoto.TabIndex = 50;
            this.btnAddPhoto.Text = "Add Photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.InitialImage = null;
            this.pbPhoto.Location = new System.Drawing.Point(315, 13);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(306, 222);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 55;
            this.pbPhoto.TabStop = false;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(312, 294);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(30, 13);
            this.lblNote.TabIndex = 54;
            this.lblNote.Text = "Note";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 294);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 53;
            this.lblDescription.Text = "Description";
            // 
            // chbJobDone
            // 
            this.chbJobDone.AutoSize = true;
            this.chbJobDone.Location = new System.Drawing.Point(12, 262);
            this.chbJobDone.Name = "chbJobDone";
            this.chbJobDone.Size = new System.Drawing.Size(70, 17);
            this.chbJobDone.TabIndex = 52;
            this.chbJobDone.Text = "Job done";
            this.chbJobDone.UseVisualStyleBackColor = true;
            this.chbJobDone.CheckedChanged += new System.EventHandler(this.chbJobDone_CheckedChanged);
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(318, 310);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(306, 107);
            this.tbNote.TabIndex = 49;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(15, 310);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(294, 107);
            this.tbDescription.TabIndex = 48;
            // 
            // tbWorker
            // 
            this.tbWorker.Location = new System.Drawing.Point(88, 260);
            this.tbWorker.Name = "tbWorker";
            this.tbWorker.Size = new System.Drawing.Size(212, 20);
            this.tbWorker.TabIndex = 59;
            this.tbWorker.Enter += new System.EventHandler(this.tbWorker_Enter);
            this.tbWorker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWorker_KeyPress);
            this.tbWorker.Leave += new System.EventHandler(this.tbWorker_Leave);
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(12, 136);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(85, 13);
            this.lblLink.TabIndex = 72;
            this.lblLink.Text = "Link with logitem";
            // 
            // cbLogItems
            // 
            this.cbLogItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogItems.FormattingEnabled = true;
            this.cbLogItems.Location = new System.Drawing.Point(12, 152);
            this.cbLogItems.Name = "cbLogItems";
            this.cbLogItems.Size = new System.Drawing.Size(291, 21);
            this.cbLogItems.TabIndex = 71;
            // 
            // lblFrequencyOfJob
            // 
            this.lblFrequencyOfJob.AutoSize = true;
            this.lblFrequencyOfJob.Location = new System.Drawing.Point(12, 60);
            this.lblFrequencyOfJob.Name = "lblFrequencyOfJob";
            this.lblFrequencyOfJob.Size = new System.Drawing.Size(86, 13);
            this.lblFrequencyOfJob.TabIndex = 68;
            this.lblFrequencyOfJob.Text = "Frequency of job";
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.Location = new System.Drawing.Point(158, 60);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(148, 13);
            this.lblLeave.TabIndex = 67;
            this.lblLeave.Text = "(Leave at 0 for a one time job)";
            // 
            // btnUpdateGroup
            // 
            this.btnUpdateGroup.Location = new System.Drawing.Point(180, 229);
            this.btnUpdateGroup.Name = "btnUpdateGroup";
            this.btnUpdateGroup.Size = new System.Drawing.Size(123, 23);
            this.btnUpdateGroup.TabIndex = 64;
            this.btnUpdateGroup.Text = "Update Group";
            this.btnUpdateGroup.UseVisualStyleBackColor = true;
            this.btnUpdateGroup.Click += new System.EventHandler(this.btnUpdateSubGroup_Click);
            // 
            // btnNewGroup
            // 
            this.btnNewGroup.Location = new System.Drawing.Point(12, 229);
            this.btnNewGroup.Name = "btnNewGroup";
            this.btnNewGroup.Size = new System.Drawing.Size(123, 23);
            this.btnNewGroup.TabIndex = 63;
            this.btnNewGroup.Text = "New Group";
            this.btnNewGroup.UseVisualStyleBackColor = true;
            this.btnNewGroup.Click += new System.EventHandler(this.btnNewSubgroup_Click);
            // 
            // lblSubGroup
            // 
            this.lblSubGroup.AutoSize = true;
            this.lblSubGroup.Location = new System.Drawing.Point(12, 186);
            this.lblSubGroup.Name = "lblSubGroup";
            this.lblSubGroup.Size = new System.Drawing.Size(56, 13);
            this.lblSubGroup.TabIndex = 66;
            this.lblSubGroup.Text = "Sub group";
            // 
            // cbSubGroup
            // 
            this.cbSubGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubGroup.FormattingEnabled = true;
            this.cbSubGroup.Location = new System.Drawing.Point(12, 202);
            this.cbSubGroup.Name = "cbSubGroup";
            this.cbSubGroup.Size = new System.Drawing.Size(291, 21);
            this.cbSubGroup.TabIndex = 62;
            // 
            // numTimeBetweenJobs
            // 
            this.numTimeBetweenJobs.Location = new System.Drawing.Point(12, 76);
            this.numTimeBetweenJobs.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numTimeBetweenJobs.Name = "numTimeBetweenJobs";
            this.numTimeBetweenJobs.Size = new System.Drawing.Size(291, 20);
            this.numTimeBetweenJobs.TabIndex = 61;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(12, 9);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(43, 13);
            this.lblJobTitle.TabIndex = 65;
            this.lblJobTitle.Text = "Job title";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(12, 25);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(291, 20);
            this.tbTitle.TabIndex = 60;
            // 
            // UpdateJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 485);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.cbLogItems);
            this.Controls.Add(this.lblFrequencyOfJob);
            this.Controls.Add(this.lblLeave);
            this.Controls.Add(this.btnUpdateGroup);
            this.Controls.Add(this.btnNewGroup);
            this.Controls.Add(this.lblSubGroup);
            this.Controls.Add(this.cbSubGroup);
            this.Controls.Add(this.numTimeBetweenJobs);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbWorker);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.chbJobDone);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.btnDeleteJob);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateJob);
            this.Name = "UpdateJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update job";
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeBetweenJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateJob;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.CheckBox chbJobDone;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbWorker;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.ComboBox cbLogItems;
        private System.Windows.Forms.Label lblFrequencyOfJob;
        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.Button btnUpdateGroup;
        private System.Windows.Forms.Button btnNewGroup;
        private System.Windows.Forms.Label lblSubGroup;
        private System.Windows.Forms.ComboBox cbSubGroup;
        private System.Windows.Forms.NumericUpDown numTimeBetweenJobs;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox tbTitle;
    }
}