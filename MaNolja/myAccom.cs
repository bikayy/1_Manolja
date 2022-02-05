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

namespace manolza
{
    public partial class myAccom : Form
    {
        public User CurrentUser { get; set; }

        public event EventHandler Select; //조회버튼 클릭시 발생하는 조회이벤트
        public event EventHandler Save;   //저장버튼
        public event EventHandler FormClose; //닫기버튼
        public event EventHandler AccomInfo; //업체정보
        public event EventHandler RoomInfo; //객실정보

        public int AccomId { get; set; }

        public Room UpdateRoom
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

                //if (ckbPeak.Checked)
                //{
                //    if (ckbLend.Checked)
                //    {
                if (txtLendTime_Peak_Week.Text != "")
                    room.roomLendTime_Peak_Week = Convert.ToInt32(txtLendTime_Peak_Week.Text);
                if (txtLendTime_Peak_Holi.Text != "")
                    room.roomLendTime_Peak_Holi = Convert.ToInt32(txtLendTime_Peak_Holi.Text);
                if (txtPrice_Peak_Week_Lend.Text != "")
                    room.price_Peak_Week_Lend = Convert.ToInt32(txtPrice_Peak_Week_Lend.Text);
                if (txtPrice_Peak_Holi_Lend.Text != "")
                    room.price_Peak_Holi_Lend = Convert.ToInt32(txtPrice_Peak_Holi_Lend.Text);
                //}

                //if (ckbStay.Checked)
                //{
                room.roomCheckIn_Peak_Week = dtpCheckIn_Peak_Week.Value;
                room.roomCheckOut_Peak_Week = dtpCheckOut_Peak_Week.Value;
                room.roomCheckIn_Peak_Holi = dtpCheckIn_Peak_Holi.Value;
                room.roomCheckOut_Peak_Holi = dtpCheckOut_Peak_Holi.Value;

                if (txtPrice_Peak_Week_Stay.Text != "")
                    room.price_Peak_Week_Stay = Convert.ToInt32(txtPrice_Peak_Week_Stay.Text);
                if (txtPrice_Peak_Holi_Stay.Text != "")
                    room.price_Peak_Holi_Stay = Convert.ToInt32(txtPrice_Peak_Holi_Stay.Text);
                //    }
                //}


                //if (ckbSale.Checked)
                //{
                //    if (ckbLend.Checked)
                //    {
                if (txtLendTime_Sale_Week.Text != "")
                    room.roomLendTime_Sale_Week = Convert.ToInt32(txtLendTime_Sale_Week.Text);
                if (txtLendTime_Sale_Holi.Text != "")
                    room.roomLendTime_Sale_Holi = Convert.ToInt32(txtLendTime_Sale_Holi.Text);
                if (txtPrice_Sale_Week_Lend.Text != "")
                    room.price_Sale_Week_Lend = Convert.ToInt32(txtPrice_Sale_Week_Lend.Text);
                if (txtPrice_Sale_Holi_Lend.Text != "")
                    room.price_Sale_Holi_Lend = Convert.ToInt32(txtPrice_Sale_Holi_Lend.Text);
                //}

                //if (ckbStay.Checked)
                //{
                room.roomCheckIn_Sale_Week = dtpCheckIn_Sale_Week.Value;
                room.roomCheckOut_Sale_Week = dtpCheckOut_Sale_Week.Value;
                room.roomCheckIn_Sale_Holi = dtpCheckIn_Sale_Holi.Value;
                room.roomCheckOut_Sale_Holi = dtpCheckOut_Sale_Holi.Value;

                if (txtPrice_Sale_Week_Stay.Text != "")
                    room.price_Sale_Week_Stay = Convert.ToInt32(txtPrice_Sale_Week_Stay.Text);
                if (txtPrice_Sale_Holi_Stay.Text != "")
                    room.price_Sale_Holi_Stay = Convert.ToInt32(txtPrice_Sale_Holi_Stay.Text);
                //    }
                //}

                if (txtLendTime_Common_Week.Text != "")
                    room.roomLendTime_Common_Week = Convert.ToInt32(txtLendTime_Common_Week.Text);
                if (txtLendTime_Common_Holi.Text != "")
                    room.roomLendTime_Common_Holi = Convert.ToInt32(txtLendTime_Common_Holi.Text);

                if (txtPrice_Common_Week_Lend.Text != "")
                    room.price_Common_Week_Lend = Convert.ToInt32(txtPrice_Common_Week_Lend.Text);
                if (txtPrice_Common_Week_Stay.Text != "")
                    room.price_Common_Week_Stay = Convert.ToInt32(txtPrice_Common_Week_Stay.Text);
                if (txtPrice_Common_Holi_Lend.Text != "")
                    room.price_Common_Holi_Lend = Convert.ToInt32(txtPrice_Common_Holi_Lend.Text);
                if (txtPrice_Common_Holi_Stay.Text != "")
                    room.price_Common_Holi_Stay = Convert.ToInt32(txtPrice_Common_Holi_Stay.Text);

                if (ckbStay.Checked) room.CheckStayYN = "Y";
                else room.CheckStayYN = "N";

                if (ckbLend.Checked) room.CheckLendYN = "Y";
                else room.CheckLendYN = "N";

                if (ckbPeak.Checked) room.CheckPeakYN = "Y";
                else room.CheckPeakYN = "N";

                if (ckbSale.Checked) room.CheckSaleYN = "Y";
                else room.CheckSaleYN = "N";

                return room;
            }

        }


        public myAccom(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
        }

        private void myAccom_Load(object sender, EventArgs e)
        {
            pnlRoomInfo.Visible = toolDelete.Enabled = pnlDetail.Visible = btnDetail.Enabled = false;

            DataGridViewUtil.SetInitGridView(dgvAccom);

            DataGridViewUtil.AddGridTextColumn(dgvAccom, "업체Id", "accomId", visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvAccom, "업체명", "accomName");
            DataGridViewUtil.AddGridTextColumn(dgvAccom, "대표자명", "repName");
            DataGridViewUtil.AddGridTextColumn(dgvAccom, "업체타입", "accomType", visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvAccom, "업체주소", "accomAddr1", visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvAccom, "업체주소", "accomAddr2");
            DataGridViewUtil.AddGridTextColumn(dgvAccom, "업체주소", "accomAddr3", visibility: false);

            DataGridViewUtil.AddGridTextColumn(dgvAccom, "이메일주소", "accomEmail", visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvAccom, "업체전화번호", "accomTel", visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvAccom, "사업자번호", "crNum");
            DataGridViewUtil.AddGridTextColumn(dgvAccom, "편의시설", "accomFacility", visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvAccom, "업체소개", "accomInfo", visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvAccom, "등록일자", "accomDate");


            string[] category = { "accom_Type", "accom_Area", "reserve_Type", "payment_Method", "accom_facility" };

            accomDAC dac = new accomDAC();
            dgvAccom.DataSource = dac.GetMyAccomList(CurrentUser.UserId);
            dgvAccom.CurrentCell = null;
            dgvAccom.ClearSelection();

            DataTable dtCode = dac.GetCommonCodes(category);

            CommonUtil.ComboBinding(cboAccomType, "accom_Type", dtCode);

            DataView dv = new DataView(dtCode);
            dv.RowFilter = "category = 'accom_facility'";
            for (int i = 0; i < dv.Count; i++)
            {
                clbFacility.Items.Add(dv[i]["name"].ToString());
            }

           
            dac.Dispose();

            Select += OnSelect;
            Save += OnSave;
            FormClose += OnClose;
            RoomInfo += OnRoomInfo;
            AccomInfo += OnAccomInfo;


        }
        //업체정보란 초기화
        private void ClearAccomInfo()
        {
            txtAccomName.Clear();
            txtRepName.Clear();
            txtCRNum.Clear();
            cboAccomType.SelectedIndex = 0;
            txtAccomTel.Clear();
            txtAccomEmail.Clear();
            accomZip.ZipCode = accomZip.Address1 = accomZip.Address2 = null;
            for (int i = 0; i<clbFacility.Items.Count; i++)
            {
                if (clbFacility.GetItemChecked(i))
                    clbFacility.SetItemChecked(i, false);
            }
            txtAccomInfo.Clear();
            ckbPeak.Checked = ckbSale.Checked = false;

        }
        //조회 (업체정보)
        private void SelectAccDgv()
        {
            accomDAC dac = new accomDAC();
            dgvAccom.DataSource = dac.GetMyAccomList(CurrentUser.UserId);
            dgvAccom.CurrentCell = null;
            dgvAccom.ClearSelection();

            dac.Dispose();

            toolRoomAdd.Enabled = false;
            toolDelete.Enabled = false;

        }

        //조회 (객실정보)
        private void SelectRoom()
        {
            treeView1.Nodes.Clear();

            TreeNode rootNode = new TreeNode();
            rootNode.Text = "업체명";
            treeView1.Nodes.Add(rootNode);
            rootNode.ImageIndex = 0;

            roomDAC dac = new roomDAC();
            DataTable dt = dac.GetMyAccomRoomList(CurrentUser.UserId);
            dac.Dispose();

            foreach (DataRow dr in dt.Rows)
            {

                if (!treeView1.Nodes[0].Nodes.ContainsKey(dr["accomId"].ToString()))
                {
                    TreeNode a_node = new TreeNode();
                    a_node.Text = dr["accomName"].ToString();
                    a_node.Name = dr["accomId"].ToString();
                    //a_node.Tag = dr["accomName"].ToString();
                    a_node.ImageIndex = 1;

                    treeView1.Nodes[0].Nodes.Add(a_node);
                }

                TreeNode r_node = new TreeNode();
                r_node.Text = dr["roomName"].ToString();
                r_node.Name = dr["accomId"].ToString();
                r_node.Tag = dr["accomName"].ToString();
                r_node.ImageIndex = 2;

                if (r_node.Text.Length > 0)
                    treeView1.Nodes[0].LastNode.Nodes.Add(r_node);
            }
            treeView1.ExpandAll();
            toolDelete.Enabled = pnlDetail.Visible = false;

            dtpCheckIn_Common_Holi.Text =
            dtpCheckIn_Common_Week.Text =
            dtpCheckIn_Peak_Holi.Text =
            dtpCheckIn_Peak_Week.Text =
            dtpCheckIn_Sale_Holi.Text =
            dtpCheckIn_Sale_Week.Text =
            dtpCheckOut_Common_Holi.Text =
            dtpCheckOut_Common_Week.Text =
            dtpCheckOut_Peak_Holi.Text =
            dtpCheckOut_Peak_Week.Text =
            dtpCheckOut_Sale_Holi.Text =
            dtpCheckOut_Sale_Week.Text = "00:00";
        }
            

        
    //tool 조회
    private void OnSelect(object sender, EventArgs e)
    {
        if (pnlRoomInfo.Visible == false)
        {
            SelectAccDgv();
            ClearAccomInfo();
        }
        else
        {
            SelectRoom();
            ClearRoomInfo();
        }
        toolDelete.Enabled = false;
    }

        //객실정보란 초기화
        private void ClearRoomInfo()
        {

            txtAccom.Text = txtRoomName.Text = txtRoomCnt.Text = txtPeople1.Text = txtPeople2.Text = lblImagePath.Text 
                = string.Empty;

            pictureBox1.Image  = null;
            listBox1.Items.Clear();
        }

        //tool 저장(수정) 버튼
        private void OnSave(object sender, EventArgs e)
        {
            int result;
            //업체정보에서  저장
            if (pnlRoomInfo.Visible == false) { 

                try
                {
                    accomDAC adac = new accomDAC();

                    Accom acc = new Accom();
                    acc.AccomId = AccomId;
                    acc.AccomName = txtAccomName.Text;
                    acc.AccomAddr1 = accomZip.ZipCode;
                    acc.AccomAddr2 = accomZip.Address1;
                    acc.AccomAddr3 = accomZip.Address2;
                    acc.AccomEmail = txtAccomEmail.Text;
                    acc.AccomTel = txtAccomTel.Text;
                    StringBuilder sb = new StringBuilder();
                    foreach (var item in clbFacility.CheckedItems)
                    {
                        sb.Append(item + " ");
                    }
                    acc.AccomFacility = sb.ToString();
                    acc.AccomType = cboAccomType.Text;
                    acc.AccomInfo = txtAccomInfo.Text;
                    

                    result = adac.AccomUpdate(acc);
                    adac.Dispose();

                    if (result > 0)
                    {
                        MessageBox.Show("업체 수정이 완료되었습니다.");
                        SelectAccDgv();
                    }
                    else
                    { 
                        MessageBox.Show("업체 수정에 실패했습니다. 다시 시도하세요.");
                    }
                }
                catch (Exception err)
                {
                MessageBox.Show(err.Message);
                }
            }

            
            //객실정보에서 저장
            else
            {
                try
                {
                    roomDAC rdac = new roomDAC();
                    result = rdac.RoomUpdate(UpdateRoom);
                    int imgResultUpdate = 0;
                    int imgResultDel = 0;

                    if (result > 0)
                    {
                        imageDAC idac = new imageDAC();
                        DataTable idt = idac.GetImage(AccomId, txtRoomName.Text);
                        int imageCount;

                        if (idt.Rows.Count < 1) imageCount = 1;
                        else imageCount = idt.Rows.Count;

                        for (int j = 0; j < imageCount; j++)
                        {
                            imgResultDel = 0;

                            for (int i = 0; i < listBox1.Items.Count; i++)
                            {
                                string listItem = listBox1.Items[i].ToString();

                                if (j == 0)
                                {
                                    int count = listItem.Count(f => f == '\\');

                                    if (count > 1)
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
                                        imgResultUpdate = idac.ImageAdd(AccomId, txtRoomName.Text, destFileName);

                                    }
                                }

                                if (idt.Rows.Count < 1) continue;
                                if (idt.Rows[j]["imagePath"].ToString().Contains(listItem))
                                {
                                    imgResultDel++;
                                    continue;
                                }

                            }
                            if (idt.Rows.Count < 1) continue;
                            if (imgResultDel == 0)
                            {
                                imgResultDel = idac.DeleteImage(Convert.ToInt32(idt.Rows[j]["imageId"]));
                                File.Delete(idt.Rows[j]["imagePath"].ToString());
                            }

                        }
                        if (imgResultUpdate > 0 || imgResultDel > 0)
                        {
                            MessageBox.Show("객실 등록 및 이미지 저장이 완료되었습니다.");
                            idac.Dispose();
                            rdac.Dispose();
                            this.DialogResult = DialogResult.OK;
                            //this.Close();
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

        }

        //tool 닫기 버튼
        private void OnClose(object sender, EventArgs e)
        {
            this.Close();
        }

        //tool 삭제 버튼 
        private void OnDelete(object sender, EventArgs e)
        {
            if (pnlRoomInfo.Visible == false)
            {
                DeleteAccom();
            }
            else
            {
                DeleteRoom();
            }
        }
        //업체 삭제 
        private void DeleteAccom()
        {
            if (txtAccomName.Text.Length < 1)
            {
                MessageBox.Show("삭제할 업체를 선택하세요.");
                return;
            }

            int result;
            try
            {
                if(MessageBox.Show($"[ {txtAccomName.Text} ] \n해당 업체를 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) 
                    == DialogResult.Yes)
                {
                    accomDAC adac = new accomDAC();
                    result = adac.AccomDelete(AccomId); //업체삭제
                    
                    roomDAC rdac = new roomDAC();
                    imageDAC idac = new imageDAC();
                    int resultRoomDel = rdac.RoomAllDelete(AccomId); //객실삭제
                    

                    DataTable idt = idac.GetAllImage(AccomId); //이미지 찾기

                    for (int i = 0; i < idt.Rows.Count; i++)
                    {
                        File.Delete(idt.Rows[i]["imagePath"].ToString()); //이미지파일 삭제
                    }
                    int resultImageDel = idac.DeleteAllImage(AccomId); //이미지 삭제


                    if (result > 0  && resultImageDel >= 0 && resultRoomDel >= 0)
                    {
                        MessageBox.Show("업체 및 모든 객실과 이미지 삭제가 완료되었습니다.");
                        Select(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("업체 삭제에 실패했습니다. 다시 시도하세요.");
                    }
                    idac.Dispose();
                    adac.Dispose();
                    rdac.Dispose();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        //객실 삭제
        private void DeleteRoom()
        {
            
            if (txtRoomName.Text.Length < 1)
            {
                MessageBox.Show("삭제할 객실을 선택하세요.");
                return;
            }

            int resultRoomDel, resultImageDel;
            try
            {
                
                if (MessageBox.Show($"[ {txtAccom.Text} - {txtRoomName.Text} ] \n해당 객실과 이미지를 모두 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    roomDAC rdac = new roomDAC();
                    imageDAC idac = new imageDAC();
                    resultRoomDel = rdac.RoomDelete(AccomId, txtRoomName.Text);

                    DataTable idt = idac.GetImage(AccomId, txtRoomName.Text);

                    for (int i = 0; i < idt.Rows.Count; i++)
                    {
                        File.Delete(idt.Rows[i]["imagePath"].ToString());
                    }
                    resultImageDel = idac.DeleteImage(AccomId, txtRoomName.Text);

                    if (resultRoomDel > 0 && resultImageDel != -1)
                    {            
                        rdac.Dispose();
                        idac.Dispose();

                        MessageBox.Show("객실 및 이미지 삭제가 완료되었습니다.");
                        Select(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("객실 및 이미지 삭제에 실패했습니다.");
                    }

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        //tool 객실정보
        private void OnRoomInfo(object sender, EventArgs e)
        {
            pnlRoomInfo.Visible = true;
            toolRoomAdd.Enabled = false;
            OnSelect(this, e);
        }

        //tool 업체정보
        private void OnAccomInfo(object sender, EventArgs e)
        {
            pnlRoomInfo.Visible = toolRoomAdd.Enabled = false;
            OnSelect(this, e);
        }


        
        //tool 업체추가
        private void toolAccomAdd_Click(object sender, EventArgs e)
        {
            accomAdd acadd = new accomAdd(CurrentUser);
            acadd.ShowDialog();
            if (acadd.DialogResult == DialogResult.OK)
                OnSelect(this, e);
        }

        //tool 객실추가
        private void toolRoomAdd_Click(object sender, EventArgs e)
        {

            roomAdd radd = new roomAdd(AccomId);
            radd.ShowDialog();
            radd.Dispose();
            SelectRoom();

        }

        //dgvAccom 데이터그리드뷰 업체정보 보기
        private void dgvAccom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            toolDelete.Enabled = true;
            toolRoomAdd.Enabled = true;
            toolDelete.Enabled = true;

            txtAccomName.Text = dgvAccom["accomName", e.RowIndex].Value.ToString();
            txtRepName.Text = dgvAccom["repName", e.RowIndex].Value.ToString();
            txtCRNum.Text = dgvAccom["crNum", e.RowIndex].Value.ToString();
            cboAccomType.Text = dgvAccom["accomType", e.RowIndex].Value.ToString();
            txtAccomTel.Text = dgvAccom["accomTel", e.RowIndex].Value.ToString();
            txtAccomEmail.Text = dgvAccom["accomEmail", e.RowIndex].Value.ToString();
            accomZip.ZipCode = dgvAccom["accomAddr1", e.RowIndex].Value.ToString();
            accomZip.Address1 = dgvAccom["accomAddr2", e.RowIndex].Value.ToString();
            accomZip.Address2 = dgvAccom["accomAddr3", e.RowIndex].Value.ToString();
            string fac = dgvAccom["accomFacility", e.RowIndex].Value.ToString();
            for (int i = 0; i < clbFacility.Items.Count; i++)
            {
                bool isCheck = fac.Contains(clbFacility.Items[i].ToString());
                clbFacility.SetItemChecked(i, isCheck);
            }
            txtAccomInfo.Text = dgvAccom["accomInfo", e.RowIndex].Value.ToString();

            AccomId = Convert.ToInt32(dgvAccom["accomId", e.RowIndex].Value);

        }

        //트리뷰 객실정보 보기 (노드클릭)
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            toolRoomAdd.Enabled = toolDelete.Enabled = btnDetail.Enabled =  true;
            txtCurrentPrice.Text = "";
            ClearRoomInfo();
            //rootnode 클릭
            if (e.Node.Text == "업체명")
            {
                toolRoomAdd.Enabled = toolDelete.Enabled = btnDetail.Enabled = false;
                return;
            }


            //업체명 클릭
            if (e.Node.Tag == null) { 
                AccomId = Convert.ToInt32(treeView1.SelectedNode.Name);
                
                txtAccom.Text = e.Node.Text;
                toolDelete.Enabled  = pnlDetail.Visible = false;
                return;
            }


            roomDAC rdac = new roomDAC();
            DataTable dt = rdac.GetMyRoomInfo(Convert.ToInt32(e.Node.Name), e.Node.Text);
            rdac.Dispose();

            
            AccomId = Convert.ToInt32(dt.Rows[0]["accomId"]);
            txtAccom.Text = dt.Rows[0]["accomName"].ToString();
            txtRoomName.Text = dt.Rows[0]["roomName"].ToString();
            txtRoomCnt.Text = dt.Rows[0]["roomCnt"].ToString();
            txtPeople1.Text = dt.Rows[0]["roomPeople"].ToString().Substring(0, dt.Rows[0]["roomPeople"].ToString().IndexOf('/'));
            txtPeople2.Text = dt.Rows[0]["roomPeople"].ToString().Substring(dt.Rows[0]["roomPeople"].ToString().IndexOf('/')+1);
            

            txtLendTime_Common_Holi.Text = dt.Rows[0]["roomLendTime_Common_Holi"].ToString();
            txtLendTime_Common_Week.Text = dt.Rows[0]["roomLendTime_Common_Week"].ToString();
            txtLendTime_Peak_Holi.Text = dt.Rows[0]["roomLendTime_Peak_Holi"].ToString();
            txtLendTime_Peak_Week.Text = dt.Rows[0]["roomLendTime_Peak_Week"].ToString();
            txtLendTime_Sale_Holi.Text = dt.Rows[0]["roomLendTime_Sale_Holi"].ToString();
            txtLendTime_Sale_Week.Text = dt.Rows[0]["roomLendTime_Sale_Week"].ToString();

            dtpCheckIn_Common_Holi.Text =
            dtpCheckIn_Common_Week.Text =
            dtpCheckIn_Peak_Holi.Text =
            dtpCheckIn_Peak_Week.Text =
            dtpCheckIn_Sale_Holi.Text =
            dtpCheckIn_Sale_Week.Text =
            dtpCheckOut_Common_Holi.Text =
            dtpCheckOut_Common_Week.Text =
            dtpCheckOut_Peak_Holi.Text =
            dtpCheckOut_Peak_Week.Text =
            dtpCheckOut_Sale_Holi.Text =
            dtpCheckOut_Sale_Week.Text = "00:00";


            if (dt.Rows[0]["roomCheckIn_Common_Holi"].ToString().Length>0)
                dtpCheckIn_Common_Holi.Text = dt.Rows[0]["roomCheckIn_Common_Holi"].ToString();
            if (dt.Rows[0]["roomCheckIn_Common_Week"].ToString().Length > 0)
                dtpCheckIn_Common_Week.Text = dt.Rows[0]["roomCheckIn_Common_Week"].ToString();
            if (dt.Rows[0]["roomCheckIn_Peak_Holi"].ToString().Length > 0)
                dtpCheckIn_Peak_Holi.Text = dt.Rows[0]["roomCheckIn_Peak_Holi"].ToString();
            if (dt.Rows[0]["roomCheckIn_Peak_Week"].ToString().Length > 0)
                dtpCheckIn_Peak_Week.Text = dt.Rows[0]["roomCheckIn_Peak_Week"].ToString();
            if (dt.Rows[0]["roomCheckIn_Sale_Holi"].ToString().Length > 0)
                dtpCheckIn_Sale_Holi.Text = dt.Rows[0]["roomCheckIn_Sale_Holi"].ToString();
            if (dt.Rows[0]["roomCheckIn_Sale_Week"].ToString().Length > 0)
                dtpCheckIn_Sale_Week.Text = dt.Rows[0]["roomCheckIn_Sale_Week"].ToString();

            if (dt.Rows[0]["roomCheckOut_Common_Holi"].ToString().Length > 0)
                dtpCheckOut_Common_Holi.Text = dt.Rows[0]["roomCheckOut_Common_Holi"].ToString();
            if (dt.Rows[0]["roomCheckOut_Common_Week"].ToString().Length > 0)
                dtpCheckOut_Common_Week.Text = dt.Rows[0]["roomCheckOut_Common_Week"].ToString();
            if (dt.Rows[0]["roomCheckOut_Peak_Holi"].ToString().Length > 0)
                dtpCheckOut_Peak_Holi.Text = dt.Rows[0]["roomCheckOut_Peak_Holi"].ToString();
            if (dt.Rows[0]["roomCheckOut_Peak_Week"].ToString().Length > 0)
                dtpCheckOut_Peak_Week.Text = dt.Rows[0]["roomCheckOut_Peak_Week"].ToString();
            if (dt.Rows[0]["roomCheckOut_Sale_Holi"].ToString().Length > 0)
                dtpCheckOut_Sale_Holi.Text = dt.Rows[0]["roomCheckOut_Sale_Holi"].ToString();
            if (dt.Rows[0]["roomCheckOut_Sale_Week"].ToString().Length > 0)
                dtpCheckOut_Sale_Week.Text = dt.Rows[0]["roomCheckOut_Sale_Week"].ToString();

            txtPrice_Common_Week_Stay.Text = dt.Rows[0]["price_Common_Week_Stay"].ToString();
            txtPrice_Common_Week_Lend.Text = dt.Rows[0]["price_Common_Week_Lend"].ToString();
            txtPrice_Common_Holi_Stay.Text = dt.Rows[0]["price_Common_Holi_Stay"].ToString();
            txtPrice_Common_Holi_Lend.Text = dt.Rows[0]["price_Common_Holi_Lend"].ToString();
           
            txtPrice_Peak_Week_Stay.Text = dt.Rows[0]["price_Peak_Week_Stay"].ToString();           
            txtPrice_Peak_Week_Lend.Text = dt.Rows[0]["price_Peak_Week_Lend"].ToString();
            txtPrice_Peak_Holi_Stay.Text = dt.Rows[0]["price_Peak_Holi_Stay"].ToString();
            txtPrice_Peak_Holi_Lend.Text = dt.Rows[0]["price_Peak_Holi_Lend"].ToString();

            txtPrice_Sale_Week_Stay.Text = dt.Rows[0]["price_Sale_Week_Stay"].ToString();
            txtPrice_Sale_Week_Lend.Text = dt.Rows[0]["price_Sale_Week_Lend"].ToString();
            txtPrice_Sale_Holi_Stay.Text = dt.Rows[0]["price_Sale_Holi_Stay"].ToString();           
            txtPrice_Sale_Holi_Lend.Text = dt.Rows[0]["price_Sale_Holi_Lend"].ToString();


            if (dt.Rows[0]["CheckSaleYN"].ToString() == "Y")
            {
                txtCurrentPrice.Text = "[ 특가 ]";
                txtCurrentPrice.ForeColor = Color.DeepPink;
                ckbSale.Checked = true;
                ckbPeak.Checked = ckbCommon.Checked = false;
                ckbSale_CheckedChanged(this, e);
            }
            else if (dt.Rows[0]["CheckPeakYN"].ToString() == "Y")
            {
                txtCurrentPrice.Text = "[ 성수기 ]";
                txtCurrentPrice.ForeColor = Color.DarkOrange;
                ckbPeak.Checked = true;
                ckbSale.Checked = ckbCommon.Checked = false;
                ckbPeak_CheckedChanged(this, e);
            }
            else
            {
                txtCurrentPrice.Text = "[ 일반 ]";
                txtCurrentPrice.ForeColor = Color.YellowGreen;
                ckbCommon.Checked = true;
                ckbPeak.Checked = ckbSale.Checked = false;
                ckbCommon_CheckedChanged(this, e);
            }




            if (dt.Rows[0]["checkLendYN"].ToString() == "Y")
            {
                ckbLend.Checked = true;
                ckbLend_CheckedChanged(this, e);
            }
            else
            {
                ckbLend.Checked = false;
                ckbLend_CheckedChanged(this, e);
            }

            if (dt.Rows[0]["checkStayYN"].ToString() == "Y")
            {
                ckbStay.Checked = true;
                ckbStay_CheckedChanged(this, e);
            }
            else
            {
                ckbStay.Checked = false;
                ckbStay_CheckedChanged(this, e);
            }



            pictureBox1.Image = null;
            listBox1.Items.Clear();


            imageDAC idac = new imageDAC();
            DataTable idt = idac.GetImage(Convert.ToInt32(dt.Rows[0]["accomID"]), txtRoomName.Text);
            idac.Dispose();
            if (idt.Rows.Count < 1) return;
            
            pictureBox1.Image = Image.FromFile(idt.Rows[0]["imagePath"].ToString());
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


            for (int i = 0; i < idt.Rows.Count; i++)
            {
                listBox1.Items.Add(idt.Rows[i]["imagePath"].ToString());
            }

            //리스트박스 스크롤
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            listBox1.SelectedIndex = 0;
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



        //객실정보 > 리스트박스 선택시 - 이미지 출력  
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string filePath = listBox1.SelectedItems[0].ToString();
                pictureBox1.ImageLocation = filePath;
                lblImagePath.Text = filePath;
            }
        }

        //객실정보 > 이미지 추가 버튼
        private void btnImageAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Images File(*.gif;*.jpg;*.jpeg;*.png;*.bmp)|*.gif;*.jpg;*.jpeg;*.png;*.bmp";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = dlg.FileName; //전체경로
                pictureBox1.Image = Image.FromFile(dlg.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                string sPath = ConfigurationManager.AppSettings["uploadPath"] + dlg.FileNames + "/";

                for (int i = 0; i < dlg.FileNames.Count(); i++)
                {
                    listBox1.Items.Add(dlg.FileNames[i].ToString());
                }
            }
        }

        //객실정보 > 이미지 삭제 버튼
        private void btnImageDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;    
            
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
            else
                pictureBox1.Image = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlDetail.Visible = false;
        }



        private void btnDetail_Click(object sender, EventArgs e)
        {
            pnlDetail.Visible = true;
        }


    }
}
