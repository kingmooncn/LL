﻿using System;
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

        private void btPowerCalc_Click(object sender, EventArgs e)
        {
            double PowerDbm, PowerWatter;
            
            
            if (!(tbPowerDbm.Text.Trim() == ""))
            {
                PowerDbm = Convert.ToDouble(tbPowerDbm.Text.Trim());
                double PowerDbmToWatter = Math.Pow(10, PowerDbm / 10) / 1000;
                tbPowerWatter.Text = PowerDbmToWatter.ToString();
            }
            else if (!(tbPowerWatter.Text.Trim() == ""))
            {
                PowerWatter = Convert.ToDouble(tbPowerWatter.Text.Trim());
                double PowerWatterToDbm = 10 * Math.Log10(PowerWatter*1000);
                tbPowerDbm.Text = PowerWatterToDbm.ToString();
            }
            else
            {
                
                tbPowerWatter.Text = "请输入功率值(单位为W)";
                tbPowerDbm.Text = "请输入功率值(单位为Dbm)";
            }
        }

        private void tbPowerWatter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
