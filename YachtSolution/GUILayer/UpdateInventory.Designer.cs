namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class UpdateInventory.
    /// </summary>
    partial class UpdateInventory
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
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btnUpdateItemCancel = new System.Windows.Forms.Button();
            this.btnSaveUpdateItem = new System.Windows.Forms.Button();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.numericUpDownMinAmount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSerialNr = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbManufacturer = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSerialNr = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblminimumAmount = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblPartFor = new System.Windows.Forms.Label();
            this.tbPartFor = new System.Windows.Forms.TextBox();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.rtbSuppliers = new System.Windows.Forms.RichTextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.InitialImage = null;
            this.pbPhoto.Location = new System.Drawing.Point(531, 23);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(324, 254);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 72;
            this.pbPhoto.TabStop = false;
            // 
            // btnUpdateItemCancel
            // 
            this.btnUpdateItemCancel.Location = new System.Drawing.Point(12, 413);
            this.btnUpdateItemCancel.Name = "btnUpdateItemCancel";
            this.btnUpdateItemCancel.Size = new System.Drawing.Size(268, 46);
            this.btnUpdateItemCancel.TabIndex = 10;
            this.btnUpdateItemCancel.Text = "Cancel";
            this.btnUpdateItemCancel.UseVisualStyleBackColor = true;
            this.btnUpdateItemCancel.Click += new System.EventHandler(this.btnUpdateItemCancel_Click);
            // 
            // btnSaveUpdateItem
            // 
            this.btnSaveUpdateItem.Location = new System.Drawing.Point(531, 413);
            this.btnSaveUpdateItem.Name = "btnSaveUpdateItem";
            this.btnSaveUpdateItem.Size = new System.Drawing.Size(324, 46);
            this.btnSaveUpdateItem.TabIndex = 9;
            this.btnSaveUpdateItem.Text = "Update item";
            this.btnSaveUpdateItem.UseVisualStyleBackColor = true;
            this.btnSaveUpdateItem.Click += new System.EventHandler(this.btnSaveUpdateItem_Click);
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(531, 283);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(324, 46);
            this.btnBrowseImage.TabIndex = 8;
            this.btnBrowseImage.Text = "Browse image";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(289, 7);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(30, 13);
            this.lblNote.TabIndex = 62;
            this.lblNote.Text = "Note";
            // 
            // numericUpDownMinAmount
            // 
            this.numericUpDownMinAmount.Location = new System.Drawing.Point(9, 179);
            this.numericUpDownMinAmount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownMinAmount.Name = "numericUpDownMinAmount";
            this.numericUpDownMinAmount.Size = new System.Drawing.Size(269, 20);
            this.numericUpDownMinAmount.TabIndex = 4;
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(9, 62);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(269, 20);
            this.numericUpDownAmount.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(9, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(269, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbSerialNr
            // 
            this.tbSerialNr.Location = new System.Drawing.Point(9, 101);
            this.tbSerialNr.Name = "tbSerialNr";
            this.tbSerialNr.Size = new System.Drawing.Size(269, 20);
            this.tbSerialNr.TabIndex = 2;
            this.tbSerialNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSerialNr_KeyPress);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(9, 140);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(269, 20);
            this.tbPrice.TabIndex = 3;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(9, 218);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(269, 20);
            this.tbLocation.TabIndex = 5;
            // 
            // tbManufacturer
            // 
            this.tbManufacturer.Location = new System.Drawing.Point(9, 257);
            this.tbManufacturer.Name = "tbManufacturer";
            this.tbManufacturer.Size = new System.Drawing.Size(269, 20);
            this.tbManufacturer.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 80;
            this.lblName.Text = "Name";
            // 
            // lblSerialNr
            // 
            this.lblSerialNr.AutoSize = true;
            this.lblSerialNr.Location = new System.Drawing.Point(9, 85);
            this.lblSerialNr.Name = "lblSerialNr";
            this.lblSerialNr.Size = new System.Drawing.Size(71, 13);
            this.lblSerialNr.TabIndex = 81;
            this.lblSerialNr.Text = "Serial number";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(9, 124);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 82;
            this.lblPrice.Text = "Price";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(9, 46);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 86;
            this.lblAmount.Text = "Amount";
            // 
            // lblminimumAmount
            // 
            this.lblminimumAmount.AutoSize = true;
            this.lblminimumAmount.Location = new System.Drawing.Point(9, 163);
            this.lblminimumAmount.Name = "lblminimumAmount";
            this.lblminimumAmount.Size = new System.Drawing.Size(86, 13);
            this.lblminimumAmount.TabIndex = 83;
            this.lblminimumAmount.Text = "Minimum amount";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(9, 202);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 84;
            this.lblLocation.Text = "Location";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(9, 241);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(70, 13);
            this.lblManufacturer.TabIndex = 85;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblPartFor
            // 
            this.lblPartFor.AutoSize = true;
            this.lblPartFor.Location = new System.Drawing.Point(9, 280);
            this.lblPartFor.Name = "lblPartFor";
            this.lblPartFor.Size = new System.Drawing.Size(41, 13);
            this.lblPartFor.TabIndex = 87;
            this.lblPartFor.Text = "Part for";
            // 
            // tbPartFor
            // 
            this.tbPartFor.Location = new System.Drawing.Point(9, 297);
            this.tbPartFor.Name = "tbPartFor";
            this.tbPartFor.Size = new System.Drawing.Size(269, 20);
            this.tbPartFor.TabIndex = 88;
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Location = new System.Drawing.Point(289, 225);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(50, 13);
            this.lblSuppliers.TabIndex = 89;
            this.lblSuppliers.Text = "Suppliers";
            // 
            // rtbSuppliers
            // 
            this.rtbSuppliers.Location = new System.Drawing.Point(283, 241);
            this.rtbSuppliers.Name = "rtbSuppliers";
            this.rtbSuppliers.Size = new System.Drawing.Size(242, 218);
            this.rtbSuppliers.TabIndex = 90;
            this.rtbSuppliers.Text = "";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(283, 23);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(242, 192);
            this.rtbDescription.TabIndex = 90;
            this.rtbDescription.Text = "";
            // 
            // UpdateInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 471);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.rtbSuppliers);
            this.Controls.Add(this.lblSuppliers);
            this.Controls.Add(this.tbPartFor);
            this.Controls.Add(this.lblPartFor);
            this.Controls.Add(this.numericUpDownMinAmount);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSerialNr);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.tbManufacturer);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSerialNr);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblminimumAmount);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.btnUpdateItemCancel);
            this.Controls.Add(this.btnSaveUpdateItem);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.lblNote);
            this.Name = "UpdateInventory";
            this.Text = "Update Item";
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnUpdateItemCancel;
        private System.Windows.Forms.Button btnSaveUpdateItem;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.NumericUpDown numericUpDownMinAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSerialNr;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.TextBox tbManufacturer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSerialNr;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblminimumAmount;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblPartFor;
        private System.Windows.Forms.TextBox tbPartFor;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.RichTextBox rtbSuppliers;
        private System.Windows.Forms.RichTextBox rtbDescription;

    }
}