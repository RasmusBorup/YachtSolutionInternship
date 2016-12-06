namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class CreateGroup.
    /// </summary>
    partial class CreateGroup
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveGroup = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(13, 32);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(501, 24);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Group Name";
            // 
            // btnSaveGroup
            // 
            this.btnSaveGroup.Location = new System.Drawing.Point(322, 71);
            this.btnSaveGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveGroup.Name = "btnSaveGroup";
            this.btnSaveGroup.Size = new System.Drawing.Size(192, 32);
            this.btnSaveGroup.TabIndex = 2;
            this.btnSaveGroup.Text = "Save Group";
            this.btnSaveGroup.UseVisualStyleBackColor = true;
            this.btnSaveGroup.Click += new System.EventHandler(this.btnSaveGroup_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(22, 71);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(192, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 114);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateGroup";
            this.Text = "Create Group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveGroup;
        private System.Windows.Forms.Button btnCancel;
    }
}