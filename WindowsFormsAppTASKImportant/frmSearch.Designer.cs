namespace WindowsFormsAppTASKImportant
{
    partial class frmSearch
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsBindingSourceSearch = new System.Windows.Forms.BindingSource(this.components);
            this.rentACarDataSet = new WindowsFormsAppTASKImportant.RentACarDataSet();
            this.carsTableAdapterSearch = new WindowsFormsAppTASKImportant.RentACarDataSetTableAdapters.CarsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSourceSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(278, 22);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(296, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Axtar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AutoGenerateColumns = false;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn});
            this.dgvSearch.DataSource = this.carsBindingSourceSearch;
            this.dgvSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSearch.Location = new System.Drawing.Point(0, 44);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.Size = new System.Drawing.Size(451, 238);
            this.dgvSearch.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // carsBindingSourceSearch
            // 
            this.carsBindingSourceSearch.DataMember = "Cars";
            this.carsBindingSourceSearch.DataSource = this.rentACarDataSet;
            // 
            // rentACarDataSet
            // 
            this.rentACarDataSet.DataSetName = "RentACarDataSet";
            this.rentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapterSearch
            // 
            this.carsTableAdapterSearch.ClearBeforeFill = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 282);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSourceSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private RentACarDataSet rentACarDataSet;
        private System.Windows.Forms.BindingSource carsBindingSourceSearch;
        private RentACarDataSetTableAdapters.CarsTableAdapter carsTableAdapterSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
    }
}