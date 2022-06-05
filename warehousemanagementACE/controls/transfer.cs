using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehousemanagementACE.Model;

namespace warehousemanagementACE.controls
{
    public partial class transfer : UserControl
    {
        warehousesEntities db;
        public transfer()
        {
            db = new warehousesEntities();
            InitializeComponent();
            FillFromCombo();
            FillToCombo();
        }

        public void FillFromCombo()
        {
            FromComboBox.Items.Clear();
            foreach (var product in db.Warehouses) 
            {
                FromComboBox.Items.Add(product.Name);
            }
        }
        public void FillToCombo()
        {
            ToComboBox.Items.Clear();
            foreach (var product in db.Warehouses)
            {
                ToComboBox.Items.Add(product.Name);
            }
        }
        
        public void FillFromGrid() 
        {
            FromGridView.Rows.Clear();
            var item = db.Products.Where(x => x.Warehouses.Name == FromComboBox.Text).ToList();
            foreach (var i in item) 
            {
                FromGridView.Rows.Add (i.p_Name, i.amount);
            }
        }

        public void FillToGrid()
        {
            ToGridView.Rows.Clear();
            var item = db.Products.Where(x => x.Warehouses.Name == ToComboBox.Text).ToList();
            foreach (var i in item)
            {
                ToGridView.Rows.Add(i.p_Name, i.amount);
            }
        }

        private void FromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillFromGrid();
        }

        private void ToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillToGrid();
        }

        private void Transfer1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ToComboBox.Text != FromComboBox.Text)
                {

                    var selected = FromGridView.SelectedRows[0].Cells[0].Value.ToString();
                    var itemfrom = db.Products.Where(x => x.p_Name == selected && x.Warehouses.Name == FromComboBox.Text).FirstOrDefault();
                    var isfound = db.Products.Where(x => x.p_Name == selected && x.Warehouses.Name == ToComboBox.Text).FirstOrDefault();  //check if th product is found in the other warehouse

                    if (isfound != null)
                    {
                        if (itemfrom.amount >= Convert.ToInt32(Amount_txt.Text))
                        {
                            isfound.amount += Convert.ToInt32(Amount_txt.Text);
                            itemfrom.amount -= Convert.ToInt32(Amount_txt.Text);
                            db.SaveChanges();
                            MessageBox.Show("Transfer Successful");
                            FillFromGrid();
                            FillToGrid();
                        }
                        else
                        {
                            MessageBox.Show("Not enough amount in the warehouse");
                        }
                    }
                    else
                    {
                        MessageBox.Show("item is not found in the other warehouse !");

                    }
                }
                else
                {
                    MessageBox.Show("You can't transfer to the same warehouse");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an item");
            }
        }

       
    }
}
