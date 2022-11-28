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
    public partial class ChangePassword : Form
    {
        private AccountDTO account;
        public AccountDTO Account
        {
            get { return account; }
            set { account = value; }
        }
        public ChangePassword(AccountDTO account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string oldPass = AccountBUS.Instance.EncryptPassword(txtOldPass.Text.ToString());
            if (txtOldPass.Text != "" && txtNewPass.Text != "" && txtConfirmPass.Text != "")
            {
                if (oldPass == account.Password)
                {
                    if (txtNewPass.Text == txtConfirmPass.Text)
                    {
                        string newPass = AccountBUS.Instance.EncryptPassword(txtNewPass.Text.ToString());
                        account.Password = newPass;
                        AccountBUS.Instance.ChangePassWordAccountBUS(account);
                        MessageBox.Show("Thay đổi mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu nhập lại không trùng mật khẩu mới.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ các thông tin trên để đổi mật khẩu.");
            }
        }
    }
}
