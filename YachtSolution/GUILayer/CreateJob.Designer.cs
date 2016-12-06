namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class CreateJob.
    /// </summary>
    partial class CreateJob
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.chbJobDone = new System.Windows.Forms.CheckBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.numTimeBetweenJobs = new System.Windows.Forms.NumericUpDown();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.cbSubGroup = new System.Windows.Forms.ComboBox();
            this.lblSubGroup = new System.Windows.Forms.Label();
            this.btnNewGroup = new System.Windows.Forms.Button();
            this.btnUpdateGroup = new System.Windows.Forms.Button();
            this.lblLeave = new System.Windows.Forms.Label();
            this.lblFrequencyOfJob = new System.Windows.Forms.Label();
            this.rbDays = new System.Windows.Forms.RadioButton();
            this.rbHours = new System.Windows.Forms.RadioButton();
            this.cbLogItems = new System.Windows.Forms.ComboBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.tbWorker = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeBetweenJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(12, 25);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(268, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 309);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(294, 107);
            this.tbDescription.TabIndex = 7;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(315, 309);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(306, 107);
            this.tbNote.TabIndex = 8;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(12, 9);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(43, 13);
            this.lblJobTitle.TabIndex = 18;
            this.lblJobTitle.Text = "Job title";
            // 
            // chbJobDone
            // 
            this.chbJobDone.AutoSize = true;
            this.chbJobDone.Location = new System.Drawing.Point(12, 262);
            this.chbJobDone.Name = "chbJobDone";
            this.chbJobDone.Size = new System.Drawing.Size(70, 17);
            this.chbJobDone.TabIndex = 23;
            this.chbJobDone.Text = "Job done";
            this.chbJobDone.UseVisualStyleBackColor = true;
            this.chbJobDone.CheckedChanged += new System.EventHandler(this.chbJobDone_CheckedChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 293);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 24;
            this.lblDescription.Text = "Description";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(312, 293);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(30, 13);
            this.lblNote.TabIndex = 25;
            this.lblNote.Text = "Note";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(294, 46);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.back_button_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(315, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(306, 46);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Create job";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.save_button_Click);
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
            this.numTimeBetweenJobs.TabIndex = 2;
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.InitialImage = null;
            this.pbPhoto.Location = new System.Drawing.Point(315, 12);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(306, 222);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 35;
            this.pbPhoto.TabStop = false;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(315, 240);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(306, 23);
            this.btnAddPhoto.TabIndex = 9;
            this.btnAddPhoto.Text = "Add Photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // cbSubGroup
            // 
            this.cbSubGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubGroup.FormattingEnabled = true;
            this.cbSubGroup.Location = new System.Drawing.Point(12, 202);
            this.cbSubGroup.Name = "cbSubGroup";
            this.cbSubGroup.Size = new System.Drawing.Size(291, 21);
            this.cbSubGroup.TabIndex = 4;
            // 
            // lblSubGroup
            // 
            this.lblSubGroup.AutoSize = true;
            this.lblSubGroup.Location = new System.Drawing.Point(12, 186);
            this.lblSubGroup.Name = "lblSubGroup";
            this.lblSubGroup.Size = new System.Drawing.Size(56, 13);
            this.lblSubGroup.TabIndex = 38;
            this.lblSubGroup.Text = "Sub group";
            // 
            // btnNewGroup
            // 
            this.btnNewGroup.Location = new System.Drawing.Point(12, 229);
            this.btnNewGroup.Name = "btnNewGroup";
            this.btnNewGroup.Size = new System.Drawing.Size(123, 23);
            this.btnNewGroup.TabIndex = 5;
            this.btnNewGroup.Text = "New Group";
            this.btnNewGroup.UseVisualStyleBackColor = true;
            this.btnNewGroup.Click += new System.EventHandler(this.btnNewGroup_Click);
            // 
            // btnUpdateGroup
            // 
            this.btnUpdateGroup.Location = new System.Drawing.Point(180, 229);
            this.btnUpdateGroup.Name = "btnUpdateGroup";
            this.btnUpdateGroup.Size = new System.Drawing.Size(123, 23);
            this.btnUpdateGroup.TabIndex = 6;
            this.btnUpdateGroup.Text = "Update Group";
            this.btnUpdateGroup.UseVisualStyleBackColor = true;
            this.btnUpdateGroup.Click += new System.EventHandler(this.btnUpdateGroup_Click);
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.Location = new System.Drawing.Point(158, 60);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(148, 13);
            this.lblLeave.TabIndex = 41;
            this.lblLeave.Text = "(Leave at 0 for a one time job)";
            // 
            // lblFrequencyOfJob
            // 
            this.lblFrequencyOfJob.AutoSize = true;
            this.lblFrequencyOfJob.Location = new System.Drawing.Point(12, 60);
            this.lblFrequencyOfJob.Name = "lblFrequencyOfJob";
            this.lblFrequencyOfJob.Size = new System.Drawing.Size(131, 13);
            this.lblFrequencyOfJob.TabIndex = 42;
            this.lblFrequencyOfJob.Text = "Frequency of job (In Days)";
            // 
            // rbDays
            // 
            this.rbDays.AutoSize = true;
            this.rbDays.Checked = true;
            this.rbDays.Location = new System.Drawing.Point(241, 102);
            this.rbDays.Name = "rbDays";
            this.rbDays.Size = new System.Drawing.Size(49, 17);
            this.rbDays.TabIndex = 44;
            this.rbDays.TabStop = true;
            this.rbDays.Text = "Days";
            this.rbDays.UseVisualStyleBackColor = true;
            this.rbDays.CheckedChanged += new System.EventHandler(this.rbDays_CheckedChanged);
            // 
            // rbHours
            // 
            this.rbHours.AutoSize = true;
            this.rbHours.Location = new System.Drawing.Point(180, 102);
            this.rbHours.Name = "rbHours";
            this.rbHours.Size = new System.Drawing.Size(53, 17);
            this.rbHours.TabIndex = 45;
            this.rbHours.Text = "Hours";
            this.rbHours.UseVisualStyleBackColor = true;
            // 
            // cbLogItems
            // 
            this.cbLogItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogItems.FormattingEnabled = true;
            this.cbLogItems.Location = new System.Drawing.Point(12, 152);
            this.cbLogItems.Name = "cbLogItems";
            this.cbLogItems.Size = new System.Drawing.Size(291, 21);
            this.cbLogItems.TabIndex = 46;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(12, 136);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(85, 13);
            this.lblLink.TabIndex = 47;
            this.lblLink.Text = "Link with logitem";
            // 
            // tbWorker
            // 
            this.tbWorker.Location = new System.Drawing.Point(88, 258);
            this.tbWorker.Name = "tbWorker";
            this.tbWorker.Size = new System.Drawing.Size(215, 20);
            this.tbWorker.TabIndex = 48;
            // 
            // CreateJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 485);
            this.Controls.Add(this.tbWorker);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.cbLogItems);
            this.Controls.Add(this.rbHours);
            this.Controls.Add(this.rbDays);
            this.Controls.Add(this.lblFrequencyOfJob);
            this.Controls.Add(this.lblLeave);
            this.Controls.Add(this.btnUpdateGroup);
            this.Controls.Add(this.btnNewGroup);
            this.Controls.Add(this.lblSubGroup);
            this.Controls.Add(this.cbSubGroup);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.numTimeBetweenJobs);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.chbJobDone);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTitle);
            this.Name = "CreateJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create job";
            ((System.ComponentModel.ISupportInitialize)(this.numTimeBetweenJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.CheckBox chbJobDone;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numTimeBetweenJobs;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.ComboBox cbSubGroup;
        private System.Windows.Forms.Label lblSubGroup;
        private System.Windows.Forms.Button btnNewGroup;
        private System.Windows.Forms.Button btnUpdateGroup;
        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.Label lblFrequencyOfJob;
        private System.Windows.Forms.RadioButton rbDays;
        private System.Windows.Forms.RadioButton rbHours;
        private System.Windows.Forms.ComboBox cbLogItems;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox tbWorker;
    }
}