using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbp_cafe_team
{
    public partial class Form3 : Form
    {

        DBClass dbc = new DBClass();  //*****DBClass 객체 생성

        public Form3()
        {
            InitializeComponent();
            dbc = new DBClass();
            dbc.DB_Open();
        }

        private void form3_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
        }

        private void revenue_search_Click(object sender, EventArgs e)
        {
            try
            {
                // 쿼리 수행
                string query = "SELECT Revenue_Item_Num as \"매출번호\", " +
                   "Revenue_Item_Name as \"품목이름\", " +
                   "Revenue_Date as \"매출날짜\", " +
                   "Sale_Item_Num as \"판매물품번호\", " +
                   "Payment_Method as \"결제수단\", " +
                   "Order_Num as \"주문번호\", " +
                   "Item_Quantity as \"물품수량\", " +
                   "Item_Price as \"물품가격\" " +
                   "FROM Revenue_Item " +
                   "ORDER BY Order_Num";


                dbc.DBAdapter.SelectCommand.CommandText = query;
                dbc.DBAdapter.Fill(dbc.DS, "Revenue_Item");

                // 데이터가 존재하는지 확인
                if (dbc.DS.Tables["Revenue_Item"].Rows.Count > 0)
                {
                    // DataGridView에 데이터 바인딩
                    revenue.AutoGenerateColumns = true; // 컬럼 자동 생성
                    revenue.DataSource = dbc.DS.Tables["Revenue_Item"];

                    // DataGridView 업데이트
                    revenue.Refresh();
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

        private void revenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
