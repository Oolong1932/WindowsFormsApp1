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
    public partial class uc_3 : UserControl
    {
        public Form1 main = null;

        public uc_3()
        {
            InitializeComponent();
        }

        private void uc_3_Load(object sender, EventArgs e)
        {

        }

        private void uc_3_VisibleChanged(object sender, EventArgs e)
        {
            MessageBox.Show("偵測到切換畫面動作_uc3");
        }

        private void uc3_btn_確定_Click(object sender, EventArgs e)
        {
            main.backto參數();
        }

        private void uc3_btn_取消_Click(object sender, EventArgs e)
        {
            main.backto參數();
        }
    }
}
