using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWF001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            if (sender == btnClickMe)
            {
                DialogResult flag = MessageBox.Show("Xin chào, hôm nay trời có đẹp không", "C2208I1", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                MessageBox.Show(flag == DialogResult.Yes ? "bạn chọn YES" : "bạn chọn NO");
            }
            else
            {
                DialogResult flag = MessageBox.Show("Xin chào, hôm nay trời có đẹp không", "C2208I1", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); ;

                MessageBox.Show(flag == DialogResult.OK ? "bạn chọn OK" : "bạn chọn CANCEL");
            }
        }
    }
}
