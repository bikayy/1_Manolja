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
    public partial class accomListControl : UserControl
    {
        Accom curAccom;



        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }


        public Accom AccomInfo
        {
            get
            {
                return curAccom;
            }
            set
            {
                curAccom = value;

                pictureBox1.ImageLocation = value.AccomImage;
                lblAccomName.Text = value.AccomName;
                int accomId = value.AccomId;
                lblLendPrice.Text = value.AccomLendPrice.ToString("#,##0");
                lblLendTime.Text = value.AccomLendTime+"시간";
                lblStayCheckIn.Text = value.AccomCheckinTime.Substring(0, value.AccomCheckinTime.LastIndexOf(":"))+"~";
                lblStayPrice.Text = value.AccomStayPrice.ToString("#,##0");
                string AccomAddr = value.AccomAddr2 + " " + value.AccomAddr3;
                string AccomFacility = value.AccomFacility.ToString();
                string AccomInfo = value.AccomInfo;
            }
        }

        public accomListControl()
        {
            InitializeComponent();
        }

        public accomListControl(DateTime checkindate, DateTime checkoutdate)
        {
            InitializeComponent();

            CheckinDate = checkindate;
            CheckoutDate = checkoutdate;
        }

        private void accomList_Load(object sender, EventArgs e)
        {
            
        }

        private void accomListControl_Click(object sender, EventArgs e)
        {
            accomList alist = new accomList();
            roomList rlist = new roomList(CheckinDate, CheckoutDate, AccomInfo.AccomId);
            rlist.AccomInfo = this.AccomInfo;
            rlist.Show();
        }
    }
}
