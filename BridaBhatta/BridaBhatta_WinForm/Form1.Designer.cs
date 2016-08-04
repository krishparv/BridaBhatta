namespace BridaBhatta_WinForm
{
    partial class Form1
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
            this.adultPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bridaBhataDataSet = new BridaBhatta_WinForm.BridaBhataDataSet();
            this.adultPersonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bridaBhataDataSet1 = new BridaBhatta_WinForm.BridaBhataDataSet1();
            this.adultPersonTableAdapter = new BridaBhatta_WinForm.BridaBhataDataSetTableAdapters.AdultPersonTableAdapter();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.adultPersonTableAdapter1 = new BridaBhatta_WinForm.BridaBhataDataSet1TableAdapters.AdultPersonTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gvUsers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.TabPage();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_dob = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.lb_street = new System.Windows.Forms.Label();
            this.lb_lname = new System.Windows.Forms.Label();
            this.lb_dob = new System.Windows.Forms.Label();
            this.lb_location = new System.Windows.Forms.Label();
            this.lb_fname = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_dataview = new System.Windows.Forms.DataGridView();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbox_type = new System.Windows.Forms.ComboBox();
            this.lb_amount = new System.Windows.Forms.Label();
            this.lb_age = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adultPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bridaBhataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adultPersonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bridaBhataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            this.Edit.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // adultPersonBindingSource
            // 
            this.adultPersonBindingSource.DataMember = "AdultPerson";
            this.adultPersonBindingSource.DataSource = this.bridaBhataDataSet;
            // 
            // bridaBhataDataSet
            // 
            this.bridaBhataDataSet.DataSetName = "BridaBhataDataSet";
            this.bridaBhataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adultPersonBindingSource1
            // 
            this.adultPersonBindingSource1.DataMember = "AdultPerson";
            this.adultPersonBindingSource1.DataSource = this.bridaBhataDataSet1;
            // 
            // bridaBhataDataSet1
            // 
            this.bridaBhataDataSet1.DataSetName = "BridaBhataDataSet1";
            this.bridaBhataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adultPersonTableAdapter
            // 
            this.adultPersonTableAdapter.ClearBeforeFill = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // adultPersonTableAdapter1
            // 
            this.adultPersonTableAdapter1.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Edit);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 504);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gvUsers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(930, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ViewDetails";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gvUsers
            // 
            this.gvUsers.AutoGenerateColumns = false;
            this.gvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn});
            this.gvUsers.DataSource = this.adultPersonBindingSource;
            this.gvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvUsers.Location = new System.Drawing.Point(3, 3);
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.Size = new System.Drawing.Size(924, 472);
            this.gvUsers.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.Controls.Add(this.txt_search);
            this.Edit.Controls.Add(this.txt_age);
            this.Edit.Controls.Add(this.panel1);
            this.Edit.Controls.Add(this.txt_amount);
            this.Edit.Controls.Add(this.label1);
            this.Edit.Controls.Add(this.gv_dataview);
            this.Edit.Controls.Add(this.btn_submit);
            this.Edit.Controls.Add(this.btn_Calculate);
            this.Edit.Controls.Add(this.btn_Search);
            this.Edit.Controls.Add(this.label8);
            this.Edit.Controls.Add(this.cmbox_type);
            this.Edit.Controls.Add(this.lb_amount);
            this.Edit.Controls.Add(this.lb_age);
            this.Edit.Location = new System.Drawing.Point(4, 22);
            this.Edit.Name = "Edit";
            this.Edit.Padding = new System.Windows.Forms.Padding(3);
            this.Edit.Size = new System.Drawing.Size(930, 478);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Edit/Search";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(197, 33);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(114, 20);
            this.txt_search.TabIndex = 6;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(164, 401);
            this.txt_age.Multiline = true;
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 22);
            this.txt_age.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_dob);
            this.panel1.Controls.Add(this.txt_address);
            this.panel1.Controls.Add(this.txt_street);
            this.panel1.Controls.Add(this.txt_lname);
            this.panel1.Controls.Add(this.txt_fname);
            this.panel1.Controls.Add(this.lb_street);
            this.panel1.Controls.Add(this.lb_lname);
            this.panel1.Controls.Add(this.lb_dob);
            this.panel1.Controls.Add(this.lb_location);
            this.panel1.Controls.Add(this.lb_fname);
            this.panel1.Location = new System.Drawing.Point(51, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 104);
            this.panel1.TabIndex = 5;
            // 
            // txt_dob
            // 
            this.txt_dob.Location = new System.Drawing.Point(113, 71);
            this.txt_dob.Multiline = true;
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(100, 22);
            this.txt_dob.TabIndex = 1;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(113, 45);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 20);
            this.txt_address.TabIndex = 1;
            // 
            // txt_street
            // 
            this.txt_street.Location = new System.Drawing.Point(342, 49);
            this.txt_street.Multiline = true;
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(100, 20);
            this.txt_street.TabIndex = 1;
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(342, 13);
            this.txt_lname.Multiline = true;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(100, 20);
            this.txt_lname.TabIndex = 1;
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(113, 11);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(100, 20);
            this.txt_fname.TabIndex = 1;
            // 
            // lb_street
            // 
            this.lb_street.AutoSize = true;
            this.lb_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_street.Location = new System.Drawing.Point(260, 43);
            this.lb_street.Name = "lb_street";
            this.lb_street.Size = new System.Drawing.Size(57, 20);
            this.lb_street.TabIndex = 0;
            this.lb_street.Text = "Street:";
            // 
            // lb_lname
            // 
            this.lb_lname.AutoSize = true;
            this.lb_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lname.Location = new System.Drawing.Point(231, 11);
            this.lb_lname.Name = "lb_lname";
            this.lb_lname.Size = new System.Drawing.Size(86, 20);
            this.lb_lname.TabIndex = 0;
            this.lb_lname.Text = "LastName:";
            // 
            // lb_dob
            // 
            this.lb_dob.AutoSize = true;
            this.lb_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dob.Location = new System.Drawing.Point(46, 69);
            this.lb_dob.Name = "lb_dob";
            this.lb_dob.Size = new System.Drawing.Size(48, 20);
            this.lb_dob.TabIndex = 0;
            this.lb_dob.Text = "DOB:";
            // 
            // lb_location
            // 
            this.lb_location.AutoSize = true;
            this.lb_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_location.Location = new System.Drawing.Point(32, 45);
            this.lb_location.Name = "lb_location";
            this.lb_location.Size = new System.Drawing.Size(74, 20);
            this.lb_location.TabIndex = 0;
            this.lb_location.Text = "Location:";
            // 
            // lb_fname
            // 
            this.lb_fname.AutoSize = true;
            this.lb_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fname.Location = new System.Drawing.Point(20, 11);
            this.lb_fname.Name = "lb_fname";
            this.lb_fname.Size = new System.Drawing.Size(86, 20);
            this.lb_fname.TabIndex = 0;
            this.lb_fname.Text = "FirstName:";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(393, 405);
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(100, 20);
            this.txt_amount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Edit/Create";
            // 
            // gv_dataview
            // 
            this.gv_dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_dataview.Location = new System.Drawing.Point(38, 100);
            this.gv_dataview.Name = "gv_dataview";
            this.gv_dataview.Size = new System.Drawing.Size(568, 130);
            this.gv_dataview.TabIndex = 3;
            this.gv_dataview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_dataview_CellClick);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Purple;
            this.btn_submit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_submit.Location = new System.Drawing.Point(485, 444);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(87, 28);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.Purple;
            this.btn_Calculate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Calculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Calculate.Location = new System.Drawing.Point(271, 444);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(87, 28);
            this.btn_Calculate.TabIndex = 2;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Purple;
            this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Search.Location = new System.Drawing.Point(333, 28);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(86, 32);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(311, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 0;
            // 
            // cmbox_type
            // 
            this.cmbox_type.FormattingEnabled = true;
            this.cmbox_type.Items.AddRange(new object[] {
            "Name",
            "DOB",
            "Location",
            "Street",
            "Age",
            "Amount"});
            this.cmbox_type.Location = new System.Drawing.Point(38, 33);
            this.cmbox_type.Name = "cmbox_type";
            this.cmbox_type.Size = new System.Drawing.Size(129, 21);
            this.cmbox_type.TabIndex = 0;
            this.cmbox_type.Text = "-please select-";
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_amount.Location = new System.Drawing.Point(311, 403);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(69, 20);
            this.lb_amount.TabIndex = 0;
            this.lb_amount.Text = "Amount:";
            this.lb_amount.Click += new System.EventHandler(this.lb_amount_Click);
            // 
            // lb_age
            // 
            this.lb_age.AutoSize = true;
            this.lb_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_age.Location = new System.Drawing.Point(97, 403);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(42, 20);
            this.lb_age.TabIndex = 0;
            this.lb_age.Text = "Age:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 505);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adultPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bridaBhataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adultPersonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bridaBhataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dataview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BridaBhataDataSet bridaBhataDataSet;
        private System.Windows.Forms.BindingSource adultPersonBindingSource;
        private BridaBhataDataSetTableAdapters.AdultPersonTableAdapter adultPersonTableAdapter;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private BridaBhataDataSet1 bridaBhataDataSet1;
        private BridaBhataDataSet1TableAdapters.AdultPersonTableAdapter adultPersonTableAdapter1;
        private System.Windows.Forms.BindingSource adultPersonBindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gvUsers;
        private System.Windows.Forms.TabPage Edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gv_dataview;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmbox_type;
        private System.Windows.Forms.TextBox txt_dob;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label lb_street;
        private System.Windows.Forms.Label lb_lname;
        private System.Windows.Forms.Label lb_dob;
        private System.Windows.Forms.Label lb_location;
        private System.Windows.Forms.Label lb_fname;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_amount;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;

    }
}

