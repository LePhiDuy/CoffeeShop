using BUS;
using System;
using System.Windows.Forms;
using BUS;
using System.Drawing;

namespace PBL3
{
    public partial class FormFrgtPw : Form
    {
        public FormFrgtPw()
        {
            InitializeComponent();
        }
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (AccountBUS.Instance.ForgetPasswordBUS(textBoxEmail.Text))
            {
                MessageBox.Show("Mật khẩu mới đã được gửi đến mail của bạn!");
                this.Close();
            }
            else { MessageBox.Show("Mail không hợp lệ!"); }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TextBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "abc@gmail.com")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }
        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "abc@gmail.com";
                textBoxEmail.ForeColor = Color.Silver;
            }
        }
    }
}
