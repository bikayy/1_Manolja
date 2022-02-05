using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manolza
{
    public partial class join : Form
    {
        public User JoinUser
        {
            get
            {
                User user = new User();
                user.UserId = txtUserId.Text;
                user.UserPw = txtUserPw.Text;
                user.UserPhone = txtUserPhone.Text;
                user.UserName = txtUserName.Text;
                return user;
            }
            set
            {
                txtUserId.Text = value.UserId;
                txtUserPw.Text = value.UserPw;
                txtUserPhone.Text = value.UserPhone;
                txtUserName.Text = value.UserName;
            }
        }
        public join()
        {
            InitializeComponent();
        }


        private void btnCancle_Click(object sender, EventArgs e) //회원가입 취소
        {
            this.Close();
            login log = new login();
            log.Show();
        }

        private void btnJoin_Click(object sender, EventArgs e) //회원가입 완료
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text) || string.IsNullOrWhiteSpace(txtUserPw.Text) || string.IsNullOrWhiteSpace(txtUserPw2.Text) || string.IsNullOrWhiteSpace(txtUserPhone.Text) || string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("입력하지 않은 항목이 있습니다.", "회원가입");
                return;
            }


            UserDAC dac = new UserDAC();
            int iResult = dac.Join(JoinUser);
            dac.Dispose();

            if (iResult > 0)
            {
                MessageBox.Show("회원가입이 완료되었습니다.");
                this.Close();
                login log = new login();
                log.Show();
            }

        }


        private void btnCheckId_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUserId.Text) || lblUserId.Visible == true)
            {
                MessageBox.Show("현재 비밀번호를 입력하세요.");
                return;
            }
            UserDAC dac = new UserDAC();
            bool bFlag = dac.ConfirmUserId(txtUserId.Text);
            if (!bFlag)
            {
                MessageBox.Show("사용 가능한 아이디입니다.");
                return;
            }
            else
            {
                MessageBox.Show("중복된 아이디입니다. 다른 아이디를 이용하세요.");
                return;
            }
        }



        private void btnCheckName_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length > 6 || String.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("1~6자리의 닉네임만 사용 가능합니다.");
                return;
            }
            UserDAC dac = new UserDAC();
            bool bFlag = dac.ConfirmUserName(txtUserName.Text);
            if (!bFlag)
            {
                MessageBox.Show("사용 가능한 닉네임입니다.");
                return;
            }
            else
            {
                MessageBox.Show("중복된 닉네임입니다. 다른 닉네임을 이용하세요.");
                return;
            }
        }



        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            bool validId = Regex.IsMatch(txtUserId.Text, @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?");

            if (!validId)
            {
                lblUserId.Visible = true;
            }
            else
            {
                lblUserId.Visible = false;
            }
        }


        private void txtUserPw_TextChanged(object sender, EventArgs e)
        {
            if (txtUserPw.Text.Length < 6 || txtUserPw.Text.Length > 16)
            {
                lblUserPw.Visible = true;
            }
            else
            {
                lblUserPw.Visible = false;
            }
        }



        private void txtUserPw2_TextChanged(object sender, EventArgs e)
        {
            if (txtUserPw.Text != txtUserPw2.Text)
            {
                lblUserPw2.Visible = true;
            }
            else
            {
                lblUserPw2.Visible = false;
            }
        }


        private void txtUserPhone_TextChanged(object sender, EventArgs e)
        {
            bool validPhone = Regex.IsMatch(txtUserPhone.Text, @"^[0-9]\d{1,2}-\d{3,4}-\d{4}");

            if (!validPhone)
            {
                lblUserPhone.Visible = true;
            }
            else
            {
                lblUserPhone.Visible = false;
            }
        }

        private void txtUserPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
                return;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // '\b'               
                e.Handled = true;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

            if (txtUserName.Text.Length > 6 || String.IsNullOrWhiteSpace(txtUserName.Text))
            {
                lblUserName.Visible = true;
            }
            else
            {
                lblUserName.Visible = false;
            }
        }

        private void join_Load(object sender, EventArgs e)
        {

        }
    }
}
