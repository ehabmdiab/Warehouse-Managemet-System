
namespace warehousemanagementACE
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.password1 = new MaterialSkin.Controls.MaterialTextBox();
            this.Username1 = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Maroon;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.materialLabel1.Location = new System.Drawing.Point(135, 454);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Username :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Maroon;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel2.Location = new System.Drawing.Point(135, 539);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(79, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Password :";
            // 
            // password1
            // 
            this.password1.AnimateReadOnly = false;
            this.password1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password1.Depth = 0;
            this.password1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.password1.LeadingIcon = null;
            this.password1.Location = new System.Drawing.Point(279, 523);
            this.password1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password1.MaxLength = 50;
            this.password1.MouseState = MaterialSkin.MouseState.OUT;
            this.password1.Multiline = false;
            this.password1.Name = "password1";
            this.password1.Password = true;
            this.password1.Size = new System.Drawing.Size(313, 50);
            this.password1.TabIndex = 2;
            this.password1.Text = "";
            this.password1.TrailingIcon = null;
            // 
            // Username1
            // 
            this.Username1.AnimateReadOnly = false;
            this.Username1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username1.Depth = 0;
            this.Username1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Username1.LeadingIcon = null;
            this.Username1.Location = new System.Drawing.Point(279, 437);
            this.Username1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Username1.MaxLength = 50;
            this.Username1.MouseState = MaterialSkin.MouseState.OUT;
            this.Username1.Multiline = false;
            this.Username1.Name = "Username1";
            this.Username1.Size = new System.Drawing.Size(313, 50);
            this.Username1.TabIndex = 3;
            this.Username1.Text = "";
            this.Username1.TrailingIcon = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::warehousemanagementACE.Properties.Resources._768px_Font_Awesome_5_solid_warehouse_svg_6_384x280;
            this.pictureBox1.Location = new System.Drawing.Point(175, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 315);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // login1
            // 
            this.login1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.login1.Depth = 0;
            this.login1.HighEmphasis = true;
            this.login1.Icon = null;
            this.login1.Location = new System.Drawing.Point(382, 607);
            this.login1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.login1.MouseState = MaterialSkin.MouseState.HOVER;
            this.login1.Name = "login1";
            this.login1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.login1.Size = new System.Drawing.Size(64, 36);
            this.login1.TabIndex = 5;
            this.login1.Text = "Login";
            this.login1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.login1.UseAccentColor = false;
            this.login1.UseVisualStyleBackColor = true;
            this.login1.Click += new System.EventHandler(this.login1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 673);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Username1);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox password1;
        private MaterialSkin.Controls.MaterialTextBox Username1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton login1;
    }
}