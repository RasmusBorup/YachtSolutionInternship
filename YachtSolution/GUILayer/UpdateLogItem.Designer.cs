namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class UpdateLogItem.
    /// </summary>
    partial class UpdateLogItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbUnitOfMeasurement = new System.Windows.Forms.TextBox();
            this.lblUnitOfMeasurement = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbItemDescription = new System.Windows.Forms.RichTextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblDifference = new System.Windows.Forms.Label();
            this.tbYesterdaysReading = new System.Windows.Forms.TextBox();
            this.lblYesterdaysHourCount = new System.Windows.Forms.Label();
            this.tbTodaysReading = new System.Windows.Forms.TextBox();
            this.lblTodaysHourCount = new System.Windows.Forms.Label();
            this.tbLogItemName = new System.Windows.Forms.TextBox();
            this.lblLogItemName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbUnitOfMeasurement);
            this.panel1.Controls.Add(this.lblUnitOfMeasurement);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.rtbItemDescription);
            this.panel1.Controls.Add(this.tbTotal);
            this.panel1.Controls.Add(this.lblDifference);
            this.panel1.Controls.Add(this.tbYesterdaysReading);
            this.panel1.Controls.Add(this.lblYesterdaysHourCount);
            this.panel1.Controls.Add(this.tbTodaysReading);
            this.panel1.Controls.Add(this.lblTodaysHourCount);
            this.panel1.Controls.Add(this.tbLogItemName);
            this.panel1.Controls.Add(this.lblLogItemName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 427);
            this.panel1.TabIndex = 0;
            // 
            // tbUnitOfMeasurement
            // 
            this.tbUnitOfMeasurement.Location = new System.Drawing.Point(12, 70);
            this.tbUnitOfMeasurement.Name = "tbUnitOfMeasurement";
            this.tbUnitOfMeasurement.Size = new System.Drawing.Size(217, 20);
            this.tbUnitOfMeasurement.TabIndex = 2;
            // 
            // lblUnitOfMeasurement
            // 
            this.lblUnitOfMeasurement.AutoSize = true;
            this.lblUnitOfMeasurement.Location = new System.Drawing.Point(12, 54);
            this.lblUnitOfMeasurement.Name = "lblUnitOfMeasurement";
            this.lblUnitOfMeasurement.Size = new System.Drawing.Size(106, 13);
            this.lblUnitOfMeasurement.TabIndex = 14;
            this.lblUnitOfMeasurement.Text = "Unit Of measurement";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(16, 251);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(216, 50);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Save Changes";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 307);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(216, 50);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Log Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(16, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(217, 50);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(258, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description";
            // 
            // rtbItemDescription
            // 
            this.rtbItemDescription.Location = new System.Drawing.Point(261, 25);
            this.rtbItemDescription.Name = "rtbItemDescription";
            this.rtbItemDescription.Size = new System.Drawing.Size(376, 389);
            this.rtbItemDescription.TabIndex = 4;
            this.rtbItemDescription.Text = "";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(12, 205);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(217, 20);
            this.tbTotal.TabIndex = 9;
            // 
            // lblDifference
            // 
            this.lblDifference.AutoSize = true;
            this.lblDifference.Location = new System.Drawing.Point(12, 189);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Size = new System.Drawing.Size(56, 13);
            this.lblDifference.TabIndex = 8;
            this.lblDifference.Text = "Difference";
            // 
            // tbYesterdaysReading
            // 
            this.tbYesterdaysReading.Location = new System.Drawing.Point(12, 160);
            this.tbYesterdaysReading.Name = "tbYesterdaysReading";
            this.tbYesterdaysReading.ReadOnly = true;
            this.tbYesterdaysReading.Size = new System.Drawing.Size(217, 20);
            this.tbYesterdaysReading.TabIndex = 7;
            // 
            // lblYesterdaysHourCount
            // 
            this.lblYesterdaysHourCount.AutoSize = true;
            this.lblYesterdaysHourCount.Location = new System.Drawing.Point(12, 144);
            this.lblYesterdaysHourCount.Name = "lblYesterdaysHourCount";
            this.lblYesterdaysHourCount.Size = new System.Drawing.Size(113, 13);
            this.lblYesterdaysHourCount.TabIndex = 6;
            this.lblYesterdaysHourCount.Text = "Yesterdays hour count";
            // 
            // tbTodaysReading
            // 
            this.tbTodaysReading.Location = new System.Drawing.Point(12, 115);
            this.tbTodaysReading.Name = "tbTodaysReading";
            this.tbTodaysReading.Size = new System.Drawing.Size(217, 20);
            this.tbTodaysReading.TabIndex = 3;
            this.tbTodaysReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTodaysReading_KeyPress);
            // 
            // lblTodaysHourCount
            // 
            this.lblTodaysHourCount.AutoSize = true;
            this.lblTodaysHourCount.Location = new System.Drawing.Point(12, 99);
            this.lblTodaysHourCount.Name = "lblTodaysHourCount";
            this.lblTodaysHourCount.Size = new System.Drawing.Size(96, 13);
            this.lblTodaysHourCount.TabIndex = 4;
            this.lblTodaysHourCount.Text = "Todays hour count";
            // 
            // tbLogItemName
            // 
            this.tbLogItemName.Location = new System.Drawing.Point(12, 25);
            this.tbLogItemName.Name = "tbLogItemName";
            this.tbLogItemName.Size = new System.Drawing.Size(217, 20);
            this.tbLogItemName.TabIndex = 1;
            // 
            // lblLogItemName
            // 
            this.lblLogItemName.AutoSize = true;
            this.lblLogItemName.Location = new System.Drawing.Point(12, 9);
            this.lblLogItemName.Name = "lblLogItemName";
            this.lblLogItemName.Size = new System.Drawing.Size(76, 13);
            this.lblLogItemName.TabIndex = 0;
            this.lblLogItemName.Text = "Log item name";
            // 
            // UpdateLogItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 427);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateLogItem";
            this.Text = "Update Log Item";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogItemName;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblDifference;
        private System.Windows.Forms.TextBox tbYesterdaysReading;
        private System.Windows.Forms.Label lblYesterdaysHourCount;
        private System.Windows.Forms.TextBox tbTodaysReading;
        private System.Windows.Forms.Label lblTodaysHourCount;
        private System.Windows.Forms.TextBox tbLogItemName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbItemDescription;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbUnitOfMeasurement;
        private System.Windows.Forms.Label lblUnitOfMeasurement;
    }
}