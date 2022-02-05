using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manolza
{
    public partial class myReserve : Form
    {
        public User CurrentUser { get; set; }

        public myReserve()
        {
            InitializeComponent();
        }
        public myReserve(User user)
        {
            InitializeComponent();
            CurrentUser = user;


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void myReserve_Load(object sender, EventArgs e)
        {
            pnlReserveDetail.Visible = btnBack.Visible= false;

            DataGridViewUtil.SetInitGridView(dgvReserve);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "이미지Id", "imagePath", visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "예약번호", "reserveId", visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "업체Id", "accomId", visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "업체명", "accomName");
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "객실명", "roomName");
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "업체주소", "accomAddr2", visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "예약타입", "reserveTypeLS", visibility: false);

            DataGridViewUtil.AddGridTextColumn(dgvReserve, "예약자명", "guestName", visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "예약자 연락처", "guestPhone", visibility: false);

            DataGridViewUtil.AddGridTextColumn(dgvReserve, "입실일시", "reserveCheckIn");
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "퇴실일시", "reserveCheckOut");

            DataGridViewUtil.AddGridTextColumn(dgvReserve, "예약상태", "reserveState");
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "결제수단", "paymentMethod", visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "결제금액", "payment");
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "예약일자", "reserveDate", visibility: false);

            reserveDAC rdac = new reserveDAC();
            dgvReserve.DataSource = rdac.GetMyReserve(CurrentUser.UserId);
            dgvReserve.CurrentCell = null;
            dgvReserve.ClearSelection();
            rdac.Dispose();
        }



        private void dgvReserve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBack.Visible = pnlReserveDetail.Visible = true;

            lblAccomName.Text = dgvReserve["accomName", e.RowIndex].Value.ToString();

            lblAddr.Text = dgvReserve["accomAddr2", e.RowIndex].Value.ToString();

            pictureBox1.Image = Image.FromFile(dgvReserve["imagePath", e.RowIndex].Value.ToString());
            


            lblCheckin.Text = Convert.ToDateTime(dgvReserve["reserveCheckIn", e.RowIndex].Value).ToString("yyyy-MM-dd HH:mm"); 
            //dgvReserve["reserveCheckIn", e.RowIndex].Value.ToString().Substring(0, 10);
            lblCheckout.Text = Convert.ToDateTime(dgvReserve["reserveCheckOut", e.RowIndex].Value).ToString("yyyy-MM-dd HH:mm");

            lblDate.Text = dgvReserve["reserveDate", e.RowIndex].Value.ToString().Substring(0, 10);
            lblGuestName.Text = dgvReserve["guestName", e.RowIndex].Value.ToString();
            lblGuestPhone.Text = dgvReserve["guestPhone", e.RowIndex].Value.ToString();
            lblPayment.Text = Convert.ToInt32(dgvReserve["payment", e.RowIndex].Value).ToString("#,##0")+"원";
            lblPayMethod.Text = dgvReserve["paymentMethod", e.RowIndex].Value.ToString();
            lblReserveId.Text = dgvReserve["reserveId", e.RowIndex].Value.ToString();
            lblroomName.Text = dgvReserve["roomName", e.RowIndex].Value.ToString();
            lblState.Text = dgvReserve["reserveState", e.RowIndex].Value.ToString();



            //txtAccomInfo.Text = dgvAccom["accomInfo", e.RowIndex].Value.ToString();

            //AccomId = Convert.ToInt32(dgvAccom["accomId", e.RowIndex].Value);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Visible = pnlReserveDetail.Visible = false;
        }
    }
}
