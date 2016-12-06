namespace YachtSolution.GUILayer
{
    partial class JobGUI
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
            this.update_job_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.main_menu_button = new System.Windows.Forms.Button();
            this.delete_job_button = new System.Windows.Forms.Button();
            this.list_job_button = new System.Windows.Forms.Button();
            this.create_job_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // update_job_button
            // 
            this.update_job_button.Location = new System.Drawing.Point(12, 93);
            this.update_job_button.Name = "update_job_button";
            this.update_job_button.Size = new System.Drawing.Size(268, 75);
            this.update_job_button.TabIndex = 2;
            this.update_job_button.Text = "Update Job";
            this.update_job_button.UseVisualStyleBackColor = true;
            this.update_job_button.Click += new System.EventHandler(this.UpdateJobClick);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(12, 174);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(268, 75);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.BackClick);
            // 
            // main_menu_button
            // 
            this.main_menu_button.Location = new System.Drawing.Point(294, 174);
            this.main_menu_button.Name = "main_menu_button";
            this.main_menu_button.Size = new System.Drawing.Size(268, 75);
            this.main_menu_button.TabIndex = 5;
            this.main_menu_button.Text = "Main Menu";
            this.main_menu_button.UseVisualStyleBackColor = true;
            this.main_menu_button.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // delete_job_button
            // 
            this.delete_job_button.Location = new System.Drawing.Point(292, 93);
            this.delete_job_button.Name = "delete_job_button";
            this.delete_job_button.Size = new System.Drawing.Size(268, 75);
            this.delete_job_button.TabIndex = 3;
            this.delete_job_button.Text = "Delete Job";
            this.delete_job_button.UseVisualStyleBackColor = true;
            this.delete_job_button.Click += new System.EventHandler(this.DeleteJobClick);
            // 
            // list_job_button
            // 
            this.list_job_button.Location = new System.Drawing.Point(292, 12);
            this.list_job_button.Name = "list_job_button";
            this.list_job_button.Size = new System.Drawing.Size(268, 75);
            this.list_job_button.TabIndex = 1;
            this.list_job_button.Text = "List Jobs";
            this.list_job_button.UseVisualStyleBackColor = true;
            this.list_job_button.Click += new System.EventHandler(this.ListJobsClick);
            // 
            // create_job_button
            // 
            this.create_job_button.Location = new System.Drawing.Point(12, 12);
            this.create_job_button.Name = "create_job_button";
            this.create_job_button.Size = new System.Drawing.Size(268, 75);
            this.create_job_button.TabIndex = 0;
            this.create_job_button.Text = "Create Job";
            this.create_job_button.UseVisualStyleBackColor = true;
            this.create_job_button.Click += new System.EventHandler(this.CreateJobClick);
            // 
            // JobGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 261);
            this.Controls.Add(this.main_menu_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.delete_job_button);
            this.Controls.Add(this.update_job_button);
            this.Controls.Add(this.list_job_button);
            this.Controls.Add(this.create_job_button);
            this.Name = "JobGUI";
            this.Text = "JobGUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button update_job_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button main_menu_button;
        private System.Windows.Forms.Button delete_job_button;
        private System.Windows.Forms.Button list_job_button;
        private System.Windows.Forms.Button create_job_button;

    }
}