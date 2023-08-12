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
    public partial class frmLichDangKy : Form
    {
        public frmLichDangKy()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        private void frmLichDangKy_Load(object sender, EventArgs e)
        {
            Getdata();
        }

        public void Getdata()
        {
            string truyvan = "select * from LichDangKy";
            dgvDuLieu.DataSource = kn.Laydulieu(truyvan);
        }
     
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string truyvan = string.Format(
            "select PhongMay.* from PhongMay inner join LichDangKy on LichDangKy.MaPM = PhongMay.MaPM where PhongMay.TenPM like N'%{0}%'", 
            txtTimKiem.Text);
            dgvDuLieu.DataSource = kn.Laydulieu(truyvan);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaPM.ResetText();
            txtMaGV.ResetText();
            txtBatDau.ResetText();
            txtKetThuc.ResetText();
            txtNamHoc.ResetText();
            Getdata(); 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string truyvan = string.Format(
                "insert into LichDangKy values ('{0}', '{1}','{2}','{3}',{4})",
                txtMaPM.Text,txtMaGV.Text,txtBatDau.Text,txtKetThuc.Text,txtNamHoc.Text
                );
            if (kn.thucthi(truyvan) == true)
            {
                MessageBox.Show("Them thanh cong!");
                btnReset.PerformClick();
            }
            else
            {
              MessageBox.Show("Them that bai!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string truyvan = string.Format(
                "delete from LichDangKy where MaPM = '{0}'",
                txtMaPM.Text
                );
            if (kn.thucthi(truyvan) == true)
            {
                MessageBox.Show("Xoa thanh cong!");
                btnReset.PerformClick();
            }
            else
            {
                MessageBox.Show("Xoa that bai!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string truyvan = string.Format(
               "update LichDangKy set MaGV = '{1}', BatDau = '{2}', KetThuc = '{3}',NamHoc = '{4}' where MaPM ='{0}'",
               txtMaPM.Text, txtMaGV.Text, txtBatDau.Text, txtKetThuc.Text, txtNamHoc.Text
               );
            if (kn.thucthi(truyvan) == true)
            {
                MessageBox.Show("Sua thanh cong!");
                btnReset.PerformClick();
            }
            else
            {
                MessageBox.Show("Sua that bai!");
            }
        }
    }
}
