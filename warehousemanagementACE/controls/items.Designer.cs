namespace warehousemanagementACE.controls
{
    partial class items
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
            this.label4 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ItemGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_NAme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Measuring_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new MaterialSkin.Controls.MaterialButton();
            this.Update = new MaterialSkin.Controls.MaterialButton();
            this.Add = new MaterialSkin.Controls.MaterialButton();
            this.WarehouseCombo = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Measuring_txt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.units_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(519, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 39);
            this.label4.TabIndex = 17;
            this.label4.Text = "Items";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(272, 74);
            this.id_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(217, 22);
            this.id_txt.TabIndex = 19;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(272, 129);
            this.name_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(217, 22);
            this.name_txt.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(162, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "BarCode";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(155, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Item Name";
            // 
            // ItemGridView
            // 
            this.ItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BarCode,
            this.Item_NAme,
            this.Measuring_unit,
            this.Amount});
            this.ItemGridView.Location = new System.Drawing.Point(542, 74);
            this.ItemGridView.Name = "ItemGridView";
            this.ItemGridView.RowHeadersWidth = 51;
            this.ItemGridView.RowTemplate.Height = 24;
            this.ItemGridView.Size = new System.Drawing.Size(583, 255);
            this.ItemGridView.TabIndex = 22;
            this.ItemGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ItemGridView_RowHeaderMouseClick);
            // 
            // BarCode
            // 
            this.BarCode.HeaderText = "BarCode";
            this.BarCode.MinimumWidth = 6;
            this.BarCode.Name = "BarCode";
            this.BarCode.Width = 125;
            // 
            // Item_NAme
            // 
            this.Item_NAme.HeaderText = "Item Name";
            this.Item_NAme.MinimumWidth = 6;
            this.Item_NAme.Name = "Item_NAme";
            this.Item_NAme.Width = 125;
            // 
            // Measuring_unit
            // 
            this.Measuring_unit.HeaderText = "Measuring unit";
            this.Measuring_unit.MinimumWidth = 6;
            this.Measuring_unit.Name = "Measuring_unit";
            this.Measuring_unit.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Delete.Depth = 0;
            this.Delete.HighEmphasis = true;
            this.Delete.Icon = null;
            this.Delete.Location = new System.Drawing.Point(375, 408);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.Delete.Name = "Delete";
            this.Delete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Delete.Size = new System.Drawing.Size(73, 36);
            this.Delete.TabIndex = 25;
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
            this.Update.Location = new System.Drawing.Point(242, 408);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Update.MouseState = MaterialSkin.MouseState.HOVER;
            this.Update.Name = "Update";
            this.Update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Update.Size = new System.Drawing.Size(77, 36);
            this.Update.TabIndex = 24;
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
            this.Add.Location = new System.Drawing.Point(122, 408);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Add.MouseState = MaterialSkin.MouseState.HOVER;
            this.Add.Name = "Add";
            this.Add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Add.Size = new System.Drawing.Size(64, 36);
            this.Add.TabIndex = 23;
            this.Add.Text = "Add";
            this.Add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Add.UseAccentColor = false;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // WarehouseCombo
            // 
            this.WarehouseCombo.AutoResize = false;
            this.WarehouseCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WarehouseCombo.Depth = 0;
            this.WarehouseCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WarehouseCombo.DropDownHeight = 174;
            this.WarehouseCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WarehouseCombo.DropDownWidth = 121;
            this.WarehouseCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WarehouseCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WarehouseCombo.FormattingEnabled = true;
            this.WarehouseCombo.IntegralHeight = false;
            this.WarehouseCombo.ItemHeight = 43;
            this.WarehouseCombo.Location = new System.Drawing.Point(277, 290);
            this.WarehouseCombo.MaxDropDownItems = 4;
            this.WarehouseCombo.MouseState = MaterialSkin.MouseState.OUT;
            this.WarehouseCombo.Name = "WarehouseCombo";
            this.WarehouseCombo.Size = new System.Drawing.Size(231, 49);
            this.WarehouseCombo.StartIndex = 0;
            this.WarehouseCombo.TabIndex = 26;
            this.WarehouseCombo.SelectedIndexChanged += new System.EventHandler(this.WarehouseCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Warehouse Name";
            // 
            // Measuring_txt
            // 
            this.Measuring_txt.AutoSize = true;
            this.Measuring_txt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Measuring_txt.Location = new System.Drawing.Point(118, 184);
            this.Measuring_txt.Name = "Measuring_txt";
            this.Measuring_txt.Size = new System.Drawing.Size(148, 24);
            this.Measuring_txt.TabIndex = 29;
            this.Measuring_txt.Text = "Measuring unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "amount";
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(273, 237);
            this.amount_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(217, 22);
            this.amount_txt.TabIndex = 30;
            // 
            // units_txt
            // 
            this.units_txt.Location = new System.Drawing.Point(273, 184);
            this.units_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.units_txt.Name = "units_txt";
            this.units_txt.Size = new System.Drawing.Size(217, 22);
            this.units_txt.TabIndex = 32;
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.units_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.Measuring_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WarehouseCombo);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ItemGridView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label4);
            this.Name = "items";
            this.Size = new System.Drawing.Size(1255, 528);
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView ItemGridView;
        private MaterialSkin.Controls.MaterialButton Delete;
        private MaterialSkin.Controls.MaterialButton Update;
        private MaterialSkin.Controls.MaterialButton Add;
        private MaterialSkin.Controls.MaterialComboBox WarehouseCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Measuring_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_NAme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Measuring_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.TextBox units_txt;
    }
}
