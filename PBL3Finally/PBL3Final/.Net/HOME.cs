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
    public partial class HOME : Form
    {
        public delegate void ShowFormLogin();
        public ShowFormLogin LoginForm;
        private bool ShowSubMenu = true;
        public static AccountDTO account;
        string table;
        public AccountDTO Account
        {
            get { return account; }
            set { account = value; }
        }
        public HOME(bool role, AccountDTO account)
        {
            InitializeComponent();
            ShowFLP();
            LoadCBB();
            panel2.Hide();
            this.Account = account;
            PEOPLE_INFODTO peopleinfo = null;
            foreach (PEOPLE_INFODTO item in PEOPLE_INFOBUS.Instance.GetPeopleInfoByIdAccountBUS(account.Id))
            {
                peopleinfo = item;
            }
            lblNameUser.Text = peopleinfo.FullName;
            if (!role)
            {
                btnManage.Enabled = false;
                btnAnalytic.Enabled = false;
            }
            SetCBB();
            ShowDTGFood();
        }
        public void SetCBB()
        {
            cbbFoodType.Items.Clear();
            cbbFoodType.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbFoodType.Items.AddRange(FoodTypeBUS.Instance.GetAllCBBItem().ToArray());
            cbbFoodType.SelectedIndex = 0;
        }
        // Ham load danh sach ban len flowlayout
        public void ShowFLP()
        {

            flpTable.Controls.Clear();
            List<TableDTO> list = TableBUS.Instance.GetAllTableBUS();
            foreach (TableDTO table in list)
            {
                Button but = new Button()
                {
                    Width = 110,
                    Height = 110
                };
                but.Text = table.Name;
                but.FlatStyle = FlatStyle.Flat;
                but.Font = new Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                but.Margin = new Padding(10);
                but.FlatAppearance.BorderSize = 0;
                but.Click += new EventHandler(Buttons_Click);
                if (table.Status == "Trống")
                {
                    but.BackColor = Color.White;
                }
                else
                {
                    but.BackColor = Color.FromArgb(255, 157, 98);
                }
                if (cbbChangeTable.SelectedItem != null)
                {
                    if (table.Name == cbbChangeTable.SelectedItem.ToString())
                    {
                        but.PerformClick();
                    }
                }
                flpTable.Controls.Add(but);
            }

        }
        public void ShowDTGFood()
        {
            int Food_Type_ID = ((CBBItem)cbbFoodType.SelectedItem).Value;
            string txt = txtSearch.Text.ToString();
            gridFood.DataSource = FoodBUS.Instance.ConvertToDataTable(Food_Type_ID, txt);
            gridFood.Columns[1].Visible = false;
            gridFood.Columns[3].DefaultCellStyle.Format = "#,####.####";
        }
        private void ResetButtonBorder()
        {
            foreach (object item in this.flpTable.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).FlatAppearance.BorderSize = 0;
                }
            }
        }
        // load danh sach ban vao cbb
        private void LoadCBB()
        {
            cbbChangeTable.Items.Clear();
            List<TableDTO> list = TableBUS.Instance.GetAllTableBUS();
            List<string> vs = new List<string>();
            foreach (TableDTO table in list)
            {
                vs.Add(table.Name);
            }
            foreach (string item in vs)
            {
                cbbChangeTable.Items.Add(item);
            }
        }
        // Thay doi mau border khi nhan vao button
        private void Buttons_Click(object sender, EventArgs e)
        {
            ResetButtonBorder();
            Button btn = (Button)sender;
            table = btn.Text.ToString();
            btn.FlatAppearance.BorderColor = Color.FromArgb(77, 198, 121);
            btn.FlatAppearance.BorderSize = 6;
            foreach (string item in cbbChangeTable.Items)
            {
                if (item == btn.Text)
                {
                    cbbChangeTable.SelectedItem = item;
                }
            }
        }
        private void btnManage_Click(object sender, EventArgs e)
        {
            FormManage.FormManage manage = new FormManage.FormManage();
            manage.d = LoadAllData;
            manage.Show();

        }
        private void PictureBox6_Click(object sender, EventArgs e)
        {
            if (ShowSubMenu)
            {
                panel2.Show();
                ShowSubMenu = !ShowSubMenu;
            }
            else
            {
                panel2.Hide();
                ShowSubMenu = !ShowSubMenu;
            }
        }
        private void ButLogout_Click(object sender, EventArgs e)
        {
            LoginForm();
            this.Close();
        }
        private void HOME_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm();
        }
        private void cbbFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDTGFood();
        }
        private void txtSearch_Change(object sender, EventArgs e)
        {
            ShowDTGFood();
        }
        private void cbbChangeTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<TableDTO> list = TableBUS.Instance.GetAllTableBUS();
            foreach (TableDTO table in list)
            {
                if (table.Name == cbbChangeTable.SelectedItem.ToString())
                {
                    if (table.Status == "Đang có khách")
                    {
                        List<OrderDTO> data = OrderBUS.Instance.GetBillInfoBUS(table.Id);
                        int total2 = 0;
                        foreach (OrderDTO order in data)
                        {
                            total2 += order.Total;
                        }
                        orderDTOBindingSource.DataSource = data;
                        txtTotal.Text = total2.ToString();
                    }
                    else
                    {
                        orderDTOBindingSource.DataSource = null;
                        txtTotal.Text = null;
                    }
                    foreach (Button button in flpTable.Controls)
                    {
                        if (button.Text == table.Name)
                        {
                            Buttons_Click(button, e);
                        }
                    }
                }
            }
        }
        private void gridFood_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbbChangeTable.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bàn trước!");
            }
            else
            {
                List<TableDTO> list = TableBUS.Instance.GetAllTableBUS();
                TableDTO table1 = new TableDTO();
                foreach (TableDTO table in list)
                {
                    if (table.Name == cbbChangeTable.SelectedItem.ToString())
                    {
                        table1 = table;
                    }
                }
                if (table1.Status == "Trống")
                {
                    table1.Status = "Đang có khách";
                    TableBUS.Instance.EditTableBUS(table1);
                    int discount;
                    if (txtDiscount.Text == "")
                    {
                        discount = 0;
                    }
                    else
                    {
                        discount = Convert.ToInt32(txtDiscount.Text);
                    }
                    OrderBUS.Instance.AddNewOrderBUS(table1.Id, account.Id, discount);
                    ShowFLP();
                }
                int fid = (Int32)gridFood.CurrentRow.Cells["ID"].Value;
                OrderBUS.Instance.AddFoodIntoOrderBUS(table1.Id, fid);
                List<OrderDTO> data = OrderBUS.Instance.GetBillInfoBUS(table1.Id);
                int total2 = 0;
                foreach (OrderDTO order in data)
                {
                    total2 += order.Total;
                }
                orderDTOBindingSource.DataSource = data;
                txtTotal.Text = String.Format("{0:#,##0.##}", total2);
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            List<TableDTO> list = TableBUS.Instance.GetAllTableBUS();
            List<Bill> bills = new List<Bill>();
            foreach (DataGridViewRow row in gridOrder.Rows)
            {
                bills.Add(new Bill
                {
                    Food = row.Cells[0].Value.ToString(),
                    Amount = Convert.ToInt32(row.Cells[1].Value.ToString()),
                    Total = Convert.ToInt32(row.Cells[2].Value.ToString())
                });
            };
            int discount;
            try
            {
                discount = Convert.ToInt32(txtDiscount.Text);
                if (discount < 0 || discount > 100)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Giá trị giảm giá phải là số dương lớn hơn hoặc bằng 0 và nhỏ hơn 100 \n", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiscount.Text = "";
                return;
            }
            PrintBill frb = new PrintBill(bills, DateTime.Now.ToString("dd/MM/yyyy"), table.ToString(), lblNameUser.Text.ToString(), txtTotal.Text.ToString(), discount.ToString());
            frb.Show();
            foreach (TableDTO table in list)
            {
                if (table.Name == cbbChangeTable.SelectedItem.ToString())
                {
                    if (table.Status == "Đang có khách")
                    {
                        table.Status = "Trống";
                        TableBUS.Instance.EditTableBUS(table);
                        orderDTOBindingSource.DataSource = null;
                        txtTotal.Text = "";
                        ShowFLP();
                    }
                }
            }

        }
        private void ButInfo_Click(object sender, EventArgs e)
        {
            FormInfo.InfoAccount infoAccount = new FormInfo.InfoAccount(account);
            infoAccount.ShowDialog();
        }
        private void HOME_Load(object sender, EventArgs e)
        {
            ShowDTGFood();
        }
        private void btnAnalytic_Click(object sender, EventArgs e)
        {
            StatisticForm statisticForm = new StatisticForm();
            statisticForm.ShowDialog();
        }
        private void gridOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string NameFood = gridOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (gridOrder.Columns[e.ColumnIndex].Name == "Tang")
            {
                OrderBUS.Instance.AdjustAmountFood(TableBUS.Instance.GetIdTableByName(table), FoodBUS.Instance.GetIdFromName(NameFood), "+");
            }
            else
            {
                OrderBUS.Instance.AdjustAmountFood(TableBUS.Instance.GetIdTableByName(table), FoodBUS.Instance.GetIdFromName(NameFood), "-");
            }

            List<OrderDTO> data = OrderBUS.Instance.GetBillInfoBUS(TableBUS.Instance.GetIdTableByName(table));
            int total = 0;
            foreach (OrderDTO order in data)
            {
                total += order.Total;
            }
            orderDTOBindingSource.DataSource = data;
            if (gridOrder.Rows[e.RowIndex].Cells[1].Value.ToString() == "0")
            {
                OrderBUS.Instance.DelFood(TableBUS.Instance.GetIdTableByName(table), FoodBUS.Instance.GetIdFromName(NameFood));
                List<OrderDTO> data1 = OrderBUS.Instance.GetBillInfoBUS(TableBUS.Instance.GetIdTableByName(table));
                total = 0;
                foreach (OrderDTO order in data1)
                {
                    total += order.Total;
                }
                orderDTOBindingSource.DataSource = data1;
                if (data1.Count == 0)
                {
                    List<TableDTO> list = TableBUS.Instance.GetAllTableBUS();
                    foreach (TableDTO table in list)
                    {
                        if (table.Name == cbbChangeTable.SelectedItem.ToString())
                        {
                            if (table.Status == "Đang có khách")
                            {
                                table.Status = "Trống";
                                TableBUS.Instance.EditTableBUS(table);
                                orderDTOBindingSource.DataSource = null;
                                txtTotal.Text = "";
                                ShowFLP();
                            }
                        }
                    }
                }
            }
            txtTotal.Text = String.Format("{0:#,##0.##}", total);
        }
        public void LoadAllData()
        {
            ShowFLP();
            ShowDTGFood();
            LoadCBB();
            SetCBB();
        }
    }
}
