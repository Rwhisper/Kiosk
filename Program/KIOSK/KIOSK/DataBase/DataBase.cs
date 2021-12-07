using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KIOSK
{
    class DataBase
    {
        public MySqlConnection connection;
        public MySqlCommand cmd;
        public MySqlDataReader data;

        public DataBase()
        {
            setting();
        }

        private void setting()
        {
            string connectionString;
            connectionString = $"SERVER=localhost;PORT=3306;DATABASE=kioskdb;UID=root;PASSWORD=andlseh12;";
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            {
                try
                {
                    connection.Open();
                    //MessageBox.Show("DataBase연동 성공");
                    return true;
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("데이터베이스 서버에 연결할 수 없습니다.");
                            break;

                        case 1045:
                            MessageBox.Show("유저 ID 또는 Password를 확인해주세요.");
                            break;
                    }
                    return false;
                }
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }
        /// <summary>
        /// 주문 추가
        /// </summary>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public void OrderInsert(string product_name,  int count, int pay_card)
        {
            string product_code = GetProductCode(product_name);
            if (OpenConnection() == true)
            {              
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO pay  (PRO_CODE, PAY_CARD, PAY_VOL, PAY_DATE) VALUES('{product_code}', {pay_card}, {count}, sysdate())", connection);
                cmd.ExecuteNonQuery();
                CloseConnection();                
             
            }
        }

        public string GetProductCode(string product_name)
        {
            string result = "a";
            product_name = product_name.Replace(" ", "");
            
            if (OpenConnection() == true)
            {
                try
                {
                    
                    MySqlCommand cmd = new MySqlCommand($"SELECT pro_code FROM product WHERE pro_name = '{product_name}'", connection);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    
                    while (rdr.Read())
                    {
                       
                        result = string.Format("{0}", rdr["pro_code"]);
                        //MessageBox.Show(result);
                    }
                    
                    rdr.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    result = "";
                }
                finally
                {
                    CloseConnection();
                }
            }
            return result;
        }
        /// <summary>
        /// 로그인 확인 메서드, result = 0 : 아이디가 존재하지 않음 , result = 1 : 로그인 성공, result = -1 : 패스워드가 일치하지 않음
        /// </summary>
        /// <param name="col"></param>
        /// <returns></returns>
        public int Loing(string col, string pwd)
        {
            int result = 0;
            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM user WHERE id = '{col}'", connection);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    User user = new User();
                    while (rdr.Read())
                    {
                        user.password = string.Format("{0}", rdr["password"]);

                    }
                    if (user.password == pwd)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = -1;
                    }    
                    rdr.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    result = 0;
                }
                finally
                {
                    CloseConnection();
                }
            }
            return result;
        }
        //회원가입 중복확인
        public bool checkuser(string id, string password)
        {
            bool isCheck = false;
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM user", connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    if (id == (string.Format("{0}", rdr["id"])))
                    {
                        isCheck = false;                        
                        break;
                    }
                    else
                    {
                        isCheck = true;
                    }
                }
                rdr.Close();
                CloseConnection();
            }
            else
            {
                isCheck = false;
            }
            return isCheck;
            
        }
        //회원가입
        public bool Insertuser(string id, string password)
        {
            bool result = false;
            bool c = checkuser(id, password);
            if (OpenConnection() == true)
            {
                if (c)
                {
                    MySqlCommand cmd = new MySqlCommand($"INSERT INTO user VALUES('{id}', '{password}')", connection);
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
        //비밀번호 수정
        public User Updateuser(string id, string password)
        {
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand($"UPDATE user SET password = '{password}' WHERE id = '{id}'", connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
                return null;
        }

        //랭킹에 추가하기 전 랭킹확인
        public bool Checkranking(string stagecode, string userid)
        {
            bool isRankCheck = false;
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT userid, stagecode FROM ranking", connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (userid == (string.Format("{0}", rdr["userid"])) && stagecode == (string.Format("{0}", rdr["stagecode"])))
                    {
                        isRankCheck = true;                       
                        break;
                    }
                    else
                    {
                        isRankCheck = false;
                    }
                }
                rdr.Close();
                CloseConnection();
            }
            return isRankCheck;
        }
        public string Checkcleartime(string stagecode, string userid, string cleartime)
        {
            bool clearresult = false;
            string clearTimeStr = null;
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT cleartime FROM ranking WHERE userid = '{userid}' AND stagecode = '{stagecode}'", connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                { 
                    clearTimeStr = rdr["cleartime"].ToString();
                }
                    rdr.Close();
                CloseConnection();
            }
                return clearTimeStr;
        }
        //랭킹에 추가
        public bool Insertranking(string stagecode, string userid, string cleartime)
        {
                bool a = Checkranking(stagecode, userid);
                string b = Checkcleartime(stagecode, userid, cleartime);
                bool result = false;
                if (OpenConnection() == true)
                {
                try
                {

                    if (a)
                    {
                        MySqlCommand cmd = new MySqlCommand($"UPDATE ranking SET cleartime = '{cleartime}' WHERE userid = '{userid}' AND stagecode = '{stagecode}' AND '{b}' > '{cleartime}'", connection);
                        cmd.ExecuteNonQuery();
                        result = true;
                    }
                    else
                    {
                        MySqlCommand cmd = new MySqlCommand($"INSERT INTO ranking(stagecode, userid, cleartime) VALUES('{stagecode}', '{userid}', '{cleartime}')", connection);
                        cmd.ExecuteNonQuery();
                        result = true;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    CloseConnection();
                }
                }
                return result;
        }
        public List<Ranking> Selectranking(string stage)
        {
            List<Ranking> Lid = null;
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM ranking where stagecode = {stage} order by cleartime desc", connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                Lid = new List<Ranking>();
                while (rdr.Read())
                {
                    Lid.Add(new Ranking() { rank = Convert.ToInt32(rdr["rank"]), stagecode = string.Format("{0}", rdr["stagecode"]), userid = string.Format("{0}", rdr["userid"]), cleartime = string.Format("{0}", rdr["cleartime"]) });
                }

                foreach (var item in Lid)
                {
                    Console.WriteLine(item.rank + " / " + item.stagecode + " / " + item.userid + " / " + item.cleartime);
                }
                CloseConnection();
            }
                return Lid;
        }
    }
}
