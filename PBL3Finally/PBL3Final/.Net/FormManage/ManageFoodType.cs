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

namespace PBL3.FormManage
{
    public partial class ManageFoodType : Form
    {
        public ManageFoodType()
        {
            InitializeComponent();
            ShowDTGFoodType();
            SetAttributeNotEnabled();
        }
        public void ShowDTGFoodType()
        {
            string nameFoodType = txtSearch.Text;
            gridFoodType.DataSource = FoodTypeBUS.Instance.ConvertToDataTableFoodType(nameFoodType);
            gridFoodType.Columns[1].Visible = false;
        }
        private void ManageFoodType_Load(object sender, EventArgs e)
        {
            ShowDTGFoodType();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Text = FoodTypeBUS.Instance.GetIdToAddBUS().ToString();
            txtID.Enabled = false;
            txtName.Enabled = true;
            txtName.Text = "";
            btnOK.Enabled = true;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridFoodType.SelectedRows.Count == 1)
            {
                txtID.Text = gridFoodType.CurrentRow.Cells["ID"].Value.ToString();
                txtID.Enabled = false;
                txtName.Text = gridFoodType.CurrentRow.Cells["Tên loại món ăn"].Value.ToString();
                txtName.Enabled = true;
                btnOK.Enabled = true;
            } else
            {
                MessageBox.Show("Vui lòng chọn 1 loại món để chỉnh sửa");
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (gridFoodType.SelectedRows.Count > 0)
            {
                DialogResult dlgConfirm = MessageBox.Show("Bạn có muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dlgConfirm == DialogResult.Yes)
                {
                    List<int> listFoodTypeDel = new List<int>();
                    foreach (DataGridViewRow i in gridFoodType.SelectedRows)
                    {
                        listFoodTypeDel.Add(Convert.ToInt32(i.Cells["ID"].Value));
                    }
                    if (FoodTypeBUS.Instance.DeleteFoodTypeBUS(listFoodTypeDel))
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    ShowDTGFoodType();
                }
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string name = txtName.Text.ToString();
            if (name == "")
            {
                MessageBox.Show("Tên loại món không được để trống. \n",
                                "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FoodTypeDTO foodType = new FoodTypeDTO(id, name);
            MessageBox.Show(FoodTypeBUS.Instance.ExecuteDB(foodType));
            ShowDTGFoodType();
            txtID.Text = "";
            txtName.Text = "";
            SetAttributeNotEnabled();
        }
        public void SetAttributeNotEnabled()
        {
            txtID.Enabled = false;
            txtName.Enabled = false;
            btnOK.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowDTGFoodType();
        }
    }
}
