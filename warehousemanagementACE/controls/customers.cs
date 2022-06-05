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
    public partial class customers : UserControl
    {
        warehousesEntities db;
        public customers()
        {
            db = new warehousesEntities();
            InitializeComponent();
            FillCustomerGrid();
        }
        public void FillCustomerGrid() 
        {
            CustomerGridview.Rows.Clear();
            foreach(var customer in db.Customer) 
            {
                CustomerGridview.Rows.Add(customer.C_Id, customer.Name, customer.Phone, customer.Fax, customer.Email,customer.Website); 
            }
        }
        public void ClearCustomerBoxes() 
        {
            Id_txt.Text = Name_txt.Text = Phone_txt.Text = Fax_txt.Text = Email_txt.Text = Website_txt.Text = " ";

        }
        public void SelectIntoBoxes()
        {
            Id_txt.Text = CustomerGridview.SelectedRows[0].Cells[0].Value.ToString();
            Name_txt.Text = CustomerGridview.SelectedRows[0].Cells[1].Value.ToString();
            Phone_txt.Text = CustomerGridview.SelectedRows[0].Cells[2].Value.ToString();
            Fax_txt.Text = CustomerGridview.SelectedRows[0].Cells[3].Value.ToString();
            Email_txt.Text = CustomerGridview.SelectedRows[0].Cells[4].Value.ToString();
            Website_txt.Text = CustomerGridview.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var IsFound = db.Customer.Where(a => a.Name == Name_txt.Text).FirstOrDefault();

                if (IsFound is null)
                {
                    Customer customer = new Customer();
                    customer.Name = Name_txt.Text;
                    customer.Phone = Int32.Parse(Phone_txt.Text);
                    customer.Fax = Fax_txt.Text;
                    customer.Email = Email_txt.Text;
                    customer.Website = Website_txt.Text;
                    db.Customer.Add(customer);
                    db.SaveChanges();
                    FillCustomerGrid();
                    ClearCustomerBoxes();
                }
                else
                {
                    MessageBox.Show("Customer already exists");
                    ClearCustomerBoxes();
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("Please fill all the fields");
                ClearCustomerBoxes();
            }
        }

        private void CustomerGridview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SelectIntoBoxes();
            }
            catch (Exception)
            {
                ClearCustomerBoxes();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Int32.Parse(Id_txt.Text);
                var Customer = db.Customer.Where(a => a.C_Id == id).FirstOrDefault();

                if (Customer != null)
                {
                    Customer.C_Id = Convert.ToInt32(Id_txt.Text);
                    Customer.Name = Name_txt.Text;
                    Customer.Phone = Convert.ToInt32(Phone_txt.Text);
                    Customer.Fax = Fax_txt.Text;
                    Customer.Email = Email_txt.Text;
                    Customer.Website = Website_txt.Text;
                    db.SaveChanges();
                    FillCustomerGrid();
                    ClearCustomerBoxes();
                }
                else
                {
                    MessageBox.Show("Customer not found");
                    ClearCustomerBoxes();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("PLease Select a Row First");
                ClearCustomerBoxes();
            }
        }
           

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Int32.Parse(Id_txt.Text);
                var Customer = db.Customer.Where(a => a.C_Id == id).FirstOrDefault();
                if (Customer != null)
                {
                    db.Customer.Remove(Customer);
                    db.SaveChanges();
                    FillCustomerGrid();
                    ClearCustomerBoxes();
                }
                else
                {
                    MessageBox.Show("Customer not found");
                    ClearCustomerBoxes();
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("PLease Select a Row First");
                ClearCustomerBoxes();
            }
        }
        }
    }

