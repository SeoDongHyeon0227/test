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

namespace Test_Guna
{
    public partial class Form2 : Form
    {
        OracleCommand cmd;

        //product 클래스 있음
        //TextBox는 윈폼에 있는 TextBox
        List<product> list = new List<product>();
        List<TextBox> txt = new List<TextBox>();

        public Form2(OracleCommand cmd)
        {
            InitializeComponent();
            this.cmd = cmd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] text_names =
            {
                "Add_a", "Add_b", "Add_c", "Add_d", "Add_e", "Add_f", "Add_g"
            };

            foreach (var item in text_names)
            {
                // this.는 form2
                // Control는 form2의 요소들 ( textbox, label, ...)
                // item에는 "Add_a"가 들어가니까 "Add_a"를 찾으라는 뜻 true일 때 배열에 넣어라
                Control[] ccc = this.Controls.Find(item, true);

                // txt 리스트(추가하는 값)에 textbox값 추가
                txt.Add((TextBox)ccc[0]);
            }

            cmd.CommandText = "select * from ingredient where RowNum< 8 order by id";

            // 결과 리더 객체를 리턴
            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string ID = rdr["ID"].ToString();
                string NAME = rdr["NAME"].ToString();
                string VOL = rdr["VOL"].ToString();
                
                list.Add(new product(ID, NAME, VOL));
            }

            for (int z = 0; z < list.Count; z++)
            {
                //list = 기존에 있는 값, txt = 추가할 값
                // list[z].VOL, txt[z].Text 문자열임
                int total = Convert.ToInt32(list[z].VOL) + Convert.ToInt32(txt[z].Text);
                if (total > 100)
                {
                    MessageBox.Show($"{list[z].NAME}가 {total - 100}가 초과 되었습니다");
                }

                // VOL+{txt[z].Text}가 100이상이면 100으로 처리
                // 100이하면 그대로 처리
                cmd.CommandText = $"update ingredient " +
                    $"set VOL = (CASE WHEN VOL+{txt[z].Text} >= 100 THEN 100 " +
                    $"ELSE VOL+{txt[z].Text} END) where ID = {list[z].ID}";
                cmd.ExecuteNonQuery();
            }
            //for (int z = 0; z < list.Count; z++)
            //{
            //    // 
            //    cmd.CommandText = $"update ingredient " +
            //        $"set VOL = (CASE WHEN VOL+{txt[z].Text} >= 100 THEN 100 " +
            //        $"ELSE VOL+{txt[z].Text} END) where ID = {list[z].ID}";
            //    cmd.ExecuteNonQuery();
            //}
            this.Close();
        }
    }
}
