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
    public partial class reserveLend : Form
    {
        public Room RoomInfo { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }

        public reserveLend()
        {
            InitializeComponent();
        }

        public reserveLend(DateTime checkinDate, DateTime checkoutDate)
        {
            InitializeComponent();
            CheckinDate = checkinDate;
            CheckoutDate = checkoutDate;
        }
        private void reserveLend_Load(object sender, EventArgs e)
        {
            reserveDAC dac = new reserveDAC();
            roomList rlist = new roomList();
            lblRoomName.Text = RoomInfo.RoomName;
            lblCheckinDate.Text = CheckinDate.ToString("yyyy-MM-dd") + $" ({dac.GetDay(CheckinDate.DayOfWeek.ToString())})";
            lblCheckoutDate.Text = CheckinDate.ToString("yyyy-MM-dd") + $" ({dac.GetDay(CheckoutDate.DayOfWeek.ToString())})";
            lblCheckinTime.Text = RoomInfo.RoomCheckinTime.Substring(0, RoomInfo.RoomCheckinTime.LastIndexOf(":"));
            lblCheckoutTime.Text = RoomInfo.RoomCheckoutTime.Substring(0, RoomInfo.RoomCheckoutTime.LastIndexOf(":"));
            lblPayment.Text = RoomInfo.RoomLendPrice.ToString("#,##0") + "원";
            lblAccomName.Text = RoomInfo.AccomName.ToString();

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
