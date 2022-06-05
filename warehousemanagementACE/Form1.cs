using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using warehousemanagementACE.controls;
using warehousemanagementACE.Model;
namespace warehousemanagementACE
{
    public partial class Form1 : MaterialForm
    {
        public warehousesEntities db = new warehousesEntities();       
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.Brown500, Accent.LightBlue200, TextShade.WHITE);

         
        }

        private void addcontrol(UserControl control) 
        {
            control.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(control);
            control.BringToFront();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
       
            
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            warehouse w = new warehouse();
            addcontrol(w);
        }

        private void items1_Click(object sender, EventArgs e)
        {
            items i = new items();
            addcontrol(i);
        }

        private void suppliers1_Click(object sender, EventArgs e)
        {
            suppliers s = new suppliers();
            addcontrol(s);
        }

        private void customers1_Click(object sender, EventArgs e)
        {
            customers c = new customers();
            addcontrol(c);

        }

        private void buying1_Click(object sender, EventArgs e)
        {
            buying b = new buying();
            addcontrol(b);
        }

        private void selling1_Click(object sender, EventArgs e)
        {
            selling s = new selling();
            addcontrol(s);
        }

        private void transfer1_Click(object sender, EventArgs e)
        {
            transfer t = new transfer();
            addcontrol(t);
        }

        private void reports1_Click(object sender, EventArgs e)
        {
            reports r = new reports();
            addcontrol(r);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
            
        }
    }
}
