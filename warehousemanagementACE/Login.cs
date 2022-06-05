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
using warehousemanagementACE.Model;



namespace warehousemanagementACE
{
    public partial class Login : MaterialForm
    {
        public warehousesEntities db = new warehousesEntities();
        public Login()
        {
            InitializeComponent();


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.Brown500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            var user = db.Managers.Where(x => x.Username == Username1.Text && x.Password == password1.Text).FirstOrDefault();

            if (user!=null)
            {

                this.Hide();
                
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            
        }
    }
}
