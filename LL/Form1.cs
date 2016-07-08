using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlHelper;
using System.Data.OleDb;


namespace LL
{
    
    public partial class Form1 : Form
    {
        //数据库连接公共变量
        public OleDbConnection conn;
        public OleDbCommand comm;
        public DataTable dt;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 查询LTE参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
   


        /// <summary>
        /// 显示功率计算窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PowerCalc_Click(object sender, EventArgs e)
        {
            Form fmPowerCalc = new FormPowerCalc();
            //fmPowerCalc.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btOpenDb_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = SqlHeper.connectDatabase();
            SqlHeper.openDbConnection(conn);
           
            if (conn.State == ConnectionState.Open)
            {
                tsslParaDbStatus.ForeColor = Color.Green;
                tsslParaDbStatus.Text = "数据库打开成功";
                comm = SqlHeper.openDbCommand(conn);
                btOpenDb.Enabled = false;
            }
            else
            {
                tsslParaDbStatus.ForeColor = Color.Red;
                tsslParaDbStatus.Text = "数据库打开失败";
            }
        }

        private void btCloseDb_Click(object sender, EventArgs e)
        {
            tsslParaDbStatus.ForeColor = Color.Yellow;
            tsslParaDbStatus.Text = "Db Closed";
            btOpenDb.Enabled = true;
            btCloseDb.Enabled = false;
        }

        private void btParaQuery_Click(object sender, EventArgs e)
        {

            lbParaName.Items.Clear();
            string queryKeyValue = "'%" + tbParaName.Text.Trim() + "%';";
            string queryStr = "select * from para where parameter_name like "+ queryKeyValue;
            
            dt = SqlHeper.dataTable(comm,conn,queryStr);
            if (dt.Rows.Count > 0)
            {
                lbParaName.Enabled = true;
            }
            else
            {
                lbParaName.Enabled = false;
            }
                

            for (int i = 0; i < dt.Rows.Count;i++)
            {
                lbParaName.Items.Add(dt.Rows[i]["parameter_name"].ToString());
            }

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void lbParaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lb_num = lbParaName.SelectedIndex;
            if(dt.Rows.Count>0 && lb_num>-1 && lb_num< dt.Rows.Count)
            {
                tbParaName.Text = dt.Rows[lb_num]["parameter_name"].ToString();
                tbPara3GPPName.Text = dt.Rows[lb_num]["3gpp_name"].ToString();
                tbParaObject.Text = dt.Rows[lb_num]["object"].ToString();
                tbParaRange.Text = dt.Rows[lb_num]["range"].ToString();
                tbParaDescription.Text = dt.Rows[lb_num]["description"].ToString();
                tbParaInfluence.Text = dt.Rows[lb_num]["influence"].ToString();
                tbParaDefaultValue.Text = dt.Rows[lb_num]["default_value"].ToString();
                tbParaSuggestValue.Text = dt.Rows[lb_num]["suggestive_value"].ToString();
            }
            
        }
    }
}
