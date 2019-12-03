namespace WindowsFormsContact
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lstBoxProduct = new System.Windows.Forms.ListBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDataSet = new WindowsFormsContact.Data.ContactDataSet();
            this.LboxSub = new System.Windows.Forms.ListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabChoose = new System.Windows.Forms.TabPage();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.categoryTableAdapter = new WindowsFormsContact.Data.ContactDataSetTableAdapters.CategoryTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.productImage1 = new WindowsFormsContact.Controls.ProductImage();
            this.productImage2 = new WindowsFormsContact.Controls.ProductImage();
            this.subCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subCategoryTableAdapter = new WindowsFormsContact.Data.ContactDataSetTableAdapters.SubCategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabChoose.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lstBoxProduct);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.LboxSub);
            this.splitContainer.Size = new System.Drawing.Size(186, 377);
            this.splitContainer.SplitterDistance = 225;
            this.splitContainer.TabIndex = 0;
            // 
            // lstBoxProduct
            // 
            this.lstBoxProduct.DataSource = this.categoryBindingSource;
            this.lstBoxProduct.DisplayMember = "Name";
            this.lstBoxProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxProduct.FormattingEnabled = true;
            this.lstBoxProduct.Location = new System.Drawing.Point(0, 0);
            this.lstBoxProduct.Name = "lstBoxProduct";
            this.lstBoxProduct.Size = new System.Drawing.Size(186, 225);
            this.lstBoxProduct.TabIndex = 0;
            this.lstBoxProduct.ValueMember = "Id";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.contactDataSet;
            // 
            // contactDataSet
            // 
            this.contactDataSet.DataSetName = "ContactDataSet";
            this.contactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LboxSub
            // 
            this.LboxSub.DataSource = this.subCategoryBindingSource;
            this.LboxSub.DisplayMember = "Name";
            this.LboxSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LboxSub.FormattingEnabled = true;
            this.LboxSub.Location = new System.Drawing.Point(0, 0);
            this.LboxSub.Name = "LboxSub";
            this.LboxSub.Size = new System.Drawing.Size(186, 148);
            this.LboxSub.TabIndex = 0;
            this.LboxSub.ValueMember = "Id";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl.Controls.Add(this.tabChoose);
            this.tabControl.Controls.Add(this.tabSearch);
            this.tabControl.Location = new System.Drawing.Point(1, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(200, 409);
            this.tabControl.TabIndex = 1;
            // 
            // tabChoose
            // 
            this.tabChoose.Controls.Add(this.splitContainer);
            this.tabChoose.Location = new System.Drawing.Point(4, 22);
            this.tabChoose.Name = "tabChoose";
            this.tabChoose.Padding = new System.Windows.Forms.Padding(3);
            this.tabChoose.Size = new System.Drawing.Size(192, 383);
            this.tabChoose.TabIndex = 0;
            this.tabChoose.Text = "Sechim";
            this.tabChoose.UseVisualStyleBackColor = true;
            // 
            // tabSearch
            // 
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(192, 383);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.Text = "Axtarish";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.productImage1);
            this.flowLayoutPanel1.Controls.Add(this.productImage2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(203, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(563, 375);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // productImage1
            // 
            this.productImage1.Location = new System.Drawing.Point(3, 3);
            this.productImage1.Name = "productImage1";
            this.productImage1.Picture = ((System.Drawing.Image)(resources.GetObject("productImage1.Picture")));
            this.productImage1.Price = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.productImage1.Size = new System.Drawing.Size(200, 245);
            this.productImage1.TabIndex = 0;
            // 
            // productImage2
            // 
            this.productImage2.Location = new System.Drawing.Point(209, 3);
            this.productImage2.Name = "productImage2";
            this.productImage2.Picture = ((System.Drawing.Image)(resources.GetObject("productImage2.Picture")));
            this.productImage2.Price = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.productImage2.Size = new System.Drawing.Size(242, 245);
            this.productImage2.TabIndex = 1;
            // 
            // subCategoryBindingSource
            // 
            this.subCategoryBindingSource.DataMember = "SubCategory";
            this.subCategoryBindingSource.DataSource = this.contactDataSet;
            // 
            // subCategoryTableAdapter
            // 
            this.subCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 411);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabControl);
            this.Name = "UserForm";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabChoose.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabChoose;
        private System.Windows.Forms.TabPage tabSearch;
        private Data.ContactDataSet contactDataSet;
        private System.Windows.Forms.ListBox lstBoxProduct;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private Data.ContactDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.ProductImage productImage1;
        private Controls.ProductImage productImage2;
        private System.Windows.Forms.ListBox LboxSub;
        private System.Windows.Forms.BindingSource subCategoryBindingSource;
        private Data.ContactDataSetTableAdapters.SubCategoryTableAdapter subCategoryTableAdapter;
    }
}

