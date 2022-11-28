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

namespace PBL3.FormInfo
{
    public partial class InfoPersonal : Form
    {
        PEOPLE_INFODTO peopleInfo = null;
        private AccountDTO account;
        public AccountDTO Account
        {
            get { return account; }
            set { account = value; }
        }
        public InfoPersonal(AccountDTO account)
        {
            InitializeComponent();
            this.account = account;
            Load();
        }
        public void Load()
        {
            foreach (PEOPLE_INFODTO item in PEOPLE_INFOBUS.Instance.GetPeopleInfoByIdAccountBUS(account.Id))
            {
                peopleInfo = item;
            }
            txtAddress.Text = peopleInfo.Address;
            txtPhone.Text = peopleInfo.Phone;
            txtName.Text = peopleInfo.FullName;
            if (peopleInfo.Gender)
            {
                rdMale.Checked = true;
            }
            else
            {
                rdFemale.Checked = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text != "" && txtPhone.Text != "" && txtName.Text != "")
            {
                DialogResult dlgConfirm = MessageBox.Show("Bạn có muốn lưu hay không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (dlgConfirm == DialogResult.OK)
                {
                    peopleInfo.Id = 1;
                    peopleInfo.FullName = txtName.Text.ToString();
                    peopleInfo.Gender = rdMale.Checked;
                    peopleInfo.Address = txtAddress.Text.ToString();
                    peopleInfo.Phone = txtPhone.Text.ToString();
                    PEOPLE_INFOBUS.Instance.EditPeopleInfoBUS(peopleInfo);
                    MessageBox.Show("Lưu thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để lưu.");
            }
        }
    }
}
