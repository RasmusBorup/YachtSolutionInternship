namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class CreateGuest.
    /// </summary>
    partial class CreateGuest
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
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.ssn_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.note_textBox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.birthday_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ssn_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.phonenumber_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.birthday_label = new System.Windows.Forms.Label();
            this.note_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(303, 64);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(268, 20);
            this.name_textBox.TabIndex = 5;
            // 
            // ssn_textBox
            // 
            this.ssn_textBox.Location = new System.Drawing.Point(12, 65);
            this.ssn_textBox.Name = "ssn_textBox";
            this.ssn_textBox.Size = new System.Drawing.Size(268, 20);
            this.ssn_textBox.TabIndex = 4;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(303, 142);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(268, 20);
            this.email_textBox.TabIndex = 11;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(12, 142);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(268, 20);
            this.phone_textBox.TabIndex = 10;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(12, 220);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(268, 20);
            this.address_textBox.TabIndex = 16;
            // 
            // note_textBox
            // 
            this.note_textBox.Location = new System.Drawing.Point(13, 298);
            this.note_textBox.Multiline = true;
            this.note_textBox.Name = "note_textBox";
            this.note_textBox.Size = new System.Drawing.Size(558, 72);
            this.note_textBox.TabIndex = 26;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 428);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(268, 46);
            this.save_button.TabIndex = 29;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(304, 428);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(268, 46);
            this.back_button.TabIndex = 30;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // birthday_dateTimePicker
            // 
            this.birthday_dateTimePicker.Location = new System.Drawing.Point(303, 220);
            this.birthday_dateTimePicker.Name = "birthday_dateTimePicker";
            this.birthday_dateTimePicker.Size = new System.Drawing.Size(268, 20);
            this.birthday_dateTimePicker.TabIndex = 31;
            // 
            // ssn_label
            // 
            this.ssn_label.AutoSize = true;
            this.ssn_label.Location = new System.Drawing.Point(13, 46);
            this.ssn_label.Name = "ssn_label";
            this.ssn_label.Size = new System.Drawing.Size(29, 13);
            this.ssn_label.TabIndex = 32;
            this.ssn_label.Text = "SSN";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(300, 46);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(35, 13);
            this.Name_label.TabIndex = 33;
            this.Name_label.Text = "Name";
            // 
            // phonenumber_label
            // 
            this.phonenumber_label.AutoSize = true;
            this.phonenumber_label.Location = new System.Drawing.Point(13, 126);
            this.phonenumber_label.Name = "phonenumber_label";
            this.phonenumber_label.Size = new System.Drawing.Size(78, 13);
            this.phonenumber_label.TabIndex = 34;
            this.phonenumber_label.Text = "Phone Number";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(301, 126);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(32, 13);
            this.email_label.TabIndex = 35;
            this.email_label.Text = "Email";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(9, 204);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(45, 13);
            this.address_label.TabIndex = 36;
            this.address_label.Text = "Address";
            // 
            // birthday_label
            // 
            this.birthday_label.AutoSize = true;
            this.birthday_label.Location = new System.Drawing.Point(301, 204);
            this.birthday_label.Name = "birthday_label";
            this.birthday_label.Size = new System.Drawing.Size(45, 13);
            this.birthday_label.TabIndex = 37;
            this.birthday_label.Text = "Birthday";
            // 
            // note_label
            // 
            this.note_label.AutoSize = true;
            this.note_label.Location = new System.Drawing.Point(13, 282);
            this.note_label.Name = "note_label";
            this.note_label.Size = new System.Drawing.Size(30, 13);
            this.note_label.TabIndex = 38;
            this.note_label.Text = "Note";
            // 
            // CreateGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 485);
            this.Controls.Add(this.note_label);
            this.Controls.Add(this.birthday_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.phonenumber_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.ssn_label);
            this.Controls.Add(this.birthday_dateTimePicker);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.note_textBox);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.ssn_textBox);
            this.Name = "CreateGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Guest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox ssn_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox note_textBox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.DateTimePicker birthday_dateTimePicker;
        private System.Windows.Forms.Label ssn_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label phonenumber_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label birthday_label;
        private System.Windows.Forms.Label note_label;
    }
}