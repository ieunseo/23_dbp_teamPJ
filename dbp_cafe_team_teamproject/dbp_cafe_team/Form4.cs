using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.DataAccess.Client;

namespace dbp_cafe_team
{
    public partial class Form4 : Form
    {
        //수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다.
        private int SelectedRowIndex;
        // Data Provider인 DBAdapter 입니다.
        OracleDataAdapter DBAdapter;
        // DataSet 객체입니다.
        DataSet DS;
        // 추가, 수정, 삭제시에 필요한 명령문을 
        // 자동으로 작성해주는 객체입니다.
        OracleCommandBuilder myCommandBuilder;
        // DataTable 객체입니다.
        DataTable phoneTable;
        // 수정, 삭제할 때 필요한 레코드의 키값을 보관할 필드
        private int SelectedKeyValue;

        private void DB_Open()
        {
            try
            {
                string connectionString = "User Id=cafe1; Password = 1111; Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe))); ";
            string commandString = "select * from Sale_Item";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
        public Form4()
        {
            InitializeComponent();
            DB_Open();  
        }
        Form1 form1;
        Form2 form2;
        Form3 form3;
        Form4 form4;
        
        private void Form4_Load(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void 결제내역ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (form2 == null || form2.IsDisposed) //Form4
            {
                form2 = new Form2();
                form2.MdiParent = this;
                form2.Show();
            }
        }

        private void 주문관리ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (form1 == null || form1.IsDisposed)
            {
                form1 = new Form1();
                form1.MdiParent = this;
                form1.Show();
            }
        }

        private void 매출관리ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (form3 == null || form3.IsDisposed) //Form5
            {
                form3 = new Form3();
                form3.MdiParent = this;
                form3.Show();
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
