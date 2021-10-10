
namespace MySQLMonitor
{
    partial class MainFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            this.TEXTBox_ConnectAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TEXTBox_Uesr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TEXTBox_Pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBox_DBName = new System.Windows.Forms.ComboBox();
            this.BTN_Connect = new System.Windows.Forms.Button();
            this.BTN_DisConnect = new System.Windows.Forms.Button();
            this.BTN_DeleteLogs = new System.Windows.Forms.Button();
            this.BTN_CleanLogs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Logs = new System.Windows.Forms.DataGridView();
            this.OperaTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperaType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperaSQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperaUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_ManualRefresh = new System.Windows.Forms.Button();
            this.BTN_StopListenLogs = new System.Windows.Forms.Button();
            this.BTN_StartListenLogs = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TEXTBox_ConnectPort = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TEXTBox_SearchStr = new System.Windows.Forms.RichTextBox();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Logs)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TEXTBox_ConnectAddress
            // 
            this.TEXTBox_ConnectAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TEXTBox_ConnectAddress.Location = new System.Drawing.Point(65, 20);
            this.TEXTBox_ConnectAddress.Name = "TEXTBox_ConnectAddress";
            this.TEXTBox_ConnectAddress.Size = new System.Drawing.Size(150, 21);
            this.TEXTBox_ConnectAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "连接地址:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "连接账号:";
            // 
            // TEXTBox_Uesr
            // 
            this.TEXTBox_Uesr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TEXTBox_Uesr.Location = new System.Drawing.Point(65, 77);
            this.TEXTBox_Uesr.Name = "TEXTBox_Uesr";
            this.TEXTBox_Uesr.Size = new System.Drawing.Size(150, 21);
            this.TEXTBox_Uesr.TabIndex = 3;
            this.TEXTBox_Uesr.Text = "root";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "连接密码:";
            // 
            // TEXTBox_Pass
            // 
            this.TEXTBox_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TEXTBox_Pass.Location = new System.Drawing.Point(65, 104);
            this.TEXTBox_Pass.Name = "TEXTBox_Pass";
            this.TEXTBox_Pass.Size = new System.Drawing.Size(150, 21);
            this.TEXTBox_Pass.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "数据库列表:";
            // 
            // ComboBox_DBName
            // 
            this.ComboBox_DBName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_DBName.Enabled = false;
            this.ComboBox_DBName.FormattingEnabled = true;
            this.ComboBox_DBName.Location = new System.Drawing.Point(83, 134);
            this.ComboBox_DBName.Name = "ComboBox_DBName";
            this.ComboBox_DBName.Size = new System.Drawing.Size(132, 20);
            this.ComboBox_DBName.TabIndex = 7;
            // 
            // BTN_Connect
            // 
            this.BTN_Connect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Connect.Location = new System.Drawing.Point(8, 170);
            this.BTN_Connect.Name = "BTN_Connect";
            this.BTN_Connect.Size = new System.Drawing.Size(207, 23);
            this.BTN_Connect.TabIndex = 8;
            this.BTN_Connect.Text = "立即连接(&C)";
            this.BTN_Connect.UseVisualStyleBackColor = true;
            this.BTN_Connect.Click += new System.EventHandler(this.BTN_Connect_Click);
            // 
            // BTN_DisConnect
            // 
            this.BTN_DisConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_DisConnect.Enabled = false;
            this.BTN_DisConnect.Location = new System.Drawing.Point(8, 199);
            this.BTN_DisConnect.Name = "BTN_DisConnect";
            this.BTN_DisConnect.Size = new System.Drawing.Size(207, 23);
            this.BTN_DisConnect.TabIndex = 9;
            this.BTN_DisConnect.Text = "断开连接(&K)";
            this.BTN_DisConnect.UseVisualStyleBackColor = true;
            this.BTN_DisConnect.Click += new System.EventHandler(this.BTN_DisConnect_Click);
            // 
            // BTN_DeleteLogs
            // 
            this.BTN_DeleteLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_DeleteLogs.Enabled = false;
            this.BTN_DeleteLogs.Location = new System.Drawing.Point(8, 344);
            this.BTN_DeleteLogs.Name = "BTN_DeleteLogs";
            this.BTN_DeleteLogs.Size = new System.Drawing.Size(207, 23);
            this.BTN_DeleteLogs.TabIndex = 11;
            this.BTN_DeleteLogs.Text = "删除日志(&D)";
            this.BTN_DeleteLogs.UseVisualStyleBackColor = true;
            this.BTN_DeleteLogs.Click += new System.EventHandler(this.BTN_DeleteLogs_Click);
            // 
            // BTN_CleanLogs
            // 
            this.BTN_CleanLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_CleanLogs.Enabled = false;
            this.BTN_CleanLogs.Location = new System.Drawing.Point(8, 315);
            this.BTN_CleanLogs.Name = "BTN_CleanLogs";
            this.BTN_CleanLogs.Size = new System.Drawing.Size(207, 23);
            this.BTN_CleanLogs.TabIndex = 10;
            this.BTN_CleanLogs.Text = "清除日志(&L)";
            this.BTN_CleanLogs.UseVisualStyleBackColor = true;
            this.BTN_CleanLogs.Click += new System.EventHandler(this.BTN_CleanLogs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView_Logs);
            this.groupBox1.Location = new System.Drawing.Point(232, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 532);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "监控日志";
            // 
            // dataGridView_Logs
            // 
            this.dataGridView_Logs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Logs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OperaTime,
            this.OperaType,
            this.OperaSQL,
            this.OperaUser});
            this.dataGridView_Logs.Enabled = false;
            this.dataGridView_Logs.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_Logs.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_Logs.Name = "dataGridView_Logs";
            this.dataGridView_Logs.RowTemplate.Height = 3;
            this.dataGridView_Logs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView_Logs.Size = new System.Drawing.Size(935, 506);
            this.dataGridView_Logs.TabIndex = 0;
            // 
            // OperaTime
            // 
            this.OperaTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OperaTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.OperaTime.HeaderText = "操作时间";
            this.OperaTime.Name = "OperaTime";
            this.OperaTime.ReadOnly = true;
            // 
            // OperaType
            // 
            this.OperaType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OperaType.DefaultCellStyle = dataGridViewCellStyle2;
            this.OperaType.HeaderText = "操作类型";
            this.OperaType.MinimumWidth = 20;
            this.OperaType.Name = "OperaType";
            this.OperaType.ReadOnly = true;
            // 
            // OperaSQL
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OperaSQL.DefaultCellStyle = dataGridViewCellStyle3;
            this.OperaSQL.HeaderText = "SQL语句";
            this.OperaSQL.MinimumWidth = 100;
            this.OperaSQL.Name = "OperaSQL";
            this.OperaSQL.ReadOnly = true;
            this.OperaSQL.Width = 200;
            // 
            // OperaUser
            // 
            this.OperaUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OperaUser.DefaultCellStyle = dataGridViewCellStyle4;
            this.OperaUser.HeaderText = "操作用户";
            this.OperaUser.MinimumWidth = 20;
            this.OperaUser.Name = "OperaUser";
            this.OperaUser.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_ManualRefresh);
            this.groupBox2.Controls.Add(this.BTN_StopListenLogs);
            this.groupBox2.Controls.Add(this.BTN_StartListenLogs);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TEXTBox_ConnectPort);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BTN_DeleteLogs);
            this.groupBox2.Controls.Add(this.TEXTBox_ConnectAddress);
            this.groupBox2.Controls.Add(this.BTN_CleanLogs);
            this.groupBox2.Controls.Add(this.TEXTBox_Uesr);
            this.groupBox2.Controls.Add(this.BTN_DisConnect);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BTN_Connect);
            this.groupBox2.Controls.Add(this.TEXTBox_Pass);
            this.groupBox2.Controls.Add(this.ComboBox_DBName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 375);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数配置";
            // 
            // BTN_ManualRefresh
            // 
            this.BTN_ManualRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ManualRefresh.Enabled = false;
            this.BTN_ManualRefresh.Location = new System.Drawing.Point(6, 228);
            this.BTN_ManualRefresh.Name = "BTN_ManualRefresh";
            this.BTN_ManualRefresh.Size = new System.Drawing.Size(207, 23);
            this.BTN_ManualRefresh.TabIndex = 16;
            this.BTN_ManualRefresh.Text = "手动刷新(&G)";
            this.BTN_ManualRefresh.UseVisualStyleBackColor = true;
            this.BTN_ManualRefresh.Click += new System.EventHandler(this.BTN_ManualRefresh_Click);
            // 
            // BTN_StopListenLogs
            // 
            this.BTN_StopListenLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_StopListenLogs.Enabled = false;
            this.BTN_StopListenLogs.Location = new System.Drawing.Point(6, 286);
            this.BTN_StopListenLogs.Name = "BTN_StopListenLogs";
            this.BTN_StopListenLogs.Size = new System.Drawing.Size(207, 23);
            this.BTN_StopListenLogs.TabIndex = 15;
            this.BTN_StopListenLogs.Text = "停止监听(&S)";
            this.BTN_StopListenLogs.UseVisualStyleBackColor = true;
            this.BTN_StopListenLogs.Click += new System.EventHandler(this.BTN_StopListenLogs_Click);
            // 
            // BTN_StartListenLogs
            // 
            this.BTN_StartListenLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_StartListenLogs.Enabled = false;
            this.BTN_StartListenLogs.Location = new System.Drawing.Point(8, 257);
            this.BTN_StartListenLogs.Name = "BTN_StartListenLogs";
            this.BTN_StartListenLogs.Size = new System.Drawing.Size(207, 23);
            this.BTN_StartListenLogs.TabIndex = 14;
            this.BTN_StartListenLogs.Text = "开始监听(&R)";
            this.BTN_StartListenLogs.UseVisualStyleBackColor = true;
            this.BTN_StartListenLogs.Click += new System.EventHandler(this.BTN_StartListenLogs_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "连接端口:";
            // 
            // TEXTBox_ConnectPort
            // 
            this.TEXTBox_ConnectPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TEXTBox_ConnectPort.Location = new System.Drawing.Point(65, 48);
            this.TEXTBox_ConnectPort.Name = "TEXTBox_ConnectPort";
            this.TEXTBox_ConnectPort.Size = new System.Drawing.Size(150, 21);
            this.TEXTBox_ConnectPort.TabIndex = 1;
            this.TEXTBox_ConnectPort.Text = "3306";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.TEXTBox_SearchStr);
            this.groupBox3.Controls.Add(this.BTN_Search);
            this.groupBox3.Location = new System.Drawing.Point(12, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 145);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "功能区";
            // 
            // TEXTBox_SearchStr
            // 
            this.TEXTBox_SearchStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TEXTBox_SearchStr.Enabled = false;
            this.TEXTBox_SearchStr.Location = new System.Drawing.Point(8, 20);
            this.TEXTBox_SearchStr.Name = "TEXTBox_SearchStr";
            this.TEXTBox_SearchStr.Size = new System.Drawing.Size(200, 90);
            this.TEXTBox_SearchStr.TabIndex = 5;
            this.TEXTBox_SearchStr.Text = "";
            this.TEXTBox_SearchStr.Enter += new System.EventHandler(this.TEXTBox_SearchStr_Enter_1);
            this.TEXTBox_SearchStr.Leave += new System.EventHandler(this.TEXTBox_SearchStr_Leave_1);
            // 
            // BTN_Search
            // 
            this.BTN_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Search.Enabled = false;
            this.BTN_Search.Location = new System.Drawing.Point(8, 116);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(200, 23);
            this.BTN_Search.TabIndex = 1;
            this.BTN_Search.Text = "搜索(&H)";
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 547);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL日志监控工具";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Logs)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBox_DBName;
        private System.Windows.Forms.Button BTN_Connect;
        private System.Windows.Forms.Button BTN_DisConnect;
        private System.Windows.Forms.Button BTN_DeleteLogs;
        private System.Windows.Forms.Button BTN_CleanLogs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_StopListenLogs;
        private System.Windows.Forms.Button BTN_StartListenLogs;
        private System.Windows.Forms.DataGridView dataGridView_Logs;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperaTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperaType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperaSQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperaUser;
        private System.Windows.Forms.Button BTN_ManualRefresh;
        public System.Windows.Forms.TextBox TEXTBox_ConnectAddress;
        public System.Windows.Forms.TextBox TEXTBox_Uesr;
        public System.Windows.Forms.TextBox TEXTBox_Pass;
        public System.Windows.Forms.TextBox TEXTBox_ConnectPort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.RichTextBox TEXTBox_SearchStr;
    }
}

