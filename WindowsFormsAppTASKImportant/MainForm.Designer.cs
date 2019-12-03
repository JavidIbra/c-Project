namespace WindowsFormsAppTASKImportant
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
            this.btnCars = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCars
            // 
            this.btnCars.Location = new System.Drawing.Point(101, 3);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(162, 49);
            this.btnCars.TabIndex = 0;
            this.btnCars.Text = "Cars";
            this.btnCars.UseVisualStyleBackColor = true;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(101, 67);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(162, 44);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(101, 126);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(162, 43);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 181);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnCars);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnRegister;
    }
}

