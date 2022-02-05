using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace manolza
{
    public class User
    {
        public string UserId { get; set; }
        public string UserPw { get; set; }
        public string UserName { get; set; }
        public string UserPhone { get; set; }
        public string IsAccomYN { get; set; }
    }
    public class UserDAC : IDisposable
    {
        MySqlConnection conn;

        public UserDAC()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["manolza"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        
        public User Login(string userId) //로그인
        {
            string sql = "select userId, userPw, userName, userPhone, isAccomYN from user where userId=@userId";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userId", userId);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                User loginUser = new User();
                loginUser.UserId = reader["userId"].ToString();
                loginUser.UserPw = reader["userPw"].ToString();
                loginUser.UserName = reader["userName"].ToString();
                loginUser.UserPhone = reader["userPhone"].ToString();
                loginUser.IsAccomYN = reader["isAccomYN"].ToString();

                return loginUser;
            }
            else
            {
                return null;
            }
        }

        public bool ConfirmUserId(string id) //아이디 중복체크
        {
            string sql = "select count(*) from user where userId=@userId";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userId", id);

            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            return (cnt > 0);

        }

        //public bool ConfirmUserPw(string Pw) //비밀번호 일치 확인
        //{
        //    string sql = "select  userPw, userName from user where userId='bk' and userPw= '1234';";

        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    cmd.Parameters.AddWithValue("@userId", id);

        //    int cnt = Convert.ToInt32(cmd.ExecuteScalar());
        //    return (cnt > 0);

        //}

        public bool ConfirmUserName(string name) //닉네임 중복체크
        {
            string sql = "select count(*) from user where userName=@userName";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userName", name);

            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            return (cnt > 0);
        }


        public int Join(User user) //회원가입
        {
            string sql = "insert into user(userId, userPw, userPhone, userName) values (@userId, @userPw, @userPhone, @userName);";
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userId", user.UserId);
                cmd.Parameters.AddWithValue("@userPw", user.UserPw);
                cmd.Parameters.AddWithValue("@userPhone", user.UserPhone);
                cmd.Parameters.AddWithValue("@userName", user.UserName);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }

        }


        /// <summary>
        /// 회원정보수정
        /// </summary>
        /// <param name="user"></param>
        /// <param name="userCurPw"></param>
        /// <returns></returns>
        public int UpdateUser(User user, string userCurPw)
        {
            string sql = "UPDATE user SET userPw=@userPw, userName=@userName, userPhone=@userPhone where userId=@userId and userPw=@userCurPw;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userId", user.UserId);
                cmd.Parameters.AddWithValue("@userPw", user.UserPw);
                cmd.Parameters.AddWithValue("@userPhone", user.UserPhone);
                cmd.Parameters.AddWithValue("@userName", user.UserName);
                cmd.Parameters.AddWithValue("@userCurPw", userCurPw);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }

        }
    }
}
