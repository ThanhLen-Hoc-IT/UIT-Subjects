using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_sum_Click(object sender, EventArgs e)
        {
           int num1=0, num2= 0, result = 0;
            bool isNum1Valid = int.TryParse(tb_num1.Text, out num1);
            bool isNum2Valid = int.TryParse(tb_num2.Text, out num2);
            if (!isNum1Valid || !isNum2Valid)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }
            result = num1 + num2;
            tb_result.Text = result.ToString();


        }
    }
}
