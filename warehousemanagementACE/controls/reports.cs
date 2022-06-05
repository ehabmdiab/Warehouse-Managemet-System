using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehousemanagementACE;

namespace warehousemanagementACE.controls
{
    public partial class reports : UserControl
    {
        int report;
        public reports()
        {
            InitializeComponent();
            report = 0;
        }

        private void Warehouses_Click(object sender, EventArgs e)
        {
            if (report != 0)
            {
                reportViewer1.ServerReport.ReportPath = "/warehouses/warehouses";
                reportViewer1.ServerReport.Refresh();
                reportViewer1.RefreshReport();

            }
            else
            {
                report = 1;
                MessageBox.Show("Please Diploy the Reports to your LocalHost !");
            }

        }

        private void Products_Click(object sender, EventArgs e)
        {
            if (report != 0)
            {
                this.reportViewer1.ServerReport.ReportPath = "/warehouses/Products";    
                this.reportViewer1.ServerReport.Refresh();
                this.reportViewer1.RefreshReport();

            }
            else
            {
                report = 1;
                MessageBox.Show("Please Diploy the Reports to your LocalHost !");
            }

        }
    }
}
