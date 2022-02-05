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
    public partial class reserveStay : Form
    {
        public Room RoomInfo { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }

        public Reserve ReserveStay
        {
            get
            {

                Reserve reserve = new Reserve();
                reserve.AccomId = RoomInfo.AccomId;
                reserve.RoomName = RoomInfo.RoomName;
                reserve.UserId = home.UserId.UserId;
                reserve.ReserveTypeLS = "S";
                reserve.ReserveCheckIn = Convert.ToDateTime(CheckinDate.ToShortDateString() + " " +RoomInfo.RoomCheckinTime);
                reserve.ReserveCheckOut = Convert.ToDateTime(CheckoutDate.ToShortDateString() + " " + RoomInfo.RoomCheckoutTime);
                reserve.GuestName = txtGuestName.Text;
                reserve.GuestPhone = txtGuestPhone.Text;
                reserve.ReserveState = "결제완료";
                if (rbnCardPay.Checked == true) 
                    reserve.PaymentMethod = rbnCardPay.Text;
                else if (rbnDeposit.Checked == true) 
                    reserve.PaymentMethod = rbnDeposit.Text;
                else 
                    reserve.PaymentMethod = rbnPhonePay.Text;
                reserve.Payment = RoomInfo.RoomStayPrice;

                return reserve;
            }
        }
           
        public reserveStay()
        {
            InitializeComponent();
        }

        public reserveStay(DateTime checkinDate, DateTime checkoutDate)
        {
            InitializeComponent();
            CheckinDate = checkinDate;
            CheckoutDate = checkoutDate;
        }
        private void reserve_Load(object sender, EventArgs e)
        {
            reserveDAC dac = new reserveDAC();
            lblRoomName.Text = RoomInfo.RoomName;
            lblCheckinDate.Text = CheckinDate.ToShortDateString() + $" ({dac.GetDay(CheckinDate.DayOfWeek.ToString())})";
            lblCheckoutDate.Text = CheckoutDate.ToShortDateString() + $" ({dac.GetDay(CheckoutDate.DayOfWeek.ToString())})";
            lblCheckinTime.Text = RoomInfo.RoomCheckinTime.Substring(0, RoomInfo.RoomCheckinTime.LastIndexOf(":"));
            lblCheckoutTime.Text = RoomInfo.RoomCheckoutTime.Substring(0, RoomInfo.RoomCheckoutTime.LastIndexOf(":"));
            lblPayment.Text = RoomInfo.RoomStayPrice.ToString("#,##0") + "원";
            lblAccomName.Text = RoomInfo.AccomName.ToString();


        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            reserveDAC rdac = new reserveDAC();
            int result = rdac.ReserveAdd(ReserveStay);
            if (result > 0)
            {
                MessageBox.Show("객실 예약 및 결제가 완료되었습니다.");
                this.Close();
            }
            else
            {
                MessageBox.Show("객실 예약에 실패했습니다. 다시 시도하세요.");
            }
            rdac.Dispose();
        }
    }
}
