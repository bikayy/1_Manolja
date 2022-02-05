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
    public partial class roomList : Form
    {
        DataTable dtAllList;


        public Accom AccomInfo { get; set; }

        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }

        int AccomId { get; set; }

        int dateDiffDays;
        public roomList()
        {
            InitializeComponent();
        }

        public roomList(DateTime checkindate, DateTime checkoutdate, int accomId)
        {
            InitializeComponent();

            CheckinDate = checkindate;
            CheckoutDate = checkoutdate;
   
            AccomId = accomId;
        }

        private void roomList_Load(object sender, EventArgs e)
        {
            
            accomList alist = new accomList();

            dtpCheckinDate.Value = CheckinDate;
            dtpCheckoutDate.Value = CheckoutDate;

            roomDAC dac = new roomDAC();
            dtAllList = dac.GetRoomList(AccomId);
            dac.Dispose();

            ShowRoomList(dtAllList);

            pbxAccom.Image = Image.FromFile(AccomInfo.AccomImage);
            pbxAccom.SizeMode = PictureBoxSizeMode.StretchImage;
            lblAccomName.Text = AccomInfo.AccomName;
            lblAddress.Text = AccomInfo.AccomAddr2;
            lblFacility.Text = AccomInfo.AccomFacility;
            lblInfo.Text = AccomInfo.AccomInfo;

            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = false;
            panel1.VerticalScroll.Visible = false;
            panel1.AutoScroll = true;
        }


        private void ShowRoomList(DataTable dt)
        {

            //DataTable Row수를 2로 나눈 몫의 올림
            int iRows = (int)Math.Ceiling(dt.Rows.Count / 1.0);
            int idx = 0;


            CheckinDate = dtpCheckinDate.Value;
            CheckoutDate = dtpCheckoutDate.Value;


            string lendPrice, stayPrice, checkinTime, checkoutTime, lendTime;

            for (int r = 0; r < iRows; r++)
            {
                if (idx >= dt.Rows.Count) break;
                int roomCnt = 0;
                string dayWeek = dtpCheckinDate.Value.DayOfWeek.ToString();
                if (dayWeek == "Friday" || dayWeek == "Saturday")
                {
                    lendPrice = "price_Common_Week_Stay"; stayPrice = "price_Common_Holi_Stay"; checkinTime = "roomCheckIn_Common_Holi"; checkoutTime = "roomCheckOut_Common_Holi"; lendTime = "roomLendTime_Common_Holi";
                }
                else
                {
                    lendPrice = "price_Common_Week_Lend"; stayPrice = "price_Common_Week_Stay"; checkinTime = "roomCheckIn_Common_Week"; checkoutTime = "roomCheckOut_Common_Week"; lendTime = "roomLendTime_Common_Week";
                }

                reserveDAC rdac = new reserveDAC();
                DataTable dtReserve = rdac.GetReserveCnt(Convert.ToInt32(dt.Rows[idx]["accomId"]), dt.Rows[idx]["roomName"].ToString(), "S", CheckinDate.ToShortDateString());

                if (dtReserve.Rows.Count > 0)
                {

                    TimeSpan dateDiff = (CheckoutDate.Date - CheckinDate.Date);
                    dateDiffDays = dateDiff.Days; //몇박 며칠 묵는지 => a박 a+1일

                    string[] dtpCnt = new string[dateDiffDays];

                    DateTime cin = CheckinDate;

                    for (int i = 0; i < dateDiffDays; i++)
                    {
                        dtpCnt[i] = cin.ToShortDateString();
                        cin = cin.AddDays(+1);
                    }

                    StringBuilder sb = new StringBuilder();
                    foreach (var item in dtpCnt)
                    {
                        sb.Append(item + " ");
                    }


                    //배열생성
                    string[] reserveDateCnt;

                    //체크인날짜 이후에 예약된 방 갯수만큼(데이터 로우만큼)
                    for (int j = 0; j < dtReserve.Rows.Count; j++)
                    {
                        bool check = true;
                        int dateCnt = Convert.ToInt32(dtReserve.Rows[j]["dateCnt"]);// 숙박-몇박인지
                        reserveDateCnt = new string[dateCnt];//비교할 일자만큼 배열값
                        DateTime reserveCheckIn = Convert.ToDateTime(dtReserve.Rows[j]["reserveCheckIn"]);//기준점: 체크인 날짜
                                                                                                          //StringBuilder sb2 = new StringBuilder();
                                                                                                          //예약된 객실의 연박수 만큼
                        for (int i = 0; i < dateCnt; i++)
                        {
                            reserveDateCnt[i] = reserveCheckIn.ToShortDateString();
                            //sb2.Append(reserveCheckIn.ToShortDateString() + " ");//체크인 날짜부터 몇박인지 카운트하며 배열값 넣기
                            reserveCheckIn = reserveCheckIn.AddDays(+1);
                        }

                        //내가 설정한 연박수 만큼
                        for (int q = 0; q < dtpCnt.Length; q++)
                        {
                            //예약객실 <-> 설정날짜 비교 
                            for (int i = 0; i < reserveDateCnt.Length; i++)
                            {
                                if (dtpCnt[q].Contains(reserveDateCnt[i]) == true)
                                {
                                    check = false;
                                    break;
                                }
                            }
                        }
                        if (check == false) roomCnt++;
                    }
                }


                roomListControl ctrl = new roomListControl(dtpCheckinDate.Value, dtpCheckoutDate.Value);
                ctrl.Location = new Point(10, (170 * r));
                ctrl.Size = new Size(498, 151);

                Room roomInfo = new Room()
                {
                    
                    AccomName = dt.Rows[idx]["accomName"].ToString(),
                    RoomName = dt.Rows[idx]["roomName"].ToString(),
                    RoomImage = dt.Rows[idx]["imagePath"].ToString(),
                    RoomStayPrice = (Convert.ToInt32(dt.Rows[idx][stayPrice])) * dateDiffDays,
                    RoomLendPrice = Convert.ToInt32(dt.Rows[idx][lendPrice]),
                    RoomCheckinTime = dt.Rows[idx][checkinTime].ToString(),
                    RoomCheckoutTime = dt.Rows[idx][checkoutTime].ToString(),
                    RoomLendTime = Convert.ToInt32(dt.Rows[idx][lendTime].ToString()),
                    RoomPeople = dt.Rows[idx]["roomPeople"].ToString(),
                    AccomId = Convert.ToInt32(dt.Rows[idx]["accomId"]),
                    CheckSaleYN = dt.Rows[idx]["checkSaleYN"].ToString(),
                    CheckPeakYN = dt.Rows[idx]["checkPeakYN"].ToString(),
                    CheckStayYN = dt.Rows[idx]["checkStayYN"].ToString(),
                    CheckLendYN = dt.Rows[idx]["checkLendYN"].ToString(),
                    RoomTotCnt = Convert.ToInt32(dt.Rows[idx]["roomCnt"]) - roomCnt,

                    price_Common_Week_Lend = (dt.Rows[idx]["price_Common_Week_Lend"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["price_Common_Week_Lend"]),
                    price_Common_Holi_Stay = (dt.Rows[idx]["price_Common_Week_Lend"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["price_Common_Holi_Stay"]),
                    price_Common_Week_Stay = (dt.Rows[idx]["price_Common_Week_Lend"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["price_Common_Week_Stay"]),
                    price_Peak_Week_Lend = (dt.Rows[idx]["price_Peak_Week_Lend"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["price_Peak_Week_Lend"]),
                    price_Peak_Week_Stay = (dt.Rows[idx]["price_Peak_Week_Stay"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["price_Peak_Week_Stay"]),
                    price_Peak_Holi_Lend = (dt.Rows[idx]["price_Peak_Holi_Lend"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["price_Peak_Holi_Lend"]),
                    price_Peak_Holi_Stay = (dt.Rows[idx]["price_Peak_Holi_Stay"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["price_Peak_Holi_Stay"]),
                    price_Sale_Week_Lend = (dt.Rows[idx]["price_Sale_Week_Lend"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["price_Sale_Week_Lend"]),
                    price_Sale_Week_Stay = (dt.Rows[idx]["price_Sale_Week_Stay"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["price_Sale_Week_Stay"]),
                    price_Sale_Holi_Stay = (dt.Rows[idx]["price_Sale_Holi_Stay"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["price_Sale_Holi_Stay"]),
                    price_Sale_Holi_Lend = (dt.Rows[idx]["price_Sale_Holi_Lend"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["price_Sale_Holi_Lend"]),
                    roomLendTime_Common_Holi = (dt.Rows[idx]["roomLendTime_Common_Holi"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["roomLendTime_Common_Holi"]),
                    roomLendTime_Common_Week = (dt.Rows[idx]["roomLendTime_Common_Week"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["roomLendTime_Common_Week"]),
                    roomLendTime_Peak_Holi = (dt.Rows[idx]["roomLendTime_Peak_Holi"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["roomLendTime_Peak_Holi"]),
                    roomLendTime_Peak_Week = (dt.Rows[idx]["roomLendTime_Peak_Week"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["roomLendTime_Peak_Week"]),
                    roomLendTime_Sale_Holi = (dt.Rows[idx]["roomLendTime_Sale_Holi"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["roomLendTime_Sale_Holi"]),
                    roomLendTime_Sale_Week = (dt.Rows[idx]["roomLendTime_Sale_Week"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[idx]["roomLendTime_Sale_Week"]),
                    roomCheckIn_Common_Holi = (dt.Rows[idx]["roomCheckIn_Common_Holi"] == DBNull.Value) ? new DateTime(2999, 12, 31, 00, 00, 00) : Convert.ToDateTime("1993-10-12 " + dt.Rows[idx]["roomCheckIn_Common_Holi"].ToString()),
                    roomCheckIn_Common_Week = (dt.Rows[idx]["roomCheckIn_Common_Week"] == DBNull.Value) ? Convert.ToDateTime("2999-12-31") : Convert.ToDateTime("1993-10-12 " + dt.Rows[idx]["roomCheckIn_Common_Week"].ToString()),
                    roomCheckIn_Peak_Holi = (dt.Rows[idx]["roomCheckIn_Peak_Holi"] == DBNull.Value) ? new DateTime(0) : Convert.ToDateTime("1993-10-12 " + dt.Rows[idx]["roomCheckIn_Peak_Holi"].ToString()),
                    roomCheckIn_Peak_Week = (dt.Rows[idx]["roomCheckIn_Peak_Week"] == DBNull.Value) ? Convert.ToDateTime("2999-12-31") : Convert.ToDateTime("1993-10-12 " + dt.Rows[idx]["roomCheckIn_Peak_Week"].ToString()),
                    roomCheckIn_Sale_Holi = (dt.Rows[idx]["roomCheckIn_Sale_Holi"] == DBNull.Value) ? Convert.ToDateTime("2999-12-31") : Convert.ToDateTime("1993-10-12 " + dt.Rows[idx]["roomCheckIn_Sale_Holi"].ToString()),
                    roomCheckIn_Sale_Week = (dt.Rows[idx]["roomCheckIn_Sale_Week"] == DBNull.Value) ? Convert.ToDateTime("2999-12-31") : Convert.ToDateTime("1993-10-12 " + dt.Rows[idx]["roomCheckIn_Sale_Week"].ToString()),
                    roomCheckOut_Common_Holi = (dt.Rows[idx]["roomCheckOut_Common_Holi"] == DBNull.Value) ? Convert.ToDateTime("2999-12-31") : Convert.ToDateTime("1993-10-12 " + dt.Rows[idx]["roomCheckOut_Common_Holi"].ToString()),
                    roomCheckOut_Common_Week = (dt.Rows[idx]["roomCheckOut_Common_Week"] == DBNull.Value) ? Convert.ToDateTime("2999-12-31") : Convert.ToDateTime("1993-10-12 " + dt.Rows[idx]["roomCheckOut_Common_Week"].ToString()),
                    roomCheckOut_Peak_Holi = (dt.Rows[idx]["roomCheckOut_Peak_Holi"] == DBNull.Value) ? Convert.ToDateTime("2999-12-31") : Convert.ToDateTime("1993-10-12 " + dt.Rows[idx]["roomCheckOut_Peak_Holi"].ToString()),
                    roomCheckOut_Peak_Week = (dt.Rows[idx]["roomCheckOut_Peak_Week"] == DBNull.Value) ? Convert.ToDateTime("2999-12-31") : Convert.ToDateTime("1993-10-12 " + dt.Rows[idx]["roomCheckOut_Peak_Week"].ToString()),
                    roomCheckOut_Sale_Holi = (dt.Rows[idx]["roomCheckOut_Sale_Holi"] == DBNull.Value) ? Convert.ToDateTime("2999-12-31") : Convert.ToDateTime("1993-10-12 " + dt.Rows[idx]["roomCheckOut_Sale_Holi"].ToString()),
                    roomCheckOut_Sale_Week = (dt.Rows[idx]["roomCheckOut_Sale_Week"] == DBNull.Value) ? Convert.ToDateTime("2999-12-31") : Convert.ToDateTime("1993-10-12 " + dt.Rows[idx]["roomCheckOut_Sale_Week"].ToString())

                };
                if (dt.Rows[idx]["price_Common_Holi_Lend"] != DBNull.Value)
                    roomInfo.price_Common_Holi_Lend = Convert.ToInt32(dt.Rows[idx]["price_Common_Holi_Lend"]);

                ctrl.RoomInfo = roomInfo;

                pnlRoom.Controls.Add(ctrl);
                idx++;

            }
        }


        private void dtpCheckinoutDate_ValueChanged(object sender, EventArgs e)
        {
            foreach (roomListControl ctrl in pnlRoom.Controls)
            {
                ctrl.CheckinDate = dtpCheckinDate.Value;
                ctrl.CheckoutDate = dtpCheckoutDate.Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan a = (dtpCheckoutDate.Value.Date - dtpCheckinDate.Value.Date);

            if (a.Days < 0) { 
                MessageBox.Show("체크인 날짜는 체크아웃 날짜 이전이어야 합니다.");
                return;
            }

            roomDAC dac = new roomDAC();
                dtAllList = dac.GetRoomList(AccomId);
                dac.Dispose();
                pnlRoom.Controls.Clear();
                ShowRoomList(dtAllList);
        }

    }
}
