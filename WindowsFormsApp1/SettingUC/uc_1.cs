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
    public partial class uc_1 : UserControl
    {

        public Form1 main = null;

        public uc_1()
        {
            InitializeComponent();
        }

        private void uc_1_Load(object sender, EventArgs e)
        {

        }

        private void uc_1_VisibleChanged(object sender, EventArgs e)
        {
           // if (Visible == false)
           //     MessageBox.Show("偵測到切換畫面動作_uc1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //確定

            main.backto參數();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //取消
            main.backto參數();

        }





        private void 重新整理_listbox()
        {
            listBox1.Items.Clear();
            
            //將儲存的料號 add 到listbox ___Read SQLite

            // if 長度 no 0

            //for迴圈式加入








        }





    }
}
