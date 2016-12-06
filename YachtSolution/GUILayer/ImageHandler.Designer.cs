namespace YachtSolution.GUILayer
{
    partial class ImageHandler
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
            this.pbImageBox = new System.Windows.Forms.PictureBox();
            this.btnBrowseImg = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.tbImageId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImageBox
            // 
            this.pbImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImageBox.Location = new System.Drawing.Point(129, 70);
            this.pbImageBox.Name = "pbImageBox";
            this.pbImageBox.Size = new System.Drawing.Size(219, 193);
            this.pbImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageBox.TabIndex = 0;
            this.pbImageBox.TabStop = false;
            // 
            // btnBrowseImg
            // 
            this.btnBrowseImg.Location = new System.Drawing.Point(129, 286);
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseImg.TabIndex = 1;
            this.btnBrowseImg.Text = "Browse";
            this.btnBrowseImg.UseVisualStyleBackColor = true;
            this.btnBrowseImg.Click += new System.EventHandler(this.btnBrowseImg_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(273, 286);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImage.TabIndex = 2;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(199, 315);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // tbImageId
            // 
            this.tbImageId.Location = new System.Drawing.Point(199, 353);
            this.tbImageId.Name = "tbImageId";
            this.tbImageId.Size = new System.Drawing.Size(100, 20);
            this.tbImageId.TabIndex = 4;
            // 
            // ImageHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 429);
            this.Controls.Add(this.tbImageId);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnBrowseImg);
            this.Controls.Add(this.pbImageBox);
            this.Name = "ImageHandler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image handler";
            ((System.ComponentModel.ISupportInitialize)(this.pbImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImageBox;
        private System.Windows.Forms.Button btnBrowseImg;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox tbImageId;
    }
}