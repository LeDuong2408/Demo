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
    public partial class frm_Bai2 : Form
    {
        public frm_Bai2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtName.Text + " " + cbDay.Text + "-" + cbMonth.Text + "-" + cbYear.Text + "  " + txtFavorite;

        }

        private void frm_Bai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Ban muon thoat?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
