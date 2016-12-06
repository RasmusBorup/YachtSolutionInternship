namespace YachtSolution.GUILayer
{
    partial class JobSubGroups
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
            this.txtSubGroup = new System.Windows.Forms.TextBox();
            this.btnSaveGroup = new System.Windows.Forms.Button();
            this.dgvSubGroups = new System.Windows.Forms.DataGridView();
            this.btnGetGroup = new System.Windows.Forms.Button();
            this.SubGroupPanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbSubGroup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGroups)).BeginInit();
            this.SubGroupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSubGroup
            // 
            this.txtSubGroup.Location = new System.Drawing.Point(3, 512);
            this.txtSubGroup.Name = "txtSubGroup";
            this.txtSubGroup.Size = new System.Drawing.Size(701, 20);
            this.txtSubGroup.TabIndex = 0;
            // 
            // btnSaveGroup
            // 
            this.btnSaveGroup.Location = new System.Drawing.Point(710, 486);
            this.btnSaveGroup.Name = "btnSaveGroup";
            this.btnSaveGroup.Size = new System.Drawing.Size(134, 71);
            this.btnSaveGroup.TabIndex = 1;
            this.btnSaveGroup.Text = "Save Group";
            this.btnSaveGroup.UseVisualStyleBackColor = true;
            this.btnSaveGroup.Click += new System.EventHandler(this.btnSaveGroup_Click);
            // 
            // dgvSubGroups
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubGroups.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubGroups.Location = new System.Drawing.Point(12, 10);
            this.dgvSubGroups.Name = "dgvSubGroups";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubGroups.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubGroups.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSubGroups.Size = new System.Drawing.Size(984, 470);
            this.dgvSubGroups.TabIndex = 2;
            // 
            // btnGetGroup
            // 
            this.btnGetGroup.Location = new System.Drawing.Point(710, 563);
            this.btnGetGroup.Name = "btnGetGroup";
            this.btnGetGroup.Size = new System.Drawing.Size(134, 71);
            this.btnGetGroup.TabIndex = 3;
            this.btnGetGroup.Text = "Get Group";
            this.btnGetGroup.UseVisualStyleBackColor = true;
            this.btnGetGroup.Click += new System.EventHandler(this.btnGetGroup_Click);
            // 
            // SubGroupPanel
            // 
            this.SubGroupPanel.Controls.Add(this.btnDelete);
            this.SubGroupPanel.Controls.Add(this.btnReset);
            this.SubGroupPanel.Controls.Add(this.cbSubGroup);
            this.SubGroupPanel.Controls.Add(this.dgvSubGroups);
            this.SubGroupPanel.Controls.Add(this.btnGetGroup);
            this.SubGroupPanel.Controls.Add(this.txtSubGroup);
            this.SubGroupPanel.Controls.Add(this.btnSaveGroup);
            this.SubGroupPanel.Location = new System.Drawing.Point(0, 2);
            this.SubGroupPanel.Name = "SubGroupPanel";
            this.SubGroupPanel.Size = new System.Drawing.Size(1009, 680);
            this.SubGroupPanel.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(850, 563);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 71);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(850, 486);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 71);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbSubGroup
            // 
            this.cbSubGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubGroup.FormattingEnabled = true;
            this.cbSubGroup.Location = new System.Drawing.Point(3, 589);
            this.cbSubGroup.Name = "cbSubGroup";
            this.cbSubGroup.Size = new System.Drawing.Size(701, 21);
            this.cbSubGroup.TabIndex = 4;
            // 
            // JobSubGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.SubGroupPanel);
            this.Name = "JobSubGroups";
            this.Text = "JobSubGroups";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGroups)).EndInit();
            this.SubGroupPanel.ResumeLayout(false);
            this.SubGroupPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubGroup;
        private System.Windows.Forms.Button btnSaveGroup;
        private System.Windows.Forms.DataGridView dgvSubGroups;
        private System.Windows.Forms.Button btnGetGroup;
        private System.Windows.Forms.Panel SubGroupPanel;
        private System.Windows.Forms.ComboBox cbSubGroup;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
    }
}