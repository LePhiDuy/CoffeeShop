using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class PrintBill : Form
    {
        List<Bill> listBill = new List<Bill>();
        string date, table, staff, total, discount;
        string totalPayment;
        private void PrintBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!");
        }

        public PrintBill(List<Bill> dataSource , string date, string table, string staff, string total, string discount)
        {
            InitializeComponent();
            listBill = dataSource;
            this.date = date;
            this.table = table;
            this.staff = staff;
            this.total = total + " VNĐ";
            this.discount = String.Format("{0:#,##0.##}", (Convert.ToDouble(discount) / 100 * Convert.ToDouble(total))) + " VNĐ";
            this.totalPayment = String.Format("{0:#,##0.##}", Convert.ToDouble(total) *(1- Convert.ToDouble(discount)/100));
        }
        private void PrintBill_Load(object sender, EventArgs e)
        {

            ReportParameter[] para = new ReportParameter[]
            {
                new ReportParameter("Date", date),
                new ReportParameter("table", table),
                new ReportParameter("staff", staff),
                new ReportParameter("discountP", discount),
                new ReportParameter("total_payment", totalPayment.ToString()+ " VNĐ"),
                new ReportParameter("Total",total)

            };
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",listBill));
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }
    }
}
