using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace manolza
{
    public partial class roomAdd : Form
    {
        //int accomId;

        public int AccomId { get; set; }
        public string AccomName { get; set; }
        public Room AddRoom
        {
            get
            {
                Room room = new Room();
                room.AccomId = AccomId;
                room.RoomName = txtRoomName.Text;
                room.RoomPeople = txtPeople1.Text + "/" + txtPeople2.Text;
                room.RoomTotCnt = Convert.ToInt32(txtRoomCnt.Text);

                room.roomCheckIn_Common_Week = dtpCheckIn_Common_Week.Value;
                room.roomCheckOut_Common_Week = dtpCheckOut_Common_Week.Value;
                room.roomCheckIn_Common_Holi = dtpCheckIn_Common_Holi.Value;
                room.roomCheckOut_Common_Holi = dtpCheckOut_Common_Holi.Value;

                room.roomCheckIn_Peak_Week = dtpCheckIn_Peak_Week.Value;
                room.roomCheckOut_Peak_Week = dtpCheckOut_Peak_Week.Value;
                room.roomCheckIn_Peak_Holi = dtpCheckIn_Peak_Holi.Value;
                room.roomCheckOut_Peak_Holi = dtpCheckOut_Peak_Holi.Value;

                room.roomCheckIn_Sale_Week = dtpCheckIn_Sale_Week.Value;
                room.roomCheckOut_Sale_Week = dtpCheckOut_Sale_Week.Value;
                room.roomCheckIn_Sale_Holi = dtpCheckIn_Sale_Holi.Value;
                room.roomCheckOut_Sale_Holi = dtpCheckOut_Sale_Holi.Value;


                if (txtPrice_Common_Week_Lend.Text != "")
                    room.price_Common_Week_Lend = Convert.ToInt32(txtPrice_Common_Week_Lend.Text);
                if (txtPrice_Common_Week_Stay.Text != "")
                    room.price_Common_Week_Stay = Convert.ToInt32(txtPrice_Common_Week_Stay.Text);
                if (txtPrice_Common_Holi_Lend.Text != "")
                    room.price_Common_Holi_Lend = Convert.ToInt32(txtPrice_Common_Holi_Lend.Text);
                if (txtPrice_Common_Holi_Stay.Text != "")
                    room.price_Common_Holi_Stay = Convert.ToInt32(txtPrice_Common_Holi_Stay.Text);
                
                if (txtPrice_Peak_Week_Stay.Text != "")
                    room.price_Peak_Week_Stay = Convert.ToInt32(txtPrice_Peak_Week_Stay.Text);
                if (txtPrice_Peak_Holi_Stay.Text != "")
                    room.price_Peak_Holi_Stay = Convert.ToInt32(txtPrice_Peak_Holi_Stay.Text);
                if (txtPrice_Peak_Week_Lend.Text != "")
                    room.price_Peak_Week_Lend = Convert.ToInt32(txtPrice_Peak_Week_Lend.Text);
                if (txtPrice_Peak_Holi_Lend.Text != "")
                    room.price_Peak_Holi_Lend = Convert.ToInt32(txtPrice_Peak_Holi_Lend.Text);

                if (txtPrice_Sale_Week_Stay.Text != "")
                    room.price_Sale_Week_Stay = Convert.ToInt32(txtPrice_Sale_Week_Stay.Text);
                if (txtPrice_Sale_Holi_Stay.Text != "")
                    room.price_Sale_Holi_Stay = Convert.ToInt32(txtPrice_Sale_Holi_Stay.Text);
                if (txtPrice_Sale_Week_Lend.Text != "")
                    room.price_Sale_Week_Lend = Convert.ToInt32(txtPrice_Sale_Week_Lend.Text);
                if (txtPrice_Sale_Holi_Lend.Text != "")
                    room.price_Sale_Holi_Lend = Convert.ToInt32(txtPrice_Sale_Holi_Lend.Text);


                if (txtLendTime_Common_Week.Text != "")
                    room.roomLendTime_Common_Week = Convert.ToInt32(txtLendTime_Common_Week.Text);
                if (txtLendTime_Common_Holi.Text != "")
                    room.roomLendTime_Common_Holi = Convert.ToInt32(txtLendTime_Common_Holi.Text);

                if (txtLendTime_Peak_Week.Text != "")
                    room.roomLendTime_Peak_Week = Convert.ToInt32(txtLendTime_Peak_Week.Text);
                if (txtLendTime_Peak_Holi.Text != "")
                    room.roomLendTime_Peak_Holi = Convert.ToInt32(txtLendTime_Peak_Holi.Text);

                if (txtLendTime_Sale_Week.Text != "")
                    room.roomLendTime_Sale_Week = Convert.ToInt32(txtLendTime_Sale_Week.Text);
                if (txtLendTime_Sale_Holi.Text != "")
                    room.roomLendTime_Sale_Holi = Convert.ToInt32(txtLendTime_Sale_Holi.Text);


                if (ckbStay.Checked) room.CheckStayYN = "Y";
                else room.CheckStayYN = "N";

                if (ckbLend.Checked) room.CheckLendYN = "Y";
                else room.CheckLendYN = "N";

                if (ckbSale.Checked) room.CheckSaleYN = "Y";
                else room.CheckSaleYN = "N";

                if (ckbPeak.Checked) room.CheckPeakYN = "Y";
                else room.CheckPeakYN = "N";

                return room;
            }
            set
            {

            }
        }

        public roomAdd()
        {
            InitializeComponent();
        }

        public roomAdd(int accomId)
        {
            InitializeComponent();
            AccomId = accomId;
            roomDAC dac = new roomDAC();
            AccomName = dac.GetAccomInfo(accomId).Rows[0]["accomName"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Images File(*.gif;*.jpg;*.jpeg;*.png;*.bmp)|*.gif;*.jpg;*.jpeg;*.png;*.bmp";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = dlg.FileName; //전체경로
                pictureBox1.Image = Image.FromFile(dlg.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                string sPath = ConfigurationManager.AppSettings["uploadPath"] + dlg.FileNames + "/";

                for (int i=0; i < dlg.FileNames.Count(); i++)
                {
                    listBox1.Items.Add(dlg.FileNames[i].ToString());
                }
            }
        }

        private void room_add_Load(object sender, EventArgs e)
        {
            pnlPrice.Visible = false;
            txtAccom.Text = AccomName;
            roomDAC dac = new roomDAC();
            dac.Dispose();
                        
        }
         


        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string filePath = listBox1.SelectedItems[0].ToString();

                //pictureBox1.Image = Image.FromFile(filePath);  //Image : 파일경로는 되는데, URL경로는 불가
                pictureBox1.ImageLocation = filePath;  // ImageLocation : 파일경로 가능, URL경로 가능

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pnlPrice.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlPrice.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                roomDAC rdac = new roomDAC();
                int iresult = rdac.RoomAdd(AddRoom);
                int bResult = 0;
                if (iresult > 0)
                {

                    imageDAC idac = new imageDAC();
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        string sPath = ConfigurationManager.AppSettings["uploadPath"] + AccomId + "/";
                        string localFile = listBox1.Items[i].ToString();
                        string sExt = localFile.Substring(localFile.LastIndexOf(".")).ToLower();
                        string newFileName = DateTime.Now.ToString("_yyMMdd_HHmmss_fff") + sExt;
                        string destFileName = sPath + newFileName;

                        if (!Directory.Exists(sPath)) //디렉토리가 없다면 디렉토리를 생성
                        {
                            Directory.CreateDirectory(sPath);
                        }
                        File.Copy(localFile, destFileName, true); //파일 복사

                        //DB에 파일경로 저장
                        bResult = idac.ImageAdd(AccomId, txtRoomName.Text, destFileName);
                    }

                    if (bResult>0)
                    {
                        MessageBox.Show("객실 등록 및 이미지 저장이 완료되었습니다.");
                        idac.Dispose();
                        rdac.Dispose();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("객실 등록 완료, 이미지 저장 실패");
                    }
                }
                else
                {
                    MessageBox.Show("객실 등록 및 이미지 저장이 실패했습니다. 다시 시도하세요.");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImageDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }



        //객실정보 > 숙박 체크박스 활/비활성화
        private void ckbStay_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbStay.Checked)
            {
                panel1.Enabled = panel2.Enabled = panel5.Enabled = panel6.Enabled = panel9.Enabled = panel10.Enabled = true;
            }
            else
            {
                panel1.Enabled = panel2.Enabled = panel5.Enabled = panel6.Enabled = panel9.Enabled = panel10.Enabled = false;
            }
        }


        //객실정보 > 대실 체크박스 활/비활성화
        private void ckbLend_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLend.Checked)
            {
                panel3.Enabled = panel4.Enabled = panel7.Enabled = panel8.Enabled = panel11.Enabled = panel12.Enabled = true;
            }
            else
            {
                panel3.Enabled = panel4.Enabled = panel7.Enabled = panel8.Enabled = panel11.Enabled = panel12.Enabled = false;
            }
        }

        //객실정보 > 일반 체크박스 활/비활성화
        private void ckbCommon_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCommon.Checked)
            {
                ckbCommon.BackColor = Color.PaleGreen;
                ckbPeak.Checked = ckbSale.Checked = false;
                ckbSale_CheckedChanged(this, e);
                ckbPeak_CheckedChanged(this, e);
            }
            else
            {            
                if (ckbSale.Checked == false && ckbPeak.Checked == false)
                {
                    MessageBox.Show("가격 설정은 필수입니다. (일반, 성수기, 특가 중 택1)");
                    ckbCommon.Checked = true;
                    return;
                }
                ckbCommon.BackColor = Color.Empty;
            }
        }


        //객실정보 > 성수기 체크박스 활/비활성화
        private void ckbPeak_CheckedChanged(object sender, EventArgs e)
        {

            if (ckbPeak.Checked)
            {
                if (ckbStay.Checked) panel5.Enabled = panel6.Enabled = true;
                if (ckbLend.Checked) panel7.Enabled = panel8.Enabled = true;
                ckbSale.Checked = ckbCommon.Checked = false;
                ckbPeak.BackColor = Color.Orange;
                ckbSale_CheckedChanged(this, e);
                ckbCommon_CheckedChanged(this, e);

            }
            else
            {       
                if (ckbSale.Checked == false && ckbCommon.Checked == false)
                {
                    MessageBox.Show("대표 가격 설정은 필수입니다. (일반, 성수기, 특가 중 택1)");
                    ckbPeak.Checked = true;
                    return;
                }
                ckbPeak.BackColor = Color.Empty;
            }
        }


        //객실정보 > 특가 체크박스 활/비활성화
        private void ckbSale_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSale.Checked)
            {
                if (ckbStay.Checked) panel9.Enabled = panel10.Enabled = true;
                if (ckbLend.Checked) panel11.Enabled = panel12.Enabled = true;
                ckbPeak.Checked = ckbCommon.Checked = false;
                ckbSale.BackColor = Color.HotPink;
                ckbPeak_CheckedChanged(this, e);
                ckbCommon_CheckedChanged(this, e);
            }
            else
            {
                if (ckbPeak.Checked == false && ckbCommon.Checked == false)
                {
                    MessageBox.Show("가격 설정은 필수입니다. (일반/성수기/특가 중 택1)");
                    ckbSale.Checked = true;
                    return;
                }
                ckbSale.BackColor = Color.Empty;
            }
        }
    }
}
