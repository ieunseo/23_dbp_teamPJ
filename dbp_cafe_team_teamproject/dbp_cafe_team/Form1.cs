using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.DataAccess.Client;

namespace dbp_cafe_team
{
    
    public partial class Form1 : Form
    {
          
        DBClass dbc = new DBClass();  //*****DBClass 객체 생성
        private int americanoQuantity = 0;
        private int latteQuantity = 0;

        



        public Form1()
        {
            InitializeComponent();
            dbc.DB_ObjCreate();
            dbc.DB_Open();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
        }

        private int GetItemPrice(string itemName)
        {
            int itemPrice = 0; // 아이템 가격을 저장할 변수

            try
            {
                // 데이터베이스 연결 열기
                dbc.DBAdapter.SelectCommand.Connection.Open();

                // SQL 쿼리를 생성하여 아이템 가격을 가져옵니다.
                string query = "SELECT Item_Price FROM Sale_Item WHERE Sale_Item_Name = :itemName";

                using (OracleCommand command = new OracleCommand(query, dbc.DBAdapter.SelectCommand.Connection))
                {
                    // 파라미터 설정
                    command.Parameters.Add(new OracleParameter("itemName", OracleDbType.Varchar2)).Value = itemName;

                    // 쿼리 실행
                    OracleDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // 결과에서 아이템 가격을 읽어옵니다.
                        itemPrice = Convert.ToInt32(reader["Item_Price"]);
                    }
                }
            }
            catch (Exception ex)
            {
                // 오류 처리
                MessageBox.Show("오류 발생: " + ex.Message);
            }
            finally
            {
                // 데이터베이스 연결 닫기 (필요한 경우)
                dbc.DBAdapter.SelectCommand.Connection.Close();
            }

            return itemPrice;
        }

        private void ameri_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Sale_Item_Num, Sale_Item_Name, Item_Price FROM Sale_Item WHERE Sale_Item_Num = 1";
                dbc.DBAdapter.SelectCommand.CommandText = query;
                DataSet newDataSet = new DataSet();
                dbc.DBAdapter.Fill(newDataSet);

                 americanoQuantity = 1;

                if (dbc.DS.Tables.Count == 0)
                {
                   dbc.DS.Tables.Add(newDataSet.Tables[0].Copy());
                }
                else
                {
                    foreach (DataRow row in newDataSet.Tables[0].Rows)
                    {
                        dbc.DS.Tables[0].Rows.Add(row.ItemArray);
                    }
                }

                int itemPrice = GetItemPrice("아메리카노");

     


                UpdateListView("아메리카노", americanoQuantity, itemPrice * americanoQuantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void UpdateListView(string itemName, int quantity, int itemPrice)
        {
            ListViewItem existingItem = null;

            foreach (ListViewItem item in order_list.Items)
            {
                if (item.SubItems[0].Text == itemName)
                {
                    existingItem = item;
                    break;
                }
            }

            if (existingItem != null)
            {
                int currentQuantity = int.Parse(existingItem.SubItems[1].Text);
                currentQuantity += quantity;
                existingItem.SubItems[1].Text = currentQuantity.ToString();

                int totalPrice = currentQuantity * itemPrice;
                existingItem.SubItems[2].Text = totalPrice.ToString();
            }
            else
            {
                ListViewItem newItem = new ListViewItem(itemName);
                newItem.SubItems.Add(quantity.ToString());

                int totalPrice = quantity * itemPrice;
                newItem.SubItems.Add(totalPrice.ToString());
                order_list.Items.Add(newItem);
            }
        }





        private void latte_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Sale_Item_Num, Sale_Item_Name, Item_Price FROM Sale_Item WHERE Sale_Item_Num = 2";
                dbc.DBAdapter.SelectCommand.CommandText = query;
                DataSet newDataSet = new DataSet();
                dbc.DBAdapter.Fill(newDataSet);

                // 카페라떼 수량을 1 증가
                latteQuantity=1;

                if (dbc.DS.Tables.Count == 0)
                {
                    dbc.DS.Tables.Add(newDataSet.Tables[0].Copy());
                }
                else
                {
                    foreach (DataRow row in newDataSet.Tables[0].Rows)
                    {
                       dbc.DS.Tables[0].Rows.Add(row.ItemArray);
                    }
                }

                int itemPrice = GetItemPrice("카페라떼");

                UpdateListView("카페라떼", latteQuantity, itemPrice * latteQuantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void order_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void moca_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Sale_Item_Num, Sale_Item_Name, Item_Price FROM Sale_Item WHERE Sale_Item_Num = 3";
                dbc.DBAdapter.SelectCommand.CommandText = query;
                DataSet newDataSet = new DataSet();
                dbc.DBAdapter.Fill(newDataSet);

                // 카페모카 수량을 1로 설정
                int mocaQuantity = 1;

                if (dbc.DS.Tables.Count == 0)
                {
                    dbc.DS.Tables.Add(newDataSet.Tables[0].Copy());
                }
                else
                {
                    foreach (DataRow row in newDataSet.Tables[0].Rows)
                    {
                        dbc.DS.Tables[0].Rows.Add(row.ItemArray);
                    }
                }

                int itemPrice = GetItemPrice("카페모카");

                UpdateListView("카페모카", mocaQuantity, itemPrice * mocaQuantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void caffu_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Sale_Item_Num, Sale_Item_Name, Item_Price FROM Sale_Item WHERE Sale_Item_Num = 4";
                dbc.DBAdapter.SelectCommand.CommandText = query;
                DataSet newDataSet = new DataSet();
                dbc.DBAdapter.Fill(newDataSet);

                // 카푸치노 수량을 1로 설정
                int caffuQuantity = 1;

                if (dbc.DS.Tables.Count == 0)
                {
                    dbc.DS.Tables.Add(newDataSet.Tables[0].Copy());
                }
                else
                {
                    foreach (DataRow row in newDataSet.Tables[0].Rows)
                    {
                        dbc.DS.Tables[0].Rows.Add(row.ItemArray);
                    }
                }

                int itemPrice = GetItemPrice("카푸치노");

                UpdateListView("카푸치노", caffuQuantity, itemPrice * caffuQuantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void vanil_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Sale_Item_Num, Sale_Item_Name, Item_Price FROM Sale_Item WHERE Sale_Item_Num = 5";
                dbc.DBAdapter.SelectCommand.CommandText = query;
                DataSet newDataSet = new DataSet();
                dbc.DBAdapter.Fill(newDataSet);

                // 바닐라라떼 수량을 1로 설정
                int vanilQuantity = 1;

                if (dbc.DS.Tables.Count == 0)
                {
                    dbc.DS.Tables.Add(newDataSet.Tables[0].Copy());
                }
                else
                {
                    foreach (DataRow row in newDataSet.Tables[0].Rows)
                    {
                        dbc.DS.Tables[0].Rows.Add(row.ItemArray);
                    }
                }

                int itemPrice = GetItemPrice("바닐라라떼");

                UpdateListView("바닐라라떼", vanilQuantity, itemPrice * vanilQuantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void choco_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Sale_Item_Num, Sale_Item_Name, Item_Price FROM Sale_Item WHERE Sale_Item_Num = 6";
                dbc.DBAdapter.SelectCommand.CommandText = query;
                DataSet newDataSet = new DataSet();
                dbc.DBAdapter.Fill(newDataSet);

                // 초코라떼 수량을 1로 설정
                int chocoQuantity = 1;

                if (dbc.DS.Tables.Count == 0)
                {
                    dbc.DS.Tables.Add(newDataSet.Tables[0].Copy());
                }
                else
                {
                    foreach (DataRow row in newDataSet.Tables[0].Rows)
                    {
                        dbc.DS.Tables[0].Rows.Add(row.ItemArray);
                    }
                }

                int itemPrice = GetItemPrice("초코라떼");

                UpdateListView("초코라떼", chocoQuantity, itemPrice * chocoQuantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }


        private void select_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (order_list.SelectedItems.Count > 0)
                {
                    string itemName = order_list.SelectedItems[0].SubItems[0].Text;
                    int quantity = int.Parse(order_list.SelectedItems[0].SubItems[1].Text);

                    if (quantity > 1)
                    {
                        // 수량이 1보다 크면 1 감소
                        order_list.SelectedItems[0].SubItems[1].Text = (quantity - 1).ToString();
                        int totalPrice = GetItemPrice(itemName) * (quantity - 1);
                        order_list.SelectedItems[0].SubItems[2].Text = totalPrice.ToString();
                    }
                    else
                    {
                        // 수량이 1이면 아이템을 주문 목록에서 제거
                        order_list.Items.Remove(order_list.SelectedItems[0]);
                    }

                    // 취소된 품목에 따라 해당하는 변수 업데이트
                    if (itemName == "아메리카노")
                    {
                        americanoQuantity--;
                        if (americanoQuantity < 0)
                        {
                            americanoQuantity = 0;
                        }
                    }
                    // 다른 품목에 대한 처리 추가

                }
                else
                {
                    MessageBox.Show("선택된 품목이 없습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void cash_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_Close();
                using (OracleConnection conn = new OracleConnection("User Id=cafe1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );"))
                {
                    conn.Open();
                    // 데이터베이스에서 가장 큰 ORDERNUM을 조회합니다.
                    int orderNum = GetMaxOrderNum(conn) + 1;
                    int revenueItemNum = GetMaxRevenueNum(conn) + 1;
                    //int revenueItemNum, string revenue(ItemName), (DateTime revenueDate), decimal totalRevenue, (decimal saleItemNum), (string paymentMethod), (decimal orderNum), (decimal itemQuantity), (decimal itemPrice)
                    if (order_list.Items.Count > 0)
                    {
                        // 주문 시간을 현재 시간으로 설정합니다.
                        DateTime orderTime = DateTime.Now;

                        // 주문한 모든 품목을 데이터베이스에 삽입합니다.
                        foreach (ListViewItem item in order_list.Items)
                        {
                            string itemName = item.SubItems[0].Text;
                            int itemQuantity = int.Parse(item.SubItems[1].Text);
                            int itemPrice = int.Parse(item.SubItems[2].Text) / int.Parse(item.SubItems[1].Text);

                            string paymentMethod = "현금";
                            string orderRequest = " ";
                            //revenue

                            int totalRevenue = Convert.ToInt32(order_costtxt.Text);
                            // Sale_Item_Num 값을 가져오는 대신 아이템 이름을 사용하여 적절한 Sale_Item_Num을 조회합니다.
                            int saleItemNum = GetSaleItemNumByName(itemName);
                            // InsertOrderDetails 함수를 호출하여 주문 데이터를 삽입합니다.
                            InsertOrderDetails(conn, saleItemNum, paymentMethod, orderNum, orderTime, itemName, orderRequest, itemQuantity, itemPrice);

                            InsertRevenueItem(conn, revenueItemNum, itemName, orderTime, totalRevenue, saleItemNum, paymentMethod, orderNum, itemQuantity, itemPrice);

                        }
                        // 주문이 데이터베이스에 삽입되었습니다.
                        MessageBox.Show("주문이 성공적으로 등록되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("주문할 항목을 선택해주세요.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        /*public void InsertOrderDetails(int saleItemNum, string paymentMethod, int orderNum, DateTime orderTime, string itemName, string orderRequest, int itemQuantity, decimal itemPrice)
        {
            dbc.DB_Close();
            string connectionString = "User Id=cafe1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                try
                {
                    string insertQuery = "INSERT INTO orderdetails (Sale_Item_Num, Payment_Method, Order_Num, Order_Time, Item_Name, Order_Request, Item_Quantity, Item_Price) " +
                        "VALUES (:Sale_Item_Num, :Payment_Method, :Order_Num, :Order_Time, :Item_Name, :Order_Request, :Item_Quantity, :Item_Price)";

                    using (OracleCommand command = new OracleCommand(insertQuery, connection))
                    {
                        // Sale_Item_Num 및 Item_Price를 파라미터로 사용
                        command.Parameters.Add("Sale_Item_Num", OracleDbType.Int32).Value = saleItemNum;
                        command.Parameters.Add("Payment_Method", OracleDbType.Varchar2).Value = paymentMethod;
                        command.Parameters.Add("Order_Num", OracleDbType.Int32).Value = orderNum;
                        command.Parameters.Add("Order_Time", OracleDbType.Date).Value = orderTime;
                        command.Parameters.Add("Item_Name", OracleDbType.Varchar2).Value = itemName;
                        command.Parameters.Add("Order_Request", OracleDbType.Varchar2).Value = orderRequest;
                        command.Parameters.Add("Item_Quantity", OracleDbType.Int32).Value = itemQuantity;
                        // Item_Price를 NUMBER(20)에 맞게 설정
                        command.Parameters.Add("Item_Price", OracleDbType.Int32).Value = itemPrice;

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
        }*/

        private int GetMaxOrderNum(OracleConnection conn)
        {
            int maxOrderNum = 0;

            try
            {
                string query = "SELECT MAX(Order_Num) AS MaxOrderNum FROM OrderDetails";

                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        maxOrderNum = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }

            return maxOrderNum;
        }
        private int GetMaxRevenueNum(OracleConnection conn)
        {
            int maxRevenueNum = 0;

            try
            {
                string query = "SELECT MAX(Revenue_Item_Num) AS MaxRevenueNum FROM Revenue_item";

                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        maxRevenueNum = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }

            return maxRevenueNum;
        }

        private void card_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_Close();
                using (OracleConnection conn = new OracleConnection("User Id=cafe1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );"))
                {
                    conn.Open();
                    // 데이터베이스에서 가장 큰 ORDERNUM을 조회합니다.
                    int orderNum = GetMaxOrderNum(conn) + 1;
                    int revenueItemNum = GetMaxRevenueNum(conn) + 1;
                    //int revenueItemNum, string revenue(ItemName), (DateTime revenueDate), decimal totalRevenue, (decimal saleItemNum), (string paymentMethod), (decimal orderNum), (decimal itemQuantity), (decimal itemPrice)
                    if (order_list.Items.Count > 0)
                    {
                        // 주문 시간을 현재 시간으로 설정합니다.
                        DateTime orderTime = DateTime.Now;

                        // 주문한 모든 품목을 데이터베이스에 삽입합니다.
                        foreach (ListViewItem item in order_list.Items)
                        {
                            string itemName = item.SubItems[0].Text;
                            int itemQuantity = int.Parse(item.SubItems[1].Text);
                            int itemPrice = int.Parse(item.SubItems[2].Text) / int.Parse(item.SubItems[1].Text);

                            string paymentMethod = "카드";
                            string orderRequest = " ";
                            //revenue
                            
                            int totalRevenue = Convert.ToInt32(order_costtxt.Text);
                            // Sale_Item_Num 값을 가져오는 대신 아이템 이름을 사용하여 적절한 Sale_Item_Num을 조회합니다.
                            int saleItemNum = GetSaleItemNumByName(itemName);
                            // InsertOrderDetails 함수를 호출하여 주문 데이터를 삽입합니다.
                            InsertOrderDetails(conn, saleItemNum, paymentMethod, orderNum, orderTime, itemName, orderRequest, itemQuantity, itemPrice);
                            
                            InsertRevenueItem(conn, revenueItemNum, itemName, orderTime, totalRevenue, saleItemNum, paymentMethod, orderNum, itemQuantity, itemPrice);
                            
                        }
                        // 주문이 데이터베이스에 삽입되었습니다.
                        MessageBox.Show("주문이 성공적으로 등록되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("주문할 항목을 선택해주세요.");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }
        private int GetSaleItemNumByName(string itemName)
        {
            int saleItemNum = 0;

            // 아이템 이름과 비교하여 Sale_Item_Num을 찾습니다.
            switch (itemName)
            {
                case "아메리카노":
                    saleItemNum = 1;
                    break;
                case "카페라떼":
                    saleItemNum = 2;
                    break;
                case "카페모카":
                    saleItemNum = 3;
                    break;
                case "카푸치노":
                    saleItemNum = 4;
                    break;
                case "바닐라라떼":
                    saleItemNum = 5;
                    break;
                case "초코라떼":
                    saleItemNum = 6;
                    break;
                // 다른 아이템들에 대한 처리를 추가합니다.
                default:
                    break;
            }

            return saleItemNum;
        }

        // 주문을 데이터베이스에 삽입하는 함수
        private void InsertOrderDetails(OracleConnection conn, int saleItemNum, string paymentMethod, int orderNum, DateTime orderTime, string itemName, string orderRequest, int itemQuantity, int itemPrice)
        {
            try
            {
                string insertQuery = "INSERT INTO orderdetails (Sale_Item_Num, Payment_Method, Order_Num, Order_Time, Item_Name, Order_Request, Item_Quantity, Item_Price) " +
                    "VALUES (:Sale_Item_Num, :Payment_Method, :Order_Num, :Order_Time, :Item_Name, :Order_Request, :Item_Quantity, :Item_Price)";
                
                using (OracleCommand command = new OracleCommand(insertQuery, conn))
                {
                    command.Parameters.Add("Sale_Item_Num", OracleDbType.Int32).Value = saleItemNum;
                    command.Parameters.Add("Payment_Method", OracleDbType.Varchar2).Value = paymentMethod;
                    command.Parameters.Add("Order_Num", OracleDbType.Int32).Value = orderNum;
                    command.Parameters.Add("Order_Time", OracleDbType.Date).Value = orderTime;
                    command.Parameters.Add("Item_Name", OracleDbType.Varchar2).Value = itemName;
                    command.Parameters.Add("Order_Request", OracleDbType.Varchar2).Value = orderRequest;
                    command.Parameters.Add("Item_Quantity", OracleDbType.Int32).Value = itemQuantity;
                    command.Parameters.Add("Item_Price", OracleDbType.Int32).Value = itemPrice;

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
            
        }
        private void InsertRevenueItem(OracleConnection conn, int revenueItemNum, string revenueItemName, DateTime revenueDate, int totalRevenue, int saleItemNum, string paymentMethod, int orderNum, int itemQuantity, int itemPrice)
        {
            try
            {
                string insertRQuery = "INSERT INTO Revenue_Item (Revenue_Item_Num, Revenue_Item_Name, Revenue_Date, Total_Revenue, Sale_Item_Num, Payment_Method, Order_Num, Item_Quantity, Item_Price) " +
                                         "VALUES (:Revenue_Item_Num, :Revenue_Item_Name, :Revenue_Date, :Total_Revenue, :Sale_Item_Num, :Payment_Method, :Order_Num, :Item_Quantity, :Item_Price)";

                using (OracleCommand command = new OracleCommand(insertRQuery, conn))
                {
                    command.Parameters.Add("Revenue_Item_Num", OracleDbType.Int32).Value = revenueItemNum;
                    command.Parameters.Add("Revenue_Item_Name", OracleDbType.Varchar2).Value = revenueItemName;
                    command.Parameters.Add("Revenue_Date", OracleDbType.Date).Value = revenueDate;
                    command.Parameters.Add("Total_Revenue", OracleDbType.Int32).Value = totalRevenue;
                    command.Parameters.Add("Sale_Item_Num", OracleDbType.Int32).Value = saleItemNum;
                    command.Parameters.Add("Payment_Method", OracleDbType.Varchar2).Value = paymentMethod;
                    command.Parameters.Add("Order_Num", OracleDbType.Int32).Value = orderNum;
                    command.Parameters.Add("Item_Quantity", OracleDbType.Int32).Value = itemQuantity;
                    command.Parameters.Add("Item_Price", OracleDbType.Int32).Value = itemPrice;

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void order_cost_Click(object sender, EventArgs e)
        {
            int totalCost = 0;

            // 주문 목록의 모든 품목을 순회하면서 가격을 더합니다.
            foreach (ListViewItem item in order_list.Items)
            {
                int quantity = int.Parse(item.SubItems[1].Text);
                int itemPrice = GetItemPrice(item.Text);
                totalCost += (quantity * itemPrice);
            }

            // 계산된 총 가격을 TextBox에 표시합니다.
            order_costtxt.Text = totalCost.ToString();
        }
    }
}
