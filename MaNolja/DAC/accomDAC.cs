using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace manolza
{
    public class Accom
    {
        public int AccomId { get; set; }
        public string RepName { get; set; }
        public string AccomName { get; set; }
        public string AccomAddr1 { get; set; }
        public string AccomAddr2 { get; set; }
        public string AccomAddr3 { get; set; }
        public string AccomEmail { get; set; }
        public string AccomTel { get; set; }
        public string CRNum { get; set; }
        public string AccomFacility { get; set; }
        public string AccomType { get; set; }
        public string AccomInfo { get; set; }

        public string AccomImage { get; set; }
        public string AccomCheckinTime { get; set; }
        public int AccomStayPrice { get; set; }
        public string AccomLendTime { get; set; }
        public int AccomLendPrice { get; set; }



    }

    public class accomDAC : IDisposable
    {
        MySqlConnection conn;

        public accomDAC()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["manolza"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        //public int AccomCnt()
        //{ 
        //    string sql = "select max(accomId) from accom";
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    int cnt = Convert.ToInt32(cmd.ExecuteScalar());
        //    return (cnt + 1);

        //}


        /// <summary>
        /// 업체 등록하기 (Accom타입, 로그인한 유저id 기준)
        /// </summary>
        /// <param name="accom"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public int AccomAdd(Accom accom, string userId) //업체등록
        {
            string sql = @"insert into 
accom(repName, accomName, accomAddr1, accomAddr2, accomAddr3, accomEmail, accomTel, CRNum, accomFacility, accomType, accomInfo, userId) 
values (@RepName, @accomName, @accomAddr1, @accomAddr2, @accomAddr3, @accomEmail, @accomTel, @crNum, @accomFacility, @accomType, @accomInfo, @userId);";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@repName", accom.RepName);
                cmd.Parameters.AddWithValue("@accomName", accom.AccomName);
                cmd.Parameters.AddWithValue("@accomAddr1", accom.AccomAddr1);
                cmd.Parameters.AddWithValue("@accomAddr2", accom.AccomAddr2);
                cmd.Parameters.AddWithValue("@accomAddr3", accom.AccomAddr3);
                cmd.Parameters.AddWithValue("@accomEmail", accom.AccomEmail);
                cmd.Parameters.AddWithValue("@accomTel", accom.AccomTel);
                cmd.Parameters.AddWithValue("@crNum", accom.CRNum);
                cmd.Parameters.AddWithValue("@accomFacility", accom.AccomFacility);
                cmd.Parameters.AddWithValue("@accomType", accom.AccomType);
                cmd.Parameters.AddWithValue("@accomInfo", "");
                cmd.Parameters.AddWithValue("@userId", userId);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }

        /// <summary>
        /// 업체 정보 수정하기 (Accom타입)
        /// </summary>
        /// <param name="accom"></param>
        /// <returns></returns>
        public int AccomUpdate(Accom accom)
        {
            string sql = @"UPDATE accom SET 
accomName=@accomName, accomAddr1=@accomAddr1, accomAddr2=@accomAddr2, accomAddr3=@accomAddr3, accomEmail=@accomEmail, 
accomTel=@accomTel, accomFacility=@accomFacility, accomType=@accomType, accomInfo=@accomInfo
where accomId =@accomId;";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@accomName", accom.AccomName);
                cmd.Parameters.AddWithValue("@accomAddr1", accom.AccomAddr1);
                cmd.Parameters.AddWithValue("@accomAddr2", accom.AccomAddr2);
                cmd.Parameters.AddWithValue("@accomAddr3", accom.AccomAddr3);
                cmd.Parameters.AddWithValue("@accomEmail", accom.AccomEmail);
                cmd.Parameters.AddWithValue("@accomTel", accom.AccomTel);
                cmd.Parameters.AddWithValue("@accomFacility", accom.AccomFacility);
                cmd.Parameters.AddWithValue("@accomType", accom.AccomType);
                cmd.Parameters.AddWithValue("@accomInfo", accom.AccomInfo);
                cmd.Parameters.AddWithValue("@accomId", accom.AccomId);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }

        }
        
        /// <summary>
        /// 업체 삭제하기 (업체id 기준)
        /// </summary>
        /// <param name="accomId"></param>
        /// <returns></returns>
        public int AccomDelete(int accomId)
        {
            string sql = @"DELETE FROM accom wHERE accomId = @accomId;" + "DELETE FROM room wHERE accomId = @accomId";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@accomId", accomId);


                return cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }


        /// <summary>
        /// 공통코드 가져오기 (카테고리 배열)
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public DataTable GetCommonCodes(string[] category) 
        {
            string temp = "'" + string.Join("','", category) + "'"; // category = ""

            string sql = @"select code, category, name, pcode from commoncode 
where category in (" + temp + ") order by num desc";  // category = ""

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// 공통코드 가져오기 (pcode)
        /// </summary>
        /// <param name="pcode"></param>
        /// <returns></returns>
        public DataTable GetCommonCodes(string pcode)
        {

            string sql = @"select code, category, name, pcode from commoncode 
where pcode = @pcode";  // category = ""

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@pcode", pcode);
            da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// 업체 리스트 조회하기 (기본)
        /// </summary>
        /// <returns></returns>
        public DataTable GetAccomList()
        {

            string sql = @"select a.accomId, a.accomName,  r.roomName, i.imagePath, accomType, accomAddr1, accomAddr2, accomAddr3, accomEmail, accomTel, crNum, accomFacility, accomInfo, roomCheckIn_Common_Week, roomCheckOut_Common_Week, roomCheckIn_Common_Holi, roomCheckOut_Common_Holi, roomCheckIn_Peak_Week, roomCheckOut_Peak_Week, roomCheckIn_Peak_Holi, roomCheckOut_Peak_Holi, roomCheckIn_Sale_Week, roomCheckOut_Sale_Week, roomCheckIn_Sale_Holi, roomCheckOut_Sale_Holi, roomLendTime_Common_Week, roomLendTime_Common_Holi, roomLendTime_Peak_Week, roomLendTime_Peak_Holi, roomLendTime_Sale_Week, roomLendTime_Sale_Holi, price_Common_Week_Lend, price_Common_Week_Stay, price_Common_Holi_Lend, price_Common_Holi_Stay, price_Peak_Week_Lend, price_Peak_Week_Stay, price_Peak_Holi_Lend, price_Peak_Holi_Stay, price_Sale_Week_Lend, price_Sale_Week_Stay, price_Sale_Holi_Lend, price_Sale_Holi_Stay, checkStayYN, checkLendYN, checkPeakYN, checkSaleYN
from accom a 
inner join room r on a.accomId = r.accomId
inner join image i on a.accomId = i.accomId
group by accomId;";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// 업체 리스트 조회하기 (지역별1)
        /// </summary>
        /// <param name="area1"></param>
        /// <returns></returns>
        public DataTable GetAccomList(string area1)
        {
            string area = $"%{area1}%";
            string sql = @"select a.accomId, a.accomName,  r.roomName, i.imagePath, accomType, accomAddr1, accomAddr2, accomAddr3, accomEmail, accomTel, crNum, accomFacility, accomInfo, roomCheckIn_Common_Week, roomCheckOut_Common_Week, roomCheckIn_Common_Holi, roomCheckOut_Common_Holi, roomCheckIn_Peak_Week, roomCheckOut_Peak_Week, roomCheckIn_Peak_Holi, roomCheckOut_Peak_Holi, roomCheckIn_Sale_Week, roomCheckOut_Sale_Week, roomCheckIn_Sale_Holi, roomCheckOut_Sale_Holi, roomLendTime_Common_Week, roomLendTime_Common_Holi, roomLendTime_Peak_Week, roomLendTime_Peak_Holi, roomLendTime_Sale_Week, roomLendTime_Sale_Holi, price_Common_Week_Lend, price_Common_Week_Stay, price_Common_Holi_Lend, price_Common_Holi_Stay, price_Peak_Week_Lend, price_Peak_Week_Stay, price_Peak_Holi_Lend, price_Peak_Holi_Stay, price_Sale_Week_Lend, price_Sale_Week_Stay, price_Sale_Holi_Lend, price_Sale_Holi_Stay, checkStayYN, checkLendYN, checkPeakYN, checkSaleYN
from accom a 
inner join room r on a.accomId = r.accomId
inner join image i on a.accomId = i.accomId
where accomAddr2 LIKE @area
group by accomId;";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@area", area);
            da.Fill(dt);
            return dt;
        }


        /// <summary>
        /// 업체 리스트 조회하기 (지역별1, 지역별2)
        /// </summary>
        /// <param name="area1"></param>
        /// <param name="area2"></param>
        /// <returns></returns>
        public DataTable GetAccomList(string area1, string area2)
        {
            DataTable dt = new DataTable();
           
            string[] area = area2.Split('/');

            foreach (string sql in area)
            {
                string resultArea = $"%{area1}%{sql}%";
                string sql2 = @"select a.accomId, a.accomName,  r.roomName, i.imagePath, accomType, accomAddr1, accomAddr2, accomAddr3, accomEmail, accomTel, crNum, accomFacility, accomInfo, roomCheckIn_Common_Week, roomCheckOut_Common_Week, roomCheckIn_Common_Holi, roomCheckOut_Common_Holi, roomCheckIn_Peak_Week, roomCheckOut_Peak_Week, roomCheckIn_Peak_Holi, roomCheckOut_Peak_Holi, roomCheckIn_Sale_Week, roomCheckOut_Sale_Week, roomCheckIn_Sale_Holi, roomCheckOut_Sale_Holi, roomLendTime_Common_Week, roomLendTime_Common_Holi, roomLendTime_Peak_Week, roomLendTime_Peak_Holi, roomLendTime_Sale_Week, roomLendTime_Sale_Holi, price_Common_Week_Lend, price_Common_Week_Stay, price_Common_Holi_Lend, price_Common_Holi_Stay, price_Peak_Week_Lend, price_Peak_Week_Stay, price_Peak_Holi_Lend, price_Peak_Holi_Stay, price_Sale_Week_Lend, price_Sale_Week_Stay, price_Sale_Holi_Lend, price_Sale_Holi_Stay, checkStayYN, checkLendYN, checkPeakYN, checkSaleYN
from accom a
inner
join room r on a.accomId = r.accomId
inner
join image i on a.accomId = i.accomId
where accomAddr2 LIKE @area
group by accomId; ";
            MySqlDataAdapter da = new MySqlDataAdapter(sql2, conn);
                da.SelectCommand.Parameters.AddWithValue("@area", resultArea);
                da.Fill(dt);

            }

            return dt;
        }


        /// <summary>
        /// 업주가 소유한 업체 리스트 조회하기
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataTable GetMyAccomList(string userId)
        {

            string sql = @"select a.accomId, repName, accomName, accomType, accomAddr1, accomAddr2, accomAddr3, accomEmail, accomTel, crNum, accomFacility, accomInfo, accomDate, userId, imageId, imagePath
from accom a 
left outer join image i on a.accomId = i.accomId
where userID=@userID
group by accomId;";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@userId", userId);
            da.Fill(dt);

            return dt;
        }

        public Accom GetAccomInfo(int accomId)
        {
            string sql = "select accomId, repName, accomName, accomType, accomAddr1,accomAddr2,accomAddr3, accomEmail, accomTel, accomFacility, accomInfo, crNum from accom where accomId=@accomId";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@accomId", accomId);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Accom accomList = new Accom();
                accomList.AccomId = Convert.ToInt32(reader["accomId"]);
                accomList.RepName = reader["repName"].ToString();
                accomList.AccomName = reader["accomName"].ToString();
                accomList.AccomType = reader["accomType"].ToString();
                accomList.AccomAddr1 = reader["accomAddr1"].ToString();
                accomList.AccomAddr2 = reader["accomAddr2"].ToString();
                accomList.AccomAddr3 = reader["accomAddr3"].ToString();
                accomList.AccomEmail = reader["accomEmail"].ToString();
                accomList.AccomTel = reader["accomTel"].ToString();
                accomList.AccomFacility = reader["accomFacility"].ToString();
                accomList.AccomInfo = reader["accomInfo"].ToString();
                accomList.CRNum = reader["crNum"].ToString();

                return accomList;
            }
            else
            {
                return null;
            }
        }



    }
}