using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace manolza
{
    public class Room
    {
        public int AccomId { get; set; }
        public string RoomName { get; set; }
        public string RoomPeople { get; set; }
        public int RoomTotCnt { get; set; }


        public DateTime? roomCheckIn_Common_Week { get; set; }
        public DateTime? roomCheckOut_Common_Week { get; set; }
        public DateTime? roomCheckIn_Common_Holi { get; set; }
        public DateTime? roomCheckOut_Common_Holi { get; set; }
 
        public DateTime? roomCheckIn_Peak_Week { get; set; }
        public DateTime? roomCheckOut_Peak_Week { get; set; }
        public DateTime? roomCheckIn_Peak_Holi { get; set; }
        public DateTime? roomCheckOut_Peak_Holi { get; set; }
   
        public DateTime? roomCheckIn_Sale_Week { get; set; }
        public DateTime? roomCheckOut_Sale_Week { get; set; }
        public DateTime? roomCheckIn_Sale_Holi { get; set; }
        public DateTime? roomCheckOut_Sale_Holi { get; set; }


        public int? roomLendTime_Common_Week { get; set; }
        public int? roomLendTime_Common_Holi { get; set; }
        public int? roomLendTime_Peak_Week { get; set; }
        public int? roomLendTime_Peak_Holi { get; set; }
        public int? roomLendTime_Sale_Week { get; set; }
        public int? roomLendTime_Sale_Holi { get; set; }


        public int? price_Common_Week_Lend { get; set; }
        public int? price_Common_Week_Stay { get; set; }
        public int? price_Common_Holi_Lend { get; set; }
        public int? price_Common_Holi_Stay { get; set; }


        public int? price_Peak_Week_Lend { get; set; }
        public int? price_Peak_Week_Stay { get; set; }
        public int? price_Peak_Holi_Lend { get; set; }
        public int? price_Peak_Holi_Stay { get; set; }


        public int? price_Sale_Week_Lend { get; set; }
        public int? price_Sale_Week_Stay { get; set; }
        public int? price_Sale_Holi_Lend { get; set; }
        public int? price_Sale_Holi_Stay { get; set; }


        public string CheckSaleYN { get; set; }
        public string CheckPeakYN { get; set; }

        public string CheckStayYN { get; set; }
        public string CheckLendYN { get; set; }



        //
        public string RoomImage { get; set; }
        public string RoomCheckinTime { get; set; }
        public string RoomCheckoutTime { get; set; }
        public int RoomStayPrice { get; set; }
        public int RoomLendTime { get; set; }
        public int RoomLendPrice { get; set; }
        public string AccomName { get; set; }
        
    }

    public class roomDAC : IDisposable
    {
        MySqlConnection conn;

        public roomDAC()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["manolza"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }


        public DataTable GetRoomImage(int imageId)
        {
            string sql = @"select imageId, accomId, roomName, imagePath, imageDate from image where imageId = @imageId;";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@imageId", imageId);

            da.Fill(dt);

            return dt;
        }

        public int roomCnt(int accomId)
        {

            string sql = "select count(roomName) from room where accomId=@accomId;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@accomId", accomId);
            int cnt= Convert.ToInt32(cmd.ExecuteScalar());
            return cnt;

        }

        /// <summary>
        /// 객실 등록하기 (Room타입)
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public int RoomAdd(Room room)
        {
            string sql = @"insert into
room(accomId, roomName, roomPeople, roomCnt, 
roomCheckIn_Common_Week, roomCheckOut_Common_Week, roomCheckIn_Common_Holi, roomCheckOut_Common_Holi, roomCheckIn_Peak_Week, roomCheckOut_Peak_Week, roomCheckIn_Peak_Holi, roomCheckOut_Peak_Holi, roomCheckIn_Sale_Week, roomCheckOut_Sale_Week, roomCheckIn_Sale_Holi, roomCheckOut_Sale_Holi, 
roomLendTime_Common_Week, roomLendTime_Common_Holi, roomLendTime_Peak_Week, roomLendTime_Peak_Holi, roomLendTime_Sale_Week, roomLendTime_Sale_Holi, 
price_Common_Week_Lend, price_Common_Week_Stay, price_Common_Holi_Lend, price_Common_Holi_Stay, price_Peak_Week_Lend, price_Peak_Week_Stay, price_Peak_Holi_Lend, price_Peak_Holi_Stay, price_Sale_Week_Lend, price_Sale_Week_Stay, price_Sale_Holi_Lend, price_Sale_Holi_Stay, 
checkStayYN, checkLendYN, checkPeakYN, checkSaleYN)

values(@accomId, @roomName, @roomPeople, @roomCnt, 
@roomCheckIn_Common_Week, @roomCheckOut_Common_Week, @roomCheckIn_Common_Holi, @roomCheckOut_Common_Holi, @roomCheckIn_Peak_Week, @roomCheckOut_Peak_Week, @roomCheckIn_Peak_Holi, @roomCheckOut_Peak_Holi, @roomCheckIn_Sale_Week, @roomCheckOut_Sale_Week, @roomCheckIn_Sale_Holi, @roomCheckOut_Sale_Holi, 
@roomLendTime_Common_Week, @roomLendTime_Common_Holi, @roomLendTime_Peak_Week, @roomLendTime_Peak_Holi, @roomLendTime_Sale_Week, @roomLendTime_Sale_Holi, 
@price_Common_Week_Lend, @price_Common_Week_Stay, @price_Common_Holi_Lend, @price_Common_Holi_Stay, @price_Peak_Week_Lend, @price_Peak_Week_Stay, @price_Peak_Holi_Lend, @price_Peak_Holi_Stay, @price_Sale_Week_Lend, @price_Sale_Week_Stay, @price_Sale_Holi_Lend, @price_Sale_Holi_Stay, 
@checkStayYN, @checkLendYN, @checkPeakYN, @checkSaleYN); ";
         
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@accomId", room.AccomId);
                cmd.Parameters.AddWithValue("@roomName", room.RoomName);
                cmd.Parameters.AddWithValue("@roomPeople", room.RoomPeople);
                cmd.Parameters.AddWithValue("@roomCnt", room.RoomTotCnt);

                cmd.Parameters.AddWithValue("@roomCheckIn_Common_Week", room.roomCheckIn_Common_Week);
                cmd.Parameters.AddWithValue("@roomCheckIn_Common_Holi", room.roomCheckIn_Common_Holi);
                cmd.Parameters.AddWithValue("@roomCheckIn_Peak_Week", room.roomCheckIn_Peak_Week);
                cmd.Parameters.AddWithValue("@roomCheckIn_Peak_Holi", room.roomCheckIn_Peak_Holi);
                cmd.Parameters.AddWithValue("@roomCheckIn_Sale_Week", room.roomCheckIn_Sale_Week);
                cmd.Parameters.AddWithValue("@roomCheckIn_Sale_Holi", room.roomCheckIn_Sale_Holi);

                cmd.Parameters.AddWithValue("@roomCheckOut_Common_Week", room.roomCheckOut_Common_Week);
                cmd.Parameters.AddWithValue("@roomCheckOut_Common_Holi", room.roomCheckOut_Common_Holi);
                cmd.Parameters.AddWithValue("@roomCheckOut_Peak_Week", room.roomCheckOut_Peak_Week);
                cmd.Parameters.AddWithValue("@roomCheckOut_Peak_Holi", room.roomCheckOut_Peak_Holi);
                cmd.Parameters.AddWithValue("@roomCheckOut_Sale_Week", room.roomCheckOut_Sale_Week);
                cmd.Parameters.AddWithValue("@roomCheckOut_Sale_Holi", room.roomCheckOut_Sale_Holi);

                cmd.Parameters.AddWithValue("@roomLendTime_Common_Week", room.roomLendTime_Common_Week);
                cmd.Parameters.AddWithValue("@roomLendTime_Common_Holi", room.roomLendTime_Common_Holi);
                cmd.Parameters.AddWithValue("@roomLendTime_Peak_Week", room.roomLendTime_Peak_Week);
                cmd.Parameters.AddWithValue("@roomLendTime_Peak_Holi", room.roomLendTime_Peak_Holi);
                cmd.Parameters.AddWithValue("@roomLendTime_Sale_Week", room.roomLendTime_Sale_Week);
                cmd.Parameters.AddWithValue("@roomLendTime_Sale_Holi", room.roomLendTime_Sale_Holi);

                cmd.Parameters.AddWithValue("@price_Common_Week_Lend", room.price_Common_Week_Lend);
                cmd.Parameters.AddWithValue("@price_Common_Week_Stay", room.price_Common_Week_Stay);
                cmd.Parameters.AddWithValue("@price_Common_Holi_Lend", room.price_Common_Holi_Lend);
                cmd.Parameters.AddWithValue("@price_Common_Holi_Stay", room.price_Common_Holi_Stay);

                cmd.Parameters.AddWithValue("@price_Peak_Week_Lend", room.price_Peak_Week_Lend);
                cmd.Parameters.AddWithValue("@price_Peak_Week_Stay", room.price_Peak_Week_Stay);
                cmd.Parameters.AddWithValue("@price_Peak_Holi_Lend", room.price_Peak_Week_Lend);
                cmd.Parameters.AddWithValue("@price_Peak_Holi_Stay", room.price_Peak_Holi_Stay);

                cmd.Parameters.AddWithValue("@price_Sale_Week_Lend", room.price_Sale_Holi_Lend);
                cmd.Parameters.AddWithValue("@price_Sale_Week_Stay", room.price_Sale_Week_Stay);
                cmd.Parameters.AddWithValue("@price_Sale_Holi_Lend", room.price_Sale_Holi_Lend);
                cmd.Parameters.AddWithValue("@price_Sale_Holi_Stay", room.price_Sale_Holi_Stay);

                cmd.Parameters.AddWithValue("@checkSaleYN", room.CheckSaleYN);
                cmd.Parameters.AddWithValue("@checkPeakYN", room.CheckPeakYN);
                cmd.Parameters.AddWithValue("@CheckStayYN", room.CheckStayYN);
                cmd.Parameters.AddWithValue("@CheckLendYN", room.CheckLendYN);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }

        }


        /// <summary>
        /// 객실 정보 수정하기 (Room타입)
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public int RoomUpdate(Room room) 
        {
            string sql = @"UPDATE room SET roomName=@roomName, roomPeople=@roomPeople, roomCnt=@roomCnt, 
roomCheckIn_Common_Week=@roomCheckIn_Common_Week, 
roomCheckIn_Common_Week=@roomCheckIn_Common_Week,
roomCheckIn_Peak_Week=@roomCheckIn_Peak_Week,
roomCheckIn_Peak_Holi=@roomCheckIn_Peak_Holi,
roomCheckIn_Sale_Week=@roomCheckIn_Sale_Week,
roomCheckIn_Sale_Holi=@roomCheckIn_Sale_Holi,

roomCheckOut_Common_Week=@roomCheckOut_Common_Week,
roomCheckOut_Common_Holi=@roomCheckOut_Common_Holi,
roomCheckOut_Peak_Week=@roomCheckOut_Peak_Week,
roomCheckOut_Peak_Holi=@roomCheckOut_Peak_Holi,
roomCheckOut_Sale_Week=@roomCheckOut_Sale_Week,
roomCheckOut_Sale_Holi=@roomCheckOut_Sale_Holi,
roomLendTime_Common_Week=@roomLendTime_Common_Week,
roomLendTime_Common_Holi=@roomLendTime_Common_Holi,
roomLendTime_Peak_Week=@roomLendTime_Peak_Week,
roomLendTime_Peak_Holi=@roomLendTime_Peak_Holi,
roomLendTime_Sale_Week=@roomLendTime_Sale_Week,
roomLendTime_Sale_Holi=@roomLendTime_Sale_Holi,
                     
price_Common_Week_Lend=@price_Common_Week_Lend,
price_Common_Week_Stay=@price_Common_Week_Stay,
price_Common_Holi_Lend=@price_Common_Holi_Lend,
price_Common_Holi_Stay=@price_Common_Holi_Stay,

price_Peak_Week_Lend=@price_Peak_Week_Lend,
price_Peak_Week_Stay=@price_Peak_Week_Stay,
price_Peak_Holi_Lend=@price_Peak_Holi_Lend,
price_Peak_Holi_Stay=@price_Peak_Holi_Stay,
                    
price_Sale_Week_Lend=@price_Sale_Week_Lend,
price_Sale_Week_Stay=@price_Sale_Week_Stay,
price_Sale_Holi_Lend=@price_Sale_Holi_Lend,
price_Sale_Holi_Stay=@price_Sale_Holi_Stay,
checkSaleYN =@checkSaleYN, checkPeakYN =@checkPeakYN, 
CheckStayYN=@CheckStayYN,
CheckLendYN=@CheckLendYN
            where accomId = @accomId and roomName = @roomName; ";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@accomId", room.AccomId);
                cmd.Parameters.AddWithValue("@roomName", room.RoomName);
                cmd.Parameters.AddWithValue("@roomPeople", room.RoomPeople);
                cmd.Parameters.AddWithValue("@roomCnt", room.RoomTotCnt);

                cmd.Parameters.AddWithValue("@roomCheckIn_Common_Week", room.roomCheckIn_Common_Week);
                cmd.Parameters.AddWithValue("@roomCheckIn_Common_Holi", room.roomCheckIn_Common_Holi);
                cmd.Parameters.AddWithValue("@roomCheckIn_Peak_Week", room.roomCheckIn_Peak_Week);
                cmd.Parameters.AddWithValue("@roomCheckIn_Peak_Holi", room.roomCheckIn_Peak_Holi);
                cmd.Parameters.AddWithValue("@roomCheckIn_Sale_Week", room.roomCheckIn_Sale_Week);
                cmd.Parameters.AddWithValue("@roomCheckIn_Sale_Holi", room.roomCheckIn_Sale_Holi);

                cmd.Parameters.AddWithValue("@roomCheckOut_Common_Week", room.roomCheckOut_Common_Week);
                cmd.Parameters.AddWithValue("@roomCheckOut_Common_Holi", room.roomCheckOut_Common_Holi);
                cmd.Parameters.AddWithValue("@roomCheckOut_Peak_Week", room.roomCheckOut_Peak_Week);
                cmd.Parameters.AddWithValue("@roomCheckOut_Peak_Holi", room.roomCheckOut_Peak_Holi);
                cmd.Parameters.AddWithValue("@roomCheckOut_Sale_Week", room.roomCheckOut_Sale_Week);
                cmd.Parameters.AddWithValue("@roomCheckOut_Sale_Holi", room.roomCheckOut_Sale_Holi);

                cmd.Parameters.AddWithValue("@roomLendTime_Common_Week", room.roomLendTime_Common_Week);
                cmd.Parameters.AddWithValue("@roomLendTime_Common_Holi", room.roomLendTime_Common_Holi);
                cmd.Parameters.AddWithValue("@roomLendTime_Peak_Week", room.roomLendTime_Peak_Week);
                cmd.Parameters.AddWithValue("@roomLendTime_Peak_Holi", room.roomLendTime_Peak_Holi);
                cmd.Parameters.AddWithValue("@roomLendTime_Sale_Week", room.roomLendTime_Sale_Week);
                cmd.Parameters.AddWithValue("@roomLendTime_Sale_Holi", room.roomLendTime_Sale_Holi);

                cmd.Parameters.AddWithValue("@price_Common_Week_Lend", room.price_Common_Week_Lend);
                cmd.Parameters.AddWithValue("@price_Common_Week_Stay", room.price_Common_Week_Stay);
                cmd.Parameters.AddWithValue("@price_Common_Holi_Lend", room.price_Common_Holi_Lend);
                cmd.Parameters.AddWithValue("@price_Common_Holi_Stay", room.price_Common_Holi_Stay);

                cmd.Parameters.AddWithValue("@price_Peak_Week_Lend", room.price_Peak_Week_Lend);
                cmd.Parameters.AddWithValue("@price_Peak_Week_Stay", room.price_Peak_Week_Stay);
                cmd.Parameters.AddWithValue("@price_Peak_Holi_Lend", room.price_Peak_Week_Lend);
                cmd.Parameters.AddWithValue("@price_Peak_Holi_Stay", room.price_Peak_Holi_Stay);

                cmd.Parameters.AddWithValue("@price_Sale_Week_Lend", room.price_Sale_Holi_Lend);
                cmd.Parameters.AddWithValue("@price_Sale_Week_Stay", room.price_Sale_Week_Stay);
                cmd.Parameters.AddWithValue("@price_Sale_Holi_Lend", room.price_Sale_Holi_Lend);
                cmd.Parameters.AddWithValue("@price_Sale_Holi_Stay", room.price_Sale_Holi_Stay);

                cmd.Parameters.AddWithValue("@checkSaleYN", room.CheckSaleYN);
                cmd.Parameters.AddWithValue("@checkPeakYN", room.CheckPeakYN);
                cmd.Parameters.AddWithValue("@CheckStayYN", room.CheckStayYN);
                cmd.Parameters.AddWithValue("@CheckLendYN", room.CheckLendYN);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }

        /// <summary>
        /// 선택한 객실과 모든 이미지 삭제 
        /// </summary>
        /// <param name="accomId"></param>
        /// <param name="roomName"></param>
        /// <returns></returns>
        public int RoomDelete(int accomId, string roomName) 
        {
            string sql = @"DELETE FROM room wHERE accomId = @accomId and roomName = @roomName;";

            try
            {
                MySqlCommand cmd;

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@accomId", accomId);
                cmd.Parameters.AddWithValue("@roomName", roomName);

                int roomDelete = cmd.ExecuteNonQuery();

                return roomDelete;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }

        /// <summary>
        /// 선택한 업체의 모든 객실과 이미지 삭제
        /// </summary>
        /// <param name="accomId"></param>
        /// <returns></returns>
        public int RoomAllDelete(int accomId)
        {
            string sql = @"DELETE FROM room wHERE accomId = @accomId";

            try
            {
                MySqlCommand cmd;

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@accomId", accomId);

                int roomDelete = cmd.ExecuteNonQuery();

                return roomDelete;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }

        /// <summary>
        /// 선택한 업체의 객실 리스트 조회하기 (accomId 기준)
        /// </summary>
        /// <param name="accomId"></param>
        /// <returns></returns>
        public DataTable GetRoomList(int accomId)
        {

            string sql;
            sql = @"select r.accomId, accomName, i.imagePath, r.roomName, r.roomPeople, roomCnt, roomCheckIn_Common_Week, roomCheckOut_Common_Week, roomCheckIn_Common_Holi, roomCheckOut_Common_Holi, roomCheckIn_Peak_Week, roomCheckOut_Peak_Week, roomCheckIn_Peak_Holi, roomCheckOut_Peak_Holi, roomCheckIn_Sale_Week, roomCheckOut_Sale_Week, roomCheckIn_Sale_Holi, roomCheckOut_Sale_Holi, roomLendTime_Common_Week, roomLendTime_Common_Holi, roomLendTime_Peak_Week, roomLendTime_Peak_Holi, roomLendTime_Sale_Week, roomLendTime_Sale_Holi, price_Common_Week_Lend, price_Common_Week_Stay, price_Common_Holi_Lend, price_Common_Holi_Stay, price_Peak_Week_Lend, price_Peak_Week_Stay, price_Peak_Holi_Lend, price_Peak_Holi_Stay, price_Sale_Week_Lend, price_Sale_Week_Stay, price_Sale_Holi_Lend, price_Sale_Holi_Stay, checkStayYN, checkLendYN, checkPeakYN, checkSaleYN, roomDate
from room r
inner join image i on r.roomName = i.roomName
inner join accom a on r.accomId = a.accomId
where r.accomId = @accomId
group by roomName;";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@accomId", accomId);
            da.Fill(dt);

            return dt;
        }
        
        
        
        
        public DataTable GetRoomList(int accomId, DateTime checkin, DateTime checkout)
        {

            string sql;
            sql = @"select r.accomId, accomName, i.imagePath, r.roomName, r.roomPeople, roomCnt, roomCheckIn_Common_Week, roomCheckOut_Common_Week, roomCheckIn_Common_Holi, roomCheckOut_Common_Holi, roomCheckIn_Peak_Week, roomCheckOut_Peak_Week, roomCheckIn_Peak_Holi, roomCheckOut_Peak_Holi, roomCheckIn_Sale_Week, roomCheckOut_Sale_Week, roomCheckIn_Sale_Holi, roomCheckOut_Sale_Holi, roomLendTime_Common_Week, roomLendTime_Common_Holi, roomLendTime_Peak_Week, roomLendTime_Peak_Holi, roomLendTime_Sale_Week, roomLendTime_Sale_Holi, price_Common_Week_Lend, price_Common_Week_Stay, price_Common_Holi_Lend, price_Common_Holi_Stay, price_Peak_Week_Lend, price_Peak_Week_Stay, price_Peak_Holi_Lend, price_Peak_Holi_Stay, price_Sale_Week_Lend, price_Sale_Week_Stay, price_Sale_Holi_Lend, price_Sale_Holi_Stay, checkStayYN, checkLendYN, checkPeakYN, checkSaleYN, roomDate
from room r
inner join image i on r.roomName = i.roomName
inner join accom a on r.accomId = a.accomId
where r.accomId = @accomId
group by roomName;";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@accomId", accomId);
            da.Fill(dt);

            return dt;
        }


        /// <summary>
        /// 업주가 소유한 업체/객실 조회하기
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataTable GetMyAccomRoomList(string userId)
        {

            string sql = @"select a.accomId, accomName, r.roomName, i.imagePath, r.roomPeople, roomCnt, roomCheckIn_Common_Week, roomCheckOut_Common_Week, roomCheckIn_Common_Holi, roomCheckOut_Common_Holi, roomCheckIn_Peak_Week, roomCheckOut_Peak_Week, roomCheckIn_Peak_Holi, roomCheckOut_Peak_Holi, roomCheckIn_Sale_Week, roomCheckOut_Sale_Week, roomCheckIn_Sale_Holi, roomCheckOut_Sale_Holi, roomLendTime_Common_Week, roomLendTime_Common_Holi, roomLendTime_Peak_Week, roomLendTime_Peak_Holi, roomLendTime_Sale_Week, roomLendTime_Sale_Holi, price_Common_Week_Lend, price_Common_Week_Stay, price_Common_Holi_Lend, price_Common_Holi_Stay, price_Peak_Week_Lend, price_Peak_Week_Stay, price_Peak_Holi_Lend, price_Peak_Holi_Stay, price_Sale_Week_Lend, price_Sale_Week_Stay, price_Sale_Holi_Lend, price_Sale_Holi_Stay, checkStayYN, checkLendYN, checkPeakYN, checkSaleYN, accomDate, roomDate
from room r
left outer join image i on r.roomName = i.roomName
right outer join accom a on r.accomId = a.accomId
where userId = @userId
group by a.accomId, roomName;";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@userId", userId);
            da.Fill(dt);

            return dt;
        }



        /// <summary>
        /// 선택한 업체 정보 조회하기
        /// </summary>
        /// <param name="accomId"></param>
        /// <returns></returns>        
        public DataTable GetAccomInfo(int accomId)
        {

            string sql = @"select accomId, repName, accomName, accomType, accomAddr1,accomAddr2,accomAddr3, accomEmail, accomTel, crNum, accomFacility, accomInfo, accomDate, userId
from accom
where accomId = @accomId;";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@accomId", accomId);
            da.Fill(dt);

            return dt;
        }


        /// <summary>
        /// 소유한 업체의 객실 정보
        /// </summary>
        /// <param name="accomId"></param>
        /// <param name="roomName"></param>
        /// <returns></returns>
        public DataTable GetMyRoomInfo(int accomId, string roomName)
        {
            string sql = @"select a.accomId, accomName, r.roomName, i.imagePath, r.roomPeople, roomCnt,roomCheckIn_Common_Week, roomCheckOut_Common_Week, roomCheckIn_Common_Holi, roomCheckOut_Common_Holi, roomCheckIn_Peak_Week, roomCheckOut_Peak_Week, roomCheckIn_Peak_Holi, roomCheckOut_Peak_Holi, roomCheckIn_Sale_Week, roomCheckOut_Sale_Week, roomCheckIn_Sale_Holi, roomCheckOut_Sale_Holi, roomLendTime_Common_Week, roomLendTime_Common_Holi, roomLendTime_Peak_Week, roomLendTime_Peak_Holi, roomLendTime_Sale_Week, roomLendTime_Sale_Holi, price_Common_Week_Lend, price_Common_Week_Stay, price_Common_Holi_Lend, price_Common_Holi_Stay, price_Peak_Week_Lend, price_Peak_Week_Stay, price_Peak_Holi_Lend, price_Peak_Holi_Stay, price_Sale_Week_Lend, price_Sale_Week_Stay, price_Sale_Holi_Lend, price_Sale_Holi_Stay, checkStayYN, checkLendYN, checkPeakYN, checkSaleYN, roomDate
from room r
left outer join image i on r.roomName = i.roomName
left outer join accom a on r.accomId = a.accomId
where a.accomId = @accomId and r.roomName = @roomName";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@accomId", accomId);
            da.SelectCommand.Parameters.AddWithValue("@roomName", roomName);
            da.Fill(dt);

            return dt;
        }

    }
}
