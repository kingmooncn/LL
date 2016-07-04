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
        private void button1_Click(object sender, EventArgs e)
        {
           bt
        }


        /// <summary>
        /// 显示功率计算窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PowerCalc_Click(object sender, EventArgs e)
        {
            Form fmPowerCalc = new FormPowerCalc();
            fmPowerCalc.ShowDialog();
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
                tsslParaDbStatus.Text = "Db Open Success";
                btOpenDb.Enabled = false;
            }
            else
            {
                tsslParaDbStatus.ForeColor = Color.Red;
                tsslParaDbStatus.Text = "Db Open Fail";
            }
        }

        private void btCloseDb_Click(object sender, EventArgs e)
        {
            SqlHeper.closeConnection(conn);
            tsslParaDbStatus.ForeColor = Color.Yellow;
            tsslParaDbStatus.Text = "Db Closed";
            btOpenDb.Enabled = true;
            btCloseDb.Enabled = false;
        }

        private void btParaQuery_Click(object sender, EventArgs e)
        {

        }
    }
}
