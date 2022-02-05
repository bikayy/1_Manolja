
namespace manolza
{
    partial class join
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtUserPw = new System.Windows.Forms.TextBox();
            this.txtUserPw2 = new System.Windows.Forms.TextBox();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCheckId = new System.Windows.Forms.Button();
            this.btnCheckName = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblUserPw = new System.Windows.Forms.Label();
            this.lblUserPw2 = new System.Windows.Forms.Label();
            this.lblUserPhone = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(36, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "이메일 ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(41, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(10, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호 확인";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(41, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "전화번호";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(202, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 25);
            this.label23.TabIndex = 4;
            this.label23.Text = "회원가입";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserId.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUserId.Location = new System.Drawing.Point(104, 97);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(237, 25);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
            // 
            // txtUserPw
            // 
            this.txtUserPw.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserPw.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUserPw.Location = new System.Drawing.Point(104, 163);
            this.txtUserPw.Name = "txtUserPw";
            this.txtUserPw.PasswordChar = '*';
            this.txtUserPw.Size = new System.Drawing.Size(156, 25);
            this.txtUserPw.TabIndex = 1;
            this.txtUserPw.TextChanged += new System.EventHandler(this.txtUserPw_TextChanged);
            // 
            // txtUserPw2
            // 
            this.txtUserPw2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserPw2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUserPw2.Location = new System.Drawing.Point(104, 233);
            this.txtUserPw2.Name = "txtUserPw2";
            this.txtUserPw2.PasswordChar = '*';
            this.txtUserPw2.Size = new System.Drawing.Size(156, 25);
            this.txtUserPw2.TabIndex = 2;
            this.txtUserPw2.TextChanged += new System.EventHandler(this.txtUserPw2_TextChanged);
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserPhone.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUserPhone.Location = new System.Drawing.Point(104, 292);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(156, 25);
            this.txtUserPhone.TabIndex = 3;
            this.txtUserPhone.TextChanged += new System.EventHandler(this.txtUserPhone_TextChanged);
            this.txtUserPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserPhone_KeyPress);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserName.Location = new System.Drawing.Point(105, 366);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(156, 25);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(54, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "닉네임";
            // 
            // btnCheckId
            // 
            this.btnCheckId.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckId.Location = new System.Drawing.Point(347, 96);
            this.btnCheckId.Name = "btnCheckId";
            this.btnCheckId.Size = new System.Drawing.Size(68, 26);
            this.btnCheckId.TabIndex = 11;
            this.btnCheckId.Text = "중복확인";
            this.btnCheckId.UseVisualStyleBackColor = true;
            this.btnCheckId.Click += new System.EventHandler(this.btnCheckId_Click);
            // 
            // btnCheckName
            // 
            this.btnCheckName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckName.Location = new System.Drawing.Point(267, 366);
            this.btnCheckName.Name = "btnCheckName";
            this.btnCheckName.Size = new System.Drawing.Size(68, 25);
            this.btnCheckName.TabIndex = 12;
            this.btnCheckName.Text = "중복확인";
            this.btnCheckName.UseVisualStyleBackColor = true;
            this.btnCheckName.Click += new System.EventHandler(this.btnCheckName_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(265, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 11);
            this.label6.TabIndex = 13;
            this.label6.Text = "6~12자 영문, 숫자, 특수문자 사용가능";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(265, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 11);
            this.label7.TabIndex = 14;
            this.label7.Text = "(-) 포함하여 작성";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(341, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 11);
            this.label8.TabIndex = 15;
            this.label8.Text = "1~6자리 사용가능";
            // 
            // btnJoin
            // 
            this.btnJoin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnJoin.Location = new System.Drawing.Point(70, 464);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(108, 38);
            this.btnJoin.TabIndex = 16;
            this.btnJoin.Text = "완료";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(257, 464);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(108, 38);
            this.btnCancle.TabIndex = 17;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserId.ForeColor = System.Drawing.Color.Red;
            this.lblUserId.Location = new System.Drawing.Point(103, 125);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(150, 15);
            this.lblUserId.TabIndex = 18;
            this.lblUserId.Text = "형식이 올바르지 않습니다.";
            this.lblUserId.Visible = false;
            // 
            // lblUserPw
            // 
            this.lblUserPw.AutoSize = true;
            this.lblUserPw.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserPw.ForeColor = System.Drawing.Color.Red;
            this.lblUserPw.Location = new System.Drawing.Point(103, 191);
            this.lblUserPw.Name = "lblUserPw";
            this.lblUserPw.Size = new System.Drawing.Size(150, 15);
            this.lblUserPw.TabIndex = 19;
            this.lblUserPw.Text = "형식이 올바르지 않습니다.";
            this.lblUserPw.Visible = false;
            // 
            // lblUserPw2
            // 
            this.lblUserPw2.AutoSize = true;
            this.lblUserPw2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserPw2.ForeColor = System.Drawing.Color.Red;
            this.lblUserPw2.Location = new System.Drawing.Point(103, 261);
            this.lblUserPw2.Name = "lblUserPw2";
            this.lblUserPw2.Size = new System.Drawing.Size(214, 15);
            this.lblUserPw2.TabIndex = 20;
            this.lblUserPw2.Text = "입력한 비밀번호와 일치하지 않습니다.";
            this.lblUserPw2.Visible = false;
            // 
            // lblUserPhone
            // 
            this.lblUserPhone.AutoSize = true;
            this.lblUserPhone.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserPhone.ForeColor = System.Drawing.Color.Red;
            this.lblUserPhone.Location = new System.Drawing.Point(103, 325);
            this.lblUserPhone.Name = "lblUserPhone";
            this.lblUserPhone.Size = new System.Drawing.Size(150, 15);
            this.lblUserPhone.TabIndex = 21;
            this.lblUserPhone.Text = "형식이 올바르지 않습니다.";
            this.lblUserPhone.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserName.ForeColor = System.Drawing.Color.Red;
            this.lblUserName.Location = new System.Drawing.Point(103, 394);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(150, 15);
            this.lblUserName.TabIndex = 22;
            this.lblUserName.Text = "형식이 올바르지 않습니다.";
            this.lblUserName.Visible = false;
            // 
            // join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 530);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblUserPhone);
            this.Controls.Add(this.lblUserPw2);
            this.Controls.Add(this.lblUserPw);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCheckName);
            this.Controls.Add(this.btnCheckId);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserPhone);
            this.Controls.Add(this.txtUserPw2);
            this.Controls.Add(this.txtUserPw);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "join";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.join_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserPw;
        private System.Windows.Forms.TextBox txtUserPw2;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCheckId;
        private System.Windows.Forms.Button btnCheckName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblUserPw;
        private System.Windows.Forms.Label lblUserPw2;
        private System.Windows.Forms.Label lblUserPhone;
        private System.Windows.Forms.Label lblUserName;
    }
}