using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Total_monitoring.Class
{
    public class MSSQLHelper
    {
        //커넥션 객체
        public static SqlConnection conn = null;
        public static string DBConnString { get; private set; }
        public static bool bDBConnCheck = false;
        private static int errorBoxCount = 0;

        /// <summary>
        /// 생성자
        /// </summary>
        public MSSQLHelper() { }

        public static SqlConnection DBConn
        {
            get
            {
                if (!ConnectToDB())
                {
                    return null;
                }
                return conn;
            }
        }

        public static bool ConnectToDB()
        {
            if (conn == null)
            {
                //서버명, 초기 DB명, 인증 방법
                DBConnString = String.Format("Data Source=({0});Initial Catalog={1};Integrated Security={2}; Timeout=3", "local", "ISSAC", "SSPI"); //DESKTOP-FDJ5DJ3

                conn = new SqlConnection(DBConnString);
            }
            try
            {
                if (!IsDBConnected)
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        bDBConnCheck = true;
                    }
                    else
                    {
                        bDBConnCheck = false;
                    }
                }
            }
            catch (SqlException e)
            {
                errorBoxCount++;
                if (errorBoxCount == 1)
                {
                    MessageBox.Show(e.Message, "DBHlper - ConnecToDB()");
                }
                return false;
            }
            return true;
        }
        /// <summary>
        /// DB Open 여부 확인
        /// </summary>
        public static bool IsDBConnected
        {
            get
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    return false;
                }
                return true;
            }
        }
        /// <summary>
        /// DB 해제
        /// </summary>
        public static void Close()
        {
            if (IsDBConnected)
                DBConn.Close();
        }
    }
}
