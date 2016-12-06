namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class InventoryManagement.
    /// </summary>
    partial class InventoryManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PanelMasterPanel = new System.Windows.Forms.Panel();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnMinimumAmountCheck = new System.Windows.Forms.Button();
            this.lblSerialNrOrName = new System.Windows.Forms.Label();
            this.tbSearchField = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.PanelDataGridView = new System.Windows.Forms.Panel();
            this.dgvDataAllItems = new System.Windows.Forms.DataGridView();
            this.btnViewAllItems = new System.Windows.Forms.Button();
            this.btnDeleteBySerial = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.PanelMasterPanel.SuspendLayout();
            this.PanelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataAllItems)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PanelMasterPanel
            // 
            this.PanelMasterPanel.Controls.Add(this.btnPreview);
            this.PanelMasterPanel.Controls.Add(this.btnUpdateItem);
            this.PanelMasterPanel.Controls.Add(this.btnMinimumAmountCheck);
            this.PanelMasterPanel.Controls.Add(this.lblSerialNrOrName);
            this.PanelMasterPanel.Controls.Add(this.tbSearchField);
            this.PanelMasterPanel.Controls.Add(this.btnPrint);
            this.PanelMasterPanel.Controls.Add(this.btnCreateItem);
            this.PanelMasterPanel.Controls.Add(this.PanelDataGridView);
            this.PanelMasterPanel.Controls.Add(this.btnViewAllItems);
            this.PanelMasterPanel.Controls.Add(this.btnDeleteBySerial);
            this.PanelMasterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMasterPanel.Location = new System.Drawing.Point(0, 0);
            this.PanelMasterPanel.Name = "PanelMasterPanel";
            this.PanelMasterPanel.Size = new System.Drawing.Size(1008, 681);
            this.PanelMasterPanel.TabIndex = 29;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(582, 562);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(134, 71);
            this.btnUpdateItem.TabIndex = 32;
            this.btnUpdateItem.Text = "Update item";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnMinimumAmountCheck
            // 
            this.btnMinimumAmountCheck.Location = new System.Drawing.Point(862, 562);
            this.btnMinimumAmountCheck.Name = "btnMinimumAmountCheck";
            this.btnMinimumAmountCheck.Size = new System.Drawing.Size(134, 71);
            this.btnMinimumAmountCheck.TabIndex = 4;
            this.btnMinimumAmountCheck.Text = "Show insufficient items";
            this.btnMinimumAmountCheck.UseVisualStyleBackColor = true;
            this.btnMinimumAmountCheck.Click += new System.EventHandler(this.btnMinimumAmountCheck_Click);
            // 
            // lblSerialNrOrName
            // 
            this.lblSerialNrOrName.AutoSize = true;
            this.lblSerialNrOrName.Location = new System.Drawing.Point(12, 494);
            this.lblSerialNrOrName.Name = "lblSerialNrOrName";
            this.lblSerialNrOrName.Size = new System.Drawing.Size(93, 13);
            this.lblSerialNrOrName.TabIndex = 31;
            this.lblSerialNrOrName.Text = "Serial Nr. or Name";
            // 
            // tbSearchField
            // 
            this.tbSearchField.Location = new System.Drawing.Point(12, 510);
            this.tbSearchField.Name = "tbSearchField";
            this.tbSearchField.Size = new System.Drawing.Size(564, 20);
            this.tbSearchField.TabIndex = 1;
            this.tbSearchField.TextChanged += new System.EventHandler(this.tbSearchField_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(862, 485);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 35);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.Location = new System.Drawing.Point(582, 484);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(134, 71);
            this.btnCreateItem.TabIndex = 2;
            this.btnCreateItem.Text = "Create item";
            this.btnCreateItem.UseVisualStyleBackColor = true;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // PanelDataGridView
            // 
            this.PanelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDataGridView.Controls.Add(this.dgvDataAllItems);
            this.PanelDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDataGridView.Location = new System.Drawing.Point(0, 0);
            this.PanelDataGridView.Name = "PanelDataGridView";
            this.PanelDataGridView.Size = new System.Drawing.Size(1008, 479);
            this.PanelDataGridView.TabIndex = 24;
            // 
            // dgvDataAllItems
            // 
            this.dgvDataAllItems.AllowUserToAddRows = false;
            this.dgvDataAllItems.AllowUserToDeleteRows = false;
            this.dgvDataAllItems.AllowUserToResizeRows = false;
            this.dgvDataAllItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataAllItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataAllItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataAllItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataAllItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataAllItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataAllItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDataAllItems.Location = new System.Drawing.Point(11, 11);
            this.dgvDataAllItems.MultiSelect = false;
            this.dgvDataAllItems.Name = "dgvDataAllItems";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataAllItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataAllItems.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDataAllItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataAllItems.Size = new System.Drawing.Size(984, 466);
            this.dgvDataAllItems.TabIndex = 0;
            this.dgvDataAllItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoubleClick);
            this.dgvDataAllItems.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDataAllItems_RowPostPaint);
            // 
            // btnViewAllItems
            // 
            this.btnViewAllItems.Location = new System.Drawing.Point(722, 485);
            this.btnViewAllItems.Name = "btnViewAllItems";
            this.btnViewAllItems.Size = new System.Drawing.Size(134, 71);
            this.btnViewAllItems.TabIndex = 3;
            this.btnViewAllItems.Text = "Show all items";
            this.btnViewAllItems.UseVisualStyleBackColor = true;
            this.btnViewAllItems.Click += new System.EventHandler(this.btnViewAllItems_Click);
            // 
            // btnDeleteBySerial
            // 
            this.btnDeleteBySerial.Location = new System.Drawing.Point(722, 562);
            this.btnDeleteBySerial.Name = "btnDeleteBySerial";
            this.btnDeleteBySerial.Size = new System.Drawing.Size(134, 71);
            this.btnDeleteBySerial.TabIndex = 6;
            this.btnDeleteBySerial.Text = "Delete Item";
            this.btnDeleteBySerial.UseVisualStyleBackColor = true;
            this.btnDeleteBySerial.Click += new System.EventHandler(this.btnDeleteBySerial_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(862, 521);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(134, 35);
            this.btnPreview.TabIndex = 33;
            this.btnPreview.Text = "Preview print";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.PanelMasterPanel);
            this.Name = "InventoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.PanelMasterPanel.ResumeLayout(false);
            this.PanelMasterPanel.PerformLayout();
            this.PanelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataAllItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataAllItems;
        private System.Windows.Forms.Button btnCreateItem;
        private System.Windows.Forms.Button btnDeleteBySerial;
        private System.Windows.Forms.Panel PanelDataGridView;
        private System.Windows.Forms.Button btnViewAllItems;
        private System.Windows.Forms.Panel PanelMasterPanel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblSerialNrOrName;
        private System.Windows.Forms.TextBox tbSearchField;
        private System.Windows.Forms.Button btnMinimumAmountCheck;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnPreview;
    }
}