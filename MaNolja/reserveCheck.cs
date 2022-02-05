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
    public partial class reserveCheck : Form
    {
        public User CurrentUser { get; set; }

        public reserveCheck()
        {
            InitializeComponent();
        }
        public reserveCheck(User user)
        {
            InitializeComponent();
            CurrentUser = user;


        }

        private void reserveCheck_Load(object sender, EventArgs e)
        {

            DataGridViewUtil.SetInitGridView(dgvReserve);

            DataGridViewUtil.AddGridTextColumn(dgvReserve, "예약번호", "reserveId");
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "업체Id", "accomId", visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "업체명", "accomName");
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "객실명", "roomName");
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "업체주소", "accomAddr2");
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "예약타입", "reserveTypeLS");

            DataGridViewUtil.AddGridTextColumn(dgvReserve, "예약자명", "guestName");
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "예약자 연락처", "guestPhone");

            DataGridViewUtil.AddGridTextColumn(dgvReserve, "입실일시", "reserveCheckIn");
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "퇴실일시", "reserveCheckOut");

            DataGridViewUtil.AddGridTextColumn(dgvReserve, "예약상태", "reserveState");
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "결제수단", "paymentMethod");
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "결제금액", "payment");
            DataGridViewUtil.AddGridTextColumn(dgvReserve, "예약일자", "reserveDate");

            reserveDAC rdac = new reserveDAC();
            dgvReserve.DataSource = rdac.GetReserveCheck(CurrentUser.UserId);
            dgvReserve.CurrentCell = null;
            dgvReserve.ClearSelection();
            rdac.Dispose();
        }


    }
}

