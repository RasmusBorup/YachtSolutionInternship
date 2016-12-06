namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class CreateReading.
    /// </summary>
    partial class CreateReading
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
            this.tbMachineName = new System.Windows.Forms.TextBox();
            this.tbNewValue = new System.Windows.Forms.TextBox();
            this.tbServicedBy = new System.Windows.Forms.TextBox();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblReadingValue = new System.Windows.Forms.Label();
            this.lblServicedBy = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateReading = new System.Windows.Forms.Button();
            this.lblUnitOfMeasurement = new System.Windows.Forms.Label();
            this.tbUnitOfMeasurement = new System.Windows.Forms.TextBox();
            this.lblMachineUsedFor = new System.Windows.Forms.Label();
            this.tbMachineUsedFor = new System.Windows.Forms.TextBox();
            this.tbHourCounter = new System.Windows.Forms.TextBox();
            this.lblHourCounter = new System.Windows.Forms.Label();
            this.lblMantainAtHours = new System.Windows.Forms.Label();
            this.tbMaintainAtHours = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbMachineName
            // 
            this.tbMachineName.Location = new System.Drawing.Point(12, 25);
            this.tbMachineName.Name = "tbMachineName";
            this.tbMachineName.Size = new System.Drawing.Size(268, 20);
            this.tbMachineName.TabIndex = 1;
            // 
            // tbNewValue
            // 
            this.tbNewValue.Location = new System.Drawing.Point(12, 73);
            this.tbNewValue.Name = "tbNewValue";
            this.tbNewValue.Size = new System.Drawing.Size(268, 20);
            this.tbNewValue.TabIndex = 2;
            this.tbNewValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNewValue_KeyPress);
            // 
            // tbServicedBy
            // 
            this.tbServicedBy.Location = new System.Drawing.Point(304, 25);
            this.tbServicedBy.Name = "tbServicedBy";
            this.tbServicedBy.Size = new System.Drawing.Size(268, 20);
            this.tbServicedBy.TabIndex = 4;
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Location = new System.Drawing.Point(12, 9);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(90, 13);
            this.lblMachineName.TabIndex = 3;
            this.lblMachineName.Text = "Name of machine";
            // 
            // lblReadingValue
            // 
            this.lblReadingValue.AutoSize = true;
            this.lblReadingValue.Location = new System.Drawing.Point(12, 57);
            this.lblReadingValue.Name = "lblReadingValue";
            this.lblReadingValue.Size = new System.Drawing.Size(76, 13);
            this.lblReadingValue.TabIndex = 4;
            this.lblReadingValue.Text = "Reading value";
            // 
            // lblServicedBy
            // 
            this.lblServicedBy.AutoSize = true;
            this.lblServicedBy.Location = new System.Drawing.Point(304, 9);
            this.lblServicedBy.Name = "lblServicedBy";
            this.lblServicedBy.Size = new System.Drawing.Size(63, 13);
            this.lblServicedBy.TabIndex = 5;
            this.lblServicedBy.Text = "Serviced by";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(268, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateReading
            // 
            this.btnCreateReading.Location = new System.Drawing.Point(304, 199);
            this.btnCreateReading.Name = "btnCreateReading";
            this.btnCreateReading.Size = new System.Drawing.Size(268, 46);
            this.btnCreateReading.TabIndex = 6;
            this.btnCreateReading.Text = "Save";
            this.btnCreateReading.UseVisualStyleBackColor = true;
            this.btnCreateReading.Click += new System.EventHandler(this.btnCreateReading_Click);
            // 
            // lblUnitOfMeasurement
            // 
            this.lblUnitOfMeasurement.AutoSize = true;
            this.lblUnitOfMeasurement.Location = new System.Drawing.Point(12, 105);
            this.lblUnitOfMeasurement.Name = "lblUnitOfMeasurement";
            this.lblUnitOfMeasurement.Size = new System.Drawing.Size(104, 13);
            this.lblUnitOfMeasurement.TabIndex = 7;
            this.lblUnitOfMeasurement.Text = "Unit of measurement";
            // 
            // tbUnitOfMeasurement
            // 
            this.tbUnitOfMeasurement.Location = new System.Drawing.Point(12, 121);
            this.tbUnitOfMeasurement.Name = "tbUnitOfMeasurement";
            this.tbUnitOfMeasurement.Size = new System.Drawing.Size(268, 20);
            this.tbUnitOfMeasurement.TabIndex = 3;
            // 
            // lblMachineUsedFor
            // 
            this.lblMachineUsedFor.AutoSize = true;
            this.lblMachineUsedFor.Location = new System.Drawing.Point(304, 57);
            this.lblMachineUsedFor.Name = "lblMachineUsedFor";
            this.lblMachineUsedFor.Size = new System.Drawing.Size(107, 13);
            this.lblMachineUsedFor.TabIndex = 9;
            this.lblMachineUsedFor.Text = "Machine it is used for";
            // 
            // tbMachineUsedFor
            // 
            this.tbMachineUsedFor.Location = new System.Drawing.Point(304, 73);
            this.tbMachineUsedFor.Name = "tbMachineUsedFor";
            this.tbMachineUsedFor.Size = new System.Drawing.Size(268, 20);
            this.tbMachineUsedFor.TabIndex = 5;
            // 
            // tbHourCounter
            // 
            this.tbHourCounter.Location = new System.Drawing.Point(304, 121);
            this.tbHourCounter.Name = "tbHourCounter";
            this.tbHourCounter.Size = new System.Drawing.Size(268, 20);
            this.tbHourCounter.TabIndex = 10;
            this.tbHourCounter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHourCounter_KeyPress);
            // 
            // lblHourCounter
            // 
            this.lblHourCounter.AutoSize = true;
            this.lblHourCounter.Location = new System.Drawing.Point(304, 105);
            this.lblHourCounter.Name = "lblHourCounter";
            this.lblHourCounter.Size = new System.Drawing.Size(69, 13);
            this.lblHourCounter.TabIndex = 11;
            this.lblHourCounter.Text = "Hour counter";
            // 
            // lblMantainAtHours
            // 
            this.lblMantainAtHours.AutoSize = true;
            this.lblMantainAtHours.Location = new System.Drawing.Point(12, 152);
            this.lblMantainAtHours.Name = "lblMantainAtHours";
            this.lblMantainAtHours.Size = new System.Drawing.Size(88, 13);
            this.lblMantainAtHours.TabIndex = 13;
            this.lblMantainAtHours.Text = "Maintain at hours";
            // 
            // tbMaintainAtHours
            // 
            this.tbMaintainAtHours.Location = new System.Drawing.Point(12, 168);
            this.tbMaintainAtHours.Name = "tbMaintainAtHours";
            this.tbMaintainAtHours.Size = new System.Drawing.Size(268, 20);
            this.tbMaintainAtHours.TabIndex = 12;
            this.tbMaintainAtHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaintainAtHours_KeyPress);
            // 
            // CreateReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 257);
            this.Controls.Add(this.lblMantainAtHours);
            this.Controls.Add(this.tbMaintainAtHours);
            this.Controls.Add(this.lblHourCounter);
            this.Controls.Add(this.tbHourCounter);
            this.Controls.Add(this.lblMachineUsedFor);
            this.Controls.Add(this.tbMachineUsedFor);
            this.Controls.Add(this.lblUnitOfMeasurement);
            this.Controls.Add(this.tbUnitOfMeasurement);
            this.Controls.Add(this.btnCreateReading);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblServicedBy);
            this.Controls.Add(this.lblReadingValue);
            this.Controls.Add(this.lblMachineName);
            this.Controls.Add(this.tbServicedBy);
            this.Controls.Add(this.tbNewValue);
            this.Controls.Add(this.tbMachineName);
            this.Name = "CreateReading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Reading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMachineName;
        private System.Windows.Forms.TextBox tbNewValue;
        private System.Windows.Forms.TextBox tbServicedBy;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblReadingValue;
        private System.Windows.Forms.Label lblServicedBy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateReading;
        private System.Windows.Forms.Label lblUnitOfMeasurement;
        private System.Windows.Forms.TextBox tbUnitOfMeasurement;
        private System.Windows.Forms.Label lblMachineUsedFor;
        private System.Windows.Forms.TextBox tbMachineUsedFor;
        private System.Windows.Forms.TextBox tbHourCounter;
        private System.Windows.Forms.Label lblHourCounter;
        private System.Windows.Forms.Label lblMantainAtHours;
        private System.Windows.Forms.TextBox tbMaintainAtHours;
    }
}