namespace WindowsFormsContact
{
    partial class BrandForm
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
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.brandsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDataSet = new WindowsFormsContact.Data.ContactDataSet();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bntSearch = new System.Windows.Forms.Button();
            this.brandsTableAdapter = new WindowsFormsContact.Data.ContactDataSetTableAdapters.BrandsTableAdapter();
            this.tableAdapterManager = new WindowsFormsContact.Data.ContactDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBrand);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brand";
            // 
            // txtBrand
            // 
            this.txtBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBrand.Location = new System.Drawing.Point(3, 16);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(133, 20);
            this.txtBrand.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(174, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // brandsDataGridView
            // 
            this.brandsDataGridView.AutoGenerateColumns = false;
            this.brandsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.brandsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.brandsDataGridView.DataSource = this.brandsBindingSource;
            this.brandsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.brandsDataGridView.Location = new System.Drawing.Point(0, 114);
            this.brandsDataGridView.Name = "brandsDataGridView";
            this.brandsDataGridView.Size = new System.Drawing.Size(517, 266);
            this.brandsDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CreateUserId";
            this.dataGridViewTextBoxColumn3.HeaderText = "CreateUserId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CreateDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "CreateDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DeleteDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "DeleteDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DeleteId";
            this.dataGridViewTextBoxColumn6.HeaderText = "DeleteId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // brandsBindingSource
            // 
            this.brandsBindingSource.DataMember = "Brands";
            this.brandsBindingSource.DataSource = this.contactDataSet;
            // 
            // contactDataSet
            // 
            this.contactDataSet.DataSetName = "ContactDataSet";
            this.contactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(265, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            //this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(346, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            //this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(430, 25);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(75, 23);
            this.bntSearch.TabIndex = 8;
            this.bntSearch.Text = "Search";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // brandsTableAdapter
            // 
            this.brandsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GendersTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsContact.Data.ContactDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 380);
            this.Controls.Add(this.bntSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.brandsDataGridView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "BrandForm";
            this.Text = "BrandForm";
            this.Load += new System.EventHandler(this.BrandForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBrand;
        private Data.ContactDataSet contactDataSet;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource brandsBindingSource;
        private Data.ContactDataSetTableAdapters.BrandsTableAdapter brandsTableAdapter;
        private Data.ContactDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView brandsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button bntSearch;
    }
}