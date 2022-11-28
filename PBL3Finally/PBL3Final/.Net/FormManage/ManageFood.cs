using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace PBL3.FormManage
{
    public partial class ManageFood : Form
    {
        public ManageFood()
        {
            InitializeComponent();
            SetCBB();
            ShowDTGFood();
            SetAttributeNotEnable();
        }
        public void SetCBB()
        {
            cbbFoodTypeView.Items.Clear();
            cbbFoodTypeAdd.Items.Clear();
            cbbFoodTypeView.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbFoodTypeView.Items.AddRange(FoodTypeBUS.Instance.GetAllCBBItem().ToArray());
            cbbFoodTypeAdd.Items.AddRange(FoodTypeBUS.Instance.GetAllCBBItem().ToArray());
            cbbFoodTypeView.SelectedIndex = 0;
        }
        public void ShowDTGFood()
        {
            int foodTypeID = ((CBBItem)cbbFoodTypeView.SelectedItem).Value;
            string valueSearch = txtSearch.Text.ToString();
            gridFood.DataSource = FoodBUS.Instance.ConvertToDataTable(foodTypeID, valueSearch);
            gridFood.Columns[1].Visible = false;
            gridFood.Columns[3].DefaultCellStyle.Format = "#,####.####";
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridFood.SelectedRows.Count == 1)
            {
                txtID.Text = gridFood.CurrentRow.Cells["ID"].Value.ToString();
                txtName.Text = gridFood.CurrentRow.Cells["Tên món"].Value.ToString();
                txtName.Enabled = true;
                cbbFoodTypeAdd.Text = gridFood.CurrentRow.Cells["Loại món"].Value.ToString();
                cbbFoodTypeAdd.Enabled = true;
                txtPrice.Text = String.Format("{0:#,##0.##}", gridFood.CurrentRow.Cells["Giá tiền"].Value);
                txtPrice.Enabled = true;
                btnOK.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 món để chỉnh sửa");
            }
        }
        private void ManageFood_Load(object sender, EventArgs e)
        {
            ShowDTGFood();
        }
        private void cbbFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDTGFood();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowDTGFood();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Text = FoodBUS.Instance.getIdToAddBUS().ToString();
            txtName.Enabled = true;
            txtName.Text = "";
            cbbFoodTypeAdd.Enabled = true;
            cbbFoodTypeAdd.Text = "";
            txtPrice.Enabled = true;
            txtPrice.Text = "";
            btnOK.Enabled = true;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (gridFood.SelectedRows.Count > 0)
            {
                DialogResult dlgConfirm = MessageBox.Show("Bạn có muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dlgConfirm == DialogResult.Yes)
                {
                    List<int> listFoodDel = new List<int>();
                    foreach (DataGridViewRow i in gridFood.SelectedRows)
                    {
                        listFoodDel.Add(Convert.ToInt32(i.Cells["ID"].Value));
                    }
                    if (FoodBUS.Instance.DeleteFoodBUS(listFoodDel))
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    ShowDTGFood();
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            double price = 0;
            string name = "";
            int idFoodType = 0;
            try
            {
                name = txtName.Text.ToString();
                idFoodType = ((CBBItem)cbbFoodTypeAdd.SelectedItem).Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi nhấn OK. \n",
                                "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                price = Convert.ToDouble(txtPrice.Text);
                if (price <= 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Đơn giá phải là số dương. \n", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Text = "";
                return;
            }
            FoodDTO food = new FoodDTO(id, name, idFoodType, price);
            MessageBox.Show(FoodBUS.Instance.ExecuteDB(food));
            ShowDTGFood();
            txtID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            cbbFoodTypeAdd.Text = "";
            SetAttributeNotEnable();
        }
        private void SetAttributeNotEnable()
        {
            txtID.Enabled = false;
            txtName.Enabled = false;
            cbbFoodTypeAdd.Enabled = false;
            txtPrice.Enabled = false;
            btnOK.Enabled = false;
        }
    }
}
