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

        private void btPowerCalc_Click(object sender, EventArgs e)
        {
            float PowerDbm, PowerWatter;
            PowerDbm = float.Parse(tbPowerDbm.Text);
            PowerWatter = float.Parse(tbPowerWatter.Text);

            
        }
    }
}
