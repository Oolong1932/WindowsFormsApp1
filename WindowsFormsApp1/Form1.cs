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

            panel1.Controls.Clear();

            uc_參數設定 uc參數設定 = new uc_參數設定();
            uc參數設定.main = this;
            panel1.Controls.Add(uc參數設定);

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



    }
}
