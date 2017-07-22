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
            this.btnOpen = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MU_READ_FORMAT = new System.Windows.Forms.MenuStrip();
            this.MI_TYPE1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_TYPE2 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.ckbOptionHead = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtFilePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpBar = new System.Windows.Forms.ToolStripProgressBar();
            this.mi_import_answer = new System.Windows.Forms.ToolStripMenuItem();
            this.SEQ_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Q_SEQ_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUESTIONS_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUESTIONS_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPTION_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPTION_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPTION_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPTION_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANSWER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANALYSIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROWS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MU_READ_FORMAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupbox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(76, 30);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "打开...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.MU_READ_FORMAT);
            this.splitContainer1.Size = new System.Drawing.Size(811, 416);
            this.splitContainer1.SplitterDistance = 200;
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
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 416);
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
            this.ANSWER,
            this.ANALYSIS,
            this.ROWS});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(607, 391);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MU_READ_FORMAT
            // 
            this.MU_READ_FORMAT.BackColor = System.Drawing.Color.Tan;
            this.MU_READ_FORMAT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_TYPE1,
            this.MI_TYPE2,
            this.mi_import_answer});
            this.MU_READ_FORMAT.Location = new System.Drawing.Point(0, 0);
            this.MU_READ_FORMAT.Name = "MU_READ_FORMAT";
            this.MU_READ_FORMAT.Size = new System.Drawing.Size(607, 25);
            this.MU_READ_FORMAT.TabIndex = 1;
            this.MU_READ_FORMAT.Text = "读取格式";
            // 
            // MI_TYPE1
            // 
            this.MI_TYPE1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MI_TYPE1.ForeColor = System.Drawing.Color.Tan;
            this.MI_TYPE1.Name = "MI_TYPE1";
            this.MI_TYPE1.Size = new System.Drawing.Size(51, 21);
            this.MI_TYPE1.Text = "格式1";
            this.MI_TYPE1.Click += new System.EventHandler(this.MI_TYPE1_Click);
            // 
            // MI_TYPE2
            // 
            this.MI_TYPE2.ForeColor = System.Drawing.Color.Black;
            this.MI_TYPE2.Name = "MI_TYPE2";
            this.MI_TYPE2.Size = new System.Drawing.Size(51, 21);
            this.MI_TYPE2.Text = "格式2";
            this.MI_TYPE2.Click += new System.EventHandler(this.MI_TYPE2_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.AllowDrop = true;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.groupbox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(811, 469);
            this.splitContainer2.SplitterDistance = 49;
            this.splitContainer2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(456, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "注意：单选/多选/判断/不定项 等大项之间请插入空行！";
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.btnOpen);
            this.groupbox1.Controls.Add(this.btnExport);
            this.groupbox1.Controls.Add(this.ckbOptionHead);
            this.groupbox1.Controls.Add(this.btnUpdate);
            this.groupbox1.Controls.Add(this.btnRead);
            this.groupbox1.Location = new System.Drawing.Point(4, -4);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(445, 50);
            this.groupbox1.TabIndex = 6;
            this.groupbox1.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(258, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(76, 30);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "导出EXCEL";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ckbOptionHead
            // 
            this.ckbOptionHead.AutoSize = true;
            this.ckbOptionHead.Location = new System.Drawing.Point(351, 20);
            this.ckbOptionHead.Name = "ckbOptionHead";
            this.ckbOptionHead.Size = new System.Drawing.Size(84, 16);
            this.ckbOptionHead.TabIndex = 6;
            this.ckbOptionHead.Text = "选择项符号";
            this.ckbOptionHead.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(174, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(90, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(76, 30);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "读取";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
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
            // mi_import_answer
            // 
            this.mi_import_answer.Name = "mi_import_answer";
            this.mi_import_answer.Size = new System.Drawing.Size(68, 21);
            this.mi_import_answer.Text = "导入答案";
            this.mi_import_answer.Click += new System.EventHandler(this.mi_import_answer_Click);
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
            this.Q_SEQ_NUM.HeaderText = "标题行号";
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
            this.AcceptButton = this.btnOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 491);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MU_READ_FORMAT;
            this.Name = "PaperHandler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "试题格式化-powered by rcode@163.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MU_READ_FORMAT.ResumeLayout(false);
            this.MU_READ_FORMAT.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.CheckBox ckbOptionHead;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtFilePath;
        private System.Windows.Forms.ToolStripProgressBar tpBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip MU_READ_FORMAT;
        private System.Windows.Forms.ToolStripMenuItem MI_TYPE1;
        private System.Windows.Forms.ToolStripMenuItem MI_TYPE2;
        private System.Windows.Forms.ToolStripMenuItem mi_import_answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Q_SEQ_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUESTIONS_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUESTIONS_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPTION_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPTION_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPTION_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPTION_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANSWER;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANALYSIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROWS;
    }
}

