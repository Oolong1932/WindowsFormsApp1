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
    public partial class uc_2 : UserControl
    {
        public Form1 main = null;

        public uc_2()
        {
            InitializeComponent();
        }

        private void uc_2_Load(object sender, EventArgs e)
        {
            //Read 紀錄  



        }

        private void uc_2_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == false)
                MessageBox.Show("偵測到切換畫面動作_uc2");
        }

        private void uc2_btn_確定_Click(object sender, EventArgs e)
        {
            main.backto參數();
        }

        private void uc2_btn_取消_Click(object sender, EventArgs e)
        {
            main.backto參數();
        }
    }
}
