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
    public partial class ChangeEmail : Form
    {
        PEOPLE_INFODTO peopleInfo = null;
        string code = null;
        private AccountDTO account;
        public AccountDTO Account
        {
            get { return account; }
            set { account = value; }
        }
        public ChangeEmail(AccountDTO account )
        {
            InitializeComponent();
            this.account = account;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtCode.Text != "")
            {
                if(txtCode.Text.ToString() == code)
                {
                    peopleInfo.Email = txtEmail.Text.ToString();
                    PEOPLE_INFOBUS.Instance.ChangeEmailDAL(peopleInfo);
                    MessageBox.Show("Đổi email thành công.");
                }
                else
                {
                    MessageBox.Show("Nhập sai mã xác nhận");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đẩy đủ thông tin để đổi email");
            }
        }

        private void ChangeEmail_Load(object sender, EventArgs e)
        {
            foreach (PEOPLE_INFODTO item in PEOPLE_INFOBUS.Instance.GetPeopleInfoByIdAccountBUS(account.Id))
            {
                peopleInfo = item;
            }
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            code = AccountBUS.Instance.GenerateNewCode(peopleInfo.Email);
            MessageBox.Show("Mã đã được gởi vào email của bạn.");
        }
    }
}
