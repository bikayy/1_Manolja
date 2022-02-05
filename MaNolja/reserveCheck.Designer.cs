
namespace manolza
{
    partial class reserveCheck
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
            this.dgvReserve = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserve)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReserve
            // 
            this.dgvReserve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserve.Location = new System.Drawing.Point(12, 82);
            this.dgvReserve.Name = "dgvReserve";
            this.dgvReserve.RowTemplate.Height = 23;
            this.dgvReserve.Size = new System.Drawing.Size(752, 519);
            this.dgvReserve.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(335, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 25);
            this.label23.TabIndex = 46;
            this.label23.Text = "예약확인";
            // 
            // reserveCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 613);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.dgvReserve);
            this.Name = "reserveCheck";
            this.Text = "reserveCheck";
            this.Load += new System.EventHandler(this.reserveCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReserve;
        private System.Windows.Forms.Label label23;
    }
}