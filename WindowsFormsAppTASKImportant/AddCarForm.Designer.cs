namespace WindowsFormsAppTASKImportant
{
    partial class AddCarForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new WindowsFormsAppTASKImportant.RentACarDataSet();
            this.Model = new System.Windows.Forms.GroupBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.Win = new System.Windows.Forms.GroupBox();
            this.cmbWin = new System.Windows.Forms.ComboBox();
            this.winBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Fuel = new System.Windows.Forms.GroupBox();
            this.cmbFuel = new System.Windows.Forms.ComboBox();
            this.fuelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Engine = new System.Windows.Forms.GroupBox();
            this.cmbEngine = new System.Windows.Forms.ComboBox();
            this.engineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new WindowsFormsAppTASKImportant.RentACarDataSetTableAdapters.BrandTableAdapter();
            this.winTableAdapter = new WindowsFormsAppTASKImportant.RentACarDataSetTableAdapters.WinTableAdapter();
            this.typeTableAdapter = new WindowsFormsAppTASKImportant.RentACarDataSetTableAdapters.TypeTableAdapter();
            this.fuelTableAdapter = new WindowsFormsAppTASKImportant.RentACarDataSetTableAdapters.FuelTableAdapter();
            this.engineTableAdapter = new WindowsFormsAppTASKImportant.RentACarDataSetTableAdapters.EngineTableAdapter();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.carsTableAdapter1 = new WindowsFormsAppTASKImportant.RentACarDataSetTableAdapters.CarsTableAdapter();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTableAdapter = new WindowsFormsAppTASKImportant.RentACarDataSetTableAdapters.ModelTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.Model.SuspendLayout();
            this.Win.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            this.Fuel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelBindingSource)).BeginInit();
            this.Engine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.engineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBrand);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 40);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brand";
            // 
            // cmbBrand
            // 
            this.cmbBrand.DataSource = this.brandBindingSource;
            this.cmbBrand.DisplayMember = "Name";
            this.cmbBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(3, 16);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(136, 21);
            this.cmbBrand.TabIndex = 1;
            this.cmbBrand.ValueMember = "Id";
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "Brand";
            this.brandBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "RentACarDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Model
            // 
            this.Model.Controls.Add(this.cmbModel);
            this.Model.Location = new System.Drawing.Point(200, 15);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(142, 40);
            this.Model.TabIndex = 2;
            this.Model.TabStop = false;
            this.Model.Text = "Model";
            // 
            // cmbModel
            // 
            this.cmbModel.DataSource = this.modelBindingSource;
            this.cmbModel.DisplayMember = "Name";
            this.cmbModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(3, 16);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(136, 21);
            this.cmbModel.TabIndex = 2;
            this.cmbModel.ValueMember = "Id";
            // 
            // Win
            // 
            this.Win.Controls.Add(this.cmbWin);
            this.Win.Location = new System.Drawing.Point(12, 67);
            this.Win.Name = "Win";
            this.Win.Size = new System.Drawing.Size(142, 40);
            this.Win.TabIndex = 3;
            this.Win.TabStop = false;
            this.Win.Text = "Win";
            // 
            // cmbWin
            // 
            this.cmbWin.DataSource = this.winBindingSource;
            this.cmbWin.DisplayMember = "Win";
            this.cmbWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWin.FormattingEnabled = true;
            this.cmbWin.Location = new System.Drawing.Point(3, 16);
            this.cmbWin.Name = "cmbWin";
            this.cmbWin.Size = new System.Drawing.Size(136, 21);
            this.cmbWin.TabIndex = 0;
            this.cmbWin.ValueMember = "Id";
            // 
            // winBindingSource
            // 
            this.winBindingSource.DataMember = "Win";
            this.winBindingSource.DataSource = this.dataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbType);
            this.groupBox2.Location = new System.Drawing.Point(200, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 40);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.DataSource = this.typeBindingSource;
            this.cmbType.DisplayMember = "Type";
            this.cmbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(3, 16);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(136, 21);
            this.cmbType.TabIndex = 0;
            this.cmbType.ValueMember = "Id";
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.dataSet;
            // 
            // Fuel
            // 
            this.Fuel.Controls.Add(this.cmbFuel);
            this.Fuel.Location = new System.Drawing.Point(358, 15);
            this.Fuel.Name = "Fuel";
            this.Fuel.Size = new System.Drawing.Size(142, 40);
            this.Fuel.TabIndex = 5;
            this.Fuel.TabStop = false;
            this.Fuel.Text = "Fuel";
            // 
            // cmbFuel
            // 
            this.cmbFuel.DataSource = this.fuelBindingSource;
            this.cmbFuel.DisplayMember = "UseFuel";
            this.cmbFuel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFuel.FormattingEnabled = true;
            this.cmbFuel.Location = new System.Drawing.Point(3, 16);
            this.cmbFuel.Name = "cmbFuel";
            this.cmbFuel.Size = new System.Drawing.Size(136, 21);
            this.cmbFuel.TabIndex = 0;
            this.cmbFuel.ValueMember = "Id";
            // 
            // fuelBindingSource
            // 
            this.fuelBindingSource.DataMember = "Fuel";
            this.fuelBindingSource.DataSource = this.dataSet;
            // 
            // Engine
            // 
            this.Engine.Controls.Add(this.cmbEngine);
            this.Engine.Location = new System.Drawing.Point(361, 67);
            this.Engine.Name = "Engine";
            this.Engine.Size = new System.Drawing.Size(142, 40);
            this.Engine.TabIndex = 6;
            this.Engine.TabStop = false;
            this.Engine.Text = "Engine";
            // 
            // cmbEngine
            // 
            this.cmbEngine.DataSource = this.engineBindingSource;
            this.cmbEngine.DisplayMember = "Engine";
            this.cmbEngine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEngine.FormattingEnabled = true;
            this.cmbEngine.Location = new System.Drawing.Point(3, 16);
            this.cmbEngine.Name = "cmbEngine";
            this.cmbEngine.Size = new System.Drawing.Size(136, 21);
            this.cmbEngine.TabIndex = 3;
            this.cmbEngine.ValueMember = "Id";
            // 
            // engineBindingSource
            // 
            this.engineBindingSource.DataMember = "Engine";
            this.engineBindingSource.DataSource = this.dataSet;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // winTableAdapter
            // 
            this.winTableAdapter.ClearBeforeFill = true;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // fuelTableAdapter
            // 
            this.fuelTableAdapter.ClearBeforeFill = true;
            // 
            // engineTableAdapter
            // 
            this.engineTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Location = new System.Drawing.Point(161, 25);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(17, 23);
            this.btnAddBrand.TabIndex = 7;
            this.btnAddBrand.Text = "+";
            this.btnAddBrand.UseVisualStyleBackColor = true;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // carsTableAdapter1
            // 
            this.carsTableAdapter1.ClearBeforeFill = true;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.dataSet;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 244);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.Engine);
            this.Controls.Add(this.Fuel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Win);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddCarForm";
            this.Text = "Fuel";
            this.Load += new System.EventHandler(this.AddCarForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.Model.ResumeLayout(false);
            this.Win.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.winBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            this.Fuel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fuelBindingSource)).EndInit();
            this.Engine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.engineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Model;
        private System.Windows.Forms.GroupBox Win;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Fuel;
        private System.Windows.Forms.GroupBox Engine;
        private System.Windows.Forms.ComboBox cmbWin;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbFuel;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbEngine;
        private RentACarDataSet dataSet;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private RentACarDataSetTableAdapters.BrandTableAdapter brandTableAdapter;
        private System.Windows.Forms.BindingSource winBindingSource;
        private RentACarDataSetTableAdapters.WinTableAdapter winTableAdapter;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private RentACarDataSetTableAdapters.TypeTableAdapter typeTableAdapter;
        private System.Windows.Forms.BindingSource fuelBindingSource;
        private RentACarDataSetTableAdapters.FuelTableAdapter fuelTableAdapter;
        private System.Windows.Forms.BindingSource engineBindingSource;
        private RentACarDataSetTableAdapters.EngineTableAdapter engineTableAdapter;
        private System.Windows.Forms.Button btnAddBrand;
        private RentACarDataSetTableAdapters.CarsTableAdapter carsTableAdapter1;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private RentACarDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
    }
}