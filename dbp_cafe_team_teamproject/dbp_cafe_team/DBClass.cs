using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;//ADO.Net 개체 참조
using System.Data; //DataSet 개체 참조
using System.Windows.Forms; //MessageBox 개체 참조

namespace dbp_cafe_team
{
    public class DBClass
    {
        private int selectedRowIndex;//수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다.
        private int selectedKeyValue; // 수정, 삭제할 때 필요한 레코드의 키값을 보관할 필드
        private string connectionString;

        OracleDataAdapter dBAdapter; //Data Provider인 DBAdapter 입니다.
        DataSet dS;// DataSet 객체입니다.
        OracleCommandBuilder myCommandBuilder; // 추가, 수정, 삭제시에 필요한 명령문을 자동으로 작성해주는 객체입니다.
        DataTable phoneTable;// DataTable 객체입니다.
        

        public int SelectedRowIndex { get { return selectedRowIndex; } set { selectedRowIndex = value; } }

        public int SelectedKeyValue { get { return selectedKeyValue; } set { selectedKeyValue = value; } }

        public OracleDataAdapter DBAdapter { get { return dBAdapter; } set { dBAdapter = value; } }

        public DataSet DS { get { return dS; } set { dS = value; } }

        public OracleCommandBuilder MyCommandBuilder { get { return myCommandBuilder; } set { myCommandBuilder = value; } }

        public DataTable PhoneTable { get { return phoneTable; } set { phoneTable = value; } }
        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public void DB_Open()
        {
            try
            {
                string connectionString = "User Id=cafe1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                string commandString = "SELECT * FROM Sale_Item, Stock_Manage, OrderDetails, Payment_Record, Revenue_Item";


                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                MyCommandBuilder = new OracleCommandBuilder(DBAdapter);

                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public void DB_ObjCreate()
        {
            PhoneTable = new DataTable();
        }

        public void DB_Close()
        {
            try
            {
                if (DBAdapter != null)
                {
                    DBAdapter.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }
    }
}
