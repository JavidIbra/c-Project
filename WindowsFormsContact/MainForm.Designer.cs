namespace WindowsFormsContact
{
    partial class MainForm
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
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnModels = new System.Windows.Forms.Button();
            this.btnSbCategry = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnForUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(69, 29);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(113, 47);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnModels
            // 
            this.btnModels.Location = new System.Drawing.Point(196, 29);
            this.btnModels.Name = "btnModels";
            this.btnModels.Size = new System.Drawing.Size(113, 47);
            this.btnModels.TabIndex = 1;
            this.btnModels.Text = "Model";
            this.btnModels.UseVisualStyleBackColor = true;
            this.btnModels.Click += new System.EventHandler(this.btnModels_Click);
            // 
            // btnSbCategry
            // 
            this.btnSbCategry.Location = new System.Drawing.Point(69, 110);
            this.btnSbCategry.Name = "btnSbCategry";
            this.btnSbCategry.Size = new System.Drawing.Size(113, 47);
            this.btnSbCategry.TabIndex = 2;
            this.btnSbCategry.Text = "Subcategory";
            this.btnSbCategry.UseVisualStyleBackColor = true;
            this.btnSbCategry.Click += new System.EventHandler(this.btnSbCategry_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.Location = new System.Drawing.Point(196, 110);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(113, 47);
            this.btnBrand.TabIndex = 3;
            this.btnBrand.Text = "Brand";
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(69, 176);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(113, 42);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnForUser
            // 
            this.btnForUser.Location = new System.Drawing.Point(196, 176);
            this.btnForUser.Name = "btnForUser";
            this.btnForUser.Size = new System.Drawing.Size(113, 41);
            this.btnForUser.TabIndex = 5;
            this.btnForUser.Text = "ForUser";
            this.btnForUser.UseVisualStyleBackColor = true;
            this.btnForUser.Click += new System.EventHandler(this.btnForUser_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 257);
            this.Controls.Add(this.btnForUser);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnBrand);
            this.Controls.Add(this.btnSbCategry);
            this.Controls.Add(this.btnModels);
            this.Controls.Add(this.btnCategory);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnModels;
        private System.Windows.Forms.Button btnSbCategry;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnForUser;
    }
}