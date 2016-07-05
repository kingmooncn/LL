namespace LL
{
    partial class Form1
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.bpParameter = new System.Windows.Forms.TabPage();
            this.btCloseDb = new System.Windows.Forms.Button();
            this.btOpenDb = new System.Windows.Forms.Button();
            this.btParaSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbParaSuggestValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbParaInfluence = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbParaDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbParaDefaultValue = new System.Windows.Forms.TextBox();
            this.tbParaRange = new System.Windows.Forms.TextBox();
            this.tbParaObject = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.tbPara3GPPName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbParaName = new System.Windows.Forms.TextBox();
            this.btParaQuery = new System.Windows.Forms.Button();
            this.tpPM = new System.Windows.Forms.TabPage();
            this.tpSignaling = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPowerCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssPara = new System.Windows.Forms.StatusStrip();
            this.tsslParaDbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbParaName = new System.Windows.Forms.ListBox();
            this.tcMain.SuspendLayout();
            this.bpParameter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ssPara.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.bpParameter);
            this.tcMain.Controls.Add(this.tpPM);
            this.tcMain.Controls.Add(this.tpSignaling);
            this.tcMain.Location = new System.Drawing.Point(1, 28);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(933, 508);
            this.tcMain.TabIndex = 0;
            // 
            // bpParameter
            // 
            this.bpParameter.BackColor = System.Drawing.Color.Orange;
            this.bpParameter.Controls.Add(this.lbParaName);
            this.bpParameter.Controls.Add(this.btCloseDb);
            this.bpParameter.Controls.Add(this.btOpenDb);
            this.bpParameter.Controls.Add(this.btParaSave);
            this.bpParameter.Controls.Add(this.label8);
            this.bpParameter.Controls.Add(this.tbParaSuggestValue);
            this.bpParameter.Controls.Add(this.label7);
            this.bpParameter.Controls.Add(this.tbParaInfluence);
            this.bpParameter.Controls.Add(this.label6);
            this.bpParameter.Controls.Add(this.tbParaDescription);
            this.bpParameter.Controls.Add(this.label5);
            this.bpParameter.Controls.Add(this.label4);
            this.bpParameter.Controls.Add(this.tbParaDefaultValue);
            this.bpParameter.Controls.Add(this.tbParaRange);
            this.bpParameter.Controls.Add(this.tbParaObject);
            this.bpParameter.Controls.Add(this.Label3);
            this.bpParameter.Controls.Add(this.tbPara3GPPName);
            this.bpParameter.Controls.Add(this.label2);
            this.bpParameter.Controls.Add(this.label1);
            this.bpParameter.Controls.Add(this.tbParaName);
            this.bpParameter.Controls.Add(this.btParaQuery);
            this.bpParameter.Location = new System.Drawing.Point(4, 22);
            this.bpParameter.Name = "bpParameter";
            this.bpParameter.Padding = new System.Windows.Forms.Padding(3);
            this.bpParameter.Size = new System.Drawing.Size(925, 482);
            this.bpParameter.TabIndex = 0;
            this.bpParameter.Text = "参数";
            // 
            // btCloseDb
            // 
            this.btCloseDb.Location = new System.Drawing.Point(19, 283);
            this.btCloseDb.Name = "btCloseDb";
            this.btCloseDb.Size = new System.Drawing.Size(75, 23);
            this.btCloseDb.TabIndex = 20;
            this.btCloseDb.Text = "关闭数据库";
            this.btCloseDb.UseVisualStyleBackColor = true;
            this.btCloseDb.Click += new System.EventHandler(this.btCloseDb_Click);
            // 
            // btOpenDb
            // 
            this.btOpenDb.Location = new System.Drawing.Point(19, 245);
            this.btOpenDb.Name = "btOpenDb";
            this.btOpenDb.Size = new System.Drawing.Size(75, 23);
            this.btOpenDb.TabIndex = 19;
            this.btOpenDb.Text = "打开数据库";
            this.btOpenDb.UseVisualStyleBackColor = true;
            this.btOpenDb.Click += new System.EventHandler(this.btOpenDb_Click);
            // 
            // btParaSave
            // 
            this.btParaSave.Location = new System.Drawing.Point(19, 361);
            this.btParaSave.Name = "btParaSave";
            this.btParaSave.Size = new System.Drawing.Size(75, 23);
            this.btParaSave.TabIndex = 17;
            this.btParaSave.Text = "保存";
            this.btParaSave.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(41, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "建议值：";
            // 
            // tbParaSuggestValue
            // 
            this.tbParaSuggestValue.Location = new System.Drawing.Point(100, 151);
            this.tbParaSuggestValue.Name = "tbParaSuggestValue";
            this.tbParaSuggestValue.Size = new System.Drawing.Size(223, 21);
            this.tbParaSuggestValue.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(355, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "经验总结：";
            // 
            // tbParaInfluence
            // 
            this.tbParaInfluence.Location = new System.Drawing.Point(426, 151);
            this.tbParaInfluence.Multiline = true;
            this.tbParaInfluence.Name = "tbParaInfluence";
            this.tbParaInfluence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbParaInfluence.Size = new System.Drawing.Size(491, 325);
            this.tbParaInfluence.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(355, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "参数描述：";
            // 
            // tbParaDescription
            // 
            this.tbParaDescription.Location = new System.Drawing.Point(426, 10);
            this.tbParaDescription.Multiline = true;
            this.tbParaDescription.Name = "tbParaDescription";
            this.tbParaDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbParaDescription.Size = new System.Drawing.Size(491, 135);
            this.tbParaDescription.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(41, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "默认值：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(29, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "取值范围：";
            // 
            // tbParaDefaultValue
            // 
            this.tbParaDefaultValue.Location = new System.Drawing.Point(100, 124);
            this.tbParaDefaultValue.Name = "tbParaDefaultValue";
            this.tbParaDefaultValue.Size = new System.Drawing.Size(223, 21);
            this.tbParaDefaultValue.TabIndex = 8;
            // 
            // tbParaRange
            // 
            this.tbParaRange.Location = new System.Drawing.Point(100, 97);
            this.tbParaRange.Name = "tbParaRange";
            this.tbParaRange.Size = new System.Drawing.Size(223, 21);
            this.tbParaRange.TabIndex = 7;
            // 
            // tbParaObject
            // 
            this.tbParaObject.Location = new System.Drawing.Point(100, 70);
            this.tbParaObject.Name = "tbParaObject";
            this.tbParaObject.Size = new System.Drawing.Size(223, 21);
            this.tbParaObject.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.Location = new System.Drawing.Point(29, 73);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(68, 17);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "网元级别：";
            // 
            // tbPara3GPPName
            // 
            this.tbPara3GPPName.Location = new System.Drawing.Point(100, 43);
            this.tbPara3GPPName.Name = "tbPara3GPPName";
            this.tbPara3GPPName.Size = new System.Drawing.Size(223, 21);
            this.tbPara3GPPName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(29, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "规范名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "参数名称：";
            // 
            // tbParaName
            // 
            this.tbParaName.Location = new System.Drawing.Point(100, 16);
            this.tbParaName.Name = "tbParaName";
            this.tbParaName.Size = new System.Drawing.Size(223, 21);
            this.tbParaName.TabIndex = 1;
            // 
            // btParaQuery
            // 
            this.btParaQuery.Location = new System.Drawing.Point(19, 322);
            this.btParaQuery.Name = "btParaQuery";
            this.btParaQuery.Size = new System.Drawing.Size(75, 23);
            this.btParaQuery.TabIndex = 0;
            this.btParaQuery.Text = "查询";
            this.btParaQuery.UseVisualStyleBackColor = true;
            this.btParaQuery.Click += new System.EventHandler(this.btParaQuery_Click);
            // 
            // tpPM
            // 
            this.tpPM.Location = new System.Drawing.Point(4, 22);
            this.tpPM.Name = "tpPM";
            this.tpPM.Padding = new System.Windows.Forms.Padding(3);
            this.tpPM.Size = new System.Drawing.Size(925, 482);
            this.tpPM.TabIndex = 1;
            this.tpPM.Text = "统计";
            this.tpPM.UseVisualStyleBackColor = true;
            // 
            // tpSignaling
            // 
            this.tpSignaling.Location = new System.Drawing.Point(4, 22);
            this.tpSignaling.Name = "tpSignaling";
            this.tpSignaling.Size = new System.Drawing.Size(925, 482);
            this.tpSignaling.TabIndex = 2;
            this.tpSignaling.Text = "信令";
            this.tpSignaling.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.小工具ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 小工具ToolStripMenuItem
            // 
            this.小工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPowerCalc});
            this.小工具ToolStripMenuItem.Name = "小工具ToolStripMenuItem";
            this.小工具ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.小工具ToolStripMenuItem.Text = "小工具";
            // 
            // menuPowerCalc
            // 
            this.menuPowerCalc.Name = "menuPowerCalc";
            this.menuPowerCalc.Size = new System.Drawing.Size(148, 22);
            this.menuPowerCalc.Text = "功率单位换算";
            this.menuPowerCalc.Click += new System.EventHandler(this.PowerCalc_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.说明ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 说明ToolStripMenuItem
            // 
            this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
            this.说明ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.说明ToolStripMenuItem.Text = "说明";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // ssPara
            // 
            this.ssPara.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslParaDbStatus});
            this.ssPara.Location = new System.Drawing.Point(0, 539);
            this.ssPara.Name = "ssPara";
            this.ssPara.Size = new System.Drawing.Size(934, 22);
            this.ssPara.TabIndex = 2;
            this.ssPara.Text = "ssPara";
            // 
            // tsslParaDbStatus
            // 
            this.tsslParaDbStatus.ForeColor = System.Drawing.Color.Red;
            this.tsslParaDbStatus.Name = "tsslParaDbStatus";
            this.tsslParaDbStatus.Size = new System.Drawing.Size(60, 17);
            this.tsslParaDbStatus.Text = "DbStatus";
            // 
            // lbParaName
            // 
            this.lbParaName.Enabled = false;
            this.lbParaName.FormattingEnabled = true;
            this.lbParaName.ItemHeight = 12;
            this.lbParaName.Location = new System.Drawing.Point(100, 209);
            this.lbParaName.Name = "lbParaName";
            this.lbParaName.ScrollAlwaysVisible = true;
            this.lbParaName.Size = new System.Drawing.Size(223, 268);
            this.lbParaName.TabIndex = 21;
            this.lbParaName.SelectedIndexChanged += new System.EventHandler(this.lbParaName_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.ssPara);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "我爱北京天安门";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMain.ResumeLayout(false);
            this.bpParameter.ResumeLayout(false);
            this.bpParameter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ssPara.ResumeLayout(false);
            this.ssPara.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage bpParameter;
        private System.Windows.Forms.TabPage tpPM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssPara;
        private System.Windows.Forms.Button btParaQuery;
        private System.Windows.Forms.TabPage tpSignaling;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPowerCalc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbParaDefaultValue;
        private System.Windows.Forms.TextBox tbParaRange;
        private System.Windows.Forms.TextBox tbParaObject;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox tbPara3GPPName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbParaName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbParaSuggestValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbParaInfluence;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbParaDescription;
        private System.Windows.Forms.Button btParaSave;
        private System.Windows.Forms.Button btCloseDb;
        private System.Windows.Forms.Button btOpenDb;
        private System.Windows.Forms.ToolStripStatusLabel tsslParaDbStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ListBox lbParaName;
    }
}

