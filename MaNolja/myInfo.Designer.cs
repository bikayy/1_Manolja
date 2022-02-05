
namespace manolza
{
    partial class myInfo
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserPhone = new System.Windows.Forms.Label();
            this.lblUserPw2 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheckName = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.txtUserNewPw2 = new System.Windows.Forms.TextBox();
            this.txtUserCurPw = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblUserPw = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUserNewPw = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserName.ForeColor = System.Drawing.Color.Red;
            this.lblUserName.Location = new System.Drawing.Point(121, 410);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(150, 15);
            this.lblUserName.TabIndex = 44;
            this.lblUserName.Text = "형식이 올바르지 않습니다.";
            this.lblUserName.Visible = false;
            // 
            // lblUserPhone
            // 
            this.lblUserPhone.AutoSize = true;
            this.lblUserPhone.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserPhone.ForeColor = System.Drawing.Color.Red;
            this.lblUserPhone.Location = new System.Drawing.Point(121, 351);
            this.lblUserPhone.Name = "lblUserPhone";
            this.lblUserPhone.Size = new System.Drawing.Size(150, 15);
            this.lblUserPhone.TabIndex = 43;
            this.lblUserPhone.Text = "형식이 올바르지 않습니다.";
            this.lblUserPhone.Visible = false;
            // 
            // lblUserPw2
            // 
            this.lblUserPw2.AutoSize = true;
            this.lblUserPw2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserPw2.ForeColor = System.Drawing.Color.Red;
            this.lblUserPw2.Location = new System.Drawing.Point(121, 286);
            this.lblUserPw2.Name = "lblUserPw2";
            this.lblUserPw2.Size = new System.Drawing.Size(214, 15);
            this.lblUserPw2.TabIndex = 42;
            this.lblUserPw2.Text = "입력한 비밀번호와 일치하지 않습니다.";
            this.lblUserPw2.Visible = false;
            this.lblUserPw2.TextChanged += new System.EventHandler(this.txtUserPw_TextChanged);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(251, 463);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(108, 38);
            this.btnCancle.TabIndex = 8;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.Location = new System.Drawing.Point(64, 463);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 38);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Tag = "";
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(354, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 11);
            this.label8.TabIndex = 37;
            this.label8.Text = "1~6자";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(283, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 11);
            this.label7.TabIndex = 36;
            this.label7.Text = "(-) 포함하여 작성";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(283, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 11);
            this.label6.TabIndex = 35;
            this.label6.Text = "6~12자";
            // 
            // btnCheckName
            // 
            this.btnCheckName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckName.Location = new System.Drawing.Point(285, 382);
            this.btnCheckName.Name = "btnCheckName";
            this.btnCheckName.Size = new System.Drawing.Size(68, 25);
            this.btnCheckName.TabIndex = 6;
            this.btnCheckName.Tag = "";
            this.btnCheckName.Text = "중복확인";
            this.btnCheckName.UseVisualStyleBackColor = true;
            this.btnCheckName.Click += new System.EventHandler(this.btnCheckName_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserName.Location = new System.Drawing.Point(123, 382);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(156, 25);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(72, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "닉네임";
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserPhone.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUserPhone.Location = new System.Drawing.Point(122, 318);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(156, 25);
            this.txtUserPhone.TabIndex = 4;
            this.txtUserPhone.TextChanged += new System.EventHandler(this.txtUserPhone_TextChanged);
            // 
            // txtUserNewPw2
            // 
            this.txtUserNewPw2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserNewPw2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUserNewPw2.Location = new System.Drawing.Point(122, 258);
            this.txtUserNewPw2.Name = "txtUserNewPw2";
            this.txtUserNewPw2.PasswordChar = '*';
            this.txtUserNewPw2.Size = new System.Drawing.Size(156, 25);
            this.txtUserNewPw2.TabIndex = 3;
            this.txtUserNewPw2.TextChanged += new System.EventHandler(this.txtUserPw_TextChanged);
            // 
            // txtUserCurPw
            // 
            this.txtUserCurPw.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserCurPw.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUserCurPw.Location = new System.Drawing.Point(122, 138);
            this.txtUserCurPw.Name = "txtUserCurPw";
            this.txtUserCurPw.PasswordChar = '*';
            this.txtUserCurPw.Size = new System.Drawing.Size(156, 25);
            this.txtUserCurPw.TabIndex = 1;
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserId.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUserId.Location = new System.Drawing.Point(122, 83);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(157, 25);
            this.txtUserId.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(59, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "전화번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(28, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "비밀번호 확인";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(28, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "현재 비밀번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(72, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "아이디";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(164, 30);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 25);
            this.label23.TabIndex = 45;
            this.label23.Text = "내 정보";
            // 
            // lblUserPw
            // 
            this.lblUserPw.AutoSize = true;
            this.lblUserPw.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserPw.ForeColor = System.Drawing.Color.Red;
            this.lblUserPw.Location = new System.Drawing.Point(121, 227);
            this.lblUserPw.Name = "lblUserPw";
            this.lblUserPw.Size = new System.Drawing.Size(150, 15);
            this.lblUserPw.TabIndex = 49;
            this.lblUserPw.Text = "형식이 올바르지 않습니다.";
            this.lblUserPw.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(283, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 11);
            this.label10.TabIndex = 48;
            this.label10.Text = "6~12자";
            // 
            // txtUserNewPw
            // 
            this.txtUserNewPw.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserNewPw.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUserNewPw.Location = new System.Drawing.Point(122, 199);
            this.txtUserNewPw.Name = "txtUserNewPw";
            this.txtUserNewPw.PasswordChar = '*';
            this.txtUserNewPw.Size = new System.Drawing.Size(156, 25);
            this.txtUserNewPw.TabIndex = 2;
            this.txtUserNewPw.TextChanged += new System.EventHandler(this.txtUserPw_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(38, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 47;
            this.label11.Text = "새 비밀번호";
            // 
            // myInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 517);
            this.Controls.Add(this.lblUserPw);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUserNewPw);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblUserPhone);
            this.Controls.Add(this.lblUserPw2);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCheckName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserPhone);
            this.Controls.Add(this.txtUserNewPw2);
            this.Controls.Add(this.txtUserCurPw);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "myInfo";
            this.Text = "내 정보";
            this.Load += new System.EventHandler(this.myInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserPhone;
        private System.Windows.Forms.Label lblUserPw2;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCheckName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.TextBox txtUserNewPw2;
        private System.Windows.Forms.TextBox txtUserCurPw;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblUserPw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUserNewPw;
        private System.Windows.Forms.Label label11;
    }
}