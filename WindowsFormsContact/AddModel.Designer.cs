namespace WindowsFormsContact
{
    partial class s
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.contactDataSet = new WindowsFormsContact.Data.ContactDataSet();
            this.modelsTableAdapter = new WindowsFormsContact.Data.ContactDataSetTableAdapters.ModelsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDataSet1 = new WindowsFormsContact.Data.ContactDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.brandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandsTableAdapter = new WindowsFormsContact.Data.ContactDataSetTableAdapters.BrandsTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModel.Location = new System.Drawing.Point(3, 16);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(194, 20);
            this.txtModel.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(455, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // contactDataSet
            // 
            this.contactDataSet.DataSetName = "ContactDataSet";
            this.contactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.brandIdDataGridViewTextBoxColumn,
            this.createUserIdDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.deleteDateDataGridViewTextBoxColumn,
            this.deleteIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.modelsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(686, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            this.brandNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandIdDataGridViewTextBoxColumn
            // 
            this.brandIdDataGridViewTextBoxColumn.DataPropertyName = "BrandId";
            this.brandIdDataGridViewTextBoxColumn.HeaderText = "BrandId";
            this.brandIdDataGridViewTextBoxColumn.Name = "brandIdDataGridViewTextBoxColumn";
            this.brandIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // createUserIdDataGridViewTextBoxColumn
            // 
            this.createUserIdDataGridViewTextBoxColumn.DataPropertyName = "CreateUserId";
            this.createUserIdDataGridViewTextBoxColumn.HeaderText = "CreateUserId";
            this.createUserIdDataGridViewTextBoxColumn.Name = "createUserIdDataGridViewTextBoxColumn";
            this.createUserIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.createUserIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // deleteDateDataGridViewTextBoxColumn
            // 
            this.deleteDateDataGridViewTextBoxColumn.DataPropertyName = "DeleteDate";
            this.deleteDateDataGridViewTextBoxColumn.HeaderText = "DeleteDate";
            this.deleteDateDataGridViewTextBoxColumn.Name = "deleteDateDataGridViewTextBoxColumn";
            this.deleteDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deleteIdDataGridViewTextBoxColumn
            // 
            this.deleteIdDataGridViewTextBoxColumn.DataPropertyName = "DeleteId";
            this.deleteIdDataGridViewTextBoxColumn.HeaderText = "DeleteId";
            this.deleteIdDataGridViewTextBoxColumn.Name = "deleteIdDataGridViewTextBoxColumn";
            this.deleteIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "Models";
            this.modelsBindingSource.DataSource = this.contactDataSet1;
            // 
            // contactDataSet1
            // 
            this.contactDataSet1.DataSetName = "ContactDataSet";
            this.contactDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbBrand);
            this.groupBox2.Location = new System.Drawing.Point(231, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 53);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brand";
            // 
            // cmbBrand
            // 
            this.cmbBrand.DataSource = this.brandsBindingSource;
            this.cmbBrand.DisplayMember = "Name";
            this.cmbBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(3, 16);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(194, 21);
            this.cmbBrand.TabIndex = 4;
            this.cmbBrand.ValueMember = "Id";
            // 
            // brandsBindingSource
            // 
            this.brandsBindingSource.DataMember = "Brands";
            this.brandsBindingSource.DataSource = this.contactDataSet;
            // 
            // brandsTableAdapter
            // 
            this.brandsTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(547, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(455, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(547, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 244);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "s";
            this.Text = "AddModel";
            this.Load += new System.EventHandler(this.AddModel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnAdd;
        private Data.ContactDataSet contactDataSet;
        private Data.ContactDataSetTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.BindingSource brandsBindingSource;
        private Data.ContactDataSetTableAdapters.BrandsTableAdapter brandsTableAdapter;
        private Data.ContactDataSet contactDataSet1;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
    }
}