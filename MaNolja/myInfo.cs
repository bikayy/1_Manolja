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
    public partial class myInfo : Form
    {
        public User CurrentUser { get; set; }


        public User UpdateUser
        {
            get
            {
                User user = new User();
                user.UserId = txtUserId.Text;
                user.UserPw = txtUserNewPw.Text;
                user.UserPhone = txtUserPhone.Text;
                user.UserName = txtUserName.Text;
                return user;
            }
            set
            {
                value.UserId.ToString();
                value.UserPw.ToString();
                value.UserPhone.ToString();
                value.UserName.ToString();
            }
        }

        public myInfo(User curUser)
        {
            InitializeComponent();
            CurrentUser = curUser;
        }

        private void btnCancle_Click(object sender, EventArgs e) //
        {
            this.Close();
        }

        private void myInfo_Load(object sender, EventArgs e)
        {
            UserDAC dac = new UserDAC();
            User user = dac.Login(CurrentUser.UserId);

            txtUserId.Text = user.UserId;
            txtUserName.Text = user.UserName;
            txtUserPhone.Text = user.UserPhone;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserCurPw.Text) || string.IsNullOrWhiteSpace(txtUserNewPw.Text) || string.IsNullOrWhiteSpace(txtUserNewPw2.Text) || string.IsNullOrWhiteSpace(txtUserPhone.Text) || string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("입력하지 않은 항목이 있습니다.", "정보수정");
                return;
            }

            if (lblUserPw.Visible == true || lblUserPw2.Visible == true || lblUserPhone.Visible == true || lblUserName.Visible == true)
            {
                MessageBox.Show("입력한 값의 유형이 올바르지 않습니다.", "정보수정");
                return;
            }
            UserDAC dac = new UserDAC();
            int iResult = dac.UpdateUser(UpdateUser, txtUserCurPw.Text);
            dac.Dispose();



            if (iResult > 0)
            {
                MessageBox.Show("정보 수정이 완료되었습니다.");

            }
            else
            {
                MessageBox.Show("정보 수정에 실패했습니다. 입력 값을 다시 확인하세요.");
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


        

        private void txtUserPw_TextChanged(object sender, EventArgs e)
        {
            if (txtUserNewPw.Text.Length < 6 || txtUserNewPw.Text.Length > 16)
            {
                lblUserPw.Visible = true;
            }
            else
            {
                lblUserPw.Visible = false;
            }

            if (txtUserNewPw2.Text.Length < 6 || txtUserNewPw2.Text.Length > 16)
            {
                lblUserPw2.Visible = true;
            }
            else
            {
                lblUserPw2.Visible = false;
            }

            if (txtUserNewPw.Text != txtUserNewPw2.Text)
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


        private void btnCancle_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
