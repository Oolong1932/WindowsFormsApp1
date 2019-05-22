using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "2222";

            backto參數();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backtoMain();
        }


        //back function
        public void backtoMain()
        {
            panel1.Controls.Clear();
            uc_main ucMain = new uc_main();
            panel1.Controls.Add(ucMain);

        }

        public void backto參數()
        {
            panel1.Controls.Clear();
            uc_參數設定 uc參數設定 = new uc_參數設定();
            uc參數設定.main = this;
            panel1.Controls.Add(uc參數設定);

        }



        public void ChangToUc1()
        {
            panel1.Controls.Clear();
            SettingUC.uc_1 uc1 = new SettingUC.uc_1();
            uc1.main = this;
            panel1.Controls.Add(uc1);              
        }


        public void ChangToUc2()
        {
            panel1.Controls.Clear();
            SettingUC.uc_2 uc2 = new SettingUC.uc_2();
            uc2.main = this;
            panel1.Controls.Add(uc2);
        }

        public void ChangToUc3()
        {
            panel1.Controls.Clear();
            SettingUC.uc_3 uc3 = new SettingUC.uc_3();
            uc3.main = this;
            panel1.Controls.Add(uc3);
        }

        public void ChangToUc4()
        {
            panel1.Controls.Clear();
            SettingUC.uc_4 uc4 = new SettingUC.uc_4();
            uc4.main = this;
            panel1.Controls.Add(uc4);
        }




    }
}
