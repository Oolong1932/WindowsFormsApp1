namespace WindowsFormsApp1.SettingUC
{
    partial class uc_1
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.uc1_btn_確定 = new System.Windows.Forms.Button();
            this.uc1_btn_取消 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "料號管理";
            // 
            // uc1_btn_確定
            // 
            this.uc1_btn_確定.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uc1_btn_確定.Location = new System.Drawing.Point(201, 396);
            this.uc1_btn_確定.Name = "uc1_btn_確定";
            this.uc1_btn_確定.Size = new System.Drawing.Size(65, 30);
            this.uc1_btn_確定.TabIndex = 1;
            this.uc1_btn_確定.Text = "確定";
            this.uc1_btn_確定.UseVisualStyleBackColor = true;
            this.uc1_btn_確定.Click += new System.EventHandler(this.button1_Click);
            // 
            // uc1_btn_取消
            // 
            this.uc1_btn_取消.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uc1_btn_取消.Location = new System.Drawing.Point(290, 396);
            this.uc1_btn_取消.Name = "uc1_btn_取消";
            this.uc1_btn_取消.Size = new System.Drawing.Size(65, 30);
            this.uc1_btn_取消.TabIndex = 2;
            this.uc1_btn_取消.Text = "取消";
            this.uc1_btn_取消.UseVisualStyleBackColor = true;
            this.uc1_btn_取消.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "新增";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(77, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 31);
            this.button4.TabIndex = 4;
            this.button4.Text = "編輯";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(146, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 31);
            this.button5.TabIndex = 5;
            this.button5.Text = "刪除";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(3, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(559, 292);
            this.listBox1.TabIndex = 6;
            // 
            // uc_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.uc1_btn_取消);
            this.Controls.Add(this.uc1_btn_確定);
            this.Controls.Add(this.label1);
            this.Name = "uc_1";
            this.Size = new System.Drawing.Size(565, 430);
            this.Load += new System.EventHandler(this.uc_1_Load);
            this.VisibleChanged += new System.EventHandler(this.uc_1_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uc1_btn_確定;
        private System.Windows.Forms.Button uc1_btn_取消;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
    }
}
