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
    public partial class items : UserControl //kharbana
    {
       public warehousesEntities db;
        public items()
        {
            InitializeComponent();
            db = new warehousesEntities();
            FillComboWarehouse();
            FillItemsGrid();
            OrphenedItemsCollector();
        }
        public void FillItemsGrid() 
        {
            ItemGridView.Rows.Clear();

            var item = db.Products.Where(x => x.Warehouses.Name == WarehouseCombo.Text).ToList();
            
           
            foreach (var product in item)
            {
                ItemGridView.Rows.Add(product.P_Id, product.p_Name, product.Measuring_unit,product.amount);
            }

        }
        public void FillComboWarehouse() 
        {
            foreach (var warehouse in db.Warehouses)
            {
                WarehouseCombo.Items.Add(warehouse.Name);
            }
        }
        public void ClearBoxes()
        {
            amount_txt.Text = id_txt.Text = units_txt.Text = name_txt.Text = String.Empty;
        }
        public void SelectIntoBoxes()
        {
            id_txt.Text = ItemGridView.SelectedRows[0].Cells[0].Value.ToString();
            name_txt.Text = ItemGridView.SelectedRows[0].Cells[1].Value.ToString();
              units_txt.Text = ItemGridView.SelectedRows[0].Cells[2].Value.ToString();
            amount_txt.Text = ItemGridView.SelectedRows[0].Cells[3].Value.ToString();
        }
        public void OrphenedItemsCollector()
        {
            var orphened = db.Products.Where(a => a.p_Name == null);
            if (orphened != null)
            {
                foreach (var item in orphened)
                {
                    db.Products.Remove(item);
                }
                db.SaveChanges();
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var isfound = db.Products.Where(a => a.W_name == WarehouseCombo.Text && a.p_Name == name_txt.Text).FirstOrDefault();
                if (isfound != null)
                {
                    isfound.amount += Convert.ToInt32(amount_txt.Text);
                    db.SaveChanges();
                    FillItemsGrid();
                    ClearBoxes();
                }
                else
                {
                    Products product = new Products();
                    product.p_Name = name_txt.Text;
                    product.W_name = WarehouseCombo.Text;
                    product.P_Id = Convert.ToInt32(id_txt.Text);
                    product.Measuring_unit = units_txt.Text;
                    product.amount = Convert.ToInt32(amount_txt.Text);
                    db.Products.Add(product);
                    db.SaveChanges();
                    FillItemsGrid();
                    ClearBoxes();

                }
            }
            catch (Exception) 
            {
                MessageBox.Show("please fill all the fields!");
                ClearBoxes();
            }
        }

        private void WarehouseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillItemsGrid();
        }

        private void ItemGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try 
            {
                SelectIntoBoxes();
            }
            catch(Exception)
            { 
                ClearBoxes();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(id_txt.Text);
                var isfound = db.Products.Where(a => a.W_name == WarehouseCombo.Text && a.P_Id == id).FirstOrDefault();
                if (isfound != null)
                {
                    isfound.p_Name = name_txt.Text;
                    isfound.Measuring_unit = units_txt.Text;
                    isfound.amount = Convert.ToInt32(amount_txt.Text);
                    db.SaveChanges();
                    FillItemsGrid();
                    ClearBoxes();

                }
                else
                {
                    MessageBox.Show("product not found ! please update with Barcode");
                    ClearBoxes();
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("please select a row first !");
                ClearBoxes();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var isfound = db.Products.Where(a => a.W_name == WarehouseCombo.Text && a.p_Name==name_txt.Text).FirstOrDefault();
                if(isfound != null) 
                {
                    db.Products.Remove(isfound);
                    db.SaveChanges();
                    FillItemsGrid();
                    ClearBoxes();
                }
                else 
                {
                    MessageBox.Show("product not found ! ");
                    ClearBoxes();
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("please select a row first !");
                ClearBoxes();
            }
        }
    }
}
