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
    public partial class ManageTable : Form
    {
        public ManageTable()
        {
            InitializeComponent();
            SetAttributeNotEnable();
        }
        public void ShowDTGTable()
        {
            string valueSearch = txtSearch.Text;
            gridTable.DataSource = TableBUS.Instance.ConvertToDataTable(valueSearch);
            gridTable.Columns[1].Visible = false;
        }
        private void ManageTable_Load(object sender, EventArgs e)
        {
            ShowDTGTable();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Text = TableBUS.Instance.GetIdToAddBUS().ToString();
            txtName.Enabled = true;
            txtName.Text = "";
            cbbStt.SelectedIndex = 0;
            cbbStt.Enabled = false;
            btnOK.Enabled = true;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridTable.SelectedRows.Count == 1)
            {
                txtID.Text = gridTable.CurrentRow.Cells["Mã bàn "].Value.ToString();
                txtName.Text = gridTable.CurrentRow.Cells["Tên bàn"].Value.ToString();
                txtName.Enabled = true;
                cbbStt.Text = gridTable.CurrentRow.Cells["Trạng thái"].Value.ToString();
                btnOK.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 bàn để chỉnh sửa");
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string name = txtName.Text.ToString();
            if (name == "")
            {
                MessageBox.Show("Tên bàn không được để trống. \n",
                                "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string status = cbbStt.SelectedItem.ToString();
            TableDTO table = new TableDTO(id, name, status);
            MessageBox.Show(TableBUS.Instance.ExecuteDB(table));
            txtID.Text = "";
            txtName.Text = "";
            SetAttributeNotEnable();
            ShowDTGTable();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (gridTable.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in gridTable.SelectedRows)
                {
                    if (i.Cells["Trạng thái"].Value.ToString() == "Đang có khách")
                    {
                        MessageBox.Show("Bàn đang có khách. Không được xóa ", "Cảnh báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ShowDTGTable();
                        return;
                    }
                }
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                List<int> listTableDel = new List<int>();
                foreach (DataGridViewRow j in gridTable.SelectedRows)
                {
                    listTableDel.Add(Convert.ToInt32(j.Cells["Mã bàn "].Value));
                }
                if (TableBUS.Instance.DeleteTableBUS(listTableDel))
                {
                    MessageBox.Show("Xóa thành công!");
                }
            }
            ShowDTGTable();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowDTGTable();
        }
        private void SetAttributeNotEnable()
        {
            txtID.Enabled = false;
            txtName.Enabled = false;
            cbbStt.Enabled = false;
            btnOK.Enabled = false;
        }
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            ShowDTGTable();
        }
    }
}
