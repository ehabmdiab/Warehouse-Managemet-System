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
    public partial class suppliers : UserControl
    {
        public warehousesEntities db;
        public suppliers()
        {
            InitializeComponent();
            db = new warehousesEntities();
            FillSupplierGrid();
        }
        public void FillSupplierGrid()
        {
            Suppliers_gridview.Rows.Clear();

            foreach (var sup in db.Supplier)
            {
                Suppliers_gridview.Rows.Add(sup.S_Id, sup.Name, sup.Phone, sup.Fax, sup.Email,sup.Website);
            }
        }
        public void ClearBoxes() 
        {
            Id_txt.Text = Name_txt.Text = Phone_txt.Text = Fax_txt.Text = Email_txt.Text = Website_txt.Text = "";

        }
        public void SelectIntoBoxes()
        {
            Id_txt.Text = Suppliers_gridview.SelectedRows[0].Cells[0].Value.ToString();
            Name_txt.Text = Suppliers_gridview.SelectedRows[0].Cells[1].Value.ToString();
            Phone_txt.Text = Suppliers_gridview.SelectedRows[0].Cells[2].Value.ToString();
            Fax_txt.Text = Suppliers_gridview.SelectedRows[0].Cells[3].Value.ToString();
            Email_txt.Text = Suppliers_gridview.SelectedRows[0].Cells[4].Value.ToString();
            Website_txt.Text = Suppliers_gridview.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var isfound = db.Supplier.Where(x => x.Name == Name_txt.Text).FirstOrDefault();
                if (isfound is null)
                {
                    Supplier supplier = new Supplier();
                    supplier.S_Id = Convert.ToInt32(Id_txt.Text);  // 
                    supplier.Name = Name_txt.Text;
                    supplier.Phone = Convert.ToInt32(Phone_txt.Text);
                    supplier.Fax = Fax_txt.Text;
                    supplier.Email = Email_txt.Text;
                    supplier.Website = Website_txt.Text;
                    db.Supplier.Add(supplier);
                    db.SaveChanges();
                    FillSupplierGrid();
                    ClearBoxes();
                }
                else
                {
                    MessageBox.Show("Supplier already exists");
                    ClearBoxes();

                }
            }
            catch (Exception) 
            {
                MessageBox.Show("please fill all the fields !");
                ClearBoxes();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try {
                int id = Convert.ToInt32(Id_txt.Text);
                var isfound = db.Supplier.Where(x => x.S_Id == id).FirstOrDefault();
                if (isfound !=null) 
                {
                    isfound.Name = Name_txt.Text;
                    isfound.Phone = Convert.ToInt32(Phone_txt.Text);
                    isfound.Fax = Fax_txt.Text;
                    isfound.Email = Email_txt.Text;
                    isfound.Website = Website_txt.Text;
                    db.SaveChanges();
                    FillSupplierGrid();
                    ClearBoxes();
                }
            } 
            catch(Exception) 
            { MessageBox.Show("please select a row first"); }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Id_txt.Text);
                var isfound = db.Supplier.Where(x => x.S_Id == id).FirstOrDefault();
                if (isfound != null)
                {
                    db.Supplier.Remove(isfound);
                    db.SaveChanges();
                    FillSupplierGrid();
                    ClearBoxes();

                }
                else
                {
                    MessageBox.Show("Supplier not found");
                    ClearBoxes();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("please select a row first");
            }

        }

        private void Suppliers_gridview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SelectIntoBoxes();
            }
            catch (Exception)
            {
                ClearBoxes();
            }
            
        }
    }
}
