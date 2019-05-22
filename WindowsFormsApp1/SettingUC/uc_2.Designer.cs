namespace WindowsFormsApp1.SettingUC
{
    partial class uc_2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_人員工號 = new System.Windows.Forms.Button();
            this.btn_料號 = new System.Windows.Forms.Button();
            this.uc2_btn_確定 = new System.Windows.Forms.Button();
            this.uc2_btn_取消 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode Only";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(36, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "人員工號輸入框";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(119, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "料號";
            // 
            // btn_人員工號
            // 
            this.btn_人員工號.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_人員工號.Location = new System.Drawing.Point(338, 148);
            this.btn_人員工號.Name = "btn_人員工號";
            this.btn_人員工號.Size = new System.Drawing.Size(114, 32);
            this.btn_人員工號.TabIndex = 3;
            this.btn_人員工號.Text = "--";
            this.btn_人員工號.UseVisualStyleBackColor = true;
            // 
            // btn_料號
            // 
            this.btn_料號.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_料號.Location = new System.Drawing.Point(338, 245);
            this.btn_料號.Name = "btn_料號";
            this.btn_料號.Size = new System.Drawing.Size(114, 32);
            this.btn_料號.TabIndex = 4;
            this.btn_料號.Text = "--";
            this.btn_料號.UseVisualStyleBackColor = true;
            // 
            // uc2_btn_確定
            // 
            this.uc2_btn_確定.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uc2_btn_確定.Location = new System.Drawing.Point(169, 385);
            this.uc2_btn_確定.Name = "uc2_btn_確定";
            this.uc2_btn_確定.Size = new System.Drawing.Size(65, 30);
            this.uc2_btn_確定.TabIndex = 5;
            this.uc2_btn_確定.Text = "確定";
            this.uc2_btn_確定.UseVisualStyleBackColor = true;
            this.uc2_btn_確定.Click += new System.EventHandler(this.uc2_btn_確定_Click);
            // 
            // uc2_btn_取消
            // 
            this.uc2_btn_取消.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uc2_btn_取消.Location = new System.Drawing.Point(288, 385);
            this.uc2_btn_取消.Name = "uc2_btn_取消";
            this.uc2_btn_取消.Size = new System.Drawing.Size(65, 30);
            this.uc2_btn_取消.TabIndex = 6;
            this.uc2_btn_取消.Text = "取消";
            this.uc2_btn_取消.UseVisualStyleBackColor = true;
            this.uc2_btn_取消.Click += new System.EventHandler(this.uc2_btn_取消_Click);
            // 
            // uc_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.uc2_btn_取消);
            this.Controls.Add(this.uc2_btn_確定);
            this.Controls.Add(this.btn_料號);
            this.Controls.Add(this.btn_人員工號);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_2";
            this.Size = new System.Drawing.Size(565, 430);
            this.Load += new System.EventHandler(this.uc_2_Load);
            this.VisibleChanged += new System.EventHandler(this.uc_2_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_人員工號;
        private System.Windows.Forms.Button btn_料號;
        private System.Windows.Forms.Button uc2_btn_確定;
        private System.Windows.Forms.Button uc2_btn_取消;
    }
}
