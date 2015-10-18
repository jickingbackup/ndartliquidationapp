namespace DataApp.Winforms
{
    partial class ExpenseReportsForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ExpenseReportViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxFilterMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerMaxDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearchClearFilters = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMaxRows = new System.Windows.Forms.NumericUpDown();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxChecks = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePickerMinDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseReportViewModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRows)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxFilterMethod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerMaxDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonSearchClearFilters);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownMaxRows);
            this.groupBox1.Controls.Add(this.comboBoxProject);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.comboBoxChecks);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.dateTimePickerMinDate);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // comboBoxFilterMethod
            // 
            this.comboBoxFilterMethod.FormattingEnabled = true;
            this.comboBoxFilterMethod.Items.AddRange(new object[] {
            "Check",
            "Date",
            "Project",
            "All"});
            this.comboBoxFilterMethod.Location = new System.Drawing.Point(59, 18);
            this.comboBoxFilterMethod.Name = "comboBoxFilterMethod";
            this.comboBoxFilterMethod.Size = new System.Drawing.Size(197, 21);
            this.comboBoxFilterMethod.TabIndex = 40;
            this.comboBoxFilterMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterMethod_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Filter :";
            // 
            // dateTimePickerMaxDate
            // 
            this.dateTimePickerMaxDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMaxDate.Location = new System.Drawing.Point(319, 44);
            this.dateTimePickerMaxDate.Name = "dateTimePickerMaxDate";
            this.dateTimePickerMaxDate.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerMaxDate.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Max Date :";
            // 
            // buttonSearchClearFilters
            // 
            this.buttonSearchClearFilters.Location = new System.Drawing.Point(503, 69);
            this.buttonSearchClearFilters.Name = "buttonSearchClearFilters";
            this.buttonSearchClearFilters.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchClearFilters.TabIndex = 11;
            this.buttonSearchClearFilters.Text = "Reset";
            this.buttonSearchClearFilters.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(422, 69);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Max Rows :";
            // 
            // numericUpDownMaxRows
            // 
            this.numericUpDownMaxRows.Location = new System.Drawing.Point(503, 19);
            this.numericUpDownMaxRows.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownMaxRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxRows.Name = "numericUpDownMaxRows";
            this.numericUpDownMaxRows.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownMaxRows.TabIndex = 13;
            this.numericUpDownMaxRows.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(59, 71);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(197, 21);
            this.comboBoxProject.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Project :";
            // 
            // comboBoxChecks
            // 
            this.comboBoxChecks.FormattingEnabled = true;
            this.comboBoxChecks.Location = new System.Drawing.Point(59, 44);
            this.comboBoxChecks.Name = "comboBoxChecks";
            this.comboBoxChecks.Size = new System.Drawing.Size(197, 21);
            this.comboBoxChecks.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Check :";
            // 
            // dateTimePickerMinDate
            // 
            this.dateTimePickerMinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMinDate.Location = new System.Drawing.Point(319, 18);
            this.dateTimePickerMinDate.Name = "dateTimePickerMinDate";
            this.dateTimePickerMinDate.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerMinDate.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(261, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Min Date :";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource8.Name = "ExpenseReportDataSet";
            reportDataSource8.Value = this.ExpenseReportViewModelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DataApp.Winforms.FormsReports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(584, 241);
            this.reportViewer1.TabIndex = 1;
            // 
            // ExpenseReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 371);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExpenseReportsForm";
            this.Text = "ExpenseReportsForm";
            this.Activated += new System.EventHandler(this.ExpenseReportsForm_Activated);
            this.Load += new System.EventHandler(this.ExpenseReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseReportViewModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxChecks;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePickerMinDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxRows;
        private System.Windows.Forms.Button buttonSearchClearFilters;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.BindingSource ExpenseReportViewModelBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePickerMaxDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFilterMethod;
        private System.Windows.Forms.Label label1;
    }
}