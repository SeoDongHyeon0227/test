using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Test_Guna
{
    public partial class Form1 : Form
    {
        // 네트워크 연결 정보 직접 대입
        string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.56.1)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))" +
            ";User Id=hr;Password=hr;";

        // 오라클 연결
        OracleConnection conn;
        // 명령 객체 생성
        OracleCommand cmd;


        public Form1()
        {
            InitializeComponent();
            conn = new OracleConnection(strConn);
            conn.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn;
            

        }
        void oraclesearch()
        {
            cmd.CommandText = "select VOL from INGREDIENT where ID = 1001";
            cmd.ExecuteNonQuery();
            OracleDataReader rdr1 = cmd.ExecuteReader();
            while (rdr1.Read())
            {
                int VOL = rdr1.GetInt32(0);
                Value_Bar1.Value = VOL;
            }

            cmd.CommandText = "select VOL from INGREDIENT where ID = 1002";
            cmd.ExecuteNonQuery();
            OracleDataReader rdr2 = cmd.ExecuteReader();
            while (rdr2.Read())
            {
                int VOL = rdr2.GetInt32(0);
                Value_Bar2.Value = VOL;
            }

            cmd.CommandText = "select VOL from INGREDIENT where ID = 1003";
            cmd.ExecuteNonQuery();
            OracleDataReader rdr3 = cmd.ExecuteReader();
            while (rdr3.Read())
            {
                int VOL = rdr3.GetInt32(0);
                Value_Bar3.Value = VOL;
            }

            cmd.CommandText = "select VOL from INGREDIENT where ID = 1004";
            cmd.ExecuteNonQuery();
            OracleDataReader rdr4 = cmd.ExecuteReader();
            while (rdr4.Read())
            {
                int VOL = rdr4.GetInt32(0);
                Value_Bar4.Value = VOL;
            }

            cmd.CommandText = "select VOL from INGREDIENT where ID = 1101";
            cmd.ExecuteNonQuery();
            OracleDataReader rdr5 = cmd.ExecuteReader();
            while (rdr5.Read())
            {
                int VOL = rdr5.GetInt32(0);
                Value_Bar5.Value = VOL;
            }

            cmd.CommandText = "select VOL from INGREDIENT where ID = 1102";
            cmd.ExecuteNonQuery();
            OracleDataReader rdr6 = cmd.ExecuteReader();
            while (rdr6.Read())
            {
                int VOL = rdr6.GetInt32(0);
                Value_Bar6.Value = VOL;
            }

            cmd.CommandText = "select VOL from INGREDIENT where ID = 1103";
            cmd.ExecuteNonQuery();
            OracleDataReader rdr7 = cmd.ExecuteReader();
            while (rdr7.Read())
            {
                int VOL = rdr7.GetInt32(0);
                Value_Bar7.Value = VOL;
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oraclesearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2(cmd);
            form2.ShowDialog();
            oraclesearch();
            
        }
        
    }
}
