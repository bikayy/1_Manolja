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
    public class imageDAC : IDisposable
    {

        public class Image
        {
            public string imageId { get; set; }
            public string accomId { get; set; }
            public string roomName { get; set; }
            public string imagePath { get; set; }
        }

        MySqlConnection conn;
        public imageDAC()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["manolza"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public int ImageAdd(int accomId, string roomName, string path) //이미지 등록,,
        {
            try
            {

            string sql = "insert into image(accomId, roomName, imagePath) values(@accomId, @roomName, @imagePath)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@accomId", accomId);
            cmd.Parameters.AddWithValue("@roomName", roomName);
            cmd.Parameters.AddWithValue("@imagePath", path);    
            
            return cmd.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }


        //객실 이미지 가져오기
        public DataTable GetImage(int accomId, string roomName)
        {
            string sql = @"SELECT imageId, accomId, roomName, imagePath, imageDate FROM image where accomId=@accomId and roomName=@roomName";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@accomId", accomId);
            da.SelectCommand.Parameters.AddWithValue("@roomName", roomName);
            da.Fill(dt);

            return dt;
        }

        //업체의 모든 이미지 가져오기
        public DataTable GetAllImage(int accomId)
        {
            string sql = @"SELECT imageId, accomId, roomName, imagePath, imageDate FROM image where accomId=@accomId";

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@accomId", accomId);
            da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// 객실 이미지 삭제 (이미지id 기준)
        /// </summary>
        /// <param name="imageID"></param>
        /// <returns></returns>
        public int DeleteImage(int imageID)
        {
            try
            {
                string sql = @"delete from image where imageId=@imageID";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@imageID", imageID);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }

        /// <summary>
        /// 선택한 객실의 모든 이미지 삭제 (객실 기준)
        /// </summary>
        /// <param name="accomId"></param>
        /// <param name="roomName"></param>
        /// <returns></returns>
        public int DeleteImage(int accomId, string roomName)
        {
            try
            {
                string sql = @"delete from image where accomId=@accomId and roomName=@roomName";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@accomId", accomId);
                cmd.Parameters.AddWithValue("@roomName", roomName);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }

        /// <summary>
        /// 업체의 모든 이미지 삭제 (업체 기준)
        /// </summary>
        /// <param name="accomId"></param>
        /// <returns></returns>
        public int DeleteAllImage(int accomId)
        {
            try
            {
                string sql = @"delete from image where accomId=@accomId";

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
    }
}

