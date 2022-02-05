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
    public partial class login : Form
    {
        public User LoginUser { get; set; }
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            join jo = new join();
            this.TopLevel = false;
            jo.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text) || string.IsNullOrWhiteSpace(txtUserPw.Text))
            {
                MessageBox.Show("아이디와 비밀번호를 입력하세요.");
                return;
            }

            bool isGuestCheck = rbnGuestUser.Checked;
            UserDAC dac = new UserDAC();
            User loginUser = dac.Login(txtUserId.Text);
            dac.Dispose();

            //if (loginUser == null)
            //{
            //    MessageBox.Show("유효한 아이디가 아닙니다. 회원가입을 진행하세요.");
            //    return;
            //}

            if (loginUser != null && ((loginUser.IsAccomYN == "Y" && isGuestCheck==false) || (loginUser.IsAccomYN == "N" && isGuestCheck==true)))
            {
                if (loginUser.UserPw != txtUserPw.Text)
                {
                    MessageBox.Show("비밀번호가 틀렸습니다.");
                    return;
                }
                else
                {
                    this.LoginUser = loginUser;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("유효한 계정 정보가 아닙니다.");
                return;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void txtUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void login_Click(object sender, EventArgs e)
        {

        }
    }
}
