using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.SettingUC
{
    public partial class 料號Form : Form
    {
        int 模式type = -1;
        string 料號名稱=null;
        int 單位 = 0;


        //回傳
        public string RetureText { get; private set; }


        public 料號Form(int _模式type)
        {
            //新增
            InitializeComponent();

            模式type = _模式type;
        }

        public 料號Form(int _模式type, string _料號名稱, int _單位)
        {
            //編輯
            InitializeComponent();

            模式type = _模式type;
            料號名稱 = _料號名稱;
            單位 = _單位;
        }




        private void 料號Form_Load(object sender, EventArgs e)
        {
            switch (模式type)
            {
                case 0: //新增
                    lab_title.Text = "新增料號";
                    break;

                case 1://編輯
                    lab_title.Text = "編輯料號";
                    tb_料號名稱.Text = 料號名稱;
                    tb_單位.Text = 單位.ToString();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_料號名稱.Text) || string.IsNullOrEmpty(tb_單位.Text))
            {
                MessageBox.Show("請勿空白!");
                return;
            }
            else
            {

                RetureText = tb_料號名稱.Text + "/" + tb_單位.Text;

                DialogResult = DialogResult.OK; //回傳ok
                this.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //回傳cancel 
            this.Close();
        }
    }
}
