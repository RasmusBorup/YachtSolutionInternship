namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class CreateLogItem.
    /// </summary>
    partial class CreateLogItem
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
            this.lblLogItemName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbLogItemName = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbUnitOfMeasurement = new System.Windows.Forms.TextBox();
            this.lblUnitOfMeasurement = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(350, 364);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(149, 52);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register new log item";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(350, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 49);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbLogItemName
            // 
            this.tbLogItemName.Location = new System.Drawing.Point(12, 29);
            this.tbLogItemName.Name = "tbLogItemName";
            this.tbLogItemName.Size = new System.Drawing.Size(332, 20);
            this.tbLogItemName.TabIndex = 1;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(12, 115);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(332, 356);
            this.rtbDescription.TabIndex = 3;
            this.rtbDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 99);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description";
            // 
            // tbUnitOfMeasurement
            // 
            this.tbUnitOfMeasurement.Location = new System.Drawing.Point(12, 70);
            this.tbUnitOfMeasurement.Name = "tbUnitOfMeasurement";
            this.tbUnitOfMeasurement.Size = new System.Drawing.Size(332, 20);
            this.tbUnitOfMeasurement.TabIndex = 2;
            // 
            // lblUnitOfMeasurement
            // 
            this.lblUnitOfMeasurement.AutoSize = true;
            this.lblUnitOfMeasurement.Location = new System.Drawing.Point(12, 54);
            this.lblUnitOfMeasurement.Name = "lblUnitOfMeasurement";
            this.lblUnitOfMeasurement.Size = new System.Drawing.Size(104, 13);
            this.lblUnitOfMeasurement.TabIndex = 11;
            this.lblUnitOfMeasurement.Text = "Unit of measurement";
            // 
            // CreateLogItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 483);
            this.Controls.Add(this.tbUnitOfMeasurement);
            this.Controls.Add(this.lblUnitOfMeasurement);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.tbLogItemName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblLogItemName);
            this.Name = "CreateLogItem";
            this.Text = "Create Log Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogItemName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbLogItemName;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbUnitOfMeasurement;
        private System.Windows.Forms.Label lblUnitOfMeasurement;
    }
}