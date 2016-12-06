namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class UpdateReading.
    /// </summary>
    partial class UpdateReading
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
            this.lblOldTimeStamp = new System.Windows.Forms.Label();
            this.tbOldTimeStamp = new System.Windows.Forms.TextBox();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.tbMachineName = new System.Windows.Forms.TextBox();
            this.lblOldValue = new System.Windows.Forms.Label();
            this.tbOldValue = new System.Windows.Forms.TextBox();
            this.lblServiedBy = new System.Windows.Forms.Label();
            this.tbServicedBy = new System.Windows.Forms.TextBox();
            this.lblNewValue = new System.Windows.Forms.Label();
            this.tbNewValue = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateReading = new System.Windows.Forms.Button();
            this.lblReadId = new System.Windows.Forms.Label();
            this.tbReadId = new System.Windows.Forms.TextBox();
            this.tbUnitOfMeasurement = new System.Windows.Forms.TextBox();
            this.lblUnitOfMeasurement = new System.Windows.Forms.Label();
            this.tbMachineUsedFor = new System.Windows.Forms.TextBox();
            this.lblMachineUsedFor = new System.Windows.Forms.Label();
            this.tbHourCounter = new System.Windows.Forms.TextBox();
            this.lblHourCounter = new System.Windows.Forms.Label();
            this.tbMaintainAtHours = new System.Windows.Forms.TextBox();
            this.lblMaintainAtHours = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOldTimeStamp
            // 
            this.lblOldTimeStamp.AutoSize = true;
            this.lblOldTimeStamp.Location = new System.Drawing.Point(6, 134);
            this.lblOldTimeStamp.Name = "lblOldTimeStamp";
            this.lblOldTimeStamp.Size = new System.Drawing.Size(94, 13);
            this.lblOldTimeStamp.TabIndex = 3;
            this.lblOldTimeStamp.Text = "Last time checked";
            // 
            // tbOldTimeStamp
            // 
            this.tbOldTimeStamp.Enabled = false;
            this.tbOldTimeStamp.Location = new System.Drawing.Point(6, 150);
            this.tbOldTimeStamp.Name = "tbOldTimeStamp";
            this.tbOldTimeStamp.Size = new System.Drawing.Size(268, 20);
            this.tbOldTimeStamp.TabIndex = 2;
            this.tbOldTimeStamp.TabStop = false;
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Location = new System.Drawing.Point(294, 49);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(77, 13);
            this.lblMachineName.TabIndex = 5;
            this.lblMachineName.Text = "Machine name";
            // 
            // tbMachineName
            // 
            this.tbMachineName.Location = new System.Drawing.Point(294, 65);
            this.tbMachineName.Name = "tbMachineName";
            this.tbMachineName.Size = new System.Drawing.Size(268, 20);
            this.tbMachineName.TabIndex = 3;
            // 
            // lblOldValue
            // 
            this.lblOldValue.AutoSize = true;
            this.lblOldValue.Location = new System.Drawing.Point(6, 49);
            this.lblOldValue.Name = "lblOldValue";
            this.lblOldValue.Size = new System.Drawing.Size(114, 13);
            this.lblOldValue.TabIndex = 7;
            this.lblOldValue.Text = "Previous measurement";
            // 
            // tbOldValue
            // 
            this.tbOldValue.Enabled = false;
            this.tbOldValue.Location = new System.Drawing.Point(6, 65);
            this.tbOldValue.Name = "tbOldValue";
            this.tbOldValue.Size = new System.Drawing.Size(268, 20);
            this.tbOldValue.TabIndex = 6;
            this.tbOldValue.TabStop = false;
            // 
            // lblServiedBy
            // 
            this.lblServiedBy.AutoSize = true;
            this.lblServiedBy.Location = new System.Drawing.Point(294, 6);
            this.lblServiedBy.Name = "lblServiedBy";
            this.lblServiedBy.Size = new System.Drawing.Size(63, 13);
            this.lblServiedBy.TabIndex = 13;
            this.lblServiedBy.Text = "Serviced by";
            // 
            // tbServicedBy
            // 
            this.tbServicedBy.Location = new System.Drawing.Point(294, 22);
            this.tbServicedBy.Name = "tbServicedBy";
            this.tbServicedBy.Size = new System.Drawing.Size(268, 20);
            this.tbServicedBy.TabIndex = 2;
            // 
            // lblNewValue
            // 
            this.lblNewValue.AutoSize = true;
            this.lblNewValue.Location = new System.Drawing.Point(6, 6);
            this.lblNewValue.Name = "lblNewValue";
            this.lblNewValue.Size = new System.Drawing.Size(107, 13);
            this.lblNewValue.TabIndex = 15;
            this.lblNewValue.Text = "Current measurement";
            // 
            // tbNewValue
            // 
            this.tbNewValue.Location = new System.Drawing.Point(6, 22);
            this.tbNewValue.Name = "tbNewValue";
            this.tbNewValue.Size = new System.Drawing.Size(268, 20);
            this.tbNewValue.TabIndex = 1;
            this.tbNewValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNewValue_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(268, 46);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateReading
            // 
            this.btnUpdateReading.Location = new System.Drawing.Point(294, 235);
            this.btnUpdateReading.Name = "btnUpdateReading";
            this.btnUpdateReading.Size = new System.Drawing.Size(268, 46);
            this.btnUpdateReading.TabIndex = 5;
            this.btnUpdateReading.Text = "Save changes";
            this.btnUpdateReading.UseVisualStyleBackColor = true;
            this.btnUpdateReading.Click += new System.EventHandler(this.btnUpdateReading_Click);
            // 
            // lblReadId
            // 
            this.lblReadId.AutoSize = true;
            this.lblReadId.Location = new System.Drawing.Point(294, 134);
            this.lblReadId.Name = "lblReadId";
            this.lblReadId.Size = new System.Drawing.Size(61, 13);
            this.lblReadId.TabIndex = 19;
            this.lblReadId.Text = "Reading ID";
            // 
            // tbReadId
            // 
            this.tbReadId.Enabled = false;
            this.tbReadId.Location = new System.Drawing.Point(294, 150);
            this.tbReadId.Name = "tbReadId";
            this.tbReadId.Size = new System.Drawing.Size(268, 20);
            this.tbReadId.TabIndex = 18;
            this.tbReadId.TabStop = false;
            // 
            // tbUnitOfMeasurement
            // 
            this.tbUnitOfMeasurement.Location = new System.Drawing.Point(6, 107);
            this.tbUnitOfMeasurement.Name = "tbUnitOfMeasurement";
            this.tbUnitOfMeasurement.Size = new System.Drawing.Size(268, 20);
            this.tbUnitOfMeasurement.TabIndex = 4;
            // 
            // lblUnitOfMeasurement
            // 
            this.lblUnitOfMeasurement.AutoSize = true;
            this.lblUnitOfMeasurement.Location = new System.Drawing.Point(6, 91);
            this.lblUnitOfMeasurement.Name = "lblUnitOfMeasurement";
            this.lblUnitOfMeasurement.Size = new System.Drawing.Size(104, 13);
            this.lblUnitOfMeasurement.TabIndex = 3;
            this.lblUnitOfMeasurement.Text = "Unit of measurement";
            // 
            // tbMachineUsedFor
            // 
            this.tbMachineUsedFor.Location = new System.Drawing.Point(294, 107);
            this.tbMachineUsedFor.Name = "tbMachineUsedFor";
            this.tbMachineUsedFor.Size = new System.Drawing.Size(268, 20);
            this.tbMachineUsedFor.TabIndex = 5;
            // 
            // lblMachineUsedFor
            // 
            this.lblMachineUsedFor.AutoSize = true;
            this.lblMachineUsedFor.Location = new System.Drawing.Point(294, 91);
            this.lblMachineUsedFor.Name = "lblMachineUsedFor";
            this.lblMachineUsedFor.Size = new System.Drawing.Size(89, 13);
            this.lblMachineUsedFor.TabIndex = 19;
            this.lblMachineUsedFor.Text = "Machine used for";
            // 
            // tbHourCounter
            // 
            this.tbHourCounter.Location = new System.Drawing.Point(6, 192);
            this.tbHourCounter.Name = "tbHourCounter";
            this.tbHourCounter.Size = new System.Drawing.Size(268, 20);
            this.tbHourCounter.TabIndex = 2;
            this.tbHourCounter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHourCounter_KeyPress);
            // 
            // lblHourCounter
            // 
            this.lblHourCounter.AutoSize = true;
            this.lblHourCounter.Location = new System.Drawing.Point(6, 176);
            this.lblHourCounter.Name = "lblHourCounter";
            this.lblHourCounter.Size = new System.Drawing.Size(69, 13);
            this.lblHourCounter.TabIndex = 3;
            this.lblHourCounter.Text = "Hour counter";
            // 
            // tbMaintainAtHours
            // 
            this.tbMaintainAtHours.Location = new System.Drawing.Point(294, 192);
            this.tbMaintainAtHours.Name = "tbMaintainAtHours";
            this.tbMaintainAtHours.Size = new System.Drawing.Size(268, 20);
            this.tbMaintainAtHours.TabIndex = 18;
            this.tbMaintainAtHours.TabStop = false;
            this.tbMaintainAtHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaintainAtHours_KeyPress);
            // 
            // lblMaintainAtHours
            // 
            this.lblMaintainAtHours.AutoSize = true;
            this.lblMaintainAtHours.Location = new System.Drawing.Point(294, 176);
            this.lblMaintainAtHours.Name = "lblMaintainAtHours";
            this.lblMaintainAtHours.Size = new System.Drawing.Size(88, 13);
            this.lblMaintainAtHours.TabIndex = 19;
            this.lblMaintainAtHours.Text = "Maintain at hours";
            // 
            // UpdateReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 293);
            this.Controls.Add(this.lblMachineUsedFor);
            this.Controls.Add(this.lblMaintainAtHours);
            this.Controls.Add(this.lblReadId);
            this.Controls.Add(this.tbMachineUsedFor);
            this.Controls.Add(this.tbMaintainAtHours);
            this.Controls.Add(this.tbReadId);
            this.Controls.Add(this.btnUpdateReading);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNewValue);
            this.Controls.Add(this.tbNewValue);
            this.Controls.Add(this.lblServiedBy);
            this.Controls.Add(this.tbServicedBy);
            this.Controls.Add(this.lblOldValue);
            this.Controls.Add(this.tbOldValue);
            this.Controls.Add(this.lblMachineName);
            this.Controls.Add(this.lblUnitOfMeasurement);
            this.Controls.Add(this.tbMachineName);
            this.Controls.Add(this.lblHourCounter);
            this.Controls.Add(this.tbUnitOfMeasurement);
            this.Controls.Add(this.tbHourCounter);
            this.Controls.Add(this.lblOldTimeStamp);
            this.Controls.Add(this.tbOldTimeStamp);
            this.Name = "UpdateReading";
            this.Text = "Update Reading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldTimeStamp;
        private System.Windows.Forms.TextBox tbOldTimeStamp;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.TextBox tbMachineName;
        private System.Windows.Forms.Label lblOldValue;
        private System.Windows.Forms.TextBox tbOldValue;
        private System.Windows.Forms.Label lblServiedBy;
        private System.Windows.Forms.TextBox tbServicedBy;
        private System.Windows.Forms.Label lblNewValue;
        private System.Windows.Forms.TextBox tbNewValue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateReading;
        private System.Windows.Forms.Label lblReadId;
        private System.Windows.Forms.TextBox tbReadId;
        private System.Windows.Forms.TextBox tbUnitOfMeasurement;
        private System.Windows.Forms.Label lblUnitOfMeasurement;
        private System.Windows.Forms.TextBox tbMachineUsedFor;
        private System.Windows.Forms.Label lblMachineUsedFor;
        private System.Windows.Forms.TextBox tbHourCounter;
        private System.Windows.Forms.Label lblHourCounter;
        private System.Windows.Forms.TextBox tbMaintainAtHours;
        private System.Windows.Forms.Label lblMaintainAtHours;
    }
}