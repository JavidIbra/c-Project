namespace WindowsFormsAppTASKImportant
{
    partial class CarForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rentACarDataSet = new WindowsFormsAppTASKImportant.RentACarDataSet();
            this.spCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spCarsTableAdapter = new WindowsFormsAppTASKImportant.RentACarDataSetTableAdapters.spCarsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useFuelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.engineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCarsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 38);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(169, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brand";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 19);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Location = new System.Drawing.Point(169, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 52);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Model";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 16);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(300, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 52);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Win";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Id";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox4);
            this.groupBox4.Location = new System.Drawing.Point(453, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(136, 52);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Type";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(3, 16);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 0;
            this.comboBox4.ValueMember = "Id";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox5);
            this.groupBox5.Location = new System.Drawing.Point(765, 70);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 52);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "AvailableId";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(3, 16);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 0;
            this.comboBox5.ValueMember = "Id";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox6);
            this.groupBox6.Location = new System.Drawing.Point(606, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(136, 52);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fuel";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(3, 16);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 0;
            this.comboBox6.ValueMember = "Id";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBox7);
            this.groupBox7.Location = new System.Drawing.Point(765, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(136, 52);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Engine";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(3, 16);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 0;
            this.comboBox7.ValueMember = "Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.modelIdDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn,
            this.brandIdDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn,
            this.fuelIdDataGridViewTextBoxColumn,
            this.useFuelDataGridViewTextBoxColumn,
            this.typeIdDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn,
            this.availableIdDataGridViewTextBoxColumn,
            this.dataGridViewCheckBoxColumn1,
            this.engineIdDataGridViewTextBoxColumn,
            this.engineDataGridViewTextBoxColumn,
            this.winIdDataGridViewTextBoxColumn,
            this.winDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spCarsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 333);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnOther
            // 
            this.btnOther.Location = new System.Drawing.Point(99, 70);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(49, 23);
            this.btnOther.TabIndex = 9;
            this.btnOther.Text = "+";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(273, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 37);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rentACarDataSet
            // 
            this.rentACarDataSet.DataSetName = "RentACarDataSet";
            this.rentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spCarsBindingSource
            // 
            this.spCarsBindingSource.DataMember = "spCars";
            this.spCarsBindingSource.DataSource = this.rentACarDataSet;
            // 
            // spCarsTableAdapter
            // 
            this.spCarsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelIdDataGridViewTextBoxColumn
            // 
            this.modelIdDataGridViewTextBoxColumn.DataPropertyName = "ModelId";
            this.modelIdDataGridViewTextBoxColumn.HeaderText = "ModelId";
            this.modelIdDataGridViewTextBoxColumn.Name = "modelIdDataGridViewTextBoxColumn";
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // brandIdDataGridViewTextBoxColumn
            // 
            this.brandIdDataGridViewTextBoxColumn.DataPropertyName = "BrandId";
            this.brandIdDataGridViewTextBoxColumn.HeaderText = "BrandId";
            this.brandIdDataGridViewTextBoxColumn.Name = "brandIdDataGridViewTextBoxColumn";
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            // 
            // fuelIdDataGridViewTextBoxColumn
            // 
            this.fuelIdDataGridViewTextBoxColumn.DataPropertyName = "FuelId";
            this.fuelIdDataGridViewTextBoxColumn.HeaderText = "FuelId";
            this.fuelIdDataGridViewTextBoxColumn.Name = "fuelIdDataGridViewTextBoxColumn";
            // 
            // useFuelDataGridViewTextBoxColumn
            // 
            this.useFuelDataGridViewTextBoxColumn.DataPropertyName = "UseFuel";
            this.useFuelDataGridViewTextBoxColumn.HeaderText = "UseFuel";
            this.useFuelDataGridViewTextBoxColumn.Name = "useFuelDataGridViewTextBoxColumn";
            // 
            // typeIdDataGridViewTextBoxColumn
            // 
            this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.HeaderText = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            // 
            // availableIdDataGridViewTextBoxColumn
            // 
            this.availableIdDataGridViewTextBoxColumn.DataPropertyName = "AvailableId";
            this.availableIdDataGridViewTextBoxColumn.HeaderText = "AvailableId";
            this.availableIdDataGridViewTextBoxColumn.Name = "availableIdDataGridViewTextBoxColumn";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Available";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Available";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // engineIdDataGridViewTextBoxColumn
            // 
            this.engineIdDataGridViewTextBoxColumn.DataPropertyName = "EngineId";
            this.engineIdDataGridViewTextBoxColumn.HeaderText = "EngineId";
            this.engineIdDataGridViewTextBoxColumn.Name = "engineIdDataGridViewTextBoxColumn";
            // 
            // engineDataGridViewTextBoxColumn
            // 
            this.engineDataGridViewTextBoxColumn.DataPropertyName = "Engine";
            this.engineDataGridViewTextBoxColumn.HeaderText = "Engine";
            this.engineDataGridViewTextBoxColumn.Name = "engineDataGridViewTextBoxColumn";
            // 
            // winIdDataGridViewTextBoxColumn
            // 
            this.winIdDataGridViewTextBoxColumn.DataPropertyName = "WinId";
            this.winIdDataGridViewTextBoxColumn.HeaderText = "WinId";
            this.winIdDataGridViewTextBoxColumn.Name = "winIdDataGridViewTextBoxColumn";
            // 
            // winDataGridViewTextBoxColumn
            // 
            this.winDataGridViewTextBoxColumn.DataPropertyName = "Win";
            this.winDataGridViewTextBoxColumn.HeaderText = "Win";
            this.winDataGridViewTextBoxColumn.Name = "winDataGridViewTextBoxColumn";
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 454);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.Load += new System.EventHandler(this.CarForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCarsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnSearch;
        private RentACarDataSet rentACarDataSet;
        private System.Windows.Forms.BindingSource spCarsBindingSource;
        private RentACarDataSetTableAdapters.spCarsTableAdapter spCarsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useFuelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winDataGridViewTextBoxColumn;
    }
}