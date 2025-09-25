using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_Bai1_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 f = new Lab01_Bai01();   // tạo form Bài 1
            f.ShowDialog();        // hiển thị form Bài 1
        }
    }
}
