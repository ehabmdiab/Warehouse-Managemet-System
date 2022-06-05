namespace warehousemanagementACE.controls
{
    partial class reports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Warehouses = new Guna.UI2.WinForms.Guna2Button();
            this.Products = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(27, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportPath = "/Reports/warehouses";
            this.reportViewer1.Size = new System.Drawing.Size(1192, 441);
            this.reportViewer1.TabIndex = 0;
            // 
            // Warehouses
            // 
            this.Warehouses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Warehouses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Warehouses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Warehouses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Warehouses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Warehouses.ForeColor = System.Drawing.Color.White;
            this.Warehouses.Location = new System.Drawing.Point(342, 452);
            this.Warehouses.Name = "Warehouses";
            this.Warehouses.Size = new System.Drawing.Size(180, 36);
            this.Warehouses.TabIndex = 1;
            this.Warehouses.Text = "Warehouses";
            this.Warehouses.Click += new System.EventHandler(this.Warehouses_Click);
            // 
            // Products
            // 
            this.Products.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Products.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Products.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Products.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Products.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Products.ForeColor = System.Drawing.Color.White;
            this.Products.Location = new System.Drawing.Point(715, 452);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(180, 36);
            this.Products.TabIndex = 2;
            this.Products.Text = "products";
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Warehouses);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reports";
            this.Size = new System.Drawing.Size(1255, 528);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Button Warehouses;
        private Guna.UI2.WinForms.Guna2Button Products;
    }
}
