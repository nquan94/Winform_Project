using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string truyvan = string.Format("select * from NguoiDung where TaiKhoan = '{0}' and MatKhau = '{1}'",
                txtTaiKhoan.Text,TxtMatKhau.Text);
            DataTable tb = kn.Laydulieu(truyvan);
            if(tb.Rows.Count == 1)
            {
                MessageBox.Show("Dang nhap thanh cong");
                frmHeThong frm = new frmHeThong();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dang nhap that bai");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
