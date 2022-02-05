using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static manolza.accomListControl;

namespace manolza
{
    public partial class accomList : Form
    {
        DataTable dtAllList;


        // 입실여부 수동체크 

        public accomList()
        {
            InitializeComponent();
        }

        private void accomList_Load(object sender, EventArgs e)
        {
            //프로퍼티로 넘기기**
            dtpCheckinDate.Value = DateTime.Today;
            dtpCheckoutDate.Value = DateTime.Today.AddDays(1);

            string[] category = { "accom_Type", "accom_Area", "accom_Area1", "reserve_Type", "payment_Method", "accom_facility" };

            accomDAC dac = new accomDAC();
            DataTable dtCode = dac.GetCommonCodes(category);
            ComboBox c = new ComboBox();
            CommonUtil.ComboBinding(cboArea1, "accom_Area1", dtCode);

            

            //등록된 업체목록을 조회
            dtAllList = dac.GetAccomList();
            dac.Dispose();

            //전달받은 데이터테이블로부터 유저컨트롤 바인딩
            ShowAccomList(dtAllList);

        }

        private void cboArea1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void ShowAccomList(DataTable dt)
        {
            panel1.Controls.Clear();
            //DataTable Row수를 2로 나눈 몫의 올림
            int iRows = (int)Math.Ceiling(dt.Rows.Count / 2.0);
            int idx = 0;

            string lendPrice, stayPrice, checkinTime, lendTime;

            for (int r = 0; r < iRows; r++)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (idx >= dt.Rows.Count) break;
                    string dayWeek = dtpCheckinDate.Value.DayOfWeek.ToString();
                    if (dayWeek == "Friday" || dayWeek == "Saturday")
                    {
                        lendPrice = "price_Common_Week_Stay"; stayPrice = "price_Common_Holi_Stay"; checkinTime = "roomCheckIn_Common_Holi"; lendTime = "roomLendTime_Common_Holi";
                    }
                    else
                    {
                        lendPrice = "price_Common_Week_Lend"; stayPrice = "price_Common_Week_Stay"; checkinTime = "roomCheckIn_Common_Week"; lendTime = "roomLendTime_Common_Week";
                    }

                    accomListControl ctrl = new accomListControl(dtpCheckinDate.Value, dtpCheckoutDate.Value);
                    ctrl.Location = new Point(20 + (465 * i), 10 + (160 * r));
                    ctrl.Size = new Size(450, 145);
                    ctrl.AccomInfo = new Accom()
                    {
                        AccomId = Convert.ToInt32(dt.Rows[idx]["AccomId"]),
                        AccomName = dt.Rows[idx]["accomName"].ToString(),
                        AccomImage = dt.Rows[idx]["imagePath"].ToString(),
                        AccomStayPrice = Convert.ToInt32(dt.Rows[idx][stayPrice]),
                        AccomLendPrice = Convert.ToInt32(dt.Rows[idx][lendPrice]),
                        AccomCheckinTime = dt.Rows[idx][checkinTime].ToString(),
                        AccomLendTime = dt.Rows[idx][lendTime].ToString(),
                        AccomFacility = dt.Rows[idx]["accomFacility"].ToString(),
                        AccomAddr2 = dt.Rows[idx]["accomAddr2"].ToString(),
                        AccomAddr3 = dt.Rows[idx]["accomAddr3"].ToString(),
                        AccomInfo = dt.Rows[idx]["accomInfo"].ToString()

                    };
                    //string a;
                    //if (dtpCheckinDate.Value.DayOfWeek == 0)
                    //    a = "roomCheckInH";
                    //ctrl.roomInfo = new Room()
                    //{


                    //};

                    //ctrl.AddCart += Ctrl_AddCart;
                    panel1.Controls.Add(ctrl);
                    idx++;

                }
            }
        }

        private void dtpCheckinoutDate_ValueChanged(object sender, EventArgs e)
        {
            foreach(accomListControl ctrl in panel1.Controls)
            {
                ctrl.CheckinDate = dtpCheckinDate.Value;
                ctrl.CheckoutDate = dtpCheckoutDate.Value;
            }
        }


        private void cboArea1_SelectedIndexChanged(object sender, EventArgs e)
        {
            accomDAC dac = new accomDAC();
            if (cboArea1.Text == "" || cboArea1.Text == "선택") return;
            DataTable dtCode = dac.GetCommonCodes(cboArea1.Text);
            CommonUtil.ComboBindingPcode(cboArea2, cboArea1.Text, dtCode);

            dtAllList = dac.GetAccomList(cboArea1.Text);
            dac.Dispose();

            //전달받은 DataTable로부터 업체 control 바인딩
            ShowAccomList(dtAllList);
        }


        private void cboArea2_SelectedIndexChanged(object sender, EventArgs e)
        {
            accomDAC dac = new accomDAC();
            if (cboArea1.Text == "" || cboArea2.Text == "") return;
            if (cboArea2.Text == "전체")
                dtAllList = dac.GetAccomList(cboArea1.Text);
            else
                dtAllList = dac.GetAccomList(cboArea1.Text, cboArea2.Text);

            dac.Dispose();

            //전달받은 DataTable로부터 업체 control 바인딩
            ShowAccomList(dtAllList);
        }
    }

}

