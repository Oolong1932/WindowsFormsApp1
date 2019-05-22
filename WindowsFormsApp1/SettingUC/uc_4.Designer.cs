namespace WindowsFormsApp1.SettingUC
{
    partial class uc_4
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
            this.uc4_btn_確定 = new System.Windows.Forms.Button();
            this.uc4_btn_取消 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "資料庫相關參數設定";
            // 
            // uc4_btn_確定
            // 
            this.uc4_btn_確定.Location = new System.Drawing.Point(173, 380);
            this.uc4_btn_確定.Name = "uc4_btn_確定";
            this.uc4_btn_確定.Size = new System.Drawing.Size(65, 30);
            this.uc4_btn_確定.TabIndex = 1;
            this.uc4_btn_確定.Text = "確定";
            this.uc4_btn_確定.UseVisualStyleBackColor = true;
            this.uc4_btn_確定.Click += new System.EventHandler(this.uc4_btn_確定_Click);
            // 
            // uc4_btn_取消
            // 
            this.uc4_btn_取消.Location = new System.Drawing.Point(287, 380);
            this.uc4_btn_取消.Name = "uc4_btn_取消";
            this.uc4_btn_取消.Size = new System.Drawing.Size(65, 30);
            this.uc4_btn_取消.TabIndex = 2;
            this.uc4_btn_取消.Text = "取消";
            this.uc4_btn_取消.UseVisualStyleBackColor = true;
            this.uc4_btn_取消.Click += new System.EventHandler(this.uc4_btn_取消_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(37, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "目前路徑:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "開啟";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(67, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "C:\\\\........";
            // 
            // uc_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uc4_btn_取消);
            this.Controls.Add(this.uc4_btn_確定);
            this.Controls.Add(this.label1);
            this.Name = "uc_4";
            this.Size = new System.Drawing.Size(565, 430);
            this.Load += new System.EventHandler(this.uc_4_Load);
            this.VisibleChanged += new System.EventHandler(this.uc_4_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uc4_btn_確定;
        private System.Windows.Forms.Button uc4_btn_取消;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}
