using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace dbp_cafe_team
{
    public partial class Form2 : Form
    {
        DBClass dbc; // DBClass 객체 생성

        public Form2()
        {
            InitializeComponent();
            dbc = new DBClass(); // DBClass 객체 생성 및 초기화
            dbc.DB_Open(); // DB 연결 열기
        }

        private void form2_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pay_search_Click(object sender, EventArgs e)
        {
            // 결제 내역 조회 버튼 클릭 시 실행되는 코드
            try
            {
                // 쿼리 수행
                string query = "SELECT Order_Num, Item_Name, Item_Price * Item_Quantity AS Total_Price, Item_Quantity, Payment_Method FROM OrderDetails";

                dbc.DBAdapter.SelectCommand.CommandText = query;
                dbc.DBAdapter.Fill(dbc.DS, "OrderDetails");

                // 데이터가 존재하는지 확인
                if (dbc.DS.Tables["OrderDetails"].Rows.Count > 0)
                {
                    // ListView에 데이터 바인딩
                    listView1.Items.Clear(); // 기존 데이터 지우기

                    foreach (DataRow row in dbc.DS.Tables["OrderDetails"].Rows)
                    {
                        ListViewItem item = new ListViewItem(row["Order_Num"].ToString());
                        item.SubItems.Add(row["Item_Name"].ToString());
                        item.SubItems.Add(row["Total_Price"].ToString());
                        item.SubItems.Add(row["Item_Quantity"].ToString());
                        item.SubItems.Add(row["Payment_Method"].ToString());

                        // ListView에 추가
                        listView1.Items.Add(item);
                    }

                    // ListView 업데이트
                    listView1.Refresh();
                }
                else
                {
                    MessageBox.Show("데이터가 없습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }

        }

        private void pay_cancel_Click(object sender, EventArgs e)
        {
            dbc.DB_Close(); // 데이터베이스 연결 닫기
            try
            {
                string connectionString = "User Id=cafe1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection myConnection = new OracleConnection(connectionString);
                string deleteQuery = "DELETE FROM OrderDetails WHERE Order_Num = :orderNum";
                OracleCommand myCommand = new OracleCommand(deleteQuery, myConnection);

                myConnection.Open();

                // 여기에서 ListView에서 선택된 행을 삭제합니다.
                if (listView1.SelectedItems.Count > 0)
                {
                    int orderNum = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                    myCommand.Parameters.Add(new OracleParameter("orderNum", OracleDbType.Int32)).Value = orderNum;

                    int rowsAffected = myCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        listView1.Items.Remove(listView1.SelectedItems[0]);
                        MessageBox.Show("결제가 취소되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("결제 취소에 실패했습니다.");
                    }
                }
                else
                {
                    MessageBox.Show("선택된 결제 내역이 없습니다.");
                }

                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void OrderNum_SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 텍스트 상자에서 주문 번호 가져오기
                int orderNumToSearch = Convert.ToInt32(OrderNum_Serch_textBox.Text);

                // 주문 번호를 사용하여 쿼리 작성
                string query = "SELECT Order_Num, Item_Name, Item_Price * Item_Quantity AS Total_Price, Item_Quantity, Payment_Method FROM OrderDetails WHERE Order_Num = :orderNum";

                // 명령에 매개변수 설정
                dbc.DBAdapter.SelectCommand.Parameters.Clear();
                dbc.DBAdapter.SelectCommand.Parameters.Add(new OracleParameter("orderNum", OracleDbType.Int32)).Value = orderNumToSearch;
                dbc.DBAdapter.SelectCommand.CommandText = query;

                // 이전 데이터 지우기
                dbc.DS.Tables["OrderDetails"].Clear();

                // 쿼리 실행하고 DataSet 채우기
                dbc.DBAdapter.Fill(dbc.DS, "OrderDetails");

                // 데이터가 있는지 확인
                if (dbc.DS.Tables["OrderDetails"].Rows.Count > 0)
                {
                    // ListView에 데이터 바인딩
                    listView1.Items.Clear(); // 기존 데이터 지우기

                    foreach (DataRow row in dbc.DS.Tables["OrderDetails"].Rows)
                    {
                        ListViewItem item = new ListViewItem(row["Order_Num"].ToString());
                        item.SubItems.Add(row["Item_Name"].ToString());
                        item.SubItems.Add(row["Total_Price"].ToString());
                        item.SubItems.Add(row["Item_Quantity"].ToString());
                        item.SubItems.Add(row["Payment_Method"].ToString());

                        // ListView에 추가
                        listView1.Items.Add(item);
                    }

                    // ListView 업데이트
                    listView1.Refresh();
                }
                else
                {
                    MessageBox.Show("주문번호에 해당하는 데이터가 없습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void OrderNum_Serch_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
