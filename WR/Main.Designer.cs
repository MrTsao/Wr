namespace SySoft
{
    partial class PaperHandler
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaperHandler));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbOptionHead = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtFilePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpBar = new System.Windows.Forms.ToolStripProgressBar();
            this.MU_READ_FORMAT = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.格式1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.导入答案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXCELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.libBatch = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGetBatch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.dplKey = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SEQ_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Q_SEQ_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUESTIONS_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUESTIONS_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPTION_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPTION_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPTION_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPTION_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPTION_E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANSWER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANALYSIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROWS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.MU_READ_FORMAT.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(803, 364);
            this.splitContainer1.SplitterDistance = 197;
            this.splitContainer1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "请将word另存为文本文档（.txt）。"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 364);
            this.listBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEQ_NUM,
            this.Q_SEQ_NUM,
            this.QUESTIONS_DESC,
            this.QUESTIONS_TYPE,
            this.OPTION_A,
            this.OPTION_B,
            this.OPTION_C,
            this.OPTION_D,
            this.OPTION_E,
            this.ANSWER,
            this.ANALYSIS,
            this.ROWS});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(602, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.AllowDrop = true;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(803, 418);
            this.splitContainer2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbOptionHead);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 46);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读取选项";
            // 
            // ckbOptionHead
            // 
            this.ckbOptionHead.AutoSize = true;
            this.ckbOptionHead.Location = new System.Drawing.Point(6, 17);
            this.ckbOptionHead.Name = "ckbOptionHead";
            this.ckbOptionHead.Size = new System.Drawing.Size(84, 16);
            this.ckbOptionHead.TabIndex = 6;
            this.ckbOptionHead.Text = "选择项符号";
            this.ckbOptionHead.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(128, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "注意：单选/多选/判断/不定项 等大项之间请插入空行！";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtFilePath,
            this.tpBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(811, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(687, 17);
            this.txtFilePath.Spring = true;
            this.txtFilePath.Text = "...";
            this.txtFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpBar
            // 
            this.tpBar.Margin = new System.Windows.Forms.Padding(10, 3, -1, 3);
            this.tpBar.Name = "tpBar";
            this.tpBar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tpBar.Size = new System.Drawing.Size(100, 16);
            // 
            // MU_READ_FORMAT
            // 
            this.MU_READ_FORMAT.BackColor = System.Drawing.Color.Silver;
            this.MU_READ_FORMAT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.读取ToolStripMenuItem,
            this.导出ToolStripMenuItem});
            this.MU_READ_FORMAT.Location = new System.Drawing.Point(0, 0);
            this.MU_READ_FORMAT.Name = "MU_READ_FORMAT";
            this.MU_READ_FORMAT.Size = new System.Drawing.Size(811, 25);
            this.MU_READ_FORMAT.TabIndex = 9;
            this.MU_READ_FORMAT.Text = "读取格式";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.修改ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.打开ToolStripMenuItem.Text = "打开...";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 读取ToolStripMenuItem
            // 
            this.读取ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.格式1ToolStripMenuItem,
            this.格式2ToolStripMenuItem,
            this.toolStripSeparator1,
            this.导入答案ToolStripMenuItem});
            this.读取ToolStripMenuItem.Name = "读取ToolStripMenuItem";
            this.读取ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.读取ToolStripMenuItem.Text = "读取";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem1.Text = "重新读取";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 格式1ToolStripMenuItem
            // 
            this.格式1ToolStripMenuItem.Image = global::SySoft.Properties.Resources.forwardarr;
            this.格式1ToolStripMenuItem.Name = "格式1ToolStripMenuItem";
            this.格式1ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.格式1ToolStripMenuItem.Text = "格式1";
            this.格式1ToolStripMenuItem.Click += new System.EventHandler(this.格式1ToolStripMenuItem_Click);
            // 
            // 格式2ToolStripMenuItem
            // 
            this.格式2ToolStripMenuItem.Name = "格式2ToolStripMenuItem";
            this.格式2ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.格式2ToolStripMenuItem.Text = "格式2";
            this.格式2ToolStripMenuItem.Click += new System.EventHandler(this.格式2ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 导入答案ToolStripMenuItem
            // 
            this.导入答案ToolStripMenuItem.Name = "导入答案ToolStripMenuItem";
            this.导入答案ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导入答案ToolStripMenuItem.Text = "答案...";
            this.导入答案ToolStripMenuItem.Click += new System.EventHandler(this.导入答案ToolStripMenuItem_Click);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXCELToolStripMenuItem});
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.导出ToolStripMenuItem.Text = "导出";
            // 
            // eXCELToolStripMenuItem
            // 
            this.eXCELToolStripMenuItem.Name = "eXCELToolStripMenuItem";
            this.eXCELToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.eXCELToolStripMenuItem.Text = "EXCEL";
            this.eXCELToolStripMenuItem.Click += new System.EventHandler(this.eXCELToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 444);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(803, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "读取";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "更新";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(212, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(588, 412);
            this.dataGridView2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 412);
            this.panel1.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.libBatch);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 142);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 270);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "删除数据";
            // 
            // libBatch
            // 
            this.libBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libBatch.FormattingEnabled = true;
            this.libBatch.ItemHeight = 12;
            this.libBatch.Location = new System.Drawing.Point(3, 17);
            this.libBatch.Name = "libBatch";
            this.libBatch.Size = new System.Drawing.Size(203, 214);
            this.libBatch.TabIndex = 0;
            this.libBatch.DoubleClick += new System.EventHandler(this.libBatch_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGetBatch);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 231);
            this.panel2.MaximumSize = new System.Drawing.Size(259, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 36);
            this.panel2.TabIndex = 2;
            // 
            // btnGetBatch
            // 
            this.btnGetBatch.Location = new System.Drawing.Point(19, 3);
            this.btnGetBatch.Name = "btnGetBatch";
            this.btnGetBatch.Size = new System.Drawing.Size(79, 30);
            this.btnGetBatch.TabIndex = 2;
            this.btnGetBatch.Text = "获取批次";
            this.btnGetBatch.UseVisualStyleBackColor = true;
            this.btnGetBatch.Click += new System.EventHandler(this.btnGetBatch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(104, 3);
            this.btnDelete.MaximumSize = new System.Drawing.Size(100, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtBatchNo);
            this.groupBox1.Controls.Add(this.dplKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 142);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "增加数据";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "批次号";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(65, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 30);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Location = new System.Drawing.Point(65, 26);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.ReadOnly = true;
            this.txtBatchNo.Size = new System.Drawing.Size(121, 21);
            this.txtBatchNo.TabIndex = 10;
            // 
            // dplKey
            // 
            this.dplKey.FormattingEnabled = true;
            this.dplKey.Items.AddRange(new object[] {
            "",
            "道德",
            "法理",
            "公文",
            "行政法",
            "经济",
            "毛概",
            "民法",
            "社会主义市场经济",
            "事业单位知识",
            "宪法",
            "刑法",
            "中特"});
            this.dplKey.Location = new System.Drawing.Point(65, 52);
            this.dplKey.Name = "dplKey";
            this.dplKey.Size = new System.Drawing.Size(121, 20);
            this.dplKey.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "年份";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(65, 76);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(121, 21);
            this.txtYear.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "关键字";
            // 
            // SEQ_NUM
            // 
            this.SEQ_NUM.DataPropertyName = "SEQ_NUM";
            this.SEQ_NUM.HeaderText = "序号";
            this.SEQ_NUM.Name = "SEQ_NUM";
            this.SEQ_NUM.Width = 40;
            // 
            // Q_SEQ_NUM
            // 
            this.Q_SEQ_NUM.DataPropertyName = "Q_SEQ_NUM";
            this.Q_SEQ_NUM.HeaderText = "行号";
            this.Q_SEQ_NUM.Name = "Q_SEQ_NUM";
            this.Q_SEQ_NUM.Width = 40;
            // 
            // QUESTIONS_DESC
            // 
            this.QUESTIONS_DESC.DataPropertyName = "QUESTIONS_DESC";
            this.QUESTIONS_DESC.HeaderText = "题目";
            this.QUESTIONS_DESC.Name = "QUESTIONS_DESC";
            this.QUESTIONS_DESC.Width = 300;
            // 
            // QUESTIONS_TYPE
            // 
            this.QUESTIONS_TYPE.DataPropertyName = "QUESTIONS_TYPE";
            this.QUESTIONS_TYPE.HeaderText = "类型";
            this.QUESTIONS_TYPE.Name = "QUESTIONS_TYPE";
            this.QUESTIONS_TYPE.Width = 70;
            // 
            // OPTION_A
            // 
            this.OPTION_A.DataPropertyName = "OPTION_A";
            this.OPTION_A.HeaderText = "A";
            this.OPTION_A.Name = "OPTION_A";
            this.OPTION_A.Width = 120;
            // 
            // OPTION_B
            // 
            this.OPTION_B.DataPropertyName = "OPTION_B";
            this.OPTION_B.HeaderText = "B";
            this.OPTION_B.Name = "OPTION_B";
            this.OPTION_B.Width = 120;
            // 
            // OPTION_C
            // 
            this.OPTION_C.DataPropertyName = "OPTION_C";
            this.OPTION_C.HeaderText = "C";
            this.OPTION_C.Name = "OPTION_C";
            this.OPTION_C.Width = 120;
            // 
            // OPTION_D
            // 
            this.OPTION_D.DataPropertyName = "OPTION_D";
            this.OPTION_D.HeaderText = "D";
            this.OPTION_D.Name = "OPTION_D";
            this.OPTION_D.Width = 120;
            // 
            // OPTION_E
            // 
            this.OPTION_E.DataPropertyName = "OPTION_E";
            this.OPTION_E.HeaderText = "E";
            this.OPTION_E.Name = "OPTION_E";
            // 
            // ANSWER
            // 
            this.ANSWER.DataPropertyName = "ANSWER";
            this.ANSWER.HeaderText = "答案";
            this.ANSWER.Name = "ANSWER";
            this.ANSWER.Width = 40;
            // 
            // ANALYSIS
            // 
            this.ANALYSIS.DataPropertyName = "ANALYSIS";
            this.ANALYSIS.HeaderText = "解析";
            this.ANALYSIS.Name = "ANALYSIS";
            this.ANALYSIS.Width = 120;
            // 
            // ROWS
            // 
            this.ROWS.DataPropertyName = "ROWS";
            this.ROWS.HeaderText = "文本行";
            this.ROWS.Name = "ROWS";
            // 
            // PaperHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 491);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MU_READ_FORMAT);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaperHandler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "试题格式化-powered by rcode@163.com";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaperHandler_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaperHandler_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MU_READ_FORMAT.ResumeLayout(false);
            this.MU_READ_FORMAT.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox ckbOptionHead;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtFilePath;
        private System.Windows.Forms.ToolStripProgressBar tpBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip MU_READ_FORMAT;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读取ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 格式1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 导入答案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXCELToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox dplKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox libBatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnGetBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Q_SEQ_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUESTIONS_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUESTIONS_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPTION_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPTION_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPTION_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPTION_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPTION_E;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANSWER;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANALYSIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROWS;
    }
}

