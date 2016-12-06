namespace YachtSolution.GUILayer
{
    /// <summary>
    /// This is the class Login.
    /// </summary>
    partial class Login
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.lblUsername);
            this.panelLogin.Controls.Add(this.btnSkip);
            this.panelLogin.Controls.Add(this.tbUsername);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.tbPassword);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1008, 681);
            this.panelLogin.TabIndex = 6;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(364, 261);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username:";
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkip.Location = new System.Drawing.Point(428, 424);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(163, 74);
            this.btnSkip.TabIndex = 5;
            this.btnSkip.Text = "Skip directly to MasterGUI";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsername.Location = new System.Drawing.Point(428, 258);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(163, 20);
            this.tbUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(364, 307);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.Location = new System.Drawing.Point(428, 304);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(163, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(428, 344);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(163, 74);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.panelLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spark";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblUsername;
    }
}