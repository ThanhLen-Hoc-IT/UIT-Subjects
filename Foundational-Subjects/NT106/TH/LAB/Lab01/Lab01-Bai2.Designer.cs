namespace Lab01
{
    partial class Lab01_Bai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_num1 = new System.Windows.Forms.Label();
            this.lb_num2 = new System.Windows.Forms.Label();
            this.lb_num3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lb_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_num1
            // 
            this.lb_num1.AutoSize = true;
            this.lb_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_num1.Location = new System.Drawing.Point(59, 112);
            this.lb_num1.Name = "lb_num1";
            this.lb_num1.Size = new System.Drawing.Size(85, 25);
            this.lb_num1.TabIndex = 0;
            this.lb_num1.Text = "Số thứ 1";
            this.lb_num1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_num2
            // 
            this.lb_num2.AutoSize = true;
            this.lb_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_num2.Location = new System.Drawing.Point(301, 112);
            this.lb_num2.Name = "lb_num2";
            this.lb_num2.Size = new System.Drawing.Size(85, 25);
            this.lb_num2.TabIndex = 1;
            this.lb_num2.Text = "Số thứ 2";
            this.lb_num2.Click += new System.EventHandler(this.lb_num2_Click);
            // 
            // lb_num3
            // 
            this.lb_num3.AutoSize = true;
            this.lb_num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_num3.Location = new System.Drawing.Point(545, 112);
            this.lb_num3.Name = "lb_num3";
            this.lb_num3.Size = new System.Drawing.Size(85, 25);
            this.lb_num3.TabIndex = 2;
            this.lb_num3.Text = "Số thứ 3";
            this.lb_num3.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 112);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 25);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(392, 112);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 25);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(636, 112);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 25);
            this.textBox3.TabIndex = 5;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(143, 29);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(513, 39);
            this.lb_Title.TabIndex = 6;
            this.lb_Title.Text = "TÌM SỐ LỚN NHẤT, NHỎ NHẤT";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_Title.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Lab01_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_num3);
            this.Controls.Add(this.lb_num2);
            this.Controls.Add(this.lb_num1);
            this.Name = "Lab01_Bai2";
            this.Text = "Lab01_Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_num1;
        private System.Windows.Forms.Label lb_num2;
        private System.Windows.Forms.Label lb_num3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lb_Title;
    }
}