namespace YachtSolution.GUILayer
{
    partial class ViewTimetable
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
            this.components = new System.ComponentModel.Container();
            this.timeSearch = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Find = new System.Windows.Forms.Button();
            this.createVoyage = new System.Windows.Forms.Button();
            this.dmab0913_4sem_gruppe5DataSet = new YachtSolution.dmab0913_4sem_gruppe5DataSet();
            this.timeTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timeTableTableAdapter = new YachtSolution.dmab0913_4sem_gruppe5DataSetTableAdapters.TimeTableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.foundGrid = new System.Windows.Forms.DataGridView();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.namePick = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new YachtSolution.dmab0913_4sem_gruppe5DataSetTableAdapters.EmployeesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteButton1 = new System.Windows.Forms.Button();
            this.deleteButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmab0913_4sem_gruppe5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timeSearch
            // 
            this.timeSearch.Location = new System.Drawing.Point(12, 25);
            this.timeSearch.Name = "timeSearch";
            this.timeSearch.Size = new System.Drawing.Size(200, 20);
            this.timeSearch.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // timeTableBindingSource
            // 
            this.timeTableBindingSource.DataSource = typeof(YachtSolution.DataLayer.TimeTable);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(241, 22);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 23);
            this.Find.TabIndex = 2;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // createVoyage
            // 
            this.createVoyage.Location = new System.Drawing.Point(804, 435);
            this.createVoyage.Name = "createVoyage";
            this.createVoyage.Size = new System.Drawing.Size(117, 23);
            this.createVoyage.TabIndex = 3;
            this.createVoyage.Text = "Create new Voyage";
            this.createVoyage.UseVisualStyleBackColor = true;
            // 
            // dmab0913_4sem_gruppe5DataSet
            // 
            this.dmab0913_4sem_gruppe5DataSet.DataSetName = "dmab0913_4sem_gruppe5DataSet";
            this.dmab0913_4sem_gruppe5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timeTableBindingSource1
            // 
            this.timeTableBindingSource1.DataMember = "TimeTable";
            this.timeTableBindingSource1.DataSource = this.dmab0913_4sem_gruppe5DataSet;
            // 
            // timeTableTableAdapter
            // 
            this.timeTableTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comment on presence";
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(592, 74);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.ReadOnly = true;
            this.commentBox.Size = new System.Drawing.Size(304, 150);
            this.commentBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Coment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // foundGrid
            // 
            this.foundGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foundGrid.Location = new System.Drawing.Point(12, 289);
            this.foundGrid.Name = "foundGrid";
            this.foundGrid.Size = new System.Drawing.Size(543, 169);
            this.foundGrid.TabIndex = 7;
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(370, 24);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(100, 20);
            this.nameSearch.TabIndex = 8;
            // 
            // searchBTN
            // 
            this.searchBTN.Location = new System.Drawing.Point(489, 21);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(75, 23);
            this.searchBTN.TabIndex = 9;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(592, 289);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(592, 355);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // namePick
            // 
            this.namePick.DataSource = this.employeesBindingSource;
            this.namePick.DisplayMember = "NameOfEmployee";
            this.namePick.FormattingEnabled = true;
            this.namePick.Location = new System.Drawing.Point(592, 408);
            this.namePick.Name = "namePick";
            this.namePick.Size = new System.Drawing.Size(121, 21);
            this.namePick.TabIndex = 12;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.dmab0913_4sem_gruppe5DataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Employee";
            // 
            // deleteButton1
            // 
            this.deleteButton1.Location = new System.Drawing.Point(479, 250);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(75, 23);
            this.deleteButton1.TabIndex = 16;
            this.deleteButton1.Text = "Delete";
            this.deleteButton1.UseVisualStyleBackColor = true;
            this.deleteButton1.Click += new System.EventHandler(this.deleteButton1_Click);
            // 
            // deleteButton2
            // 
            this.deleteButton2.Location = new System.Drawing.Point(479, 464);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(75, 23);
            this.deleteButton2.TabIndex = 17;
            this.deleteButton2.Text = "Delete";
            this.deleteButton2.UseVisualStyleBackColor = true;
            this.deleteButton2.Click += new System.EventHandler(this.deleteButton2_Click);
            // 
            // ViewTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 515);
            this.Controls.Add(this.deleteButton2);
            this.Controls.Add(this.deleteButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namePick);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.nameSearch);
            this.Controls.Add(this.foundGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createVoyage);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.timeSearch);
            this.Name = "ViewTimetable";
            this.Text = "ViewTimetable";
            this.Load += new System.EventHandler(this.ViewTimetable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmab0913_4sem_gruppe5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timeSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource timeTableBindingSource;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button createVoyage;
        private dmab0913_4sem_gruppe5DataSet dmab0913_4sem_gruppe5DataSet;
        private System.Windows.Forms.BindingSource timeTableBindingSource1;
        private dmab0913_4sem_gruppe5DataSetTableAdapters.TimeTableTableAdapter timeTableTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView foundGrid;
        private System.Windows.Forms.TextBox nameSearch;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox namePick;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private dmab0913_4sem_gruppe5DataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteButton1;
        private System.Windows.Forms.Button deleteButton2;
    }
}