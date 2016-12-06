namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class UpdateGuest.
    /// </summary>
    partial class UpdateGuest
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
            this.note_label = new System.Windows.Forms.Label();
            this.birthday_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.phonenumber_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.birthday_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.note_textBox = new System.Windows.Forms.TextBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // note_label
            // 
            this.note_label.AutoSize = true;
            this.note_label.Location = new System.Drawing.Point(13, 281);
            this.note_label.Name = "note_label";
            this.note_label.Size = new System.Drawing.Size(30, 13);
            this.note_label.TabIndex = 52;
            this.note_label.Text = "Note";
            // 
            // birthday_label
            // 
            this.birthday_label.AutoSize = true;
            this.birthday_label.Location = new System.Drawing.Point(301, 203);
            this.birthday_label.Name = "birthday_label";
            this.birthday_label.Size = new System.Drawing.Size(45, 13);
            this.birthday_label.TabIndex = 51;
            this.birthday_label.Text = "Birthday";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(9, 203);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(45, 13);
            this.address_label.TabIndex = 50;
            this.address_label.Text = "Address";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(307, 125);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(32, 13);
            this.email_label.TabIndex = 49;
            this.email_label.Text = "Email";
            // 
            // phonenumber_label
            // 
            this.phonenumber_label.AutoSize = true;
            this.phonenumber_label.Location = new System.Drawing.Point(13, 125);
            this.phonenumber_label.Name = "phonenumber_label";
            this.phonenumber_label.Size = new System.Drawing.Size(78, 13);
            this.phonenumber_label.TabIndex = 48;
            this.phonenumber_label.Text = "Phone Number";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(304, 48);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(35, 13);
            this.Name_label.TabIndex = 47;
            this.Name_label.Text = "Name";
            // 
            // birthday_dateTimePicker
            // 
            this.birthday_dateTimePicker.Location = new System.Drawing.Point(303, 219);
            this.birthday_dateTimePicker.Name = "birthday_dateTimePicker";
            this.birthday_dateTimePicker.Size = new System.Drawing.Size(268, 20);
            this.birthday_dateTimePicker.TabIndex = 45;
            // 
            // note_textBox
            // 
            this.note_textBox.Location = new System.Drawing.Point(13, 297);
            this.note_textBox.Multiline = true;
            this.note_textBox.Name = "note_textBox";
            this.note_textBox.Size = new System.Drawing.Size(558, 72);
            this.note_textBox.TabIndex = 44;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(12, 219);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(268, 20);
            this.address_textBox.TabIndex = 43;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(307, 141);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(268, 20);
            this.email_textBox.TabIndex = 42;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(12, 141);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(268, 20);
            this.phone_textBox.TabIndex = 41;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(306, 64);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(268, 20);
            this.name_textBox.TabIndex = 40;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(396, 427);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(178, 46);
            this.back_button.TabIndex = 54;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(12, 427);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(178, 46);
            this.update_button.TabIndex = 53;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(204, 427);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(178, 46);
            this.delete_button.TabIndex = 55;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // UpdateGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 485);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.note_label);
            this.Controls.Add(this.birthday_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.phonenumber_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.birthday_dateTimePicker);
            this.Controls.Add(this.note_textBox);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.name_textBox);
            this.Name = "UpdateGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Guest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label note_label;
        private System.Windows.Forms.Label birthday_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label phonenumber_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.DateTimePicker birthday_dateTimePicker;
        private System.Windows.Forms.TextBox note_textBox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
    }
}