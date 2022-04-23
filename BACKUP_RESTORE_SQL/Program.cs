using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BACKUP_RESTORE_SQL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;

        //public static String servername = "HUUNHAN";
        public static String servername = "";
        public static String loginname;
        public static String password;
        public static string dbName = "";

        public static String defaultPath = "D:\\Tailieu\\Chuyen de cong nghe phan mem\\DOANCUOIKY\\BACKUP_RESTORE_SQL\\";

        public static int KetNoi() //null thì lỗi, không null thì chạy
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";User ID=" + Program.loginname + ";password=" + Program.password;
                //Program.conn.ConnectionString = connstr;
                Program.conn = new SqlConnection(Program.connstr);
                Program.conn.Open();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại username và password.\n" + ex.Message, "Lỗi kết nối!", MessageBoxButtons.OK);
                return 0;
            }
        }

        //truy vấn nhanh, chỉ thích hợp để xem; không cho sửa, thêm, xóa; 
        //nếu nhiều dòng, chỉ cho phép đi xuống, k cho phép đi ngược lại.
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
/*            conn.Close();*/
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300; // Đợi lệnh chạy. đơn vị: giây.
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
