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
    public partial class warehouse : UserControl
    {
        public warehousesEntities db = new warehousesEntities();
        public string warehousename;
        public warehouse()
        {
            InitializeComponent();
            FillWarehousegrid();

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var IsFound = db.Warehouses.Where(a => a.Name == txtbox_name1.Text).FirstOrDefault();
                if (IsFound is null)
                {
                    Warehouses w = new Warehouses();
                    w.Name = txtbox_name1.Text;
                    w.Address = txtbox_Address1.Text;
                    w.Manager_Id = Int32.Parse(txtbox_id1.Text);
                    db.Warehouses.Add(w);
                    db.SaveChanges();
                    FillWarehousegrid();
                    ClearwarehouseBoxes();
                }
                else
                {
                    MessageBox.Show("warehouse name exists");
                    ClearwarehouseBoxes();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("please fill all the fields!");
                ClearwarehouseBoxes();
            }
        } 
   


        public void FillWarehousegrid()
        {
            warehouseview.Rows.Clear();
            foreach (var store in db.Warehouses)
            {
                warehouseview.Rows.Add(store.Manager_Id, store.Name, store.Address); ;
            }
        }
        public void ClearwarehouseBoxes()
        {
            txtbox_name1.Text = "";
            txtbox_Address1.Text = "";
            txtbox_id1.Text = "";

        }
        public void SelectIntoBoxes()
        {
            txtbox_id1.Text = warehouseview.SelectedRows[0].Cells[0].Value.ToString();
            txtbox_name1.Text = warehouseview.SelectedRows[0].Cells[1].Value.ToString();
            txtbox_Address1.Text = warehouseview.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void warehouseview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SelectIntoBoxes();

            }
            catch (Exception)
            {
                ClearwarehouseBoxes();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try {
                var isfound = db.Warehouses.Find(txtbox_name1.Text);
                if (isfound != null)
                {
                    isfound.Name = txtbox_name1.Text;
                    isfound.Address = txtbox_Address1.Text;
                    isfound.Manager_Id = Int32.Parse(txtbox_id1.Text);
                    db.SaveChanges();
                    FillWarehousegrid();
                    ClearwarehouseBoxes();

                }
                else { MessageBox.Show("warehouse not found"); }
            }
            catch (Exception) 
            {
                MessageBox.Show("please select a row first !");
                ClearwarehouseBoxes();
            }
            }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var isfound = db.Warehouses.Find(txtbox_name1.Text);
                if (isfound != null)
                {
                    var products = db.Products.Where(a => a.W_name == isfound.Name);
                    db.Products.RemoveRange(products);   //remove products from the warehouse first
                    db.Warehouses.Remove(isfound);
                        db.SaveChanges();
                        FillWarehousegrid();
                        ClearwarehouseBoxes();
                }
                else {
                    MessageBox.Show("warehouse not found");
                    ClearwarehouseBoxes();
                 }
        }
            catch (Exception)
            {
                MessageBox.Show("please select a row first ! ");
                ClearwarehouseBoxes();
    }
}
    }
}
