namespace warehousemanagementACE.controls
{
    partial class buying
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
            this.label2 = new System.Windows.Forms.Label();
            this.Expiry_txt = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.OrderNum_txt = new System.Windows.Forms.TextBox();
            this.Production_date_txt = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.Buying_Date_txt = new System.Windows.Forms.DateTimePicker();
            this.Invoice_gridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Order_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buying__Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expiry_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new MaterialSkin.Controls.MaterialButton();
            this.Update = new MaterialSkin.Controls.MaterialButton();
            this.Add = new MaterialSkin.Controls.MaterialButton();
            this.product_Gridview = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label27 = new System.Windows.Forms.Label();
            this.warehouse_combo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Product_add = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.product_ComboTxt = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.amount = new System.Windows.Forms.Label();
            this.Amount_Txt = new System.Windows.Forms.TextBox();
            this.Supplier_Id_txt = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_combo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_ComboTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Supplier_Id_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(444, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 39);
            this.label2.TabIndex = 53;
            this.label2.Text = "Buying Inovices";
            // 
            // Expiry_txt
            // 
            this.Expiry_txt.Location = new System.Drawing.Point(163, 225);
            this.Expiry_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Expiry_txt.Name = "Expiry_txt";
            this.Expiry_txt.Size = new System.Drawing.Size(217, 22);
            this.Expiry_txt.TabIndex = 55;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(28, 131);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(120, 24);
            this.label30.TabIndex = 61;
            this.label30.Text = "Buying Date";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(7, 175);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(144, 24);
            this.label29.TabIndex = 60;
            this.label29.Text = "Producing date";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(23, 222);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(128, 24);
            this.label28.TabIndex = 58;
            this.label28.Text = "Expiry(Days)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(32, 312);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(109, 24);
            this.label26.TabIndex = 57;
            this.label26.Text = "Supplier Id";
            // 
            // OrderNum_txt
            // 
            this.OrderNum_txt.Location = new System.Drawing.Point(165, 84);
            this.OrderNum_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderNum_txt.Name = "OrderNum_txt";
            this.OrderNum_txt.Size = new System.Drawing.Size(217, 22);
            this.OrderNum_txt.TabIndex = 63;
            // 
            // Production_date_txt
            // 
            this.Production_date_txt.Location = new System.Drawing.Point(163, 177);
            this.Production_date_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Production_date_txt.Name = "Production_date_txt";
            this.Production_date_txt.Size = new System.Drawing.Size(249, 22);
            this.Production_date_txt.TabIndex = 65;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(36, 84);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(112, 24);
            this.label25.TabIndex = 64;
            this.label25.Text = "Order Num";
            // 
            // Buying_Date_txt
            // 
            this.Buying_Date_txt.Location = new System.Drawing.Point(165, 132);
            this.Buying_Date_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Buying_Date_txt.Name = "Buying_Date_txt";
            this.Buying_Date_txt.Size = new System.Drawing.Size(247, 22);
            this.Buying_Date_txt.TabIndex = 66;
            // 
            // Invoice_gridView
            // 
            this.Invoice_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Invoice_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_num,
            this.Buying__Date,
            this.Prod_date,
            this.Expiry_,
            this.Warehouse,
            this.Sup_id});
            this.Invoice_gridView.Location = new System.Drawing.Point(461, 84);
            this.Invoice_gridView.Name = "Invoice_gridView";
            this.Invoice_gridView.RowHeadersWidth = 51;
            this.Invoice_gridView.RowTemplate.Height = 24;
            this.Invoice_gridView.Size = new System.Drawing.Size(556, 255);
            this.Invoice_gridView.TabIndex = 67;
            this.Invoice_gridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Invoice_gridView_RowHeaderMouseClick_1);
            // 
            // Order_num
            // 
            this.Order_num.HeaderText = "Order Num";
            this.Order_num.MinimumWidth = 6;
            this.Order_num.Name = "Order_num";
            this.Order_num.Width = 125;
            // 
            // Buying__Date
            // 
            this.Buying__Date.HeaderText = "Buying Date";
            this.Buying__Date.MinimumWidth = 6;
            this.Buying__Date.Name = "Buying__Date";
            this.Buying__Date.Width = 125;
            // 
            // Prod_date
            // 
            this.Prod_date.HeaderText = "Prod Date";
            this.Prod_date.MinimumWidth = 6;
            this.Prod_date.Name = "Prod_date";
            this.Prod_date.Width = 125;
            // 
            // Expiry_
            // 
            this.Expiry_.HeaderText = "Expiry";
            this.Expiry_.MinimumWidth = 6;
            this.Expiry_.Name = "Expiry_";
            this.Expiry_.Width = 125;
            // 
            // Warehouse
            // 
            this.Warehouse.HeaderText = "Warehouse";
            this.Warehouse.MinimumWidth = 6;
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.Visible = false;
            this.Warehouse.Width = 125;
            // 
            // Sup_id
            // 
            this.Sup_id.HeaderText = "Sup_id";
            this.Sup_id.MinimumWidth = 6;
            this.Sup_id.Name = "Sup_id";
            this.Sup_id.Visible = false;
            this.Sup_id.Width = 125;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Delete.Depth = 0;
            this.Delete.HighEmphasis = true;
            this.Delete.Icon = null;
            this.Delete.Location = new System.Drawing.Point(307, 419);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.Delete.Name = "Delete";
            this.Delete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Delete.Size = new System.Drawing.Size(73, 36);
            this.Delete.TabIndex = 70;
            this.Delete.Text = "Delete";
            this.Delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Delete.UseAccentColor = false;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Update.Depth = 0;
            this.Update.HighEmphasis = true;
            this.Update.Icon = null;
            this.Update.Location = new System.Drawing.Point(174, 419);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Update.MouseState = MaterialSkin.MouseState.HOVER;
            this.Update.Name = "Update";
            this.Update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Update.Size = new System.Drawing.Size(77, 36);
            this.Update.TabIndex = 69;
            this.Update.Text = "Update";
            this.Update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Update.UseAccentColor = false;
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Add
            // 
            this.Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Add.Depth = 0;
            this.Add.HighEmphasis = true;
            this.Add.Icon = null;
            this.Add.Location = new System.Drawing.Point(54, 419);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Add.MouseState = MaterialSkin.MouseState.HOVER;
            this.Add.Name = "Add";
            this.Add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Add.Size = new System.Drawing.Size(64, 36);
            this.Add.TabIndex = 68;
            this.Add.Text = "Add";
            this.Add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Add.UseAccentColor = false;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // product_Gridview
            // 
            this.product_Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_Gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_name});
            this.product_Gridview.Location = new System.Drawing.Point(1035, 84);
            this.product_Gridview.Name = "product_Gridview";
            this.product_Gridview.RowHeadersWidth = 51;
            this.product_Gridview.RowTemplate.Height = 24;
            this.product_Gridview.Size = new System.Drawing.Size(179, 255);
            this.product_Gridview.TabIndex = 73;
            // 
            // Product_name
            // 
            this.Product_name.HeaderText = "Product Name";
            this.Product_name.MinimumWidth = 6;
            this.Product_name.Name = "Product_name";
            this.Product_name.Width = 125;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(31, 268);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(112, 24);
            this.label27.TabIndex = 59;
            this.label27.Text = "Warehouse";
            // 
            // warehouse_combo
            // 
            this.warehouse_combo.DropDownWidth = 217;
            this.warehouse_combo.Location = new System.Drawing.Point(163, 268);
            this.warehouse_combo.Name = "warehouse_combo";
            this.warehouse_combo.Size = new System.Drawing.Size(217, 25);
            this.warehouse_combo.TabIndex = 74;
            this.warehouse_combo.SelectedValueChanged += new System.EventHandler(this.warehouse_combo_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Product_add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.product_ComboTxt);
            this.groupBox1.Controls.Add(this.amount);
            this.groupBox1.Controls.Add(this.Amount_Txt);
            this.groupBox1.Location = new System.Drawing.Point(451, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 152);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "add Products";
            // 
            // Product_add
            // 
            this.Product_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Product_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Product_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Product_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Product_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Product_add.ForeColor = System.Drawing.Color.White;
            this.Product_add.Location = new System.Drawing.Point(152, 100);
            this.Product_add.Name = "Product_add";
            this.Product_add.Size = new System.Drawing.Size(180, 25);
            this.Product_add.TabIndex = 78;
            this.Product_add.Text = "Add Product";
            this.Product_add.Click += new System.EventHandler(this.Product_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 76;
            this.label1.Text = "Product";
            // 
            // product_ComboTxt
            // 
            this.product_ComboTxt.DropDownWidth = 217;
            this.product_ComboTxt.Location = new System.Drawing.Point(154, 21);
            this.product_ComboTxt.Name = "product_ComboTxt";
            this.product_ComboTxt.Size = new System.Drawing.Size(217, 25);
            this.product_ComboTxt.TabIndex = 75;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(25, 67);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(83, 24);
            this.amount.TabIndex = 58;
            this.amount.Text = "Amount";
            // 
            // Amount_Txt
            // 
            this.Amount_Txt.Location = new System.Drawing.Point(149, 67);
            this.Amount_Txt.Name = "Amount_Txt";
            this.Amount_Txt.Size = new System.Drawing.Size(222, 22);
            this.Amount_Txt.TabIndex = 0;
            // 
            // Supplier_Id_txt
            // 
            this.Supplier_Id_txt.DropDownWidth = 217;
            this.Supplier_Id_txt.Location = new System.Drawing.Point(165, 318);
            this.Supplier_Id_txt.Name = "Supplier_Id_txt";
            this.Supplier_Id_txt.Size = new System.Drawing.Size(217, 25);
            this.Supplier_Id_txt.TabIndex = 76;
            // 
            // buying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Supplier_Id_txt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.warehouse_combo);
            this.Controls.Add(this.product_Gridview);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Invoice_gridView);
            this.Controls.Add(this.Production_date_txt);
            this.Controls.Add(this.Buying_Date_txt);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.OrderNum_txt);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.Expiry_txt);
            this.Controls.Add(this.label2);
            this.Name = "buying";
            this.Size = new System.Drawing.Size(1255, 528);
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_combo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_ComboTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Supplier_Id_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Expiry_txt;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox OrderNum_txt;
        private System.Windows.Forms.DateTimePicker Production_date_txt;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker Buying_Date_txt;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView Invoice_gridView;
        private MaterialSkin.Controls.MaterialButton Delete;
        private MaterialSkin.Controls.MaterialButton Update;
        private MaterialSkin.Controls.MaterialButton Add;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView product_Gridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.Label label27;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox warehouse_combo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buying__Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expiry_;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button Product_add;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox product_ComboTxt;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.TextBox Amount_Txt;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Supplier_Id_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_id;
    }
}
