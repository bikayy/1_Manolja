using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manolza
{

    public class Reserve
    {
        public int ReserveId { get; set; }
        public int AccomId { get; set; }
        public string RoomName { get; set; }
        public string UserId { get; set; }
        public string ReserveTypeLS { get; set; }
        public DateTime ReserveCheckIn { get; set; }
        public DateTime ReserveCheckOut { get; set; }        
        public DateTime ReserveDate { get; set; }
        public string GuestName { get; set; }
        public string GuestPhone { get; set; }
        public string ReserveState { get; set; }
        public string PaymentMethod { get; set; }
        public int Payment { get; set; }
    }


    public class reserveDAC : IDisposable
    {
        MySqlConnection conn;

        public reserveDAC()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["manolza"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

    
        public string GetDay(string day)
        {

			switch (day)
			{
				case "Monday": return "월";
				case "Tuesday": return "화";
				case "Wednesday": return "수";
				case "Thursday": return "목";
				case "Friday": return "금";
				case "Saturday": return "토";
				case "Sunday": return "일";
				default: return "";
			}
		}


        public int ReserveAdd(Reserve reserve) //객실 예약하기
        {
            string sql = @"insert into 
reserve (accomId, roomName, userId, reserveTypeLS, reserveCheckIn, reserveCheckOut, reserveDate, GuestName, GuestPhone, reserveState, paymentMethod, payment) 
values (@accomId, @roomName, @userId, @reserveTypeLS, @reserveCheckIn, @reserveCheckOut, @reserveDate, @GuestName, @GuestPhone, @reserveState, @paymentMethod, @payment);";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@accomId", reserve.AccomId);
                cmd.Parameters.AddWithValue("@roomName", reserve.RoomName);
                cmd.Parameters.AddWithValue("@userId", reserve.UserId);
                cmd.Parameters.AddWithValue("@reserveTypeLS", reserve.ReserveTypeLS);
                cmd.Parameters.AddWithValue("@reserveCheckIn", reserve.ReserveCheckIn);
                cmd.Parameters.AddWithValue("@reserveCheckOut", reserve.ReserveCheckOut);
                cmd.Parameters.AddWithValue("@reserveDate", reserve.ReserveDate);
                cmd.Parameters.AddWithValue("@guestName", reserve.GuestName);
                cmd.Parameters.AddWithValue("@guestPhone", reserve.GuestPhone);
                cmd.Parameters.AddWithValue("@reserveState", reserve.ReserveState);
                cmd.Parameters.AddWithValue("@paymentMethod", reserve.PaymentMethod);
                cmd.Parameters.AddWithValue("@payment", reserve.Payment);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }


        /// <summary>
        /// 숙박 예약 조회 (accomId, roomName 기준)
        /// </summary>
        /// <param name="accomId"></param>
        /// <param name="roomName"></param>
        /// <returns></returns>
        public DataTable GetReserve (int accomId, string roomName, string reserveTypeLS)
        {
            string sql = @"SELECT reserveId, accomId, roomName, userId, guestName, guestPhone, reserveTypeLS, reserveCheckIn, reserveCheckOut, reserveState, paymentMethod, payment, reserveDate where accomId = @accomId and roomName = @roomName and reserveTypeLS = @reserveTypeLS;";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@accomId", accomId);
            da.SelectCommand.Parameters.AddWithValue("@roomName", roomName);
            da.SelectCommand.Parameters.AddWithValue("@reserveTypeLS", reserveTypeLS);
            da.Fill(dt);

            return dt;
        }

        public DataTable GetReserveCnt(int accomId, string roomName, string reserveTypeLS, string checkinDate)
        {
            string sql = @"SELECT reserveCheckIn, reserveCheckOut, TIMESTAMPDIFF(DAY, date_format(reserveCheckIn, '%Y-%m-%d'), date_format(reserveCheckOut, '%Y-%m-%d'))as dateCnt 
from reserve 
where accomId = @accomId and roomName = @roomName and reserveTypeLS=@reserveTypeLS and reserveCheckOut >= @checkinDate;";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@accomId", accomId);
            da.SelectCommand.Parameters.AddWithValue("@roomName", roomName);
            da.SelectCommand.Parameters.AddWithValue("@reserveTypeLS", reserveTypeLS);
            da.SelectCommand.Parameters.AddWithValue("@checkinDate", checkinDate);

            da.Fill(dt);

            return dt;
        }


        public DataTable GetMyReserve(string userId)
        {
            string sql = @"SELECT i.imagePath, reserveId, r.accomId, accomName, accomAddr2, r.roomName, r.userId, guestName, guestPhone, reserveTypeLS, reserveCheckIn, reserveCheckOut, reserveState, paymentMethod, payment, reserveDate FROM reserve r
inner join accom a on a.accomId = r.accomId 
inner join image i on r.roomName = i.roomName 
where r.userId = @userId
group by reserveId;";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@userId", userId);

            da.Fill(dt);

            return dt;
        }


        public DataTable GetReserveCheck(string userId)
        {
            string sql = @"SELECT i.imagePath, reserveId, r.accomId, accomName, accomAddr2, r.roomName, r.userId, guestName, guestPhone, CASE reserveTypeLS WHEN 'S' THEN '숙박' WHEN 'L' THEN '대실' end as reserveTypeLS, reserveCheckIn, reserveCheckOut, reserveState, paymentMethod, payment, reserveDate FROM reserve r
inner join accom a on a.accomId = r.accomId 
inner join image i on r.roomName = i.roomName 
where a.userId = @userId
group by reserveId order by reserveCheckIn;";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@userId", userId);

            da.Fill(dt);

            return dt;
        }
    }
}
