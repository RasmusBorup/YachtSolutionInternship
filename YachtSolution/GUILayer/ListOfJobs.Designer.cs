namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class ListOfJobs.
    /// </summary>
    partial class ListOfJobs
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
            this.searchWorkerId_button = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.jobListGridView = new System.Windows.Forms.DataGridView();
            this.listOfJobs_panel = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chbSubGroup = new System.Windows.Forms.CheckBox();
            this.chbEndDate = new System.Windows.Forms.CheckBox();
            this.chbStartDate = new System.Windows.Forms.CheckBox();
            this.lblSubGroup = new System.Windows.Forms.Label();
            this.cbSubGroup = new System.Windows.Forms.ComboBox();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.dateEnd_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateStart_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateJob = new System.Windows.Forms.Button();
            this.btnCreateJob = new System.Windows.Forms.Button();
            this.tcListOfJobs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.jobListGridView)).BeginInit();
            this.listOfJobs_panel.SuspendLayout();
            this.tcListOfJobs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchWorkerId_button
            // 
            this.searchWorkerId_button.Location = new System.Drawing.Point(0, 0);
            this.searchWorkerId_button.Name = "searchWorkerId_button";
            this.searchWorkerId_button.Size = new System.Drawing.Size(75, 23);
            this.searchWorkerId_button.TabIndex = 42;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(483, 544);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 77);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset search fields";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // jobListGridView
            // 
            this.jobListGridView.AllowUserToAddRows = false;
            this.jobListGridView.AllowUserToDeleteRows = false;
            this.jobListGridView.AllowUserToResizeRows = false;
            this.jobListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jobListGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobListGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.jobListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobListGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.jobListGridView.Location = new System.Drawing.Point(0, 0);
            this.jobListGridView.MultiSelect = false;
            this.jobListGridView.Name = "jobListGridView";
            this.jobListGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobListGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.jobListGridView.RowHeadersVisible = false;
            this.jobListGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.jobListGridView.RowTemplate.ReadOnly = true;
            this.jobListGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.jobListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobListGridView.Size = new System.Drawing.Size(994, 519);
            this.jobListGridView.TabIndex = 23;
            this.jobListGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jobListGridView_CellDoubleClick);
            this.jobListGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.jobListGridView_RowPostPaint);
            // 
            // listOfJobs_panel
            // 
            this.listOfJobs_panel.Controls.Add(this.btnPreview);
            this.listOfJobs_panel.Controls.Add(this.btnPrint);
            this.listOfJobs_panel.Controls.Add(this.btnSearch);
            this.listOfJobs_panel.Controls.Add(this.chbSubGroup);
            this.listOfJobs_panel.Controls.Add(this.chbEndDate);
            this.listOfJobs_panel.Controls.Add(this.chbStartDate);
            this.listOfJobs_panel.Controls.Add(this.lblSubGroup);
            this.listOfJobs_panel.Controls.Add(this.cbSubGroup);
            this.listOfJobs_panel.Controls.Add(this.lblDateEnd);
            this.listOfJobs_panel.Controls.Add(this.lblDateStart);
            this.listOfJobs_panel.Controls.Add(this.dateEnd_dateTimePicker);
            this.listOfJobs_panel.Controls.Add(this.dateStart_dateTimePicker);
            this.listOfJobs_panel.Controls.Add(this.btnUpdateJob);
            this.listOfJobs_panel.Controls.Add(this.btnCreateJob);
            this.listOfJobs_panel.Controls.Add(this.jobListGridView);
            this.listOfJobs_panel.Controls.Add(this.btnReset);
            this.listOfJobs_panel.Controls.Add(this.searchWorkerId_button);
            this.listOfJobs_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOfJobs_panel.Location = new System.Drawing.Point(3, 3);
            this.listOfJobs_panel.Margin = new System.Windows.Forms.Padding(6);
            this.listOfJobs_panel.Name = "listOfJobs_panel";
            this.listOfJobs_panel.Size = new System.Drawing.Size(994, 635);
            this.listOfJobs_panel.TabIndex = 24;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(867, 584);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(122, 35);
            this.btnPreview.TabIndex = 53;
            this.btnPreview.Text = "Preview Print";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(867, 544);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(122, 35);
            this.btnPrint.TabIndex = 52;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(355, 544);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 77);
            this.btnSearch.TabIndex = 51;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chbSubGroup
            // 
            this.chbSubGroup.AutoSize = true;
            this.chbSubGroup.Location = new System.Drawing.Point(334, 605);
            this.chbSubGroup.Name = "chbSubGroup";
            this.chbSubGroup.Size = new System.Drawing.Size(15, 14);
            this.chbSubGroup.TabIndex = 50;
            this.chbSubGroup.UseVisualStyleBackColor = true;
            // 
            // chbEndDate
            // 
            this.chbEndDate.AutoSize = true;
            this.chbEndDate.Location = new System.Drawing.Point(334, 578);
            this.chbEndDate.Name = "chbEndDate";
            this.chbEndDate.Size = new System.Drawing.Size(15, 14);
            this.chbEndDate.TabIndex = 48;
            this.chbEndDate.UseVisualStyleBackColor = true;
            // 
            // chbStartDate
            // 
            this.chbStartDate.AutoSize = true;
            this.chbStartDate.Location = new System.Drawing.Point(334, 548);
            this.chbStartDate.Name = "chbStartDate";
            this.chbStartDate.Size = new System.Drawing.Size(15, 14);
            this.chbStartDate.TabIndex = 47;
            this.chbStartDate.UseVisualStyleBackColor = true;
            // 
            // lblSubGroup
            // 
            this.lblSubGroup.AutoSize = true;
            this.lblSubGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubGroup.Location = new System.Drawing.Point(13, 601);
            this.lblSubGroup.Name = "lblSubGroup";
            this.lblSubGroup.Size = new System.Drawing.Size(76, 18);
            this.lblSubGroup.TabIndex = 45;
            this.lblSubGroup.Text = "Sub group";
            // 
            // cbSubGroup
            // 
            this.cbSubGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubGroup.FormattingEnabled = true;
            this.cbSubGroup.Location = new System.Drawing.Point(109, 600);
            this.cbSubGroup.Name = "cbSubGroup";
            this.cbSubGroup.Size = new System.Drawing.Size(219, 21);
            this.cbSubGroup.TabIndex = 44;
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEnd.Location = new System.Drawing.Point(13, 574);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(67, 18);
            this.lblDateEnd.TabIndex = 36;
            this.lblDateEnd.Text = "Date end";
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateStart.Location = new System.Drawing.Point(13, 544);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(72, 18);
            this.lblDateStart.TabIndex = 35;
            this.lblDateStart.Text = "Date start";
            // 
            // dateEnd_dateTimePicker
            // 
            this.dateEnd_dateTimePicker.Location = new System.Drawing.Point(109, 574);
            this.dateEnd_dateTimePicker.Name = "dateEnd_dateTimePicker";
            this.dateEnd_dateTimePicker.Size = new System.Drawing.Size(219, 20);
            this.dateEnd_dateTimePicker.TabIndex = 28;
            // 
            // dateStart_dateTimePicker
            // 
            this.dateStart_dateTimePicker.Location = new System.Drawing.Point(109, 544);
            this.dateStart_dateTimePicker.Name = "dateStart_dateTimePicker";
            this.dateStart_dateTimePicker.Size = new System.Drawing.Size(219, 20);
            this.dateStart_dateTimePicker.TabIndex = 26;
            // 
            // btnUpdateJob
            // 
            this.btnUpdateJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateJob.Location = new System.Drawing.Point(739, 544);
            this.btnUpdateJob.Name = "btnUpdateJob";
            this.btnUpdateJob.Size = new System.Drawing.Size(122, 77);
            this.btnUpdateJob.TabIndex = 25;
            this.btnUpdateJob.Text = "Update job";
            this.btnUpdateJob.UseVisualStyleBackColor = true;
            this.btnUpdateJob.Click += new System.EventHandler(this.btnUpdateJob_Click);
            // 
            // btnCreateJob
            // 
            this.btnCreateJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateJob.Location = new System.Drawing.Point(611, 544);
            this.btnCreateJob.Name = "btnCreateJob";
            this.btnCreateJob.Size = new System.Drawing.Size(122, 77);
            this.btnCreateJob.TabIndex = 24;
            this.btnCreateJob.Text = "Create job";
            this.btnCreateJob.UseVisualStyleBackColor = true;
            this.btnCreateJob.Click += new System.EventHandler(this.btnCreateJob_Click);
            // 
            // tcListOfJobs
            // 
            this.tcListOfJobs.Controls.Add(this.tabPage1);
            this.tcListOfJobs.Controls.Add(this.tabPage2);
            this.tcListOfJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcListOfJobs.ItemSize = new System.Drawing.Size(58, 32);
            this.tcListOfJobs.Location = new System.Drawing.Point(0, 0);
            this.tcListOfJobs.Name = "tcListOfJobs";
            this.tcListOfJobs.SelectedIndex = 0;
            this.tcListOfJobs.Size = new System.Drawing.Size(1008, 681);
            this.tcListOfJobs.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listOfJobs_panel);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ListOfJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.tcListOfJobs);
            this.Name = "ListOfJobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jobs Management";
            ((System.ComponentModel.ISupportInitialize)(this.jobListGridView)).EndInit();
            this.listOfJobs_panel.ResumeLayout(false);
            this.listOfJobs_panel.PerformLayout();
            this.tcListOfJobs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchWorkerId_button;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView jobListGridView;
        private System.Windows.Forms.Panel listOfJobs_panel;
        private System.Windows.Forms.Button btnCreateJob;
        private System.Windows.Forms.Button btnUpdateJob;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.DateTimePicker dateEnd_dateTimePicker;
        private System.Windows.Forms.DateTimePicker dateStart_dateTimePicker;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.Label lblSubGroup;
        private System.Windows.Forms.ComboBox cbSubGroup;
        private System.Windows.Forms.TabControl tcListOfJobs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chbSubGroup;
        private System.Windows.Forms.CheckBox chbEndDate;
        private System.Windows.Forms.CheckBox chbStartDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}