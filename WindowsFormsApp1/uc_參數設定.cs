using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class uc_參數設定 : UserControl
    {

        public Form1 main = null;

        public uc_參數設定()
        {
            InitializeComponent();
        }

        private void uc_參數設定_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            main.backtoMain();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.ChangToUc1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.ChangToUc2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            main.ChangToUc3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            main.ChangToUc4();
        }

        private void uc_參數設定_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == false) //
                MessageBox.Show("偵測到切換畫面動作_uc參數設定");
        }
    }
}
