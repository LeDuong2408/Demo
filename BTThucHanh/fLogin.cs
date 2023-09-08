using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTThucHanh
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtLogin.Text == "duong123" && this.txtPassword.Text == "1223")
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
                MessageBox.Show("Sai thông tin đăng nhập", "Thông báo");
            this.txtLogin.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel ) != DialogResult.OK)
                e.Cancel = true;
        }
    }
}
