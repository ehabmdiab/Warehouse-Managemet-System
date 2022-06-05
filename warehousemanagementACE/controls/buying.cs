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
    public partial class buying : UserControl
    {
        public warehousesEntities db;
        public buying()
        {
            InitializeComponent();
            db = new warehousesEntities();
            FillInvoiceGrid();
            FIllWarehouseCombo();
            FillProductCombo();
            FillSupplierCombo();
        }

        public void FillInvoiceGrid()
        {
            Invoice_gridView.Rows.Clear();
            foreach (var invoice in db.Buying_Invoives)
            {
                Invoice_gridView.Rows.Add(invoice.Order_Number, invoice.buying_Date, invoice.P_Date, invoice.Expiry, invoice.W_Name, invoice.S_Id);
            }
        }
        public void SelectIntoBoxes()
        {
            OrderNum_txt.Text = Invoice_gridView.SelectedRows[0].Cells[0].Value.ToString();
            Buying_Date_txt.Text = Invoice_gridView.SelectedRows[0].Cells[1].Value.ToString();    //filling the textboxes with the selected row
            Production_date_txt.Text = Invoice_gridView.SelectedRows[0].Cells[2].Value.ToString();
            Expiry_txt.Text = Invoice_gridView.SelectedRows[0].Cells[3].Value.ToString();
            warehouse_combo.Text = Invoice_gridView.SelectedRows[0].Cells[4].Value.ToString();
            Supplier_Id_txt.Text = Invoice_gridView.SelectedRows[0].Cells[5].Value.ToString();
        }
        public void FIllWarehouseCombo()
        {
            warehouse_combo.Items.Clear();
            foreach (var ware in db.Warehouses)
            {
                warehouse_combo.Items.Add(ware.Name);
            }
        }
        public void FillProductsGrid()
        {
            product_Gridview.Rows.Clear();
            var selected = int.Parse(Invoice_gridView.SelectedRows[0].Cells[0].Value.ToString());  //getting selected ordernumber from invoice gird
            var invoicep = db.buying_invoice_p.Where(a => a.B_I_Order_Number == selected); //getting invoice products when order number = selected row
            foreach (var invoice in invoicep)
            {
                var items = db.Products.Where(a => a.P_Id == invoice.P_Id).ToList();
                foreach (var item in items)
                {
                    product_Gridview.Rows.Add(item.p_Name);
                }
            }


        }
        public void FillProductCombo()
        {
            product_ComboTxt.Items.Clear();

            var items = db.Products.Where(a => a.W_name == warehouse_combo.Text);
            foreach (var item in items)
            {
                product_ComboTxt.Items.Add(item.p_Name);
            }

        }
        public void FillSupplierCombo()
        {
            Supplier_Id_txt.Items.Clear();
            foreach (var item in db.Supplier)
            {
                Supplier_Id_txt.Items.Add(item.S_Id);
            }
        }
        public void CLearBoxes()
        {
            Buying_Date_txt.Text = Expiry_txt.Text = OrderNum_txt.Text
           = Production_date_txt.Text = Supplier_Id_txt.Text = warehouse_combo.Text = "";

            product_Gridview.Rows.Clear();

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                int order = Convert.ToInt32(OrderNum_txt.Text);
                var invoice = db.Buying_Invoives.Where(a => a.Order_Number == order).FirstOrDefault();
                if (invoice == null)
                {
                    db.SaveChanges();
                    Buying_Invoives invoice1 = new Buying_Invoives();

                    invoice1.Order_Number = Convert.ToInt32(OrderNum_txt.Text);
                    invoice1.buying_Date = Convert.ToDateTime(Buying_Date_txt.Text);
                    invoice1.P_Date = Convert.ToDateTime(Production_date_txt.Text);
                    invoice1.Expiry = Convert.ToInt32(Expiry_txt.Text);
                    invoice1.W_Name = warehouse_combo.Text;
                    invoice1.S_Id = Convert.ToInt32(Supplier_Id_txt.Text);
                    db.Buying_Invoives.Add(invoice1);
                    db.SaveChanges();
                    FillInvoiceGrid();
                    MessageBox.Show("Invoice Added ! Now Add products");
                }
                else
                {
                    MessageBox.Show("invoice already exists");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill all the fields");
            }

        }

        private void Product_add_Click(object sender, EventArgs e)
        {
            try
            {
                int ordernum = Convert.ToInt32(OrderNum_txt.Text);
                var order = db.Buying_Invoives.Where(a => a.Order_Number == ordernum).FirstOrDefault();  //check for order if the order exists
                if (OrderNum_txt != null && order != null)
                {
                    buying_invoice_p bying = new buying_invoice_p();
                    bying.P_Id = db.Products.Where(a => a.p_Name == product_ComboTxt.Text).Select(a => a.P_Id).FirstOrDefault();
                    bying.B_I_Order_Number = Convert.ToInt32(OrderNum_txt.Text);
                    bying.amount = Convert.ToInt32(Amount_Txt.Text);
                    db.buying_invoice_p.Add(bying);
                    var product = db.Products.Where(a => a.p_Name == product_ComboTxt.Text).FirstOrDefault();
                    product.amount = product.amount + Convert.ToInt32(Amount_Txt.Text);
                    db.SaveChanges();
                    product_ComboTxt.Text = Amount_Txt.Text = "";
                }
                else
                {
                    MessageBox.Show("please Fill Order Number first !");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Add Invoice First !");
            }
        }

        private void warehouse_combo_SelectedValueChanged(object sender, EventArgs e)
        {
            FillProductCombo();   //to fill product combo box based on warehouse value
        }



        private void Invoice_gridView_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try {
                SelectIntoBoxes();
                FillProductsGrid();
            }
            catch (Exception)
            {
                CLearBoxes();
                // handling click on empty row by clear boxes
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                int oredernum = Convert.ToInt32(OrderNum_txt.Text);
                var isfound = db.Buying_Invoives.Where(x => x.Order_Number == oredernum).FirstOrDefault();
                if (isfound != null)
                {
                    isfound.P_Date = DateTime.Parse(Production_date_txt.Text);
                    isfound.buying_Date = DateTime.Parse(Buying_Date_txt.Text);
                    isfound.Expiry = int.Parse(Expiry_txt.Text);
                    isfound.S_Id = int.Parse(Supplier_Id_txt.Text);

                    db.SaveChanges();
                    FillInvoiceGrid();
                    CLearBoxes();
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("PLease Select a Row first !");
            }          
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = Convert.ToInt32(OrderNum_txt.Text);
                var isfound = db.Buying_Invoives.Where(a => a.Order_Number == order).FirstOrDefault();
                if (isfound != null)
                {
                    db.Buying_Invoives.Remove(isfound);
                    
                    db.SaveChanges();
                    FillInvoiceGrid();
                    CLearBoxes();
                        
                }
                else
                {
                    MessageBox.Show("Invoice not Found ! ");
                    CLearBoxes();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("please select a row first !");
                CLearBoxes();
            }
        }
    }
}
