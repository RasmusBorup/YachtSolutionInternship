namespace YachtSolution.GUILayer
{
    partial class AddPhotoToJob
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
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGetPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrowse
            // 
            this.txtBrowse.Enabled = false;
            this.txtBrowse.Location = new System.Drawing.Point(12, 26);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(338, 20);
            this.txtBrowse.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(371, 22);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(98, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(371, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save photo";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 281);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnGetPhoto
            // 
            this.btnGetPhoto.Location = new System.Drawing.Point(371, 80);
            this.btnGetPhoto.Name = "btnGetPhoto";
            this.btnGetPhoto.Size = new System.Drawing.Size(98, 23);
            this.btnGetPhoto.TabIndex = 4;
            this.btnGetPhoto.Text = "Get photo";
            this.btnGetPhoto.UseVisualStyleBackColor = true;
            this.btnGetPhoto.Click += new System.EventHandler(this.btnGetPhoto_Click);
            // 
            // AddPhotoToJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 379);
            this.Controls.Add(this.btnGetPhoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtBrowse);
            this.Name = "AddPhotoToJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPhotoToJob";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGetPhoto;
    }
}