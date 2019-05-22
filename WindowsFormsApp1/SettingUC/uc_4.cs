using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.SettingUC
{
    public partial class uc_4 : UserControl
    {
        public Form1 main = null;

        public uc_4()
        {
            InitializeComponent();
        }

        private void uc_4_Load(object sender, EventArgs e)
        {

        }

        private void uc_4_VisibleChanged(object sender, EventArgs e)
        {
            MessageBox.Show("偵測到切換畫面動作_uc4");
        }

        private void uc4_btn_確定_Click(object sender, EventArgs e)
        {
            main.backto參數();
        }

        private void uc4_btn_取消_Click(object sender, EventArgs e)
        {
            main.backto參數();
        }
    }
}
