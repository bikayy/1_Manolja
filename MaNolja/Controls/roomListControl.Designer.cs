
namespace manolza
{
    partial class roomListControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLendPrice = new System.Windows.Forms.Label();
            this.lblLendTime = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblStayPrice = new System.Windows.Forms.Label();
            this.lblPeople = new System.Windows.Forms.Label();
            this.lblStayCheckinTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStayCheckoutTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlStay = new System.Windows.Forms.Panel();
            this.pnlLend = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRoomCnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlStay.SuspendLayout();
            this.pnlLend.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(18, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 57;
            this.label2.Text = "숙박";
            this.label2.Click += new System.EventHandler(this.btnReserveStay_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "대실";
            this.label1.Click += new System.EventHandler(this.btnReserveLend_Click);
            // 
            // lblLendPrice
            // 
            this.lblLendPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLendPrice.AutoEllipsis = true;
            this.lblLendPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblLendPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLendPrice.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLendPrice.Location = new System.Drawing.Point(133, 11);
            this.lblLendPrice.Name = "lblLendPrice";
            this.lblLendPrice.Size = new System.Drawing.Size(104, 17);
            this.lblLendPrice.TabIndex = 55;
            this.lblLendPrice.Text = "00000원";
            this.lblLendPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLendPrice.Click += new System.EventHandler(this.btnReserveLend_Click);
            // 
            // lblLendTime
            // 
            this.lblLendTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLendTime.AutoSize = true;
            this.lblLendTime.BackColor = System.Drawing.Color.Transparent;
            this.lblLendTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLendTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLendTime.Location = new System.Drawing.Point(83, 12);
            this.lblLendTime.Name = "lblLendTime";
            this.lblLendTime.Size = new System.Drawing.Size(38, 15);
            this.lblLendTime.TabIndex = 54;
            this.lblLendTime.Text = "0시간";
            this.lblLendTime.Click += new System.EventHandler(this.btnReserveLend_Click);
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRoomName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRoomName.Location = new System.Drawing.Point(265, 12);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(25, 20);
            this.lblRoomName.TabIndex = 49;
            this.lblRoomName.Text = "(-)";
            // 
            // lblStayPrice
            // 
            this.lblStayPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStayPrice.AutoEllipsis = true;
            this.lblStayPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblStayPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStayPrice.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStayPrice.Location = new System.Drawing.Point(132, 4);
            this.lblStayPrice.Name = "lblStayPrice";
            this.lblStayPrice.Size = new System.Drawing.Size(107, 17);
            this.lblStayPrice.TabIndex = 52;
            this.lblStayPrice.Text = "00000원";
            this.lblStayPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStayPrice.Click += new System.EventHandler(this.btnReserveStay_Click);
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.lblPeople.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPeople.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPeople.Location = new System.Drawing.Point(263, 38);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(110, 15);
            this.lblPeople.TabIndex = 50;
            this.lblPeople.Text = "기준 -명 / 최대 -명";
            // 
            // lblStayCheckinTime
            // 
            this.lblStayCheckinTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStayCheckinTime.AutoSize = true;
            this.lblStayCheckinTime.BackColor = System.Drawing.Color.Transparent;
            this.lblStayCheckinTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStayCheckinTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStayCheckinTime.Location = new System.Drawing.Point(85, 5);
            this.lblStayCheckinTime.Name = "lblStayCheckinTime";
            this.lblStayCheckinTime.Size = new System.Drawing.Size(38, 15);
            this.lblStayCheckinTime.TabIndex = 51;
            this.lblStayCheckinTime.Text = "00:00";
            this.lblStayCheckinTime.Click += new System.EventHandler(this.btnReserveStay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // lblStayCheckoutTime
            // 
            this.lblStayCheckoutTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStayCheckoutTime.AutoSize = true;
            this.lblStayCheckoutTime.BackColor = System.Drawing.Color.Transparent;
            this.lblStayCheckoutTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStayCheckoutTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStayCheckoutTime.Location = new System.Drawing.Point(85, 22);
            this.lblStayCheckoutTime.Name = "lblStayCheckoutTime";
            this.lblStayCheckoutTime.Size = new System.Drawing.Size(38, 15);
            this.lblStayCheckoutTime.TabIndex = 60;
            this.lblStayCheckoutTime.Text = "00:00";
            this.lblStayCheckoutTime.Click += new System.EventHandler(this.btnReserveStay_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(55, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 61;
            this.label4.Text = "입실";
            this.label4.Click += new System.EventHandler(this.btnReserveStay_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(55, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "퇴실";
            this.label5.Click += new System.EventHandler(this.btnReserveStay_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(53, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 63;
            this.label6.Text = "최대";
            this.label6.Click += new System.EventHandler(this.btnReserveLend_Click);
            // 
            // pnlStay
            // 
            this.pnlStay.BackColor = System.Drawing.Color.Transparent;
            this.pnlStay.Controls.Add(this.lblStayPrice);
            this.pnlStay.Controls.Add(this.label4);
            this.pnlStay.Controls.Add(this.label5);
            this.pnlStay.Controls.Add(this.lblStayCheckinTime);
            this.pnlStay.Controls.Add(this.label2);
            this.pnlStay.Controls.Add(this.lblStayCheckoutTime);
            this.pnlStay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlStay.Location = new System.Drawing.Point(246, 106);
            this.pnlStay.Name = "pnlStay";
            this.pnlStay.Size = new System.Drawing.Size(252, 45);
            this.pnlStay.TabIndex = 64;
            this.pnlStay.Click += new System.EventHandler(this.btnReserveStay_Click);
            // 
            // pnlLend
            // 
            this.pnlLend.BackColor = System.Drawing.Color.Transparent;
            this.pnlLend.Controls.Add(this.lblLendPrice);
            this.pnlLend.Controls.Add(this.label6);
            this.pnlLend.Controls.Add(this.lblLendTime);
            this.pnlLend.Controls.Add(this.label1);
            this.pnlLend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLend.Location = new System.Drawing.Point(248, 72);
            this.pnlLend.Name = "pnlLend";
            this.pnlLend.Size = new System.Drawing.Size(252, 34);
            this.pnlLend.TabIndex = 65;
            this.pnlLend.Click += new System.EventHandler(this.btnReserveLend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(419, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "잔여:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRoomCnt
            // 
            this.lblRoomCnt.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRoomCnt.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRoomCnt.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRoomCnt.Location = new System.Drawing.Point(447, 9);
            this.lblRoomCnt.Name = "lblRoomCnt";
            this.lblRoomCnt.Size = new System.Drawing.Size(38, 13);
            this.lblRoomCnt.TabIndex = 67;
            this.lblRoomCnt.Text = "00 개";
            this.lblRoomCnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roomListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.lblRoomCnt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.pnlLend);
            this.Controls.Add(this.pnlStay);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "roomListControl";
            this.Size = new System.Drawing.Size(498, 151);
            this.Load += new System.EventHandler(this.roomListControl_Load);
            this.Click += new System.EventHandler(this.roomListControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlStay.ResumeLayout(false);
            this.pnlStay.PerformLayout();
            this.pnlLend.ResumeLayout(false);
            this.pnlLend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLendPrice;
        private System.Windows.Forms.Label lblLendTime;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblStayPrice;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Label lblStayCheckinTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStayCheckoutTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlStay;
        private System.Windows.Forms.Panel pnlLend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRoomCnt;
    }
}
