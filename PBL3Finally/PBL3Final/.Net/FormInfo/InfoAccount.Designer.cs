namespace PBL3.FormInfo
{
    partial class InfoAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlChoose = new System.Windows.Forms.Panel();
            this.pnlSubSecurity = new System.Windows.Forms.Panel();
            this.btnChangeEmail = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.pnlView = new System.Windows.Forms.Panel();
            this.pnlChoose.SuspendLayout();
            this.pnlSubSecurity.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChoose
            // 
            this.pnlChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.pnlChoose.Controls.Add(this.pnlSubSecurity);
            this.pnlChoose.Controls.Add(this.btnSecurity);
            this.pnlChoose.Controls.Add(this.btnGeneral);
            this.pnlChoose.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlChoose.Location = new System.Drawing.Point(0, 0);
            this.pnlChoose.Name = "pnlChoose";
            this.pnlChoose.Size = new System.Drawing.Size(200, 399);
            this.pnlChoose.TabIndex = 0;
            // 
            // pnlSubSecurity
            // 
            this.pnlSubSecurity.Controls.Add(this.btnChangeEmail);
            this.pnlSubSecurity.Controls.Add(this.btnChangePassword);
            this.pnlSubSecurity.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubSecurity.Location = new System.Drawing.Point(0, 140);
            this.pnlSubSecurity.Name = "pnlSubSecurity";
            this.pnlSubSecurity.Size = new System.Drawing.Size(200, 247);
            this.pnlSubSecurity.TabIndex = 2;
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.btnChangeEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangeEmail.FlatAppearance.BorderSize = 0;
            this.btnChangeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChangeEmail.Location = new System.Drawing.Point(0, 70);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnChangeEmail.Size = new System.Drawing.Size(200, 70);
            this.btnChangeEmail.TabIndex = 3;
            this.btnChangeEmail.Text = "Thay đổi email";
            this.btnChangeEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeEmail.UseVisualStyleBackColor = false;
            this.btnChangeEmail.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 0);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(200, 70);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Thay đổi mật khẩu";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnSecurity
            // 
            this.btnSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.btnSecurity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecurity.FlatAppearance.BorderSize = 0;
            this.btnSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurity.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecurity.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSecurity.Image = global::PBL3.Properties.Resources.shield_2_32;
            this.btnSecurity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurity.Location = new System.Drawing.Point(0, 70);
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSecurity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSecurity.Size = new System.Drawing.Size(200, 70);
            this.btnSecurity.TabIndex = 1;
            this.btnSecurity.Text = "Bảo mật";
            this.btnSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSecurity.UseVisualStyleBackColor = false;
            this.btnSecurity.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.btnGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneral.FlatAppearance.BorderSize = 0;
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGeneral.Image = global::PBL3.Properties.Resources.settings_21_32;
            this.btnGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneral.Location = new System.Drawing.Point(0, 0);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGeneral.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGeneral.Size = new System.Drawing.Size(200, 70);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "Tổng quan";
            this.btnGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // pnlView
            // 
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(200, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(614, 399);
            this.pnlView.TabIndex = 1;
            // 
            // InfoAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 399);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlChoose);
            this.Name = "InfoAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoAccount";
            this.pnlChoose.ResumeLayout(false);
            this.pnlSubSecurity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChoose;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnSecurity;
        private System.Windows.Forms.Panel pnlSubSecurity;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnChangeEmail;
        private System.Windows.Forms.Panel pnlView;
    }
}