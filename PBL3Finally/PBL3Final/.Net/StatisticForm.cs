using BUS;
using DTO;
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
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
            loadComboBoxYear();
            lbBill.Visible = lbFood.Visible = lbRevenue.Visible = false;
        }
        public void load1()
        {
            chartRatio.DataSource = PercentageBUS.Instance.GetAllPercentages2BUS(Convert.ToInt32(((CBBItem)cbbYear.SelectedItem).Text), Convert.ToInt32(((CBBItem)cbbMonth.SelectedItem).Text));
            chartRatio.Series["Ratio"].XValueMember = "Name";
            chartRatio.Series["Ratio"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartRatio.Series["Ratio"].YValueMembers = "Percentage";
            chartRatio.Series["Ratio"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }
        public void load2()
        {
            chart1.DataSource = RevenueBUS.Instance.GetAllRevenueBUS(Convert.ToInt32(((CBBItem)cbbYear.SelectedItem).Text), Convert.ToInt32(((CBBItem)cbbMonth.SelectedItem).Text));
            chart1.Series["Doanh thu"].XValueMember = "Day";
            chart1.Series["Doanh thu"].LabelFormat = "{0:#,##0.##}";
            chart1.Series["Doanh thu"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart1.Series["Doanh thu"].YValueMembers = "Revenue";
            chart1.Series["Doanh thu"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "{0:#,##0.##}";
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
        }
        public void loadComboBoxYear()
        {
            int k = 0;
            foreach (BillDTO i in BillBUS.Instance.GetAllBillsBUS())
            {
                k = 1;
                for (int j = 0; j < cbbYear.Items.Count; j++)
                {
                    if (cbbYear.Items[j].ToString() == i.BillDate.Year.ToString())
                    {
                        k = 0;
                        break;
                    }
                }
                if (k == 1)
                {
                    cbbYear.Items.Add(new CBBItem { Value = i.BillDate.Year, Text = i.BillDate.Year.ToString() });
                }
            }
        }
        public void load3()
        {
           this.lbFood.Text = String.Format("{0:#,##0.##}", CountBUS.Instance.GetAllCountOfFoodBUS(Convert.ToInt32(((CBBItem)cbbYear.SelectedItem).Text), Convert.ToInt32(((CBBItem)cbbMonth.SelectedItem).Text))[0].Count);
           this.lbRevenue.Text = String.Format("{0:#,##0.##}", CountBUS.Instance.GetAllCountOfRevenueBUS(Convert.ToInt32(((CBBItem)cbbYear.SelectedItem).Text), Convert.ToInt32(((CBBItem)cbbMonth.SelectedItem).Text))[0].Count);
           this.lbBill.Text = String.Format("{0:#,##0.##}", CountBUS.Instance.GetAllCountOfBillBUS(Convert.ToInt32(((CBBItem)cbbYear.SelectedItem).Text), Convert.ToInt32(((CBBItem)cbbMonth.SelectedItem).Text))[0].Count);
        }
        private void cbbyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbMonth.Items.Clear();
            cbbMonth.Text = "";
            int k = 1;
            foreach (BillDTO i in BillBUS.Instance.GetAllBillsBUS())
            {

                if (i.BillDate.Year.ToString() == ((CBBItem)cbbYear.SelectedItem).Text)
                {
                    for (int j = 0; j < cbbMonth.Items.Count; j++)
                    {
                        k = 1;
                        if (cbbMonth.Items[j].ToString() == i.BillDate.Month.ToString())
                        {
                            k = 0;
                            break;
                        }
                    }
                    if (k == 1)
                    {
                        cbbMonth.Items.Add(new CBBItem { Value = i.BillDate.Month, Text = i.BillDate.Month.ToString() });
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(cbbYear.Text == ""||cbbMonth.Text=="")
            {
                MessageBox.Show("Vui lòng nhập năm và tháng cần tạo thống kê");
            }else
            {
                load2();
                load1();
                load3();
                lbBill.Visible = lbFood.Visible = lbRevenue.Visible = true;
            }
        }
    }
}

