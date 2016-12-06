namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class PrintTest.
    /// </summary>
    partial class PrintTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvPrint = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPreview = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.dgvPrint);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 413);
            this.panel1.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(3, 357);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(106, 40);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvPrint
            // 
            this.dgvPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrint.Location = new System.Drawing.Point(3, 3);
            this.dgvPrint.Name = "dgvPrint";
            this.dgvPrint.Size = new System.Drawing.Size(549, 337);
            this.dgvPrint.TabIndex = 0;
            // 
            // printDocument1
            // 
            //this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(115, 357);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(106, 40);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // PrintTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 438);
            this.Controls.Add(this.panel1);
            this.Name = "PrintTest";
            this.Text = "PrintTest";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPrint;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnPreview;
    }
}