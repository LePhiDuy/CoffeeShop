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
    public partial class InfoAccount : Form
    {
        private Form ActiveForm;
        private AccountDTO account;
        public AccountDTO Account
        {
            get { return account; }
            set { account = value; }
        }
        public InfoAccount(AccountDTO account)
        {
            InitializeComponent();
            CustomizeDesing();
            this.account = account;
            FirstLoad();
        }
        private void FirstLoad()
        {
            btnGeneral.BackColor = Color.FromArgb(3, 11, 36);
            OpenChildForm(new InfoPersonal(account));
        }
        private void CustomizeDesing()
        {
            pnlSubSecurity.Visible = false;
        }
        private void HideSubMenu()
        {
            pnlSubSecurity.Visible = false;
        }
        private void ShowSubMenuSecurity(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void ResetButtonBackColor()
        {
            foreach (object item in this.pnlChoose.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).BackColor = Color.FromArgb(24, 38, 57);
                }
            }
        }
        private void Buttons_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Bảo mật")
            {
                ResetButtonBackColor();
                ((Button)sender).BackColor = Color.FromArgb(3, 11, 36);
                ShowSubMenuSecurity(pnlSubSecurity);
            }
            if (((Button)sender).Text == "Tổng quan")
            {
                HideSubMenu();
                ResetButtonBackColor();
                ((Button)sender).BackColor = Color.FromArgb(3, 11, 36);
                OpenChildForm(new InfoPersonal(account));
            }
            if (((Button)sender).Text == "Thay đổi mật khẩu")
            {
                OpenChildForm(new ChangePassword(account));
            }
            if (((Button)sender).Text == "Thay đổi email")
            {
                OpenChildForm(new ChangeEmail(account));
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlView.Controls.Add(childForm);
            pnlView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
    
}
