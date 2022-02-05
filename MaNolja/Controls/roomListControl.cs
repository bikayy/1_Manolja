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
    public partial class roomListControl : UserControl
    {

        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }

        public DateTime[] DateCnt { get; set; }

        Room curRoom;

        public Room RoomInfo
        {
            get
            {
                return curRoom;
            }
            set
            {
                curRoom = value;
                pictureBox1.ImageLocation = value.RoomImage;
                lblRoomName.Text = value.RoomName;

                if (value.CheckLendYN == "Y")
                {
                    pnlStay.Visible = true;
                    lblLendPrice.Text = value.RoomLendPrice.ToString("#,##0") + "원";
                    lblLendTime.Text = value.RoomLendTime + "시간";
                }
                else
                {
                    pnlLend.Visible = false;
                    pnlStay.Location = new Point(pnlStay.Location.X, pnlStay.Location.Y - 15);
                }
                if (value.CheckStayYN == "Y")
                {
                    pnlStay.Visible = true;
                    lblStayCheckinTime.Text = value.RoomCheckinTime.Substring(0, value.RoomCheckinTime.LastIndexOf(":"));
                    lblStayCheckoutTime.Text = value.RoomCheckoutTime.Substring(0, value.RoomCheckinTime.LastIndexOf(":"));
                    lblStayPrice.Text = value.RoomStayPrice.ToString("#,##0") + "원";
                }
                else
                {
                    pnlStay.Visible = false;
                    pnlLend.Location = new Point(pnlLend.Location.X, pnlLend.Location.Y + 28 );
                }
                //string stayCheckoutTime = value.RoomCheckoutTime;
                
                string[] people = value.RoomPeople.Split('/');                
                lblPeople.Text = $"기준 {people[0]}명 / 최대 {people[1]}명";
                if (value.RoomTotCnt < 0) value.RoomTotCnt = 0;
                lblRoomCnt.Text = value.RoomTotCnt.ToString()+" 개";
                //string sss = value.price_Common_Holi_Lend.Value.ToString();
                //value.roomCheckIn_Common_Week.ToString();
                //value.roomCheckOut_Common_Week.ToString();
                //value.roomCheckIn_Common_Holi.ToString();
                //value.roomCheckOut_Common_Holi.ToString();


                //value.roomCheckIn_Peak_Week.ToString();
                //value.roomCheckOut_Peak_Week.ToString();
                //value.roomCheckIn_Peak_Holi.ToString();
                //value.roomCheckOut_Peak_Holi.ToString();

                //value.roomCheckIn_Sale_Week.ToString();
                //value.roomCheckOut_Sale_Week.ToString();
                //value.roomCheckIn_Sale_Holi.ToString();
                //value.roomCheckOut_Sale_Holi.ToString();

                //value.roomLendTime_Common_Week.ToString();
                //value.roomLendTime_Common_Holi.ToString();
                //value.roomLendTime_Peak_Week.ToString(); 
                //value.roomLendTime_Peak_Holi.ToString();
                //value.roomLendTime_Sale_Week.ToString();
                //value.roomLendTime_Sale_Holi.ToString(); 

                //value.price_Common_Week_Lend.ToString();
                //value.price_Common_Week_Stay.ToString();
                //value.price_Common_Holi_Lend.ToString();
                //value.price_Common_Holi_Stay.ToString(); 


                // value.price_Peak_Week_Lend.ToString();
                //value.price_Peak_Week_Stay.ToString();
                //value.price_Peak_Holi_Lend.ToString();
                //value.price_Peak_Holi_Stay.ToString(); 

                //value.price_Sale_Week_Lend.ToString();
                //value.price_Sale_Week_Stay.ToString();
                //value.price_Sale_Holi_Lend.ToString();
                //value.price_Sale_Holi_Stay.ToString();


                //value.CheckSaleYN.ToString();
                //value.CheckPeakYN.ToString();
                //value.CheckStayYN.ToString();
                //value.CheckLendYN.ToString();

            }
        }

        public roomListControl()
        {
            InitializeComponent();
        }

        public roomListControl(DateTime checkindate, DateTime checkoutdate)
        {
            InitializeComponent();

            CheckinDate = checkindate;
            CheckoutDate = checkoutdate;
        }

        public roomListControl(DateTime checkindate, DateTime checkoutdate, DateTime[] dateCnt)
        {
            InitializeComponent();

            CheckinDate = checkindate;
            CheckoutDate = checkoutdate;
            DateCnt = dateCnt;
        }

        private void roomListControl_Load(object sender, EventArgs e)
        {

        }

        private void roomListControl_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnReserveStay_Click(object sender, EventArgs e)
        {
            if (RoomInfo.RoomTotCnt <= 0)
            {
                MessageBox.Show("해당 일자에 예약 가능한 객실이 없습니다.");
                return;
            }
            reserveStay reserveL = new reserveStay(CheckinDate, CheckoutDate);
            reserveL.RoomInfo = this.RoomInfo;
            reserveL.ShowDialog();
        }

        private void btnReserveLend_Click(object sender, EventArgs e)
        {
            //if (RoomInfo.RoomTotCnt <= 0)
            //{
            //    MessageBox.Show("해당 일자에 예약 가능한 객실이 없습니다.");
            //    return;
            //}
            reserveLend reserveL = new reserveLend(CheckinDate, CheckoutDate);
            reserveL.RoomInfo = this.RoomInfo;
            reserveL.ShowDialog();
        }
    }
}
