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
    public partial class home : Form
    {
        public User CurrentUser { get; set; }

        
        public static User UserId { get; set; }



        //임시로 업체ID 고정 저장
        int accomId = 2;

        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            login login = new login();
            if (login.ShowDialog() == DialogResult.OK)
            {

                //로그인 권한 ~
                CurrentUser = login.LoginUser;
                UserId = this.CurrentUser;
                lblUserName.Text = $"{CurrentUser.UserName}님, 환영합니다.";
                

                if (CurrentUser.IsAccomYN == "Y")
                {
                    accomMenu.Visible = true;
                    userMenu.Visible = true;// false;
                }
                else
                {
                    accomMenu.Visible = false;
                    userMenu.Visible = true;
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void 객실등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomAdd rmadd = new roomAdd(accomId);
            rmadd.MdiParent = this;
            rmadd.Show();
        }

        private void 내정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myInfo myinfo = new myInfo(CurrentUser);
            myinfo.MdiParent = this;
            myinfo.Show();
        }

        private void 업체등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accomAdd acadd = new accomAdd(CurrentUser);
            acadd.MdiParent = this;
            acadd.Show();
        }

        private void 나의업체ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myAccom myacc = new myAccom(CurrentUser);
            myacc.MdiParent = this;
            myacc.Show();
        }

        private void 숙박검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accomList acclist = new accomList();
            acclist.MdiParent = this;
            acclist.Show();
        }

        private void 내정보ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            myInfo myinfo = new myInfo(CurrentUser);
            myinfo.MdiParent = this;
            myinfo.Show();
        }

        private void 예약내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myReserve myreserve = new myReserve(CurrentUser);
            myreserve.MdiParent = this;
            myreserve.Show();
        }

        private void 예약내역ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            reserveCheck rcheck = new reserveCheck(CurrentUser);
            rcheck.MdiParent = this;
            rcheck.Show();
        }
    }
}
