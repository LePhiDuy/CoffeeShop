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
    public partial class FormManage : Form
    {
        private Form ActiveForm;
        public delegate void MyDel();
        public MyDel d;
        public FormManage()
        {
            InitializeComponent();
            FirstLoad();
            CustomizeDesing();
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
        private void FirstLoad()
        {
            OpenChildForm(new ManageAccount());
            btnManageAccount.BackColor = Color.FromArgb(3, 11, 36);
        }
        private void Buttons_Click(object sender, EventArgs e)
        {
           
                if (((Button)sender).Text == "QUẢN LÝ TÀI KHOẢN")
                {
                    ResetButtonBackColor();
                    ((Button)sender).BackColor = Color.FromArgb(3, 11, 36);
                    OpenChildForm(new ManageAccount());
                    HideSubMenu();
                }
                if (((Button)sender).Text == "QUẢN LÝ BÀN ")
                {
                    ResetButtonBackColor();
                    ((Button)sender).BackColor = Color.FromArgb(3, 11, 36);
                    OpenChildForm(new ManageTable());
                    HideSubMenu();
                }
                if (((Button)sender).Text == "QUẢN LÝ THỰC ĐƠN")
                {
                    ResetButtonBackColor();
                    ((Button)sender).BackColor = Color.FromArgb(3, 11, 36);
                    ShowSubMenuFood(panelSubFood);
                }
                if (((Button)sender).Text == "DANH SÁCH")
                {
                    OpenChildForm(new ManageFood());
                }
                if (((Button)sender).Text == "LOẠI MÓN")
                {
                    OpenChildForm(new ManageFoodType());
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
        private void CustomizeDesing()
        {
            panelSubFood.Visible = false;
        }
        private void HideSubMenu()
        {
            panelSubFood.Visible = false;
        }
        private void ShowSubMenuFood(Panel subMenu)
        {
            if(!subMenu.Visible)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void FormManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            d();
        }
    }
}
