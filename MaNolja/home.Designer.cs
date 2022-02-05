
namespace manolza
{
    partial class home
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
            this.userMenu = new System.Windows.Forms.MenuStrip();
            this.숙박검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예약내역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.내정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accomMenu = new System.Windows.Forms.MenuStrip();
            this.업체등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예약내역ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.나의업체ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.내정보ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserName = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userMenu.SuspendLayout();
            this.accomMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // userMenu
            // 
            this.userMenu.BackColor = System.Drawing.Color.White;
            this.userMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.숙박검색ToolStripMenuItem,
            this.예약내역ToolStripMenuItem,
            this.내정보ToolStripMenuItem});
            this.userMenu.Location = new System.Drawing.Point(0, 27);
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(1119, 27);
            this.userMenu.TabIndex = 2;
            this.userMenu.Text = "menuStrip3";
            // 
            // 숙박검색ToolStripMenuItem
            // 
            this.숙박검색ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.숙박검색ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.숙박검색ToolStripMenuItem.Name = "숙박검색ToolStripMenuItem";
            this.숙박검색ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.숙박검색ToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.숙박검색ToolStripMenuItem.Tag = "accomList";
            this.숙박검색ToolStripMenuItem.Text = "숙박검색";
            this.숙박검색ToolStripMenuItem.Click += new System.EventHandler(this.숙박검색ToolStripMenuItem_Click);
            // 
            // 예약내역ToolStripMenuItem
            // 
            this.예약내역ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.예약내역ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.예약내역ToolStripMenuItem.Name = "예약내역ToolStripMenuItem";
            this.예약내역ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.예약내역ToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.예약내역ToolStripMenuItem.Text = "예약내역";
            this.예약내역ToolStripMenuItem.Click += new System.EventHandler(this.예약내역ToolStripMenuItem_Click);
            // 
            // 내정보ToolStripMenuItem
            // 
            this.내정보ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.내정보ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.내정보ToolStripMenuItem.Name = "내정보ToolStripMenuItem";
            this.내정보ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.내정보ToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.내정보ToolStripMenuItem.Tag = "myInfo";
            this.내정보ToolStripMenuItem.Text = "내 정보";
            this.내정보ToolStripMenuItem.Click += new System.EventHandler(this.내정보ToolStripMenuItem_Click);
            // 
            // accomMenu
            // 
            this.accomMenu.BackColor = System.Drawing.Color.White;
            this.accomMenu.GripMargin = new System.Windows.Forms.Padding(2);
            this.accomMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.업체등록ToolStripMenuItem,
            this.나의업체ToolStripMenuItem,
            this.예약내역ToolStripMenuItem1,
            this.내정보ToolStripMenuItem1});
            this.accomMenu.Location = new System.Drawing.Point(0, 0);
            this.accomMenu.Name = "accomMenu";
            this.accomMenu.Size = new System.Drawing.Size(1119, 27);
            this.accomMenu.TabIndex = 3;
            this.accomMenu.Text = "menuStrip4";
            // 
            // 업체등록ToolStripMenuItem
            // 
            this.업체등록ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.업체등록ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.업체등록ToolStripMenuItem.Name = "업체등록ToolStripMenuItem";
            this.업체등록ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.업체등록ToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.업체등록ToolStripMenuItem.Tag = "accomAdd";
            this.업체등록ToolStripMenuItem.Text = "업체등록";
            this.업체등록ToolStripMenuItem.Click += new System.EventHandler(this.업체등록ToolStripMenuItem_Click);
            // 
            // 예약내역ToolStripMenuItem1
            // 
            this.예약내역ToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.예약내역ToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.예약내역ToolStripMenuItem1.Name = "예약내역ToolStripMenuItem1";
            this.예약내역ToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.예약내역ToolStripMenuItem1.Size = new System.Drawing.Size(73, 23);
            this.예약내역ToolStripMenuItem1.Text = "예약확인";
            this.예약내역ToolStripMenuItem1.Click += new System.EventHandler(this.예약내역ToolStripMenuItem1_Click);
            // 
            // 나의업체ToolStripMenuItem
            // 
            this.나의업체ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.나의업체ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.나의업체ToolStripMenuItem.Name = "나의업체ToolStripMenuItem";
            this.나의업체ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.나의업체ToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.나의업체ToolStripMenuItem.Tag = "myAccom";
            this.나의업체ToolStripMenuItem.Text = "나의업체";
            this.나의업체ToolStripMenuItem.Click += new System.EventHandler(this.나의업체ToolStripMenuItem_Click);
            // 
            // 내정보ToolStripMenuItem1
            // 
            this.내정보ToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.내정보ToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.내정보ToolStripMenuItem1.Name = "내정보ToolStripMenuItem1";
            this.내정보ToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.내정보ToolStripMenuItem1.Size = new System.Drawing.Size(65, 23);
            this.내정보ToolStripMenuItem1.Text = "내 정보";
            this.내정보ToolStripMenuItem1.Click += new System.EventHandler(this.내정보ToolStripMenuItem1_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.White;
            this.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserName.Location = new System.Drawing.Point(947, 6);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(161, 15);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "ㅇㅇㅇㅇㅇㅇ님, 환영합니다.";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 23);
            this.toolStripMenuItem1.Tag = "accomList";
            this.toolStripMenuItem1.Text = "숙박검색";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.숙박검색ToolStripMenuItem_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1119, 749);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.userMenu);
            this.Controls.Add(this.accomMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.Name = "home";
            this.Text = "마놀자";
            this.Load += new System.EventHandler(this.home_Load);
            this.userMenu.ResumeLayout(false);
            this.userMenu.PerformLayout();
            this.accomMenu.ResumeLayout(false);
            this.accomMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip userMenu;
        private System.Windows.Forms.ToolStripMenuItem 숙박검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예약내역ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 내정보ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip accomMenu;
        private System.Windows.Forms.ToolStripMenuItem 업체등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예약내역ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 나의업체ToolStripMenuItem;
        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ToolStripMenuItem 내정보ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}