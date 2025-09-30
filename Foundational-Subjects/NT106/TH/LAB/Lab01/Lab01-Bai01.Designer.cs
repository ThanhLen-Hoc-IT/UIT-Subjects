namespace Lab01
{
    partial class Lab01_Bai01
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.tb_num1 = new System.Windows.Forms.TextBox();
            this.tb_num2 = new System.Windows.Forms.TextBox();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.bt_sum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(70, 28);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(446, 39);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "TÍNH TỔNG 2 SỐ NGUYÊN";
            this.lbl_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num1.Location = new System.Drawing.Point(47, 90);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(114, 31);
            this.lbl_num1.TabIndex = 1;
            this.lbl_num1.Text = "Số thứ 1";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num2.Location = new System.Drawing.Point(47, 148);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(114, 31);
            this.lbl_num2.TabIndex = 2;
            this.lbl_num2.Text = "Số thứ 2";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(47, 211);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(107, 31);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = "Kết quả";
            // 
            // tb_num1
            // 
            this.tb_num1.Location = new System.Drawing.Point(223, 90);
            this.tb_num1.Multiline = true;
            this.tb_num1.Name = "tb_num1";
            this.tb_num1.Size = new System.Drawing.Size(265, 31);
            this.tb_num1.TabIndex = 4;
            // 
            // tb_num2
            // 
            this.tb_num2.Location = new System.Drawing.Point(223, 148);
            this.tb_num2.Multiline = true;
            this.tb_num2.Name = "tb_num2";
            this.tb_num2.Size = new System.Drawing.Size(265, 31);
            this.tb_num2.TabIndex = 5;
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(223, 211);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.ReadOnly = true;
            this.tb_result.Size = new System.Drawing.Size(265, 31);
            this.tb_result.TabIndex = 6;
            // 
            // bt_sum
            // 
            this.bt_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sum.Location = new System.Drawing.Point(223, 275);
            this.bt_sum.Name = "bt_sum";
            this.bt_sum.Size = new System.Drawing.Size(111, 50);
            this.bt_sum.TabIndex = 16;
            this.bt_sum.Text = "Tính";
            this.bt_sum.UseVisualStyleBackColor = true;
            this.bt_sum.Click += new System.EventHandler(this.bt_sum_Click);
            // 
            // Lab01_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.bt_sum);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.tb_num2);
            this.Controls.Add(this.tb_num1);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_num1);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Lab01_Bai01";
            this.Text = "Lab01_Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox tb_num1;
        private System.Windows.Forms.TextBox tb_num2;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Button bt_sum;
    }
}