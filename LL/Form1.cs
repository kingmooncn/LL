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


namespace LL
{
    public partial class Form1 : Form
    {
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
    }
}
