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
    public partial class ManageAccount : Form
    {
        public ManageAccount()
        {
            InitializeComponent();
            ShowDTG();
            SetAttributeNotEnabled(false);
        }
        public bool status = true;
        public void ResetText()
        {
            txtID.Text = txtAddress.Text = txtPhone.Text = txtUserName.Text = txtName.Text = cbbRole.Text = txtEmail.Text = txtAddress.Text = "";
            rdMale.Checked = rdFemale.Checked = false;
        }
        public void ShowDTG()
        {
            string valueSearch = txtSearch.Text.ToString();
            gridAccount.DataSource = AccountBUS.Instance.ConvertToDataTable(valueSearch);
            gridAccount.Columns[1].Visible = false;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow i in gridAccount.SelectedRows)
            {
                if (HOME.account.Id == Convert.ToInt32(i.Cells["ID"].Value))
                {
                    MessageBox.Show("Không được xóa ! \n" +
                                    "Tài khoản đang được đăng nhập vào hệ thống.", "Cảnh báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ShowDTG();
                    return;
                }
            }
            if (gridAccount.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    List<int> del = new List<int>();
                    foreach (DataGridViewRow i in gridAccount.SelectedRows)
                    {
                        del.Add(Convert.ToInt32(i.Cells["ID"].Value));
                    }
                    if (AccountBUS.Instance.DeleteAccountBUS(del))
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    ShowDTG();
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResetText();
            txtID.Text = AccountBUS.Instance.getIdToAddBUS().ToString();
            SetAttributeNotEnabled(true);
            txtID.Enabled = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            status = false;
            txtID.Text = gridAccount.CurrentRow.Cells[1].Value.ToString();
            txtUserName.Text = gridAccount.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = gridAccount.CurrentRow.Cells[3].Value.ToString();
            if (Convert.ToBoolean(gridAccount.CurrentRow.Cells[4].Value) == true)
            {
                cbbRole.Text = "Admin";
            }
            else
            {
                cbbRole.Text = "User";
            }
            txtName.Text = gridAccount.CurrentRow.Cells[5].Value.ToString();
            if (Convert.ToBoolean(gridAccount.CurrentRow.Cells[6].Value) == true)
            {
                rdMale.Checked = true;
            }
            else
            {
                rdFemale.Checked = true;
            }
            txtAddress.Text = gridAccount.CurrentRow.Cells[7].Value.ToString();
            txtPhone.Text = gridAccount.CurrentRow.Cells[8].Value.ToString();
            SetAttributeNotEnabled(true);
            txtID.Enabled = false;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text != "" && txtUserName.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && cbbRole.Text != "" && txtName.Text != "" && rdMale.Checked != rdFemale.Checked)
            {
                if (status == true)
                {
                    int id = 1;
                    string username = txtUserName.Text.ToString();
                    string email = txtEmail.Text.ToString();
                    if (AccountBUS.Instance.CheckAccountInDatabase(username) == false)
                    {
                        string newpw = AccountBUS.Instance.GenerateNewPassword(email);
                        bool accountType = cbbRole.SelectedText == "Admin" ? true : false;
                        string fullName = txtName.Text.ToString();
                        string address = txtAddress.Text.ToString();
                        string phoneNumber = txtPhone.Text.ToString();
                        bool sex = rdMale.Checked ? true : false;
                        PEOPLE_INFODTO peopleinfo = new PEOPLE_INFODTO(1, 2, fullName, sex, address, phoneNumber, email);
                        AccountDTO account = new AccountDTO(id, username, newpw, accountType);
                        if (AccountBUS.Instance.AddAccountBUS(account) && PEOPLE_INFOBUS.Instance.AddPeopleInfoBUS(peopleinfo))
                        {
                            MessageBox.Show("Thêm thành công");
                            ResetText();
                            SetAttributeNotEnabled(false);
                            ShowDTG();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại tài khoản có tên tài khoản như vậy.");
                    }
                }
                else
                {
                    int id = Convert.ToInt32(txtID.Text);
                    string username = txtUserName.Text.ToString();
                    bool accounttype;
                    if (cbbRole.Text == "admin")
                    {
                        accounttype = true;
                    }
                    else
                    {
                        accounttype = false;
                    }
                    string fullname = txtName.Text.ToString();
                    string address = txtAddress.Text.ToString();
                    string phonenumber = txtPhone.Text.ToString();
                    bool sex;
                    string email = txtEmail.Text.ToString();
                    if (rdMale.Checked)
                    {
                        sex = true;
                    }
                    else
                    {
                        sex = false;
                    }
                    AccountDTO account = new AccountDTO(id, username, "", accounttype);
                    PEOPLE_INFODTO peopleinfo = new PEOPLE_INFODTO(1, id, fullname, sex, address, phonenumber, email);
                    DialogResult f = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel);
                    if (f == DialogResult.OK)
                    {
                        if (AccountBUS.Instance.EditAccountBUS(account) && PEOPLE_INFOBUS.Instance.EditPeopleInfoBUS(peopleinfo))
                        {
                            MessageBox.Show("Sửa thành công");
                            ShowDTG();
                            ResetText();
                        }
                    }
                }
            }
            else
            {
                if (status == true)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin để thêm");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin để sửa");
                }
            }
        }
        public void SetAttributeNotEnabled(bool isEnable)
        {
            txtID.Enabled = isEnable;
            txtName.Enabled = isEnable;
            txtAddress.Enabled = isEnable;
            txtEmail.Enabled = isEnable;
            txtPhone.Enabled = isEnable;
            txtUserName.Enabled = isEnable;
            cbbRole.Enabled = isEnable;
            rdFemale.Enabled = isEnable;
            rdMale.Enabled = isEnable;
            btnOK.Enabled = isEnable;
        }

        private void ManageAccount_Load(object sender, EventArgs e)
        {
            ShowDTG();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowDTG();
        }
    }
}
