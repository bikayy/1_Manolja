
namespace manolza
{
    partial class accomList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboArea2 = new System.Windows.Forms.ComboBox();
            this.cboArea1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpCheckoutDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpCheckinDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 551);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "지역선택";
            // 
            // cboArea2
            // 
            this.cboArea2.BackColor = System.Drawing.Color.LavenderBlush;
            this.cboArea2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboArea2.FormattingEnabled = true;
            this.cboArea2.Location = new System.Drawing.Point(144, 15);
            this.cboArea2.Name = "cboArea2";
            this.cboArea2.Size = new System.Drawing.Size(191, 23);
            this.cboArea2.TabIndex = 0;
            this.cboArea2.SelectedValueChanged += new System.EventHandler(this.cboArea2_SelectedIndexChanged);
            // 
            // cboArea1
            // 
            this.cboArea1.BackColor = System.Drawing.Color.LavenderBlush;
            this.cboArea1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboArea1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboArea1.FormattingEnabled = true;
            this.cboArea1.Location = new System.Drawing.Point(73, 15);
            this.cboArea1.Name = "cboArea1";
            this.cboArea1.Size = new System.Drawing.Size(61, 23);
            this.cboArea1.TabIndex = 18;
            this.cboArea1.SelectedIndexChanged += new System.EventHandler(this.cboArea1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpCheckoutDate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpCheckinDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cboArea1);
            this.panel2.Controls.Add(this.cboArea2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 50);
            this.panel2.TabIndex = 19;
            // 
            // dtpCheckoutDate
            // 
            this.dtpCheckoutDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpCheckoutDate.CustomFormat = "yyyy년 MM월 dd일";
            this.dtpCheckoutDate.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpCheckoutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckoutDate.Location = new System.Drawing.Point(797, 15);
            this.dtpCheckoutDate.Name = "dtpCheckoutDate";
            this.dtpCheckoutDate.Size = new System.Drawing.Size(148, 25);
            this.dtpCheckoutDate.TabIndex = 34;
            this.dtpCheckoutDate.ValueChanged += new System.EventHandler(this.dtpCheckinoutDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(732, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "체크아웃";
            // 
            // dtpCheckinDate
            // 
            this.dtpCheckinDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpCheckinDate.CustomFormat = "yyyy년 MM월 dd일";
            this.dtpCheckinDate.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpCheckinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckinDate.Location = new System.Drawing.Point(555, 15);
            this.dtpCheckinDate.Name = "dtpCheckinDate";
            this.dtpCheckinDate.Size = new System.Drawing.Size(145, 25);
            this.dtpCheckinDate.TabIndex = 31;
            this.dtpCheckinDate.ValueChanged += new System.EventHandler(this.dtpCheckinoutDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(506, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "체크인";
            // 
            // accomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "accomList";
            this.Text = "업체검색";
            this.Load += new System.EventHandler(this.accomList_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboArea2;
        private System.Windows.Forms.ComboBox cboArea1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpCheckoutDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpCheckinDate;
        private System.Windows.Forms.Label label2;
    }
}