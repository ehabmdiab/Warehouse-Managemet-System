namespace warehousemanagementACE.controls
{
    partial class transfer
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
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.Expiry_Date_txt = new System.Windows.Forms.DateTimePicker();
            this.prod_date_txt = new System.Windows.Forms.DateTimePicker();
            this.Amount_txt = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Transfer1 = new MaterialSkin.Controls.MaterialButton();
            this.ToGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Product_Name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromComboBox = new System.Windows.Forms.ComboBox();
            this.ToComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ToGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(176, 307);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(44, 16);
            this.label39.TabIndex = 28;
            this.label39.Text = "Expiry";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(147, 252);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(100, 16);
            this.label38.TabIndex = 27;
            this.label38.Text = "Producing Date";
            // 
            // Expiry_Date_txt
            // 
            this.Expiry_Date_txt.Location = new System.Drawing.Point(99, 326);
            this.Expiry_Date_txt.Name = "Expiry_Date_txt";
            this.Expiry_Date_txt.Size = new System.Drawing.Size(200, 22);
            this.Expiry_Date_txt.TabIndex = 26;
            // 
            // prod_date_txt
            // 
            this.prod_date_txt.Location = new System.Drawing.Point(99, 271);
            this.prod_date_txt.Name = "prod_date_txt";
            this.prod_date_txt.Size = new System.Drawing.Size(200, 22);
            this.prod_date_txt.TabIndex = 25;
            // 
            // Amount_txt
            // 
            this.Amount_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_txt.Location = new System.Drawing.Point(140, 204);
            this.Amount_txt.Name = "Amount_txt";
            this.Amount_txt.Size = new System.Drawing.Size(107, 38);
            this.Amount_txt.TabIndex = 24;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(134, 165);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(118, 36);
            this.label37.TabIndex = 23;
            this.label37.Text = "Amount";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(695, 88);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(103, 74);
            this.label35.TabIndex = 17;
            this.label35.Text = "To:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(213, 88);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(177, 74);
            this.label34.TabIndex = 18;
            this.label34.Text = "From:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Salmon;
            this.label6.Location = new System.Drawing.Point(510, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 39);
            this.label6.TabIndex = 16;
            this.label6.Text = "Stock Transfer";
            // 
            // Transfer1
            // 
            this.Transfer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Transfer1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Transfer1.Depth = 0;
            this.Transfer1.HighEmphasis = true;
            this.Transfer1.Icon = null;
            this.Transfer1.Location = new System.Drawing.Point(128, 416);
            this.Transfer1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Transfer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Transfer1.Name = "Transfer1";
            this.Transfer1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Transfer1.Size = new System.Drawing.Size(94, 36);
            this.Transfer1.TabIndex = 29;
            this.Transfer1.Text = "Transfer";
            this.Transfer1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Transfer1.UseAccentColor = false;
            this.Transfer1.UseVisualStyleBackColor = true;
            this.Transfer1.Click += new System.EventHandler(this.Transfer1_Click);
            // 
            // ToGridView
            // 
            this.ToGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name2,
            this.Amount2});
            this.ToGridView.Location = new System.Drawing.Point(770, 177);
            this.ToGridView.Name = "ToGridView";
            this.ToGridView.RowHeadersWidth = 51;
            this.ToGridView.RowTemplate.Height = 24;
            this.ToGridView.Size = new System.Drawing.Size(322, 219);
            this.ToGridView.TabIndex = 30;
            // 
            // Product_Name2
            // 
            this.Product_Name2.HeaderText = "Product Name";
            this.Product_Name2.MinimumWidth = 6;
            this.Product_Name2.Name = "Product_Name2";
            this.Product_Name2.Width = 125;
            // 
            // Amount2
            // 
            this.Amount2.HeaderText = "Amount";
            this.Amount2.MinimumWidth = 6;
            this.Amount2.Name = "Amount2";
            this.Amount2.Width = 125;
            // 
            // FromGridView
            // 
            this.FromGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FromGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name,
            this.Amount});
            this.FromGridView.Location = new System.Drawing.Point(342, 177);
            this.FromGridView.Name = "FromGridView";
            this.FromGridView.RowHeadersWidth = 51;
            this.FromGridView.RowTemplate.Height = 24;
            this.FromGridView.Size = new System.Drawing.Size(322, 219);
            this.FromGridView.TabIndex = 31;
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // FromComboBox
            // 
            this.FromComboBox.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromComboBox.FormattingEnabled = true;
            this.FromComboBox.Location = new System.Drawing.Point(346, 100);
            this.FromComboBox.Name = "FromComboBox";
            this.FromComboBox.Size = new System.Drawing.Size(318, 36);
            this.FromComboBox.TabIndex = 20;
            this.FromComboBox.SelectedIndexChanged += new System.EventHandler(this.FromComboBox_SelectedIndexChanged);
            // 
            // ToComboBox
            // 
            this.ToComboBox.Font = new System.Drawing.Font("Agency FB", 13.8F);
            this.ToComboBox.FormattingEnabled = true;
            this.ToComboBox.Location = new System.Drawing.Point(770, 100);
            this.ToComboBox.Name = "ToComboBox";
            this.ToComboBox.Size = new System.Drawing.Size(322, 36);
            this.ToComboBox.TabIndex = 19;
            this.ToComboBox.SelectedIndexChanged += new System.EventHandler(this.ToComboBox_SelectedIndexChanged);
            // 
            // transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FromGridView);
            this.Controls.Add(this.ToGridView);
            this.Controls.Add(this.Transfer1);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.Expiry_Date_txt);
            this.Controls.Add(this.prod_date_txt);
            this.Controls.Add(this.Amount_txt);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.ToComboBox);
            this.Controls.Add(this.FromComboBox);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label6);
            this.Name = "transfer";
            this.Size = new System.Drawing.Size(1255, 528);
            ((System.ComponentModel.ISupportInitialize)(this.ToGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.DateTimePicker Expiry_Date_txt;
        private System.Windows.Forms.DateTimePicker prod_date_txt;
        private System.Windows.Forms.TextBox Amount_txt;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialButton Transfer1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView ToGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView FromGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.ComboBox FromComboBox;
        private System.Windows.Forms.ComboBox ToComboBox;
    }
}
