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
            this.button1 = new System.Windows.Forms.Button();
            this.dep = new System.Windows.Forms.TextBox();
            this.rlen = new System.Windows.Forms.TextBox();
            this.len = new System.Windows.Forms.TextBox();
            this.lagl = new System.Windows.Forms.TextBox();
            this.Llen = new System.Windows.Forms.TextBox();
            this.ragl = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RightLength = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ColorCheck = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dep
            // 
            this.dep.Location = new System.Drawing.Point(670, 169);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(100, 25);
            this.dep.TabIndex = 1;
            this.dep.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rlen
            // 
            this.rlen.Location = new System.Drawing.Point(670, 307);
            this.rlen.Name = "rlen";
            this.rlen.Size = new System.Drawing.Size(100, 25);
            this.rlen.TabIndex = 2;
            this.rlen.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // len
            // 
            this.len.Location = new System.Drawing.Point(670, 215);
            this.len.Name = "len";
            this.len.Size = new System.Drawing.Size(100, 25);
            this.len.TabIndex = 3;
            this.len.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lagl
            // 
            this.lagl.Location = new System.Drawing.Point(670, 353);
            this.lagl.Name = "lagl";
            this.lagl.Size = new System.Drawing.Size(100, 25);
            this.lagl.TabIndex = 4;
            this.lagl.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Llen
            // 
            this.Llen.Location = new System.Drawing.Point(670, 261);
            this.Llen.Name = "Llen";
            this.Llen.Size = new System.Drawing.Size(100, 25);
            this.Llen.TabIndex = 5;
            this.Llen.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // ragl
            // 
            this.ragl.Location = new System.Drawing.Point(670, 399);
            this.ragl.Name = "ragl";
            this.ragl.Size = new System.Drawing.Size(100, 25);
            this.ragl.TabIndex = 6;
            this.ragl.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(40, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 440);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Depth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "LeftLength";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RightLength
            // 
            this.RightLength.AutoSize = true;
            this.RightLength.Location = new System.Drawing.Point(675, 289);
            this.RightLength.Name = "RightLength";
            this.RightLength.Size = new System.Drawing.Size(95, 15);
            this.RightLength.TabIndex = 12;
            this.RightLength.Text = "RightLength";
            this.RightLength.Click += new System.EventHandler(this.label4_Click);
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Location = new System.Drawing.Point(691, 335);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(79, 15);
            this.L.TabIndex = 13;
            this.L.Text = "LeftAngle";
            this.L.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "RightAngle";
            // 
            // ColorCheck
            // 
            this.ColorCheck.FormattingEnabled = true;
            this.ColorCheck.Items.AddRange(new object[] {
            "RED",
            "BLUE",
            "GREEN"});
            this.ColorCheck.Location = new System.Drawing.Point(620, 41);
            this.ColorCheck.Name = "ColorCheck";
            this.ColorCheck.Size = new System.Drawing.Size(168, 84);
            this.ColorCheck.TabIndex = 18;
            this.ColorCheck.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ColorCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.L);
            this.Controls.Add(this.RightLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ragl);
            this.Controls.Add(this.Llen);
            this.Controls.Add(this.lagl);
            this.Controls.Add(this.len);
            this.Controls.Add(this.rlen);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dep;
        private System.Windows.Forms.TextBox rlen;
        private System.Windows.Forms.TextBox len;
        private System.Windows.Forms.TextBox lagl;
        private System.Windows.Forms.TextBox Llen;
        private System.Windows.Forms.TextBox ragl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RightLength;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox ColorCheck;
    }
}

