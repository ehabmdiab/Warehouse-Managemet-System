namespace warehousemanagementACE.controls
{
    partial class warehouse
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
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_id1 = new System.Windows.Forms.TextBox();
            this.txtbox_Address1 = new System.Windows.Forms.TextBox();
            this.txtbox_name1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.warehouseview = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.m_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Add = new MaterialSkin.Controls.MaterialButton();
            this.Update = new MaterialSkin.Controls.MaterialButton();
            this.Delete = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(101, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Manger ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(127, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Name";
            // 
            // txtbox_id1
            // 
            this.txtbox_id1.Location = new System.Drawing.Point(214, 172);
            this.txtbox_id1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_id1.Name = "txtbox_id1";
            this.txtbox_id1.Size = new System.Drawing.Size(217, 22);
            this.txtbox_id1.TabIndex = 8;
            // 
            // txtbox_Address1
            // 
            this.txtbox_Address1.Location = new System.Drawing.Point(214, 273);
            this.txtbox_Address1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_Address1.Name = "txtbox_Address1";
            this.txtbox_Address1.Size = new System.Drawing.Size(217, 22);
            this.txtbox_Address1.TabIndex = 9;
            // 
            // txtbox_name1
            // 
            this.txtbox_name1.Location = new System.Drawing.Point(214, 221);
            this.txtbox_name1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_name1.Name = "txtbox_name1";
            this.txtbox_name1.Size = new System.Drawing.Size(217, 22);
            this.txtbox_name1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(506, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "WareHouses";
            // 
            // warehouseview
            // 
            this.warehouseview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warehouseview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_id,
            this.Name,
            this.Address});
            this.warehouseview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.warehouseview.Location = new System.Drawing.Point(592, 118);
            this.warehouseview.Name = "warehouseview";
            this.warehouseview.RowHeadersWidth = 51;
            this.warehouseview.RowTemplate.Height = 24;
            this.warehouseview.Size = new System.Drawing.Size(431, 255);
            this.warehouseview.TabIndex = 14;
            this.warehouseview.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.warehouseview_RowHeaderMouseClick);
            // 
            // m_id
            // 
            this.m_id.HeaderText = "manager ID";
            this.m_id.MinimumWidth = 6;
            this.m_id.Name = "m_id";
            this.m_id.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataMember = "Warehouses";
            // 
            // Add
            // 
            this.Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Add.Depth = 0;
            this.Add.HighEmphasis = true;
            this.Add.Icon = null;
            this.Add.Location = new System.Drawing.Point(105, 411);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Add.MouseState = MaterialSkin.MouseState.HOVER;
            this.Add.Name = "Add";
            this.Add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Add.Size = new System.Drawing.Size(64, 36);
            this.Add.TabIndex = 15;
            this.Add.Text = "Add";
            this.Add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Add.UseAccentColor = false;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Update.Depth = 0;
            this.Update.HighEmphasis = true;
            this.Update.Icon = null;
            this.Update.Location = new System.Drawing.Point(225, 411);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Update.MouseState = MaterialSkin.MouseState.HOVER;
            this.Update.Name = "Update";
            this.Update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Update.Size = new System.Drawing.Size(77, 36);
            this.Update.TabIndex = 16;
            this.Update.Text = "Update";
            this.Update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Update.UseAccentColor = false;
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Delete.Depth = 0;
            this.Delete.HighEmphasis = true;
            this.Delete.Icon = null;
            this.Delete.Location = new System.Drawing.Point(358, 411);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.Delete.Name = "Delete";
            this.Delete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Delete.Size = new System.Drawing.Size(73, 36);
            this.Delete.TabIndex = 17;
            this.Delete.Text = "Delete";
            this.Delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Delete.UseAccentColor = false;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.warehouseview);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbox_id1);
            this.Controls.Add(this.txtbox_Address1);
            this.Controls.Add(this.txtbox_name1);
            this.Controls.Add(this.label1);
            this.Size = new System.Drawing.Size(1255, 528);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_id1;
        private System.Windows.Forms.TextBox txtbox_Address1;
        private System.Windows.Forms.TextBox txtbox_name1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView warehouseview;
        private MaterialSkin.Controls.MaterialButton Add;
        private MaterialSkin.Controls.MaterialButton Update;
        private MaterialSkin.Controls.MaterialButton Delete;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn managersMIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}
