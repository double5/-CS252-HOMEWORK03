namespace Homework01
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BaseSalaryTextBox = new System.Windows.Forms.TextBox();
            this.BenefitTextBox = new System.Windows.Forms.TextBox();
            this.SetSalary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BaseSalaryTextBox
            // 
            this.BaseSalaryTextBox.Location = new System.Drawing.Point(62, 32);
            this.BaseSalaryTextBox.Name = "BaseSalaryTextBox";
            this.BaseSalaryTextBox.Size = new System.Drawing.Size(93, 22);
            this.BaseSalaryTextBox.TabIndex = 0;
            // 
            // BenefitTextBox
            // 
            this.BenefitTextBox.Location = new System.Drawing.Point(62, 67);
            this.BenefitTextBox.Name = "BenefitTextBox";
            this.BenefitTextBox.Size = new System.Drawing.Size(93, 22);
            this.BenefitTextBox.TabIndex = 1;
            // 
            // SetSalary
            // 
            this.SetSalary.Location = new System.Drawing.Point(184, 26);
            this.SetSalary.Name = "SetSalary";
            this.SetSalary.Size = new System.Drawing.Size(96, 30);
            this.SetSalary.TabIndex = 3;
            this.SetSalary.Text = "設定薪水";
            this.SetSalary.UseVisualStyleBackColor = true;
            this.SetSalary.Click += new System.EventHandler(this.SetSalary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "底薪";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "獎金";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 139);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetSalary);
            this.Controls.Add(this.BenefitTextBox);
            this.Controls.Add(this.BaseSalaryTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BaseSalaryTextBox;
        private System.Windows.Forms.TextBox BenefitTextBox;
        private System.Windows.Forms.Button SetSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

