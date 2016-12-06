namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class ListOfGuests.
    /// </summary>
    partial class ListOfGuests
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_label = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.updateGuest_button = new System.Windows.Forms.Button();
            this.createGuest_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.Guests_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guests_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.search_label);
            this.panel1.Controls.Add(this.search_textBox);
            this.panel1.Controls.Add(this.search_button);
            this.panel1.Controls.Add(this.updateGuest_button);
            this.panel1.Controls.Add(this.createGuest_button);
            this.panel1.Controls.Add(this.reset_button);
            this.panel1.Controls.Add(this.Guests_dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 681);
            this.panel1.TabIndex = 0;
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Location = new System.Drawing.Point(4, 510);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(130, 13);
            this.search_label.TabIndex = 7;
            this.search_label.Text = "ssn, name, phone or email";
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(7, 526);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(578, 20);
            this.search_textBox.TabIndex = 6;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(591, 506);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(179, 57);
            this.search_button.TabIndex = 5;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // updateGuest_button
            // 
            this.updateGuest_button.Location = new System.Drawing.Point(776, 570);
            this.updateGuest_button.Name = "updateGuest_button";
            this.updateGuest_button.Size = new System.Drawing.Size(179, 57);
            this.updateGuest_button.TabIndex = 4;
            this.updateGuest_button.Text = "Update Guest";
            this.updateGuest_button.UseVisualStyleBackColor = true;
            this.updateGuest_button.Click += new System.EventHandler(this.updateGuest_button_Click);
            // 
            // createGuest_button
            // 
            this.createGuest_button.Location = new System.Drawing.Point(776, 507);
            this.createGuest_button.Name = "createGuest_button";
            this.createGuest_button.Size = new System.Drawing.Size(179, 57);
            this.createGuest_button.TabIndex = 3;
            this.createGuest_button.Text = "Create Guest";
            this.createGuest_button.UseVisualStyleBackColor = true;
            this.createGuest_button.Click += new System.EventHandler(this.createGuest_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(591, 570);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(179, 57);
            this.reset_button.TabIndex = 1;
            this.reset_button.Text = "Refresh  List";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // Guests_dataGridView
            // 
            this.Guests_dataGridView.AllowUserToAddRows = false;
            this.Guests_dataGridView.AllowUserToDeleteRows = false;
            this.Guests_dataGridView.AllowUserToResizeRows = false;
            this.Guests_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guests_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Guests_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Guests_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Guests_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Guests_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.Guests_dataGridView.Name = "Guests_dataGridView";
            this.Guests_dataGridView.RowHeadersVisible = false;
            this.Guests_dataGridView.Size = new System.Drawing.Size(984, 488);
            this.Guests_dataGridView.TabIndex = 0;
            // 
            // ListOfGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.panel1);
            this.Name = "ListOfGuests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guests_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Guests_dataGridView;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button updateGuest_button;
        private System.Windows.Forms.Button createGuest_button;
        private System.Windows.Forms.Button reset_button;
    }
}