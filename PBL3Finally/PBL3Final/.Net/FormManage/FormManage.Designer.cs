namespace PBL3.FormManage
{
    partial class FormManage
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
            this.panelSubFood = new System.Windows.Forms.Panel();
            this.btnManageTypeFood = new System.Windows.Forms.Button();
            this.btnManageFood = new System.Windows.Forms.Button();
            this.btnManageMenu = new System.Windows.Forms.Button();
            this.btnManageTable = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.pnlView = new System.Windows.Forms.Panel();
            this.pnlChoose.SuspendLayout();
            this.panelSubFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChoose
            // 
            this.pnlChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.pnlChoose.Controls.Add(this.panelSubFood);
            this.pnlChoose.Controls.Add(this.btnManageMenu);
            this.pnlChoose.Controls.Add(this.btnManageTable);
            this.pnlChoose.Controls.Add(this.btnManageAccount);
            this.pnlChoose.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlChoose.Location = new System.Drawing.Point(0, 0);
            this.pnlChoose.Name = "pnlChoose";
            this.pnlChoose.Size = new System.Drawing.Size(287, 681);
            this.pnlChoose.TabIndex = 0;
            // 
            // panelSubFood
            // 
            this.panelSubFood.Controls.Add(this.btnManageTypeFood);
            this.panelSubFood.Controls.Add(this.btnManageFood);
            this.panelSubFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubFood.Location = new System.Drawing.Point(0, 216);
            this.panelSubFood.Name = "panelSubFood";
            this.panelSubFood.Size = new System.Drawing.Size(287, 143);
            this.panelSubFood.TabIndex = 3;
            // 
            // btnManageTypeFood
            // 
            this.btnManageTypeFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btnManageTypeFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageTypeFood.FlatAppearance.BorderSize = 0;
            this.btnManageTypeFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageTypeFood.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTypeFood.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManageTypeFood.Location = new System.Drawing.Point(0, 70);
            this.btnManageTypeFood.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageTypeFood.Name = "btnManageTypeFood";
            this.btnManageTypeFood.Size = new System.Drawing.Size(287, 73);
            this.btnManageTypeFood.TabIndex = 1;
            this.btnManageTypeFood.Text = "LOẠI MÓN";
            this.btnManageTypeFood.UseVisualStyleBackColor = false;
            this.btnManageTypeFood.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnManageFood
            // 
            this.btnManageFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btnManageFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageFood.FlatAppearance.BorderSize = 0;
            this.btnManageFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageFood.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageFood.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManageFood.Location = new System.Drawing.Point(0, 0);
            this.btnManageFood.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageFood.Name = "btnManageFood";
            this.btnManageFood.Size = new System.Drawing.Size(287, 70);
            this.btnManageFood.TabIndex = 0;
            this.btnManageFood.Text = "DANH SÁCH";
            this.btnManageFood.UseVisualStyleBackColor = false;
            this.btnManageFood.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnManageMenu
            // 
            this.btnManageMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageMenu.FlatAppearance.BorderSize = 0;
            this.btnManageMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMenu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManageMenu.Image = global::PBL3.Properties.Resources.hamburger_48;
            this.btnManageMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageMenu.Location = new System.Drawing.Point(0, 144);
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Size = new System.Drawing.Size(287, 72);
            this.btnManageMenu.TabIndex = 2;
            this.btnManageMenu.Text = "QUẢN LÝ THỰC ĐƠN";
            this.btnManageMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageMenu.UseVisualStyleBackColor = true;
            this.btnManageMenu.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnManageTable
            // 
            this.btnManageTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageTable.FlatAppearance.BorderSize = 0;
            this.btnManageTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageTable.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManageTable.Image = global::PBL3.Properties.Resources.table_48;
            this.btnManageTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageTable.Location = new System.Drawing.Point(0, 72);
            this.btnManageTable.Name = "btnManageTable";
            this.btnManageTable.Size = new System.Drawing.Size(287, 72);
            this.btnManageTable.TabIndex = 1;
            this.btnManageTable.Text = "QUẢN LÝ BÀN ";
            this.btnManageTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageTable.UseVisualStyleBackColor = true;
            this.btnManageTable.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageAccount.FlatAppearance.BorderSize = 0;
            this.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAccount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccount.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManageAccount.Image = global::PBL3.Properties.Resources.manager_48;
            this.btnManageAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAccount.Location = new System.Drawing.Point(0, 0);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(287, 72);
            this.btnManageAccount.TabIndex = 0;
            this.btnManageAccount.Text = "QUẢN LÝ TÀI KHOẢN";
            this.btnManageAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageAccount.UseVisualStyleBackColor = true;
            this.btnManageAccount.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // pnlView
            // 
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(287, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(977, 681);
            this.pnlView.TabIndex = 1;
            // 
            // FormManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlChoose);
            this.Name = "FormManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManage_FormClosed);
            this.pnlChoose.ResumeLayout(false);
            this.panelSubFood.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChoose;
        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Button btnManageTable;
        private System.Windows.Forms.Button btnManageMenu;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Panel panelSubFood;
        private System.Windows.Forms.Button btnManageTypeFood;
        private System.Windows.Forms.Button btnManageFood;
    }
}