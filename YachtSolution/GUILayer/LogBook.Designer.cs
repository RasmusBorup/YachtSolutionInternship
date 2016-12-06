namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class LogBook.
    /// </summary>
    partial class LogBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlLogBook = new System.Windows.Forms.Panel();
            this.btnPreviousDate = new System.Windows.Forms.Button();
            this.btnNextDate = new System.Windows.Forms.Button();
            this.lblChiefEngineer = new System.Windows.Forms.Label();
            this.cbChief = new System.Windows.Forms.ComboBox();
            this.rtbRemarks = new System.Windows.Forms.RichTextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblLogBookDate = new System.Windows.Forms.Label();
            this.dtpLogBookDate = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnRegisterLogItem = new System.Windows.Forms.Button();
            this.dgvLogItems = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlLogBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 32);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 681);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlLogBook);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlLogBook
            // 
            this.pnlLogBook.Controls.Add(this.btnPreview);
            this.pnlLogBook.Controls.Add(this.btnPrint);
            this.pnlLogBook.Controls.Add(this.btnPreviousDate);
            this.pnlLogBook.Controls.Add(this.btnNextDate);
            this.pnlLogBook.Controls.Add(this.lblChiefEngineer);
            this.pnlLogBook.Controls.Add(this.cbChief);
            this.pnlLogBook.Controls.Add(this.rtbRemarks);
            this.pnlLogBook.Controls.Add(this.lblRemarks);
            this.pnlLogBook.Controls.Add(this.lblDescription);
            this.pnlLogBook.Controls.Add(this.rtbDescription);
            this.pnlLogBook.Controls.Add(this.lblLogBookDate);
            this.pnlLogBook.Controls.Add(this.dtpLogBookDate);
            this.pnlLogBook.Controls.Add(this.btnDelete);
            this.pnlLogBook.Controls.Add(this.btnSaveChanges);
            this.pnlLogBook.Controls.Add(this.btnDetails);
            this.pnlLogBook.Controls.Add(this.btnRegisterLogItem);
            this.pnlLogBook.Controls.Add(this.dgvLogItems);
            this.pnlLogBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogBook.Location = new System.Drawing.Point(3, 3);
            this.pnlLogBook.Name = "pnlLogBook";
            this.pnlLogBook.Size = new System.Drawing.Size(994, 635);
            this.pnlLogBook.TabIndex = 0;
            // 
            // btnPreviousDate
            // 
            this.btnPreviousDate.Location = new System.Drawing.Point(8, 32);
            this.btnPreviousDate.Name = "btnPreviousDate";
            this.btnPreviousDate.Size = new System.Drawing.Size(24, 23);
            this.btnPreviousDate.TabIndex = 18;
            this.btnPreviousDate.Text = "<";
            this.btnPreviousDate.UseVisualStyleBackColor = true;
            this.btnPreviousDate.Click += new System.EventHandler(this.btnPreviousDate_Click);
            // 
            // btnNextDate
            // 
            this.btnNextDate.Location = new System.Drawing.Point(244, 32);
            this.btnNextDate.Name = "btnNextDate";
            this.btnNextDate.Size = new System.Drawing.Size(24, 23);
            this.btnNextDate.TabIndex = 17;
            this.btnNextDate.Text = ">";
            this.btnNextDate.UseVisualStyleBackColor = true;
            this.btnNextDate.Click += new System.EventHandler(this.btnNextDate_Click);
            // 
            // lblChiefEngineer
            // 
            this.lblChiefEngineer.AutoSize = true;
            this.lblChiefEngineer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiefEngineer.Location = new System.Drawing.Point(633, 579);
            this.lblChiefEngineer.Name = "lblChiefEngineer";
            this.lblChiefEngineer.Size = new System.Drawing.Size(104, 18);
            this.lblChiefEngineer.TabIndex = 11;
            this.lblChiefEngineer.Text = "Chief Engineer";
            // 
            // cbChief
            // 
            this.cbChief.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChief.FormattingEnabled = true;
            this.cbChief.Location = new System.Drawing.Point(636, 603);
            this.cbChief.Name = "cbChief";
            this.cbChief.Size = new System.Drawing.Size(355, 26);
            this.cbChief.TabIndex = 2;
            // 
            // rtbRemarks
            // 
            this.rtbRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRemarks.Location = new System.Drawing.Point(636, 320);
            this.rtbRemarks.Name = "rtbRemarks";
            this.rtbRemarks.Size = new System.Drawing.Size(355, 256);
            this.rtbRemarks.TabIndex = 1;
            this.rtbRemarks.Text = "";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(633, 299);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(69, 18);
            this.lblRemarks.TabIndex = 23;
            this.lblRemarks.Text = "Remarks";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(633, 13);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 18);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Description";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(636, 34);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(352, 256);
            this.rtbDescription.TabIndex = 0;
            this.rtbDescription.Text = "";
            // 
            // lblLogBookDate
            // 
            this.lblLogBookDate.AutoSize = true;
            this.lblLogBookDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogBookDate.Location = new System.Drawing.Point(79, 10);
            this.lblLogBookDate.Name = "lblLogBookDate";
            this.lblLogBookDate.Size = new System.Drawing.Size(108, 18);
            this.lblLogBookDate.TabIndex = 21;
            this.lblLogBookDate.Text = "Log Book Date";
            // 
            // dtpLogBookDate
            // 
            this.dtpLogBookDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLogBookDate.Location = new System.Drawing.Point(38, 31);
            this.dtpLogBookDate.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dtpLogBookDate.Name = "dtpLogBookDate";
            this.dtpLogBookDate.Size = new System.Drawing.Size(200, 24);
            this.dtpLogBookDate.TabIndex = 19;
            this.dtpLogBookDate.Value = new System.DateTime(2015, 10, 14, 0, 0, 0, 0);
            this.dtpLogBookDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(480, 582);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 50);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(480, 122);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(150, 50);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(480, 66);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(150, 50);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "Detailed View";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnRegisterLogItem
            // 
            this.btnRegisterLogItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterLogItem.Location = new System.Drawing.Point(480, 526);
            this.btnRegisterLogItem.Name = "btnRegisterLogItem";
            this.btnRegisterLogItem.Size = new System.Drawing.Size(150, 50);
            this.btnRegisterLogItem.TabIndex = 5;
            this.btnRegisterLogItem.Text = "Register New Log Item";
            this.btnRegisterLogItem.UseVisualStyleBackColor = true;
            this.btnRegisterLogItem.Click += new System.EventHandler(this.btnRegisterLogItem_Click);
            // 
            // dgvLogItems
            // 
            this.dgvLogItems.AllowUserToAddRows = false;
            this.dgvLogItems.AllowUserToDeleteRows = false;
            this.dgvLogItems.AllowUserToResizeRows = false;
            this.dgvLogItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLogItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLogItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogItems.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLogItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvLogItems.Location = new System.Drawing.Point(8, 66);
            this.dgvLogItems.MultiSelect = false;
            this.dgvLogItems.Name = "dgvLogItems";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLogItems.RowHeadersVisible = false;
            this.dgvLogItems.RowHeadersWidth = 75;
            this.dgvLogItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLogItems.Size = new System.Drawing.Size(466, 563);
            this.dgvLogItems.TabIndex = 20;
            this.dgvLogItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogItems_CellDoubleClick);
            this.dgvLogItems.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvLogItems_CurrentCellDirtyStateChanged);
            this.dgvLogItems.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvLogItems_EditingControlShowing);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(481, 178);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(149, 35);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(481, 220);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(149, 35);
            this.btnPreview.TabIndex = 25;
            this.btnPreview.Text = "Preview print";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // LogBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.tabControl1);
            this.Name = "LogBook";
            this.Text = "LogBook";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlLogBook.ResumeLayout(false);
            this.pnlLogBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlLogBook;
        private System.Windows.Forms.DataGridView dgvLogItems;
        private System.Windows.Forms.Button btnRegisterLogItem;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblLogBookDate;
        private System.Windows.Forms.DateTimePicker dtpLogBookDate;
        private System.Windows.Forms.Label lblChiefEngineer;
        private System.Windows.Forms.ComboBox cbChief;
        private System.Windows.Forms.RichTextBox rtbRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnPreviousDate;
        private System.Windows.Forms.Button btnNextDate;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}