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
    

    }
}
