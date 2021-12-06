using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace KIOSK
{
    class Database : IDatabase
    {
        /*  
            readme.txt 를 꼭 읽어주세요!
        */
        private const int STUDENT = 0;
        private const int PROFESSOR = 1;
        private const int SCHEDULE = 2;


        private static string dbIp = "LocalHost";
        private static string dbName = "YUHAN";
        private static string dbId = "jaewook00";
        private static string dbPw = "1234";
        private static bool attFlag = false;
        private OracleConnection conn;
        private OracleCommand command;
        private OracleDataAdapter adapter;
        private DataSet data = null;


        public Database()
        {
            string strConn = string.Format($"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
            conn = new OracleConnection(strConn);
            try
            {
                conn.Open();
                Console.WriteLine("db연결됨");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
        }

        ~Database()
        {
            conn.Close();
        }

        public void Execute(string query)
        {
            int row;

            if (IsOpen())
            {
                using (command = new OracleCommand(query, conn))
                {
                    row = command.ExecuteNonQuery();
                }
                Console.WriteLine($"{row}");
            }
            else
            {
                Console.WriteLine("ERROR : 데이터 베이스 연결에 실패했습니다.");
            }
        }

       

        public bool IsOpen()
        {
            return (!Equals(conn.State, ConnectionState.Closed));

        }

        /// <summary>
        /// 데이터를 조회하는 함수입니다. 
        /// 컬럼명, 테이블명
        /// </summary>
        /// <param name="col"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public DataSet Select(string col, string table)
        {
            string query = $"select {col} from {table}";
            DataSet ds;

            using (ds = new DataSet())
            {
                if (IsOpen())
                {
                    using (adapter = new OracleDataAdapter(query, conn))
                    {
                        adapter.Fill(ds);
                        return ds;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR : 데이터 베이스 연결이 실패했습니다.");
                }
            }
            return null;
        }

        /// <summary>
        /// 데이터를 조회하는 함수입니다. 
        /// 컬럼명, 테이블명, 조건
        /// </summary>
        /// <param name="col"></param>
        /// <param name="table"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public DataSet Select(string col, string table, string where)
        {
            DataSet ds = new DataSet();
            string query = @$"select {col}
                               from {table}
                               where {where}  ";

            //using (data = Select("s.id, s.pw, s.name, s.student_id", "student s, student_lecture sl", @$"s.student_id = sl.student_id
            //                                                                                                 sl.lecture_code = {Lecture_Code}"))

            using (ds = new DataSet())
            {
                if (IsOpen())
                {
                    try
                    {
                        using (adapter = new OracleDataAdapter(query, conn))
                        {
                            Console.WriteLine("SELECT......");
                            adapter.Fill(ds);
                            return ds;
                        }
                    }
                    catch (Exception e )
                    {
                        
                        Console.WriteLine(e.StackTrace);
                    }
                }
                else
                {
                    Console.WriteLine("ERROR : 데이터 베이스 연결이 실패했습니다.");
                }
            }
            return null;
        }

        /// <summary>
        /// 데이터를 삽입하는 함수입니다. 테이블명, 값 <br/>
        /// 값은 괄호로 묶이며 Comma(,)로 구분합니다. 문자열의 경우 Quotation(' ')로 감싸입니다.<br/>
        /// 예 ) table = "student", values = "('Yuhan', 1234)"
        /// </summary>
        /// <param name="table"></param>
        /// <param name="values"></param>
        public void Insert(string table, string values)
        {
            string query = @$"
                insert into {table} 
                values({values})
            ";

            Execute(query);
        }

        /// <summary>
        /// 데이터를 수정하는 함수입니다. 테이블명, 값, 조건 <br/>
        /// 조건은 " id = 'Yuhan' " 형식 입니다.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="value"></param>
        /// <param name="where"></param>
        public void Update(string table, string value, string where)
        {
            string query = @$"
                update {table} 
                set {value}
                where {where}
            ";

            Execute(query);
        }

        /// <summary>
        /// 데이터를 삭제하는 함수입니다. 테이블명, 조건
        /// 조건은 " id = 'Yuhan' " 형식 입니다.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="where"></param>
        public void Delete(string table, string where)
        {
            string query = @$"
                delete from {table}
                where {where}
            ";

            Execute(query);
        }

        /// <summary>
        /// 상품 이름으로 상품 코드 검색
        /// </summary>
        /// <param name="product_name"></param>
        /// <returns></returns>
        public string GetProductCode(string product_name)
        {
            string s = null;
            using (data = Select("pro_code", "product", $"pro_name = '{product_name}'"))
            {
                DataRow[] row = data.Tables[0].Select();
                s = row[0].ItemArray[0].ToString();       
            }
            return s;
        }

        public void OrderInsert(string product_name, int count , int card_code, int price)
        {
            string product_code = GetProductCode(product_name);
            Insert("pay", $"{product_code}, {card_code}, {count}, {price}");

        }

     
       


       
     

        /// <summary>
        /// 특정 강의를 수강하고 있는 학생들의 리스트를 반환받는 함수입니다.
        /// </summary>
        /// <param name="Lecture_Code"></param>
        public List<Student> GetStudentsExistLecture(string Lecture_Code)
        {
            List<Student> Students = new List<Student>();
            Student student;
            string id, pw, name, studentId;

            using (data = Select("s.id, s.pw, s.name, s.student_id",
                                 "student s, student_lecture sl",
                                 @$"s.student_id = sl.student_id
                                 AND sl.lecture_code = '{Lecture_Code}'"))
            {
                foreach (DataRow r in data.Tables[0].Rows)
                {
                    id = r["id"].ToString();
                    pw = r["pw"].ToString();
                    name = r["name"].ToString();
                    studentId = r["student_id"].ToString();
                    student = new Student(id, pw, studentId, name);
                    Students.Add(student);
                }
            }

            return Students;
        }
    

        /// <summary>
        /// 교수가 강의하고 있는 강의들 중 특정 시간의 강의를 반환받는 함수입니다.
        /// </summary>
        /// <param name="Professor_Id"></param>
        /// <param name="Start_Time"></param>
        public Lecture GetLectureExistProfessorTime(string Professor_Id, string Time )
        {
            Lecture lecture;

            using (data = Select("*", "Lecture", @$"Professor_Id = '{Professor_Id}' AND
                                                    Start_Time <= '{Time}' AND end_time >= '{Time}' AND
                                                    Week_Day = '수'"))
                //Week_Day = '{getDay(DateTime.Now)}'"))
                                                    

            {
                DataRow[] row = data.Tables[0].Select();
                lecture = new Lecture(row[0].ItemArray[0].ToString(),
                                        row[0].ItemArray[1].ToString(),
                                        row[0].ItemArray[2].ToString(),
                                        int.Parse(row[0].ItemArray[3].ToString()),
                                        row[0].ItemArray[4].ToString(),
                                        row[0].ItemArray[5].ToString(),
                                        row[0].ItemArray[6].ToString());
                if (data.Tables[0].Rows.Count == 0)
                {
                    Console.WriteLine("없음");
                    return null;
                }
            }

            return lecture;
        }


      
    }
}
