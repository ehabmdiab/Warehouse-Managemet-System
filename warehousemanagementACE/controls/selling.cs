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
    public partial class selling : UserControl
    {
        public warehousesEntities db;
        public selling()
        {
            InitializeComponent();
            db = new warehousesEntities();

            FillInvoiceGrid();
            FIllWarehouseCombo();
            FillProductCombo();
            FillCustomerCombo();
        }
        public void FillInvoiceGrid()
        {
            Invoice_gridView.Rows.Clear();
            foreach (var invoice in db.Selling_Invoices)
            {
                Invoice_gridView.Rows.Add(invoice.Order_Number, invoice.Selling_Date,invoice.W_Name,invoice.C_Id);
            }
        }
        public void SelectIntoBoxes()
        {
            OrderNum_txt.Text = Invoice_gridView.SelectedRows[0].Cells[0].Value.ToString();
            Selling_Date_txt.Text = Invoice_gridView.SelectedRows[0].Cells[1].Value.ToString();    //filling the textboxes with the selected row
           warehouse_combo_txt.Text = Invoice_gridView.SelectedRows[0].Cells[2].Value.ToString();
            Customer_Id_txt.Text = Invoice_gridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        public void FIllWarehouseCombo()
        {
            warehouse_combo_txt.Items.Clear();
            foreach (var ware in db.Warehouses)
            {
                warehouse_combo_txt.Items.Add(ware.Name);
            }
        }
        public void FillProductsGrid()
        {
            product_Gridview.Rows.Clear();
            var selected = int.Parse(Invoice_gridView.SelectedRows[0].Cells[0].Value.ToString());  //getting selected ordernumber from invoice gird
            var invoicep = db.selling_invoice_p.Where(a => a.S_I_Order_Number == selected); //getting invoice products when order number = selected row
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

            var items = db.Products.Where(a => a.W_name == warehouse_combo_txt.Text);
            foreach (var item in items)
            {
                product_ComboTxt.Items.Add(item.p_Name);
            }

        }

        public void FillCustomerCombo()
        {
            Customer_Id_txt.Items.Clear();
            foreach (var item in db.Customer)
            {
                Customer_Id_txt.Items.Add(item.C_Id);
            }
        }
        public void CLearBoxes()
        {
            OrderNum_txt.Text = Customer_Id_txt.Text = Selling_Date_txt.Text = warehouse_combo_txt.Text = "";
            product_Gridview.Rows.Clear();

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                int order = Convert.ToInt32(OrderNum_txt.Text);
                var invoice = db.Selling_Invoices.Where(a => a.Order_Number == order).FirstOrDefault();
                if (invoice == null)
                {
                    Selling_Invoices invoice1 = new Selling_Invoices();

                    invoice1.Order_Number = Convert.ToInt32(OrderNum_txt.Text);
                    invoice1.Selling_Date = Convert.ToDateTime(Selling_Date_txt.Text);
                    invoice1.W_Name = warehouse_combo_txt.Text;
                    invoice1.C_Id = Convert.ToInt32(Customer_Id_txt.Text);
                    
                    db.Selling_Invoices.Add(invoice1);
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
                var order = db.Selling_Invoices.Where(a => a.Order_Number == ordernum).FirstOrDefault();  //check for order if the order exists
                if (OrderNum_txt != null && order != null)
                {
                    selling_invoice_p sell = new selling_invoice_p();
                    sell.P_Id = db.Products.Where(a => a.p_Name == product_ComboTxt.Text).Select(a => a.P_Id).FirstOrDefault();
                    sell.S_I_Order_Number = Convert.ToInt32(OrderNum_txt.Text);
                    sell.amount = Convert.ToInt32(Amount_Txt.Text);
                    db.selling_invoice_p.Add(sell);
                    var product = db.Products.Where(a => a.p_Name == product_ComboTxt.Text).FirstOrDefault();
                    product.amount = product.amount - Convert.ToInt32(Amount_Txt.Text);
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

        private void warehouse_combo_txt_SelectedValueChanged(object sender, EventArgs e)
        {
            FillProductCombo();   //to fill product combo box based on warehouse value
        }

        private void Invoice_gridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
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
                var isfound = db.Selling_Invoices.Where(x => x.Order_Number == oredernum).FirstOrDefault();
                if (isfound != null)
                {
                    isfound.Selling_Date = DateTime.Parse(Selling_Date_txt.Text);
                    isfound.C_Id = int.Parse(Customer_Id_txt.Text);

                    db.SaveChanges();
                    FillInvoiceGrid();
                    CLearBoxes();
                }
            }catch(Exception)
            {
                MessageBox.Show("please select a row first !");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = Convert.ToInt32(OrderNum_txt.Text);
                var isfound = db.Selling_Invoices.Where(a => a.Order_Number == order).FirstOrDefault();
                if (isfound != null)
                {
                    db.Selling_Invoices.Remove(isfound);

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
