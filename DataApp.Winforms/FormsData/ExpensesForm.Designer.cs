namespace DataApp.Winforms
{
    partial class ExpensesForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxIncludeHidden = new System.Windows.Forms.CheckBox();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearchClearFilters = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMaxRow = new System.Windows.Forms.NumericUpDown();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilterName = new System.Windows.Forms.TextBox();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDetailsUpdate = new System.Windows.Forms.Button();
            this.buttonDetailsDelete = new System.Windows.Forms.Button();
            this.buttonDetailsAdd = new System.Windows.Forms.Button();
            this.buttonDetailsReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDetailsDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDetailsCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxDetailsCheck = new System.Windows.Forms.ComboBox();
            this.comboBoxDetailsProject = new System.Windows.Forms.ComboBox();
            this.numericUpDownDetailsAmount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDetailsCompany = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownDetailsID = new System.Windows.Forms.NumericUpDown();
            this.textBoxDetailsDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDetailsName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStripGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEditRow = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRow)).BeginInit();
            this.tabPageDetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDetailsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDetailsID)).BeginInit();
            this.contextMenuStripGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Controls.Add(this.tabPageDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 381);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.dataGridView1);
            this.tabPageSearch.Controls.Add(this.groupBox2);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(616, 355);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 135);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(586, 212);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.checkBoxIncludeHidden);
            this.groupBox2.Controls.Add(this.numericUpDownId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonSearchClearFilters);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDownMaxRow);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxFilterName);
            this.groupBox2.Location = new System.Drawing.Point(8, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 126);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // checkBoxIncludeHidden
            // 
            this.checkBoxIncludeHidden.AutoSize = true;
            this.checkBoxIncludeHidden.Location = new System.Drawing.Point(9, 97);
            this.checkBoxIncludeHidden.Name = "checkBoxIncludeHidden";
            this.checkBoxIncludeHidden.Size = new System.Drawing.Size(98, 17);
            this.checkBoxIncludeHidden.TabIndex = 13;
            this.checkBoxIncludeHidden.Text = "Include Hidden";
            this.checkBoxIncludeHidden.UseVisualStyleBackColor = true;
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(76, 15);
            this.numericUpDownId.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownId.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Id :";
            // 
            // buttonSearchClearFilters
            // 
            this.buttonSearchClearFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchClearFilters.Location = new System.Drawing.Point(506, 97);
            this.buttonSearchClearFilters.Name = "buttonSearchClearFilters";
            this.buttonSearchClearFilters.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchClearFilters.TabIndex = 9;
            this.buttonSearchClearFilters.Text = "Reset";
            this.buttonSearchClearFilters.UseVisualStyleBackColor = true;
            this.buttonSearchClearFilters.Click += new System.EventHandler(this.buttonClearFilters_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Max Rows :";
            this.label2.Visible = false;
            // 
            // numericUpDownMaxRow
            // 
            this.numericUpDownMaxRow.Location = new System.Drawing.Point(75, 41);
            this.numericUpDownMaxRow.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownMaxRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxRow.Name = "numericUpDownMaxRow";
            this.numericUpDownMaxRow.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownMaxRow.TabIndex = 7;
            this.numericUpDownMaxRow.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxRow.Visible = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(425, 97);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "OR # :";
            // 
            // textBoxFilterName
            // 
            this.textBoxFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterName.Location = new System.Drawing.Point(225, 15);
            this.textBoxFilterName.Name = "textBoxFilterName";
            this.textBoxFilterName.Size = new System.Drawing.Size(355, 20);
            this.textBoxFilterName.TabIndex = 4;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(this.groupBox3);
            this.tabPageDetails.Controls.Add(this.groupBox1);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(616, 355);
            this.tabPageDetails.TabIndex = 1;
            this.tabPageDetails.Text = "New/Edit";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonDetailsUpdate);
            this.groupBox3.Controls.Add(this.buttonDetailsDelete);
            this.groupBox3.Controls.Add(this.buttonDetailsAdd);
            this.groupBox3.Controls.Add(this.buttonDetailsReset);
            this.groupBox3.Location = new System.Drawing.Point(6, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 64);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // buttonDetailsUpdate
            // 
            this.buttonDetailsUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDetailsUpdate.Location = new System.Drawing.Point(293, 35);
            this.buttonDetailsUpdate.Name = "buttonDetailsUpdate";
            this.buttonDetailsUpdate.Size = new System.Drawing.Size(109, 23);
            this.buttonDetailsUpdate.TabIndex = 13;
            this.buttonDetailsUpdate.Text = "Update";
            this.buttonDetailsUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDetailsDelete
            // 
            this.buttonDetailsDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDetailsDelete.Location = new System.Drawing.Point(9, 35);
            this.buttonDetailsDelete.Name = "buttonDetailsDelete";
            this.buttonDetailsDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDetailsDelete.TabIndex = 12;
            this.buttonDetailsDelete.Text = "Delete";
            this.buttonDetailsDelete.UseVisualStyleBackColor = true;
            // 
            // buttonDetailsAdd
            // 
            this.buttonDetailsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDetailsAdd.Location = new System.Drawing.Point(408, 35);
            this.buttonDetailsAdd.Name = "buttonDetailsAdd";
            this.buttonDetailsAdd.Size = new System.Drawing.Size(109, 23);
            this.buttonDetailsAdd.TabIndex = 11;
            this.buttonDetailsAdd.Text = "Add";
            this.buttonDetailsAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDetailsReset
            // 
            this.buttonDetailsReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDetailsReset.Location = new System.Drawing.Point(523, 35);
            this.buttonDetailsReset.Name = "buttonDetailsReset";
            this.buttonDetailsReset.Size = new System.Drawing.Size(75, 23);
            this.buttonDetailsReset.TabIndex = 10;
            this.buttonDetailsReset.Text = "Reset";
            this.buttonDetailsReset.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateTimePickerDetailsDate);
            this.groupBox1.Controls.Add(this.comboBoxDetailsCategory);
            this.groupBox1.Controls.Add(this.comboBoxDetailsCheck);
            this.groupBox1.Controls.Add(this.comboBoxDetailsProject);
            this.groupBox1.Controls.Add(this.numericUpDownDetailsAmount);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxDetailsCompany);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericUpDownDetailsID);
            this.groupBox1.Controls.Add(this.textBoxDetailsDescription);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxDetailsName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 271);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Details";
            // 
            // dateTimePickerDetailsDate
            // 
            this.dateTimePickerDetailsDate.Location = new System.Drawing.Point(237, 123);
            this.dateTimePickerDetailsDate.Name = "dateTimePickerDetailsDate";
            this.dateTimePickerDetailsDate.Size = new System.Drawing.Size(345, 20);
            this.dateTimePickerDetailsDate.TabIndex = 30;
            // 
            // comboBoxDetailsCategory
            // 
            this.comboBoxDetailsCategory.FormattingEnabled = true;
            this.comboBoxDetailsCategory.Location = new System.Drawing.Point(237, 201);
            this.comboBoxDetailsCategory.Name = "comboBoxDetailsCategory";
            this.comboBoxDetailsCategory.Size = new System.Drawing.Size(345, 21);
            this.comboBoxDetailsCategory.TabIndex = 29;
            // 
            // comboBoxDetailsCheck
            // 
            this.comboBoxDetailsCheck.FormattingEnabled = true;
            this.comboBoxDetailsCheck.Location = new System.Drawing.Point(237, 176);
            this.comboBoxDetailsCheck.Name = "comboBoxDetailsCheck";
            this.comboBoxDetailsCheck.Size = new System.Drawing.Size(345, 21);
            this.comboBoxDetailsCheck.TabIndex = 28;
            // 
            // comboBoxDetailsProject
            // 
            this.comboBoxDetailsProject.FormattingEnabled = true;
            this.comboBoxDetailsProject.Location = new System.Drawing.Point(237, 149);
            this.comboBoxDetailsProject.Name = "comboBoxDetailsProject";
            this.comboBoxDetailsProject.Size = new System.Drawing.Size(345, 21);
            this.comboBoxDetailsProject.TabIndex = 27;
            // 
            // numericUpDownDetailsAmount
            // 
            this.numericUpDownDetailsAmount.Location = new System.Drawing.Point(237, 97);
            this.numericUpDownDetailsAmount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownDetailsAmount.Name = "numericUpDownDetailsAmount";
            this.numericUpDownDetailsAmount.Size = new System.Drawing.Size(345, 20);
            this.numericUpDownDetailsAmount.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(155, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Category :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(155, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Check :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Project :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Amount :";
            // 
            // textBoxDetailsCompany
            // 
            this.textBoxDetailsCompany.Location = new System.Drawing.Point(237, 71);
            this.textBoxDetailsCompany.Name = "textBoxDetailsCompany";
            this.textBoxDetailsCompany.Size = new System.Drawing.Size(345, 20);
            this.textBoxDetailsCompany.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Company :";
            // 
            // numericUpDownDetailsID
            // 
            this.numericUpDownDetailsID.Enabled = false;
            this.numericUpDownDetailsID.Location = new System.Drawing.Point(29, 19);
            this.numericUpDownDetailsID.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownDetailsID.Name = "numericUpDownDetailsID";
            this.numericUpDownDetailsID.ReadOnly = true;
            this.numericUpDownDetailsID.Size = new System.Drawing.Size(105, 20);
            this.numericUpDownDetailsID.TabIndex = 13;
            // 
            // textBoxDetailsDescription
            // 
            this.textBoxDetailsDescription.Location = new System.Drawing.Point(237, 45);
            this.textBoxDetailsDescription.Name = "textBoxDetailsDescription";
            this.textBoxDetailsDescription.Size = new System.Drawing.Size(345, 20);
            this.textBoxDetailsDescription.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID :";
            // 
            // textBoxDetailsName
            // 
            this.textBoxDetailsName.Location = new System.Drawing.Point(237, 19);
            this.textBoxDetailsName.Name = "textBoxDetailsName";
            this.textBoxDetailsName.Size = new System.Drawing.Size(345, 20);
            this.textBoxDetailsName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "OR # :";
            // 
            // contextMenuStripGridView
            // 
            this.contextMenuStripGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditRow});
            this.contextMenuStripGridView.Name = "contextMenuStrip1";
            this.contextMenuStripGridView.Size = new System.Drawing.Size(131, 26);
            // 
            // toolStripMenuItemEditRow
            // 
            this.toolStripMenuItemEditRow.Name = "toolStripMenuItemEditRow";
            this.toolStripMenuItemEditRow.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemEditRow.Text = "VIEW/EDIT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(162, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Date :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(384, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Company :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(162, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Check :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(225, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(384, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Project :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(447, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 21);
            this.comboBox2.TabIndex = 24;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(447, 41);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(133, 21);
            this.comboBox3.TabIndex = 25;
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.tabControl1);
            this.Name = "ExpensesForm";
            this.Text = "ExpensesForm";
            this.Load += new System.EventHandler(this.ProjectsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRow)).EndInit();
            this.tabPageDetails.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDetailsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDetailsID)).EndInit();
            this.contextMenuStripGridView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxIncludeHidden;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearchClearFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxRow;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilterName;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDetailsUpdate;
        private System.Windows.Forms.Button buttonDetailsDelete;
        private System.Windows.Forms.Button buttonDetailsAdd;
        private System.Windows.Forms.Button buttonDetailsReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownDetailsID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDetailsName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDetailsDescription;
        private System.Windows.Forms.TextBox textBoxDetailsCompany;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownDetailsAmount;
        private System.Windows.Forms.ComboBox comboBoxDetailsProject;
        private System.Windows.Forms.ComboBox comboBoxDetailsCategory;
        private System.Windows.Forms.ComboBox comboBoxDetailsCheck;
        private System.Windows.Forms.DateTimePicker dateTimePickerDetailsDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGridView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditRow;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}