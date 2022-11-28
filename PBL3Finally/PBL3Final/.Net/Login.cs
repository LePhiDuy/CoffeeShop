using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace PBL3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string passWord = txtPass.Text;
            AccountDTO account = new AccountDTO(userName, passWord);
            if (userName == "" || passWord == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu\nXin hãy nhập tài khoản và mật khẩu");
                txtUser.Focus();
            }
            
            else if (CheckLoginGUI(account))
            {
                AccountDTO acc = null;
                foreach (AccountDTO item in AccountBUS.Instance.GetAllAccountByUsernameBUS(userName))
                {
                    acc = item;
                }
                userName = "";
                passWord= "";
                HOME home = new HOME(CheckRole(account),acc);
                home.LoginForm = ShowFormLogin;
                home.Show();
                txtUser.Text = "";
                txtPass.Text = "";
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                txtUser.Focus();
            }
            
        }
        public void ShowFormLogin()
        {
            this.Show();
        }
        public bool CheckLoginGUI(AccountDTO account)
        {
            return AccountBUS.Instance.CheckLoginBUS(account);
        }
        public bool CheckRole(AccountDTO account)
        {
            return AccountBUS.Instance.CheckRoleBUS(account);
        }
        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // nút ẩn mật khẩu
        private void butHidePass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                butShowPass.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }
        
        // nút hiện mật khẩu
        private void butShowPass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                butHidePass.BringToFront();
                txtPass.PasswordChar = '*';
            }

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

        private void labelFrgtPw_Click(object sender, EventArgs e)
        {
            FormFrgtPw f= new FormFrgtPw();
            f.ShowDialog();
        }
    }
}
