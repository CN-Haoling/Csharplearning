namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_clk_1 = new System.Windows.Forms.Button();
            this.textBox_insert1 = new System.Windows.Forms.TextBox();
            this.textBox_insert2 = new System.Windows.Forms.TextBox();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.button_mut = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_clk_1
            // 
            this.Button_clk_1.Location = new System.Drawing.Point(630, 187);
            this.Button_clk_1.Name = "Button_clk_1";
            this.Button_clk_1.Size = new System.Drawing.Size(57, 43);
            this.Button_clk_1.TabIndex = 0;
            this.Button_clk_1.Text = "Click This";
            this.Button_clk_1.UseVisualStyleBackColor = true;
            this.Button_clk_1.Click += new System.EventHandler(this.Button_clk_1_Click);
            // 
            // textBox_insert1
            // 
            this.textBox_insert1.Location = new System.Drawing.Point(229, 93);
            this.textBox_insert1.Name = "textBox_insert1";
            this.textBox_insert1.Size = new System.Drawing.Size(119, 25);
            this.textBox_insert1.TabIndex = 2;
            // 
            // textBox_insert2
            // 
            this.textBox_insert2.Location = new System.Drawing.Point(229, 142);
            this.textBox_insert2.Name = "textBox_insert2";
            this.textBox_insert2.Size = new System.Drawing.Size(119, 25);
            this.textBox_insert2.TabIndex = 3;
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(256, 222);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(51, 51);
            this.button_plus.TabIndex = 5;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_sub
            // 
            this.button_sub.Location = new System.Drawing.Point(313, 222);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(51, 51);
            this.button_sub.TabIndex = 6;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.button_sub_Click);
            // 
            // button_mut
            // 
            this.button_mut.Location = new System.Drawing.Point(370, 222);
            this.button_mut.Name = "button_mut";
            this.button_mut.Size = new System.Drawing.Size(51, 51);
            this.button_mut.TabIndex = 7;
            this.button_mut.Text = "*";
            this.button_mut.UseVisualStyleBackColor = true;
            this.button_mut.Click += new System.EventHandler(this.button_mut_Click);
            // 
            // button_div
            // 
            this.button_div.Location = new System.Drawing.Point(439, 226);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(49, 46);
            this.button_div.TabIndex = 8;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(505, 104);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(144, 25);
            this.textBox_result.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_mut);
            this.Controls.Add(this.button_sub);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.textBox_insert2);
            this.Controls.Add(this.textBox_insert1);
            this.Controls.Add(this.Button_clk_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_clk_1;
        private System.Windows.Forms.TextBox textBox_insert1;
        private System.Windows.Forms.TextBox textBox_insert2;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_sub;
        private System.Windows.Forms.Button button_mut;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.TextBox textBox_result;
    }
}

