using System;
using System.Windows.Forms;

namespace 直流电机工作特性
{
    public partial class 项目选择窗口 : Form
    {
        public 项目选择窗口()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("退出？", "确定?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void AddEditorButton_Click(object sender, EventArgs e)
        {
            new 添加或编辑窗体().ShowDialog();
        }
    }
}
