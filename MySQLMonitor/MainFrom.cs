using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLMonitor
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        // 是否停止监听状态码
        public static int listenStatusCode = 0;

        // 获取数据库连接
        public static MySqlConnection conn = null;

        private string getConnStr()
        {
            string connectStr = "Data Source=" + TEXTBox_ConnectAddress.Text + ";Port=" + TEXTBox_ConnectPort.Text + ";UserId=" + TEXTBox_Uesr.Text + ";Password=" + TEXTBox_Pass.Text + ";Charset=utf8;TreatTinyAsBoolean=false;Allow User Variables=True";
            return connectStr;
        }

        // 连接按钮点击
        private void BTN_Connect_Click(object sender, EventArgs e)
        {
            // 判断填入信息是否为空
            if (!MyUtils.checkData(TEXTBox_ConnectAddress, TEXTBox_ConnectPort, TEXTBox_Uesr, TEXTBox_Pass)) return;

            // 获取数据库连接
            conn = MyUtils.GetMysqlConn(getConnStr());
            if( conn == null) { return; };

            // 构建SQL语句命令
            MySqlCommand mycmd = new MySqlCommand("show databases;", conn);

            // 获取查询数据库列表的返回内容
            string[] DBDataRestult = MyUtils.GetDBListData(mycmd);

            // 将数据库列表显示到CommboBox
            for (int i = 0; i < DBDataRestult.Length; i++)
            {
                ComboBox_DBName.Items.Insert(i, DBDataRestult[i]);
            }
            ComboBox_DBName.Enabled = true;
            // 选择框下标指向第一个
            ComboBox_DBName.SelectedIndex = 0;


            TEXTBox_ConnectAddress.Enabled = false;
            TEXTBox_ConnectPort.Enabled = false;
            TEXTBox_Pass.Enabled = false;
            TEXTBox_Uesr.Enabled = false;
            TEXTBox_SearchStr.Enabled = true;
            dataGridView_Logs.Enabled = true;
            
            BTN_Connect.Enabled = false;
            BTN_DisConnect.Enabled = true;
            BTN_StartListenLogs.Enabled = true;
            BTN_CleanLogs.Enabled = true;
            BTN_DeleteLogs.Enabled = true;
            BTN_ManualRefresh.Enabled = true;


            BTN_Search.Enabled = true;

            // 开启数据库日志功能
            if (!MyUtils.startLogStatus(MyUtils.GetMysqlConn(getConnStr()))) { return; };


        }

        // 断开连接按钮
        private void BTN_DisConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
            }
            catch
            {
                MessageBox.Show("关闭数据库连接失败，正在重启软件", "错误！");
                System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                System.Diagnostics.Process tt = System.Diagnostics.Process.GetProcessById(System.Diagnostics.Process.GetCurrentProcess().Id);
                tt.Kill();
            }
            ComboBox_DBName.Items.Clear();
            ComboBox_DBName.Items.Insert(0, "");
            ComboBox_DBName.SelectedIndex = 0;
            ComboBox_DBName.Enabled = false;
            BTN_Connect.Enabled = true;
            BTN_DisConnect.Enabled = false;
            BTN_StartListenLogs.Enabled = false;
            BTN_StopListenLogs.Enabled = false;
            BTN_CleanLogs.Enabled = false;
            BTN_DeleteLogs.Enabled = false;
            BTN_ManualRefresh.Enabled = false;
            BTN_Search.Enabled = false;
            dataGridView_Logs.Enabled = false;

            TEXTBox_SearchStr.Enabled = false;
            TEXTBox_ConnectAddress.Enabled = true;
            TEXTBox_ConnectPort.Enabled = true;
            TEXTBox_Pass.Enabled = true;
            TEXTBox_Uesr.Enabled = true;
        }


        // 清空DataGridView按钮
        private void BTN_CleanLogs_Click(object sender, EventArgs e)
        {
            dataGridView_Logs.Rows.Clear();
        }

        // 删除日志按钮
        private void BTN_DeleteLogs_Click(object sender, EventArgs e)
        {
            dataGridView_Logs.Rows.Clear();
            MyUtils.TruncateLogsTabels(MyUtils.GetMysqlConn(getConnStr()));
        }


        // 关闭监听按钮
        private void BTN_StopListenLogs_Click(object sender, EventArgs e)
        {
            listenStatusCode = 1;
            BTN_StartListenLogs.Enabled = true;
            BTN_StopListenLogs.Enabled = false;
        }

        //定义一个委托实现回调函数 
        public delegate void CallBackDelegate(string message, MySqlConnection conn, DataGridView dataGridView, string connStr);
        //线程执行的方法 参数是个委托, 线程中参数需要用object类型. 
        static void Fun(object o)
        {

            //此处对传进来的参数进行处理
            object[] p = (object[])o;



            //调用原来的method方法
            MySqlConnection conn = (MySqlConnection)p[1];
            DataGridView dataGridView = (DataGridView)p[2];
            string connStrData = p[3].ToString();
            int DataGridViewCount = MyUtils.GetDataGridViewRowsCount(dataGridView) - 1;
            while (true)
            {
                if (listenStatusCode != 0) { break; };
                int MysqlDBCount = MyUtils.GetMysqlDBLogsCount(conn);
                if (MysqlDBCount != DataGridViewCount)
                {
                    MyUtils.UpdateLogs(MyUtils.GetMysqlConn(connStrData), dataGridView);
                    DataGridViewCount = MyUtils.GetDataGridViewRowsCount(dataGridView) - 1;
                }
                else
                {
                    Thread.Sleep(2000);
                }
            }

            //把传来的参数转换为委托 
            var cbd = p[0] as CallBackDelegate;
            //执行回调. 
            cbd("Thread Run Over", conn, dataGridView, connStrData);
        }


        //回调方法 
        private static void CallBack(string message, MySqlConnection conn, DataGridView dataGridView, string connStr)
        {

            if (message == "Thread Run Over")
            {
                MessageBox.Show("已停止监听", "提示");
            }
            Console.WriteLine("Callback:{0}", message);
        }

        // 开始监听按钮点击
        private void BTN_StartListenLogs_Click(object sender, EventArgs e)
        {
            listenStatusCode = 0;
            BTN_StopListenLogs.Enabled = true;
            BTN_StartListenLogs.Enabled = false;


            // 查询所有日志SQL语句
            //MyUtils.UpdateLogs(conn, dataGridView_Logs);


            //程序开始的时候,把回调的方法给委托变量 
            CallBackDelegate cbd = CallBack;
            //启动线程 
            Thread th = new Thread(new ParameterizedThreadStart(Fun));
            object parm = new object[] { cbd, MyUtils.GetMysqlConn(getConnStr()), dataGridView_Logs, getConnStr() };
            //开始线程，代入参数 
            th.Start(parm);
            //Console.ReadKey();

        }



        // 窗口初始化

        private void MainFrom_Load(object sender, EventArgs e)
        {
            dataGridView_Logs.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Logs.Columns[1].Width = 120;
            dataGridView_Logs.Columns[2].Width = 350;
            CheckForIllegalCrossThreadCalls = false;
            TEXTBox_ConnectAddress.Focus();
        }

        private void BTN_ManualRefresh_Click(object sender, EventArgs e)
        {
            dataGridView_Logs.Rows.Clear();
            // 构建SQL语句命令
            MyUtils.UpdateLogs(MyUtils.GetMysqlConn(getConnStr()), dataGridView_Logs);
        }


        #region 功能区控件事件
        Boolean textboxHasText = false;
        private void TEXTBox_SearchStr_Enter_1(object sender, EventArgs e)
        {

            if (textboxHasText == false)
                TEXTBox_SearchStr.Text = "";

            TEXTBox_SearchStr.ForeColor = Color.Black;
        }

        private void TEXTBox_SearchStr_Leave_1(object sender, EventArgs e)
        {

            if (TEXTBox_SearchStr.Text == "")
            {
                TEXTBox_SearchStr.Text = "输入关键字";
                TEXTBox_SearchStr.ForeColor = Color.LightGray;
                textboxHasText = false;
            }
            else
                textboxHasText = true;
        }


        private void BTN_Search_Click(object sender, EventArgs e)
        {
            if (TEXTBox_SearchStr.Text == null && TEXTBox_SearchStr.Text == "" && TEXTBox_SearchStr.Text == "请输入关键字") { MessageBox.Show("搜索内容不能为空！", "警告"); return; }

            //string data = dataGridView_Logs.Rows[1].Cells[2].Value.ToString();

            String searchValue = TEXTBox_SearchStr.Text;
            int rowIndex = -1;
            foreach (DataGridViewRow row in dataGridView_Logs.Rows)
            {
                try
                {
                    string tableData = dataGridView_Logs.Rows[row.Index].Cells[2].Value.ToString();
                    if (tableData == null) { continue; };
                    if (tableData.Contains(searchValue))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }
                catch
                {
                    continue;
                }
                
            }
            dataGridView_Logs.Rows[rowIndex].Selected = true;
            dataGridView_Logs.FirstDisplayedScrollingRowIndex = rowIndex;



            //MessageBox.Show(data);
        }

        #endregion
    }
}
