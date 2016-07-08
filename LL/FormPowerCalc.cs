using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LL
{
    public partial class FormPowerCalc : Form
    {
        public FormPowerCalc()
        {
            InitializeComponent();
        }

        private void FormPowerCalc_Load(object sender, EventArgs e)
        {

        }
        public bool isNumber(string temp)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                int number = (int)temp[i];

                if (number > '9' || number < '0' && !(number=='.'))
                {
                    return false;
                }        
            }
            return true;
        }

        private void btPowerCalc_Click(object sender, EventArgs e)
        {
            double PowerDbm, PowerWatter;

            if (isNumber(tbPowerDbm.Text.Trim()) == true && isNumber(tbPowerWatter.Text.Trim()) == true  )
            {
                if (!(tbPowerDbm.Text.Trim() == ""))
                {
                    PowerDbm = Convert.ToDouble(tbPowerDbm.Text.Trim());
                    double PowerDbmToWatter = Math.Pow(10, PowerDbm / 10) / 1000;
                    tbPowerWatter.Text = PowerDbmToWatter.ToString("0.000");
                }
                else if (!(tbPowerWatter.Text.Trim() == ""))
                {
                    PowerWatter = Convert.ToDouble(tbPowerWatter.Text.Trim());
                    double PowerWatterToDbm = 10 * Math.Log10(PowerWatter * 1000);
                    tbPowerDbm.Text = PowerWatterToDbm.ToString("0.000");
                }
                else
                {

                    MessageBox.Show("请输入需要转换的功率值！");
                }
            }
            else
            {
                MessageBox.Show("输入错误！请输入纯数字 ");
            }
        }

        private void btPowerClear_Click(object sender, EventArgs e)
        {
            tbPowerWatter.Text = "";
            tbPowerDbm.Text = "";
        }
    }
}
